using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rotate
{
    class GraphicsRenderer
    {
        //static internal Bitmap DrawRotatingRectangle(PictureBox pictureBox, float rectangleWidth,
        //    float rectangleHeight, float yawNumber, bool isLeftButton, Point centrePoint)
        //{
           
        //    Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        //    Graphics graphics = Graphics.FromImage(bitmap);

        //    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        //    bool overrided = false;

        //    float radius = rectangleWidth / 2F;
        //    float newRadius = radius * 0.03F;
        //    Brush brush = new SolidBrush(Color.Black);
        //    Pen pen = new Pen(brush, Convert.ToSingle(newRadius / 2F));
            
        //    // Points

        //    Point leftTop = new Point();
        //    Point leftBottom = new Point();
        //    Point rightTop = new Point();
        //    Point rightBottom = new Point();
        //    float xIncrement = 4;
        //    int increment = 1;

        //    Point currentPoint;
        //    if (isLeftButton)
        //    {
        //        currentPoint = new Point(Convert.ToInt32((yawNumber * xIncrement) + centrePoint.X - rectangleWidth / 2F), centrePoint.Y);
        //    }
        //    else
        //    {
        //        currentPoint = new Point(Convert.ToInt32((yawNumber * (-xIncrement)) + centrePoint.X - rectangleWidth / 2F), centrePoint.Y);
        //    }
   
        //    Point[] points5;
        //    float xMovement = yawNumber * xIncrement;

        //    float xLeftPosition = centrePoint.X - (rectangleWidth / 2F);
        //    float xRightPosition = centrePoint.X + (rectangleWidth / 2F);

        //    int allLeftXs = Convert.ToInt32(xLeftPosition + xMovement);
        //    int allRightXs = Convert.ToInt32(xRightPosition - xMovement);

        //    float yTopPosition = centrePoint.Y - (rectangleHeight / 2F);
        //    float yBottomPosition = centrePoint.Y + (rectangleHeight / 2F);


        //    if (currentPoint.X < centrePoint.X)
        //    {
                
        //        increment = 1;
        //        // Contracting left
        //        leftTop = new Point(allLeftXs, Convert.ToInt32(yTopPosition + yawNumber));        
        //        leftBottom = new Point(allLeftXs, Convert.ToInt32(yBottomPosition - yawNumber));

        //        // Expanding right
        //        rightTop = new Point(allRightXs, Convert.ToInt32(yTopPosition - yawNumber));        
        //        rightBottom = new Point(allRightXs, Convert.ToInt32(yBottomPosition + yawNumber));
        //    }
        //    else
        //    {

        //        increment = -1;
        //        // Expanding left
        //        leftTop = new Point(allRightXs, Convert.ToInt32(yTopPosition - yawNumber));
        //        leftBottom = new Point(allRightXs, Convert.ToInt32(yBottomPosition + yawNumber));

        //        // Contracting right
        //        rightTop = new Point(allLeftXs, Convert.ToInt32(yTopPosition + yawNumber));
        //        rightBottom = new Point(allLeftXs, Convert.ToInt32(yBottomPosition - yawNumber));
        //    }
          
        //    // Drawing
        //    int rValue = Convert.ToInt32(255 - yawNumber);

        //    int gValue = Convert.ToInt32(0);
        //    int bValue = Convert.ToInt32(0 + (yawNumber/2));
        //    if (rValue < 1 || rValue > 255)
        //    {
        //        rValue = 255;
        //    }
        //    if(gValue >= 255 || gValue < 1)
        //    {
        //        gValue = 0;
        //    }
        //    if (bValue >= 255 || bValue < 1)
        //    {
        //        bValue = 0;
        //    }

        //    Color variableColor = Color.FromArgb(255, rValue, gValue, bValue);

        //    Color variableSideColor = Color.FromArgb(255, rValue, bValue, bValue);
        //    Brush brushRed = new SolidBrush(variableColor);

        //    if (leftTop.Y > leftBottom.Y)
        //    {
        //        Point trLT = leftTop;
        //        Point trLB = leftBottom;
        //        leftTop = trLB;
        //        leftBottom = trLT;
        //    }
        //    if (rightTop.Y > rightBottom.Y)
        //    {
        //        if(yawNumber != 50)
        //        {
        //            Point trRT = rightTop;
        //            Point trRB = rightBottom;
        //            rightTop = trRB;
        //            rightBottom = trRT;
        //        }
               
        //    }

        //    if (currentPoint.X >= centrePoint.X)
        //    {
 
        //        points5 = new Point[] { leftTop, leftBottom, rightBottom, rightTop, leftTop };
        //    }
        //    else
        //    {     
        //        points5 = new Point[] { leftTop, leftBottom, rightBottom, rightTop, leftTop };
        //    }

        //    Point topRightCorner = new Point(Convert.ToInt32(pictureBox.Width-yawNumber -400), rightTop.Y);
        //    Point bottomRightCorner = new Point(Convert.ToInt32(pictureBox.Width - yawNumber-400), rightBottom.Y);
        //    Point newLeftBottomShadow = new Point(leftBottom.X + 200, leftBottom.Y);
        //    Point outRightTop = new Point(newLeftBottomShadow.X, leftTop.Y);

        //    Point[] shadowPoints4 = new Point[] { newLeftBottomShadow, leftBottom,  rightBottom, bottomRightCorner };
        //    Point[] frontSidePoints1 = new Point[] { rightBottom, rightTop, topRightCorner, bottomRightCorner};
        //    Point[] parallelSidePoints2 = new Point[] { outRightTop, newLeftBottomShadow, bottomRightCorner, topRightCorner};
        //    Point[] backSidePoints3 = new Point[] {leftTop, leftBottom, newLeftBottomShadow, outRightTop};

        //    Color shadowColor = Color.FromArgb(40, 0, 0, 0);
        //    Color shadowColor2 = Color.FromArgb(40, 255, 255, 255);

        //    Brush shadowBrush = new SolidBrush(shadowColor);
        //    Brush shadowBrush2 = new SolidBrush(shadowColor2);
        //    Brush sideBrush = new SolidBrush(variableSideColor);

        //    // Axis /////////////////////////////////////////////////////////////////////////////
        //    Point botLeft = new Point(0, pictureBox.Height);
        //    Point realCentre = new Point(pictureBox.Width / 2, Convert.ToInt32((pictureBox.Height / 2) * 1.5));
        //    Point topMiddle = new Point(realCentre.X, 0);
        //    Point botRight = new Point(pictureBox.Width, pictureBox.Height);
        //    Point botMiddle = new Point(pictureBox.Width/2, pictureBox.Height);
        //    graphics.DrawLine(Pens.Blue, realCentre, topMiddle);
        //    graphics.DrawLine(Pens.Red, realCentre, botLeft);
        //    graphics.DrawLine(Pens.Green, realCentre, botRight);

        //    Point aPoint = new Point(0, Convert.ToInt32(pictureBox.Height * 0.5));
        //    Point bPoint = new Point(pictureBox.Width, Convert.ToInt32(pictureBox.Height * 0.5));
        //    Color lightGreen = Color.FromArgb(110, 0, 255, 0);
        //    Pen penG = new Pen(lightGreen);
        //    Color lightRed = Color.FromArgb(110, 255, 0, 0);
        //    Pen penR = new Pen(lightRed);
        //    Color lightBlue = Color.FromArgb(110, 0, 0, 255);
        //    Pen penB = new Pen(lightBlue);
        //    graphics.DrawLine(penG, aPoint, realCentre);
        //    graphics.DrawLine(penR, bPoint, realCentre);
        //    graphics.DrawLine(penB, realCentre, botMiddle);

        //    // End of axis ///////////////////////////////////////////////////////////////////////

        //    //graphics.FillPolygon(sideBrush, frontSidePoints1);
        //    //graphics.FillPolygon(Brushes.LightGray, backSidePoints3);
        //    //graphics.FillPolygon(shadowBrush2, parallelSidePoints2);
           
        //    //graphics.FillPolygon(shadowBrush, shadowPoints4);
        //    //graphics.FillPolygon(brushRed, points5);

        //    graphics.DrawPolygon(Pens.Black, frontSidePoints1);
        //    graphics.DrawPolygon(Pens.Black, parallelSidePoints2);
        //    graphics.DrawPolygon(Pens.Black, backSidePoints3);
        //    graphics.DrawPolygon(Pens.Black, shadowPoints4);
        //    graphics.DrawPolygon(Pens.Black, points5);


        //    float opposite = pictureBox.Height - realCentre.Y;
        //    float adjacent = pictureBox.Width / 2F;

         
           

        //    graphics.Dispose();
        //    return bitmap;
        //}

        //static internal Bitmap DrawTrippySquares(PictureBox pictureBox, float yawNumber, bool isLeftButton, Point centrePoint)
        //{
        //    Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        //    Graphics graphics = Graphics.FromImage(bitmap);
        //    float halfWidth = pictureBox.Width/2;
        //    float halfHeight = pictureBox.Height/2;

        //    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        //    float randomFloat = 0.7F;
        //    float randomFloat2 = DateTime.Now.Second / 100;

          
        //    Point realCentre = new Point(pictureBox.Width / 2, Convert.ToInt32((pictureBox.Height / 2) * 1.5));
        //    Point topMiddle = new Point(realCentre.X, 0);
            
        //    Point botMiddle = new Point(pictureBox.Width / 2, pictureBox.Height);
                                
        //    Color lightRed = Color.FromArgb(150, 255, 0, 0);
        //    Color lightGreen = Color.FromArgb(150, 0, 255, 0);
        //    Color lightBlue = Color.FromArgb(150, 0, 0, 255);

        //    Pen penR = new Pen(lightRed);
        //    Pen penG = new Pen(lightGreen);
        //    Pen penB = new Pen(lightBlue);

        //    Point farRightPoint = new Point(0, Convert.ToInt32(pictureBox.Height * 0.5));
        //    Point farLeftPoint = new Point(pictureBox.Width, Convert.ToInt32(pictureBox.Height * 0.5));
        //    Point botLeftish = new Point(0, Convert.ToInt32(pictureBox.Height - yawNumber*3));
        //    Point botRightish = new Point(pictureBox.Width, Convert.ToInt32(pictureBox.Height - yawNumber*3));

        //    graphics.DrawLine(penR, farLeftPoint, botLeftish);
        //    graphics.DrawLine(penG, farRightPoint, botRightish);               
        //    graphics.DrawLine(penB, topMiddle, botMiddle);


        //    // Outer Square
        //    Point oSTopLeftPoint = new Point(Convert.ToInt32((pictureBox.Width * randomFloat) + yawNumber), Convert.ToInt32((pictureBox.Height * randomFloat) + yawNumber));
        //    Point oSBottomLeftPoint = new Point(Convert.ToInt32((pictureBox.Width * randomFloat) + yawNumber), Convert.ToInt32((pictureBox.Height * randomFloat) - yawNumber));
        //    Point oSTopRightPoint = new Point(Convert.ToInt32((pictureBox.Width * randomFloat) - yawNumber), Convert.ToInt32((pictureBox.Height * randomFloat) + yawNumber));
        //    Point oSBottomRightoint = new Point(Convert.ToInt32((pictureBox.Width * randomFloat) - yawNumber), Convert.ToInt32((pictureBox.Height * randomFloat) - yawNumber));

        //    // Inner Square
        //    Point iSTopLeftPoint = new Point(Convert.ToInt32(halfWidth - 100 - yawNumber), Convert.ToInt32(halfHeight - 100 - yawNumber));
        //    Point iSBottomLeftPoint = new Point(Convert.ToInt32(halfWidth - 100 - yawNumber), Convert.ToInt32(halfHeight + 100 + yawNumber));
        //    Point iSTopRightPoint = new Point(Convert.ToInt32(halfWidth + 100 + yawNumber), Convert.ToInt32(halfHeight - 100 - yawNumber));
        //    Point iSBottomRightoint = new Point(Convert.ToInt32(halfWidth + 100 + yawNumber), Convert.ToInt32(halfHeight + 100 + yawNumber));

        //    Point[] pointsForOuterSquare = new Point[] { oSTopLeftPoint, oSBottomLeftPoint, oSBottomRightoint, oSTopRightPoint };
        //    Point[] pointsForInnerSquare = new Point[] { iSTopLeftPoint, iSBottomLeftPoint, iSBottomRightoint, iSTopRightPoint };
        //    graphics.DrawPolygon(Pens.Black, pointsForOuterSquare);

        //    graphics.DrawLine(Pens.Black, oSTopLeftPoint, iSTopLeftPoint);
        //    graphics.DrawLine(Pens.Black, oSBottomLeftPoint, iSBottomLeftPoint);
        //    graphics.DrawLine(Pens.Black, oSTopRightPoint, iSTopRightPoint);
        //    graphics.DrawLine(Pens.Black, oSBottomRightoint, iSBottomRightoint);

        //    graphics.DrawPolygon(Pens.Black, pointsForInnerSquare);


        //    graphics.Dispose();
        //    return bitmap;
        //}

        static internal Bitmap DrawCube(PictureBox pictureBox, double xAngle, double yAngle, double zAngle, PointF centrePoint, float actualEdgeLength)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                float halfWidth = pictureBox.Width / 2;
                float halfHeight = pictureBox.Height / 2;
                float halfEdgeLength = actualEdgeLength / 2F;

                double radX = HelperFunctions.ConvertDegreesToRadians(xAngle);
                double radY = HelperFunctions.ConvertDegreesToRadians(yAngle);
                double radZ = HelperFunctions.ConvertDegreesToRadians(zAngle);
                // X and Y angles are both 20ish. It is the Z angle that will change.
                // 90 for x and y looks directly at the screen, 0 would show a line
                double perceivedLengthXDouble = actualEdgeLength * Math.Cos(radX);
                double perceivedLengthYDouble = actualEdgeLength * Math.Cos(radY);

                float perceivedEdgeLengthX = Convert.ToSingle(perceivedLengthXDouble);

                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                float leftXs = centrePoint.X - halfEdgeLength;
                float rightXs = centrePoint.X + halfEdgeLength;
                float topYs = centrePoint.X - halfEdgeLength;
                float bottomYs = centrePoint.X + halfEdgeLength;

                float halfPercX = perceivedEdgeLengthX / 2F;

                PointF pointA = new PointF(leftXs, bottomYs + halfPercX);
                PointF pointB = new PointF(rightXs, bottomYs + halfPercX);
                PointF pointC = new PointF(rightXs + halfPercX, topYs + halfPercX);
                PointF pointD = new PointF(leftXs + halfPercX, topYs + halfPercX);

                PointF pointE = new PointF(leftXs, bottomYs + halfPercX - actualEdgeLength);
                PointF pointF = new PointF(rightXs, bottomYs + halfPercX - actualEdgeLength);
                PointF pointG = new PointF(rightXs + halfPercX, topYs + halfPercX - actualEdgeLength);
                PointF pointH = new PointF(leftXs + halfPercX, topYs + halfPercX - actualEdgeLength);

                PointF[] bottomFacePoints = new PointF[] { pointA, pointE, pointF, pointB };
                PointF[] topFacePoints = new PointF[] { pointB, pointF, pointG, pointC };
                PointF[] leftBackFacePoints = new PointF[] { pointC, pointG, pointH, pointD };
                PointF[] rightBackFacePoints = new PointF[] { pointA, pointD, pointH, pointE };
                PointF[] bottoms = new PointF[] { pointA, pointB, pointC, pointD };
                PointF[] tops = new PointF[] { pointE, pointF, pointG, pointH };

                PointF[] rotatedAroundZBot = HelperFunctions.RotatePolygon(bottomFacePoints, zAngle, centrePoint);
                PointF[] rotatedAroundZTop = HelperFunctions.RotatePolygon(topFacePoints, zAngle, centrePoint);
                PointF[] rotatedAroundZL = HelperFunctions.RotatePolygon(leftBackFacePoints, zAngle, centrePoint);
                PointF[] rotatedAroundZR = HelperFunctions.RotatePolygon(rightBackFacePoints, zAngle, centrePoint);
                PointF[] rotatedAroundZactbot = HelperFunctions.RotatePolygon(bottoms, zAngle, centrePoint);
                PointF[] rotatedAroundZacttop = HelperFunctions.RotatePolygon(tops, zAngle, centrePoint);

                graphics.FillPolygon(Brushes.LightBlue, rotatedAroundZBot);
                graphics.FillPolygon(Brushes.SteelBlue, rotatedAroundZTop);
                graphics.FillPolygon(Brushes.LightSteelBlue, rotatedAroundZR);
                graphics.FillPolygon(Brushes.AliceBlue, rotatedAroundZL);
                graphics.FillPolygon(Brushes.Gray, rotatedAroundZactbot);
                //  graphics.FillPolygon(Brushes.CadetBlue, rotatedAroundZacttop);


                graphics.DrawPolygon(Pens.Black, rotatedAroundZBot);
                graphics.DrawPolygon(Pens.Black, rotatedAroundZTop);
                graphics.DrawPolygon(Pens.Black, rotatedAroundZR);
                graphics.DrawPolygon(Pens.Black, rotatedAroundZL);


                graphics.Dispose();
            }

         
            
            return bitmap;
          
        }
    }
}
