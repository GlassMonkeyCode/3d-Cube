using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3dPractice
{
    class GraphicsRenderer
    {
        static internal Bitmap DrawShape(PictureBox pictureBox, float width, float height, Point shapeLocation, int yaw)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            float halfCanvasWidth = pictureBox.Width / 2;
            float halfCanvasHeight = pictureBox.Height / 2;
            float halfShapeWidth = width / 2F + yaw;
            float halfShapeHeight = height / 2F + yaw;

            Random random = new Random();

            double randomDouble = random.NextDouble() * 100;
            double randomDouble2 = random.NextDouble() * 350;
            double randomDouble3 = random.NextDouble() * 200;
            double randomDouble4 = random.NextDouble() * 500;
            double randomDouble5 = random.NextDouble() * 380;
            double randomDouble6 = random.NextDouble() * 600;

            if (yaw == 10)
            {
                yaw = -10;
            }

            Point centreOfCanvas = new Point(Convert.ToInt32(halfCanvasWidth), Convert.ToInt32(halfCanvasHeight));
            graphics.FillRectangle(Brushes.Black, 0, 0, pictureBox.Width, pictureBox.Height);

            int howMany = random.Next(5, 100);

            for (int index = 0; index < howMany; index++)
            {
                int randomRandom = Convert.ToInt32(random.NextDouble() * 5);
                int randomRandom2 = Convert.ToInt32(random.NextDouble() * 5);
                int randomRandom3 = Convert.ToInt32(random.NextDouble() * 5);
                int randomRandom4 = Convert.ToInt32(random.NextDouble() * 5);
                int randomRandom5 = Convert.ToInt32(random.NextDouble() * 5);
                int randomRandom6 = Convert.ToInt32(random.NextDouble() * 5); 

                double randomNum = random.NextDouble() * 100;
                double randomNum2 = random.NextDouble() * 500;
                double randomNum3 = random.NextDouble() * (pictureBox.Width - 300);
                double randomNum4 = random.NextDouble() * 200;
                double randomNum5 = random.NextDouble() * (pictureBox.Width - 300);
                double randomNum6 = random.NextDouble() * pictureBox.Height;

                double[] doubles = new double[] { randomNum, randomNum2, randomNum3, randomNum4, randomNum5, randomNum6}; 

                Point point = new Point(Convert.ToInt32(doubles[randomRandom]), Convert.ToInt32(doubles[randomRandom3]));
                Point point2 = new Point(Convert.ToInt32(doubles[randomRandom2]), Convert.ToInt32(doubles[randomRandom5]));
                Point point3 = new Point(Convert.ToInt32(doubles[randomRandom4]), Convert.ToInt32(doubles[randomRandom6]));
                Point[] pointss = new Point[] { point, point2, point3 };

                int randomColorR = Convert.ToInt32(random.NextDouble() * 255);
                int randomColorG = Convert.ToInt32(random.NextDouble() * 255);
                int randomColorB = Convert.ToInt32(random.NextDouble() * 255);

                Color color = Color.FromArgb(170, randomColorR, randomColorG, randomColorB);
                Brush brus = new SolidBrush(color);  

                graphics.FillPolygon(brus, pointss);
            }




       
            graphics.Dispose();
            return bitmap;
        }
    }
}
