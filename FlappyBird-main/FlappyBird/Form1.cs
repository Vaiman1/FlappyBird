using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        Player bird;
        TheWall wall1, wall2, wall3, wall4, wall5, wall6;

        float gravity;
        public Form1()
        {
            SqlConnection conn = null;
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(update);
            Init();
            Invalidate();
        }

        public void Init()
        {
            bird = new Player(200, 200);

            wall1 = new TheWall(500, -320,true);
            wall2 = new TheWall(500, 300);
            wall3 = new TheWall(1000, -320, true);
            wall4 = new TheWall(1000, 300);
            wall5 = new TheWall(1500, -320, true);
            wall6 = new TheWall(1500, 300);

            gravity = 0;
            this.Text = "Flappy Bird Score: 0";
            timer1.Start();
        }

        private void update(object sender, EventArgs e)
        {
            if (bird.y > 600)
            {
                bird.isAlive = false;
                timer1.Stop();
                Init();
            }

            if (Collide(bird, wall1) || Collide(bird, wall2) || Collide(bird, wall3) || Collide(bird, wall4) || Collide(bird, wall5) || Collide(bird, wall6))
            {

                bird.isAlive = false;
                timer1.Stop();
                SqlCommand command1 = new SqlCommand
                       ("INSERT INTO [Result]	(Name, Result, date)" +
                        "VALUES (@PlayerName, @birdscore, @date)", conn);

                command1.Parameters.AddWithValue("PlayerName", AucForm.PlayerName);
                command1.Parameters.AddWithValue("birdscore", bird.score);
                command1.Parameters.AddWithValue("date", DateTime.Now);
                command1.ExecuteNonQuery();
                MainMenuUI f = new MainMenuUI();
                f.Show();
                Close();
                Init();
            }

            if (bird.gravityValue != 0.10f)
                bird.gravityValue += 0.0046f;
            gravity += bird.gravityValue;
            bird.y += gravity;

            if (bird.isAlive) {
                MoveWalls();
            }
            
            Invalidate();
        }

        private bool Collide(Player bird, TheWall wall1)
        {
            PointF delta = new PointF();
            delta.X = (bird.x + bird.sizex / 2) - (wall1.x + wall1.sizeX / 2);
            delta.Y = (bird.y + bird.sizey / 2) - (wall1.y + wall1.sizeY / 2);
            if (Math.Abs(delta.X) <= bird.sizex / 2 + wall1.sizeX / 2)
            {
                if (Math.Abs(delta.Y) <= bird.sizey / 2 + wall1.sizeY / 2)
                {
                    return true;
                }
            }
            return false;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            button1.Location = new Point(this.Width - 119, this.Height - 116);
        }

        private void CreateNewWall()
        {
            if (wall1.x < bird.x - 200)
            {
                Random r = new Random();
                int y1;
                y1 = r.Next(-420, -150);
                wall1 = new TheWall(1500,y1, true);
                wall2 = new TheWall(1500, y1+630);

                this.Text = "Flappy Bird Score: "+ ++bird.score;
            }

            if (wall3.x < bird.x - 200)
            {
                Random r = new Random();
                int y1;
                y1 = r.Next(-420, -150);

                wall3 = new TheWall(1500, y1, true);
                wall4 = new TheWall(1500, y1 + 630);
                this.Text = "Flappy Bird Score: " + ++bird.score;
            }

            if (wall5.x < bird.x - 200)
            {
                Random r = new Random();
                int y1;
                y1 = r.Next(-420, -150);

                wall5 = new TheWall(1500, y1, true);
                wall6 = new TheWall(1500, y1 + 630);
                this.Text = "Flappy Bird Score: " + ++bird.score;
            }

        }

        private void MoveWalls()
        {
            wall1.x -= 3;
            wall2.x -= 3;
            wall3.x -= 3;
            wall4.x -= 3;
            wall5.x -= 3;
            wall6.x -= 3;
            CreateNewWall();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(bird.birdImg, bird.x, bird.y, bird.sizex, bird.sizey);
            
            
            graphics.DrawImage(wall1.wallImg, wall1.x, wall1.y, wall1.sizeX, wall1.sizeY);
            graphics.DrawImage(wall2.wallImg, wall2.x, wall2.y, wall2.sizeX, wall2.sizeY);

            graphics.DrawImage(wall3.wallImg, wall3.x, wall3.y, wall3.sizeX, wall3.sizeY);
            graphics.DrawImage(wall4.wallImg, wall4.x, wall4.y, wall4.sizeX, wall4.sizeY);

            graphics.DrawImage(wall5.wallImg, wall5.x, wall5.y, wall5.sizeX, wall5.sizeY);
            graphics.DrawImage(wall6.wallImg, wall6.x, wall6.y, wall6.sizeX, wall6.sizeY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bird.isAlive)
            {
                gravity = -1;
                bird.gravityValue = -0.1f;
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StrDB"].ConnectionString);
            conn.Open();
        }
    }
}
