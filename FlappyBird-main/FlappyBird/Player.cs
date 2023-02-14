using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    class Player
    {
        public float x;
        public float y;


        public int score;

        public float gravityValue;

        public Image birdImg;

        public int sizex;
        public int sizey;

        public bool isAlive;

        // объект игрока, с координатами
        public Player(int x,int y)
        {
            birdImg = new Bitmap(@"player.png");
            this.x = x-100;
            this.y = y;
            sizex = 55; // размеры текстуры
            sizey = 43;
            gravityValue = 0.16f;// текущее значение гравитации
            isAlive = true;
            score = 0; // счётчик очков
        }
    }
}
