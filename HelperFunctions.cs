using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotate
{
    class HelperFunctions
    {
        static public PointF ConvertAngleAndDistanceToXY(double angleInDegrees, double radius)
        {
            double angleInRadians = HelperFunctions.ConvertDegreesToRadians(angleInDegrees);
            int x = Convert.ToInt32(Math.Sin(angleInRadians) * radius);
            int y = Convert.ToInt32(Math.Cos(angleInRadians) * radius);

            return new PointF(x, y);
        }

        static public double ConvertDegreesToRadians(double angleInDegrees)
        {
            return angleInDegrees * (Math.PI / 180F);
        }

        static public double ConvertRadiansToDegrees(double angleInRadians)
        {
            return angleInRadians * 180F / Math.PI;
        }

        static public PointF[] RotatePolygon(PointF[] pointArray, double rotationAngle, PointF origin)
        {
            List<PointF> returnPoints = new List<PointF>();

            foreach (PointF point in pointArray)
            {
                PointF relativePoint = new PointF(point.X - origin.X, point.Y - origin.Y);
                AngleAndDistance angleAndDistance = HelperFunctions.GetAngleAndDistance(origin, point);
                PointF rotatedRelativePoint = HelperFunctions.ConvertAngleAndDistanceToXY
                    (angleAndDistance.AngleInDegrees + rotationAngle, angleAndDistance.Distance);
                returnPoints.Add(new PointF(rotatedRelativePoint.X + origin.X, rotatedRelativePoint.Y + origin.Y));
            }

            return returnPoints.ToArray();
        }

        static public AngleAndDistance GetAngleAndDistance(PointF p1, PointF p2)
        {
            AngleAndDistance angleAndDistance = new AngleAndDistance();

            angleAndDistance.Distance = HelperFunctions.GetDistanceBetweenTwoPoints(p1, p2);
            angleAndDistance.AngleInDegrees = HelperFunctions.GetAngleBetweenTwoPoints(p1, p2);
            return angleAndDistance;
        }

        static public double GetDistanceBetweenTwoPoints(PointF p1, PointF p2)
        {
            double distanceBetweenTwoPoints = 0;

            distanceBetweenTwoPoints = Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));

            return distanceBetweenTwoPoints;
        }

        static public double GetAngleBetweenTwoPoints(PointF p1, PointF p2)
        {
            double angleBetweenTwoPointsInRadians = Math.Atan2(Convert.ToDouble(p1.X - p2.X), Convert.ToDouble(p1.Y - p2.Y));

            return HelperFunctions.ConvertRadiansToDegrees(angleBetweenTwoPointsInRadians);
        }
    }
}
