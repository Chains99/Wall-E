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
    public partial class Wall_E : Form
    {
        int files = 10;
        int columns = 20;
        List<string> names;
        List<int> codes;
        Game game;
        string size = "";
        string color = "";
        bool color_;
        bool size_;
        bool direction_;
        int number;
        string shape;
        string direction = "";
      
        bool canpaint;

        public Wall_E()
        {
           
            InitializeComponent();
            game = new Game(files, columns);
            names = new List<string>();
            codes = new List<int>();

        }


        private void Map_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush b = new SolidBrush(Color.Black);
            Pen p = new Pen(Color.Black, 1);

            float height = 80;
            float width = 80;
            Map.Height = (int)(height * files);
            Map.Width = (int)(width * columns);
            for (int i = 0; i < columns; i++)
            {
                g.DrawLine(p, i * height - 1, 0, i * height - 1, Map.Height);
            }
            for (int j = 0; j < files; j++)
            {
                g.DrawLine(p, 0, j * width - 1, Map.Width, j * width - 1);
            }
          
                for (int i = 0; i < files; i++)
                    for (int j = 0; j < columns; j++)
                    {
                        GameObject o = game.obj(i, j);
                        if (o is Robot)
                        {
                            var a = Application.StartupPath;
                            g.DrawImage(Image.FromFile(o.shape + o.color + (o as Robot).GetDirection + ".png"), j * 80, i * 80, 79, 79);
                        }  
                        else if(o is GameObject)
                        {
                            g.DrawImage(Image.FromFile(o.shape + o.color + o.size + ".png"), j * 80, i * 80, 79, 79);
                        }
                    }
            }

        

        private void button1_Click(object sender, EventArgs e)
        {
            files = (int)numericUpDownFiles.Value;
            columns = (int)numericUpDownCol.Value;
            game = new Game(files, columns);
            Map.Refresh();
    

        }
        private void pictureBoxShowing_Paint(object sender, PaintEventArgs e)
        {
            bool a = shape != "" && color != "" && (size != "" || direction != "");
            if (a&& canpaint)
            {
                Image robot = Image.FromFile(shape+ color +direction+ size +".png");
                pictureBoxShowing.Image = robot;
                pictureBoxShowing.SizeMode = PictureBoxSizeMode.Zoom;a = false;canpaint = false;  return;
                
             
            }
        }
        private void pictureBoxSphere_Click(object sender, EventArgs e)
        {
            shape = "sphere";
            canpaint = true;
            direction = "";
            groupBoxDirection.Enabled = false;
            textBoxnumber.Enabled = true;
            textBoxName.Enabled = false;
            groupBoxColor.Enabled = true;
            groupBoxSize.Enabled = true;
            pictureBoxShowing.Refresh();
        }
        private void pictureBoxPlant_Click(object sender, EventArgs e)
        {

            shape = "plant";
            canpaint = true;
            direction = "";
            groupBoxDirection.Enabled = false;
            textBoxnumber.Enabled = true;
            textBoxName.Enabled = false;
            groupBoxColor.Enabled = true;
            groupBoxSize.Enabled = true;
            pictureBoxShowing.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            shape = "robot";
            size = "";
            canpaint = true;
            textBoxnumber.Enabled = true;
            textBoxName.Enabled = true;

            groupBoxColor.Enabled = true;
            groupBoxSize.Enabled = false;
            groupBoxDirection.Enabled = true;
            pictureBoxShowing.Refresh();

        }
        private void pictureBoxBox_Click(object sender, EventArgs e)
        {
    
            shape = "box";
            direction = "";
            canpaint = true;
            groupBoxDirection.Enabled = false;
            textBoxnumber.Enabled = true;
            textBoxName.Enabled = false;
            groupBoxColor.Enabled = true;
            groupBoxSize.Enabled = true;
            pictureBoxShowing.Refresh();
        }

        private void radioButtonRed_Click(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked )
            {
                color = "red";
                color_ = true;
                canpaint = true;

                pictureBoxShowing.Refresh();

            }
            
        }

        private void radioButtonBlack_Click(object sender, EventArgs e)
        {
            if (radioButtonBlack.Checked)
            {
                color = "black";
                color_ = true;
                canpaint = true;
                pictureBoxShowing.Refresh();
            }
        }

        private void radioButtonOrange_Click(object sender, EventArgs e)
        {
            if (radioButtonOrange.Checked )
            {
                color = "orange";
                color_ = true;
                canpaint = true;

                pictureBoxShowing.Refresh();
            }
        }

        private void radioButtonTransp_Click(object sender, EventArgs e)
        {
            if (radioButtonTransp.Checked)
            {
                color = "transparent";
                color_ = true;
                canpaint = true; 

                pictureBoxShowing.Refresh();
            }
        }

        private void radioButtonBrown_Click(object sender, EventArgs e)
        {
            if (radioButtonBrown.Checked )
            {
                color = "brown";
                color_ = true;
                canpaint = true;
                pictureBoxShowing.Refresh();
            }
        }

        private void radioButtonWhite_Click(object sender, EventArgs e)
        {
            if (radioButtonWhite.Checked )
            {
                color = "white";
                color_ = true;
                canpaint = true; 
               pictureBoxShowing.Refresh();
            }
        }

        private void radioButtonGreen_Click(object sender, EventArgs e)
        {
            if (radioButtonGreen.Checked)
            {
                color = "green";
                color_ = true;
                canpaint = true; 

                pictureBoxShowing.Refresh();
            }
        }

        private void radioButtonYellow_Click(object sender, EventArgs e)
        {
            if (radioButtonYellow.Checked)
            {
                color = "yellow";
                color_ = true;
                canpaint = true; ;

                pictureBoxShowing.Refresh();
            }
        }

        private void radioButtonBlue_Click(object sender, EventArgs e)
        {
            if (radioButtonBlue.Checked)
            {
                color = "blue";
                color_ = true;
                canpaint = true; ;

                pictureBoxShowing.Refresh();
            }
        }

      

        private void Map_MouseClick(object sender, MouseEventArgs e)
        { int number = Convert.ToInt32(textBoxnumber.Text);
            int x = e.Y * files/Map.Height;
            int y = e.X * columns/ Map.Width;
            if (shape == "robot" && color_  && direction_ && textBoxName.Text!=""&& names.IndexOf(textBoxName.Text)==-1 && codes.IndexOf(number)==-1)
            {
                game.AddRobot(x, y,direction,color, Convert.ToInt32(textBoxnumber.Text),textBoxName.Text);
                names.Add(textBoxName.Text);
                codes.Add(number);

                Map.Refresh();
           
                canpaint = false;
            }
            else if(color_ && size_&& codes.IndexOf(number)==-1)
            {
                switch(shape)
                {
                    case "box":
                        { game.AddObject(x, y, new Box(color, size, Convert.ToInt32(textBoxnumber.Text)));  Map.Refresh();canpaint = false; break; }
                    case "sphere":
                        {
                            game.AddObject(x, y, new Sphere(color, size, Convert.ToInt32(textBoxnumber.Text))); ; Map.Refresh(); canpaint = false; break;
                        }
                    case "plant":
                        { game.AddObject(x, y, new Plant(color, size, Convert.ToInt32(textBoxnumber.Text)));  Map.Refresh(); canpaint = false;  break; }
                }
                codes.Add(number);

            }
        }

        private void radioButtonSmall_Click(object sender, EventArgs e)
        {
          if(radioButtonSmall.Enabled)
            {
                direction = "";
                size = "small";
                size_ = true;
                canpaint = true;
                pictureBoxShowing.Refresh();
            }
        }

        private void radioButtonMedium_Click(object sender, EventArgs e)
        {
            if (radioButtonMedium.Enabled)
            {
                direction = "";
                size = "medium";
                size_=true;
                canpaint = true;
                pictureBoxShowing.Refresh();
            }
        }

        private void radioButtonLarge_Click(object sender, EventArgs e)
        {
            if (radioButtonLarge.Enabled)
            {
                direction = "";
                size = "large";
                size_ = true;
                canpaint = true;
                pictureBoxShowing.Refresh();
            }
        }

        private void radioButtonNorth_Click(object sender, EventArgs e)
        {
            if (radioButtonNorth.Enabled)
            {
                size = "";
                direction = "north";
                direction_ = true;
                canpaint = true;
                pictureBoxShowing.Refresh();
            }
        
        }

        private void radioButtonSouth_Click(object sender, EventArgs e)
        {
            if (radioButtonNorth.Enabled)
            {
                size = "";
                direction = "south";
                direction_ = true;
                pictureBoxShowing.Refresh();
            }
        }

        private void radioButtonEast_Click(object sender, EventArgs e)
        {
            if (radioButtonEast.Enabled)
            {
                direction = "east";
                direction_ = true;
                pictureBoxShowing.Refresh();
            }
        }

        private void radioButtonWest_Click(object sender, EventArgs e)
        {
            if (radioButtonWest.Enabled)
            {
                size = "";
                direction = "west";
                direction_ = true;
                pictureBoxShowing.Refresh();
            }
        }

        private void Map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int x = e.Y * files / Map.Height;
            int y = e.X * columns / Map.Width;
            if(game.obj(x,y)is Robot)
            {
               
                RobotInstruc a = new RobotInstruc((Robot)game.obj(x, y));
                a.Show();
               
   
            }
          
          
        }

        private void executeTSMI_Click(object sender, EventArgs e)
        {
            if (game.Count != 0)
            {
                Game_Wall_E a = new Game_Wall_E(game);
                a.Show();
            }
           
        }

        
    }
}

      
