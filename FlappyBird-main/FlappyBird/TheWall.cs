using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    class TheWall
    {
        public int x;
        public int y;

        public int sizeX;
        public int sizeY;

        public Image wallImg;

        public TheWall(int x, int y,bool isRotatedImage=false) // объект препядствия
        {
            wallImg = new Bitmap(@"fwall.png");
            this.x = x;
            this.y = y;
            sizeX = 90;
            sizeY = 500;
            if(isRotatedImage)  // поворот картинки
                wallImg.RotateFlip(RotateFlipType.Rotate180FlipX);
        }
    }
}
