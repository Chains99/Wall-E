using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Proyecto_2018_2019_Wall_E.Objects;
using Proyecto_2018_2019_Wall_E;

namespace Wall_E
{
    public partial class RobotInstruc : Form
    {
        int numbInt;
       
        List<int> files;
        List<int> cols;
        List<Instructions> instructions;
      
        Image image;
        Robot robot;
        string name;
        bool click = false;
        int matrixcounter = 0;

        public RobotInstruc(Robot robot)
        {
            InitializeComponent();
            this.robot = robot;
            Initialize();

        }


        private void Initialize()
        {
            int count = robot.Count();
            if (robot.Count() > 1)
            {
                click = true;
                for (int i = 1; i < count; i++)
                {
                    matrixcounter = i;

                    addRoutineTSMI_Click(this, null);

                }
                click = false;
            }
        }
        private void loadInNewTabPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addRoutineTSMI_Click(sender, null);
            loadToolStripMenuItem_Click(sender, e);
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = int.Parse(tabControlMatrix.SelectedTab.Name[7].ToString());

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                StreamReader reader=File.OpenText(ofd.FileName);
                int instructionLim;
                int i = 0;
                
                int number;
                files = new List<int>();
                string[] a = new string[3];
                cols = new List<int>();
                instructions = new List<Instructions>();
             

                instructionLim = int.Parse(reader.ReadLine().Trim());
                for (; i < instructionLim; i++)
                {
                    string s = reader.ReadLine();
                    if (s.Split().Length != 3)
                        throw new Exception("Invalid file");
                         a = s.Split();

                    if (!int.TryParse(a[0], out number))
                        throw new Exception("Invalid file");
                    files.Add(number);
                    if (!int.TryParse(a[1], out number))
                        throw new Exception("Invalid file");
                    cols.Add(number);
                    Instructions inst = Instructions_Dictionary.GetValue(a[2]);
                    if (inst == null)
                        throw new Exception("Invalid File");
                    instructions.Add(inst);
                   
                }
                string k = reader.ReadToEnd();
                if (k != "")
                    throw new Exception("Invalid File");
                robot.ConfigRoutine(index, files.Max()+1, cols.Max()+3);
                for (int j = 0; j < instructions.Count; j++)
                {
                    robot.AddInstructions(instructions[j], files[j], cols[j],index);
                }
                reader.Close();
                foreach (var item in tabControlMatrix.SelectedTab.Controls)
                {
                    if (item is PictureBox)
                    { (item as PictureBox).Refresh(); break; }
                } 

                
                
                

            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        { int index = int.Parse(tabControlMatrix.SelectedTab.Name[7].ToString());
          if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {   
                StreamWriter writer = File.CreateText(saveFileDialog1.FileName);
                
                writer.WriteLine(robot.GetNInstructions(index));
                for (int i = 0; i < robot.MatrixHeight(index) ; i++)
                    for (int j = 0; j < robot.MatrixWidth(index); j++)
                    {
                        Instructions ins = robot.InstPos(i, j, index);
                        if (ins != null)
                            writer.WriteLine(i.ToString() + " " + j.ToString() + " " + ins.name);

                    }
                writer.Close();
            }
        }

        private void pictureBoxM1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush b = new SolidBrush(Color.Black);
            Pen p = new Pen(Color.Black, 1);
            int index = int.Parse((sender as PictureBox).Name[11].ToString());
            int rows = robot.MatrixHeight(index);
            int columns = robot.MatrixWidth(index);

            float height = 60;
            float width = 60;
            (sender as PictureBox).Height = (int)(height *rows );
            (sender as PictureBox).Width = (int)(width * columns);
            for (int i = 0; i < columns; i++)
            {
                g.DrawLine(p, i * height - 1, 0, i * height - 1, (sender as PictureBox).Height);
            }
            for (int j = 0; j < rows; j++)
            {
                g.DrawLine(p, 0, j * width - 1, (sender as PictureBox).Width, j * width - 1);
            }

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    Instructions inst = robot.InstPos(i, j, index);
                    if (inst != null)
                    {
                        var a = Application.StartupPath;
                        g.DrawImage(Image.FromFile(inst.name + ".png"), j * 60, i * 60, 59, 59);
                    }
                }
            
        }
    
      
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        { int temp;
            if (!int.TryParse(toolStripTextRows.Text, out temp))
                throw new Exception("Invalid Type");
           int rows = temp;
            if (!int.TryParse(toolStripTextCol.Text, out temp))
                throw new Exception("Invalid Type");
           int columns = temp; robot.ConfigRoutine(int.Parse(tabControlMatrix.SelectedTab.Name[7].ToString()), rows, columns);
            foreach (var item in tabControlMatrix.SelectedTab.Controls)
            {
                if (item is PictureBox)
                    (item as PictureBox).Refresh();
            }
          
           
           
       
              

        }

        private void SE_Click(object sender, EventArgs e)
        {
            image = (sender as PictureBox).Image;
           
            name= (sender as PictureBox).Name;
            if ((sender as PictureBox).Name == "return_")
                name = "return";

        }

        private void forward_Click(object sender, EventArgs e)
        {
            image = (sender as PictureBox).Image;
            name = (sender as PictureBox).Name;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            image = (sender as PictureBox).Image;
            name = (sender as PictureBox).Name;
        }

        private void loaded_Click(object sender, EventArgs e)
        {
            image = (sender as PictureBox).Image;
            name = (sender as PictureBox).Name;
        }

        private void routine_Click(object sender, EventArgs e)
        {
            image = (sender as PictureBox).Image;
            name = (sender as PictureBox).Name;

        }

        private void getW_Click(object sender, EventArgs e)
        {
            image = (sender as PictureBox).Image;
            name = (sender as PictureBox).Name;
        }

        private void setX_Click(object sender, EventArgs e)
        {
            image = (sender as PictureBox).Image;
            name = (sender as PictureBox).Name;
        }

        private void addRoutineTSMI_Click(object sender, EventArgs e)
        {
            if (!click)
            {
                matrixcounter += 1;
                robot.AddRoutine(10, 20);
            }  

            TabPage tab1 = new TabPage();
            tab1.Height = tabPage0.Height;
            tab1.Width = tabPage0.Width;
            tab1.Name = "tabPage"+matrixcounter.ToString();
            tab1.Text = "Matrix"+ matrixcounter.ToString();
            tab1.AutoScroll = true;
            tab1.UseVisualStyleBackColor = true;
            tabControlMatrix.Controls.Add(tab1);
            PictureBox picture = new PictureBox();
            picture.Height = pictureBoxM0.Height;
            picture.Width = pictureBoxM0.Width;
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.TabIndex = matrixcounter;
            picture.TabStop = false;
            picture.Location = new Point(3, 0);
            picture.Name = "pictureBoxM"+matrixcounter.ToString();
            picture.MouseClick += pictureBoxM0_MouseClick;
            picture.Paint += pictureBoxM1_Paint;
            tab1.Controls.Add(picture);
            tabControlMatrix.SelectedTab = tab1;
           
        }

        private void pictureBoxM0_MouseClick(object sender, MouseEventArgs e)
        {
            int index = int.Parse((sender as PictureBox).Name[11].ToString());
            int rows = robot.MatrixHeight(index);
            int columns = robot.MatrixWidth(index);
            int x = e.Y * rows / (sender as PictureBox).Height;
            int y = e.X * columns /(sender as PictureBox).Width;
            if (image != null)
            {
                Instructions ins = Instructions_Dictionary.GetValue(name);
                robot.AddInstructions(ins, x, y, index);
                (sender as PictureBox).Refresh();
            }

        }

        private void RobotInstruc_FormClosing(object sender, FormClosingEventArgs e)
        {
            robot.Autoguide();
        }
    }
}
