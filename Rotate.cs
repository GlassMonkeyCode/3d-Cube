using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rotate
{
    public partial class Rotate : Form
    { 
        Point centrePoint;
        float _acutalEdgeLength;
        int _xAngle;
        int _yAngle;
        int _zAngle;
   

        public Rotate()
        {
            InitializeComponent();
        }


        private void Rotate_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            centrePoint = new Point((picMain.Width / 2), (picMain.Height / 2)+100);
            _acutalEdgeLength = (picMain.Height / 2F);

            _yAngle = 20;
            _xAngle = 20;
            _zAngle = 45;
      
        }

       

        private void Rotate_Resize(object sender, EventArgs e)
        {
            centrePoint = new Point((picMain.Width / 2), (picMain.Height / 2) + 200);
            picMain.BackgroundImage = GraphicsRenderer.DrawCube(picMain, tbXAngle.Value, _yAngle, tbZangle.Value, centrePoint, tbLength.Value);
        }

        private void tbXAngle_Scroll(object sender, EventArgs e)
        {        
            picMain.BackgroundImage = GraphicsRenderer.DrawCube(picMain, tbXAngle.Value, _yAngle, tbZangle.Value, centrePoint, tbLength.Value);     
        }

        private void tbZangle_Scroll(object sender, EventArgs e)
        {                       
            picMain.BackgroundImage = GraphicsRenderer.DrawCube(picMain, tbXAngle.Value, _yAngle, tbZangle.Value, centrePoint, tbLength.Value);
            
       }

        private void tbLength_Scroll(object sender, EventArgs e)
        {

            centrePoint.Y = tbVert.Value;
            picMain.BackgroundImage = GraphicsRenderer.DrawCube(picMain, tbXAngle.Value, _yAngle, tbZangle.Value, centrePoint, tbLength.Value);
          
        }

      
    }
}
