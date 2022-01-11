using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_2018_2019_Wall_E;
using Proyecto_2018_2019_Wall_E.Objects;



namespace Wall_E
{
    public partial class Game_Wall_E : Form
    {
        Game game;
     
        bool canpaint = false;
        bool canpaintins = false;

        public Game_Wall_E(Game game)
        {
            InitializeComponent();
            this.game = game;  
        }

        private void pictureBoxMap_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            float height = 60;
            float width = 60;
            int files = game.files;
            int columns = game.cols;
            pictureBoxMap.Height = (int)(height * files);
            pictureBoxMap.Width = (int)(width * columns);
            for (int i = 0; i < columns; i++)
            {
                g.DrawLine(p, i * height - 1, 0, i * height - 1, pictureBoxMap.Height);
            }
            for (int j = 0; j < files; j++)
            {
                g.DrawLine(p, 0, j * width - 1, pictureBoxMap.Width, j * width - 1);
            }

            for (int i = 0; i < files; i++)
                for (int j = 0; j < columns; j++)
                {
                   
                    GameObject o = game.obj(i, j);
                    if (o is Robot)
                    {
                        var a = Application.StartupPath;
                        g.DrawImage(Image.FromFile(o.shape + o.color + (o as Robot).GetDirection + ".png"), j * 60, i * 60, 59, 59);
                    }
                    else if (o is GameObject)
                    {
                        g.DrawImage(Image.FromFile(o.shape + o.color + o.size + ".png"), j * 60, i * 60, 59, 59);
                    }
                }
        }

        private void play_Click(object sender, EventArgs e)
        {
            IntervalInst_TextChanged(sender, e);
            IntervalRounds_TextChanged(sender, e);

            timer1.Start();
            timer2.Start();
        }
 
        private void pictureBoxAdvance_Click(object sender, EventArgs e)
        {
            IntervalInst_TextChanged(sender, e);
            IntervalRounds_TextChanged(sender, e);
            timer1.Enabled = true;
           
        }
        private void pictureBoxDebug_Click(object sender, EventArgs e)
        {
            
            game.DebugBotton();
            canpaintins = true;
            canpaint = true;
            textBoxRobotName.Text = game.GetRobotName;
            textBoxNRounds.Text = game.GetRound.ToString();
            textBoxLastValue.Text = game.LastValue;
            pictureBoxInst.Refresh();
            pictureBoxMap.Refresh();
            pictureBoxOinside.Refresh();

        }

        private void pictureBoxInst_Paint(object sender, PaintEventArgs e)
        {
            if (canpaintins)
            {
                Graphics g = e.Graphics;
                SolidBrush b = new SolidBrush(Color.FromArgb(200, 238, 100, 80));
                Pen p = new Pen(Color.Black, 1);

                int rows = game.matrixOnHeight;
                int columns = game.matrixOnWidth;

                float height = 60;
                float width = 60;
                pictureBoxInst.Height = (int)(height * rows);
                pictureBoxInst.Width = (int)(width * columns);
                for (int i = 0; i < columns; i++)
                {
                    g.DrawLine(p, i * height - 1, 0, i * height - 1, pictureBoxInst.Height);
                }
                for (int j = 0; j < rows; j++)
                {
                    g.DrawLine(p, 0, j * width - 1, pictureBoxInst.Width, j * width - 1);
                }

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < columns; j++)
                    {



                        Instructions inst = game.InstinConsum(i, j);
                        if (inst != null)
                        {
                            if (inst.name == "print") richTextBoxConsole.Text = game.GetRobotName + "-" + (inst as Print).console;
                            var a = Application.StartupPath;
                            g.DrawImage(Image.FromFile(inst.name + ".png"), j * 60, i * 60, 59, 59);
                        }
                        if (game.ActualMatrixPOsition().Item1 == i && game.ActualMatrixPOsition().Item2 == j)
                        {
                            float x = j * 60;
                            float y = i * 60;
                            RectangleF rect = new RectangleF(x, y, 60, 60);
                            g.FillRectangle(b, rect);
                        }
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBoxDebug_Click(sender, null);

            if (game.Advance)

            { timer1.Stop(); return; }
 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

             timer2.Stop(); 
            play_Click(sender, e);
          
        }

        private void pictureBoxstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            game.stop();
            canpaint = false;
            canpaintins = false;
            pictureBoxInst.Refresh();
        }

        private void pictureBoxPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void pictureBoxOInside_Paint(object sender, PaintEventArgs e)
        {
            if (canpaint)
            {
                Graphics g = e.Graphics;
                GameObject o = game.inside();
                if (o != null)
                {

                    Image img = Image.FromFile(o.shape + o.color + o.size + ".png");
                    pictureBoxOinside.Image = img;
                    pictureBoxOinside.SizeMode = PictureBoxSizeMode.Zoom;
                  


                    canpaint = false;
                }
                else
                {
                    Image img = Image.FromFile("empty.png");
                    pictureBoxOinside.Image = img;
                    pictureBoxOinside.SizeMode = PictureBoxSizeMode.Zoom;
                    canpaint = false;
                }

            }
            

            }

        private void Game_Wall_E_Load(object sender, EventArgs e)
        {
            pictureBoxstop_Click(sender, e);
        }

        private void IntervalRounds_TextChanged(object sender, EventArgs e)
        {
            int interval;
            if(int.TryParse(IntervalRounds.Text,out interval))
                   timer2.Interval = interval; 
              
        }

        private void IntervalInst_TextChanged(object sender, EventArgs e)
        {

            int interval;
            if (int.TryParse(IntervalInst.Text, out interval))
                timer1.Interval = interval;
        }

     
    }
    }

