using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
namespace Golovanov_tomogram_visualizer
{
    public partial class Form1 : Form
    {
        private int frameCount;
        private DateTime nextFPSUpdate;
        private bool loaded = false;
        private Bin binReader = new Bin();
        private View view = new View();
        private int currentLayer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string path = opf.FileName;
                binReader.ReadBIN(path);
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
                trackBar1.Maximum = Bin.Z - 1;
            }
        }
        private void DisplayFPS()
        {
            if(DateTime.Now >= nextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer (fps = {0})", frameCount);
                nextFPSUpdate = DateTime.Now.AddSeconds(1);
                frameCount = 0;
            }
            frameCount++;
        }
        private void ApplicationIdle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                DisplayFPS();
                glControl1.Invalidate();
            }
        }
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                view.DrawQuads(currentLayer);
                glControl1.SwapBuffers();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar1.Value;
            label1.Text = currentLayer.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += ApplicationIdle;
        }
    }
}
