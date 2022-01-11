namespace Wall_E
{
    partial class Game_Wall_E
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Wall_E));
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.panelMap = new System.Windows.Forms.Panel();
            this.play = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdvance = new System.Windows.Forms.PictureBox();
            this.pictureBoxDebug = new System.Windows.Forms.PictureBox();
            this.panelInst = new System.Windows.Forms.Panel();
            this.pictureBoxInst = new System.Windows.Forms.PictureBox();
            this.richTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPause = new System.Windows.Forms.PictureBox();
            this.pictureBoxstop = new System.Windows.Forms.PictureBox();
            this.textBoxNRounds = new System.Windows.Forms.TextBox();
            this.textBoxLastValue = new System.Windows.Forms.TextBox();
            this.textBoxRobotName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxOinside = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeBetweenRounsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IntervalRounds = new System.Windows.Forms.ToolStripTextBox();
            this.timeBetweenInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IntervalInst = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDebug)).BeginInit();
            this.panelInst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxstop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOinside)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMap.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(526, 511);
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMap_Paint);
            // 
            // panelMap
            // 
            this.panelMap.AutoScroll = true;
            this.panelMap.Controls.Add(this.pictureBoxMap);
            this.panelMap.Location = new System.Drawing.Point(35, 137);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(532, 517);
            this.panelMap.TabIndex = 1;
            // 
            // play
            // 
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(38, 36);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(80, 84);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play.TabIndex = 2;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pictureBoxAdvance
            // 
            this.pictureBoxAdvance.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdvance.Image")));
            this.pictureBoxAdvance.Location = new System.Drawing.Point(218, 36);
            this.pictureBoxAdvance.Name = "pictureBoxAdvance";
            this.pictureBoxAdvance.Size = new System.Drawing.Size(85, 84);
            this.pictureBoxAdvance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdvance.TabIndex = 3;
            this.pictureBoxAdvance.TabStop = false;
            this.pictureBoxAdvance.Click += new System.EventHandler(this.pictureBoxAdvance_Click);
            // 
            // pictureBoxDebug
            // 
            this.pictureBoxDebug.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDebug.Image")));
            this.pictureBoxDebug.Location = new System.Drawing.Point(403, 36);
            this.pictureBoxDebug.Name = "pictureBoxDebug";
            this.pictureBoxDebug.Size = new System.Drawing.Size(86, 84);
            this.pictureBoxDebug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDebug.TabIndex = 2;
            this.pictureBoxDebug.TabStop = false;
            this.pictureBoxDebug.Click += new System.EventHandler(this.pictureBoxDebug_Click);
            // 
            // panelInst
            // 
            this.panelInst.AutoScroll = true;
            this.panelInst.Controls.Add(this.pictureBoxInst);
            this.panelInst.Location = new System.Drawing.Point(629, 140);
            this.panelInst.Name = "panelInst";
            this.panelInst.Size = new System.Drawing.Size(564, 613);
            this.panelInst.TabIndex = 1;
            // 
            // pictureBoxInst
            // 
            this.pictureBoxInst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInst.Location = new System.Drawing.Point(3, 6);
            this.pictureBoxInst.Name = "pictureBoxInst";
            this.pictureBoxInst.Size = new System.Drawing.Size(555, 607);
            this.pictureBoxInst.TabIndex = 0;
            this.pictureBoxInst.TabStop = false;
            this.pictureBoxInst.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxInst_Paint);
            // 
            // richTextBoxConsole
            // 
            this.richTextBoxConsole.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBoxConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxConsole.ForeColor = System.Drawing.Color.Lime;
            this.richTextBoxConsole.Location = new System.Drawing.Point(35, 675);
            this.richTextBoxConsole.Name = "richTextBoxConsole";
            this.richTextBoxConsole.ReadOnly = true;
            this.richTextBoxConsole.Size = new System.Drawing.Size(532, 114);
            this.richTextBoxConsole.TabIndex = 6;
            this.richTextBoxConsole.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBoxPause
            // 
            this.pictureBoxPause.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPause.Image")));
            this.pictureBoxPause.Location = new System.Drawing.Point(124, 36);
            this.pictureBoxPause.Name = "pictureBoxPause";
            this.pictureBoxPause.Size = new System.Drawing.Size(88, 84);
            this.pictureBoxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPause.TabIndex = 2;
            this.pictureBoxPause.TabStop = false;
            this.pictureBoxPause.Click += new System.EventHandler(this.pictureBoxPause_Click);
            // 
            // pictureBoxstop
            // 
            this.pictureBoxstop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxstop.Image")));
            this.pictureBoxstop.Location = new System.Drawing.Point(309, 36);
            this.pictureBoxstop.Name = "pictureBoxstop";
            this.pictureBoxstop.Size = new System.Drawing.Size(88, 84);
            this.pictureBoxstop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxstop.TabIndex = 2;
            this.pictureBoxstop.TabStop = false;
            this.pictureBoxstop.Click += new System.EventHandler(this.pictureBoxstop_Click);
            // 
            // textBoxNRounds
            // 
            this.textBoxNRounds.Location = new System.Drawing.Point(717, 76);
            this.textBoxNRounds.Name = "textBoxNRounds";
            this.textBoxNRounds.ReadOnly = true;
            this.textBoxNRounds.Size = new System.Drawing.Size(41, 22);
            this.textBoxNRounds.TabIndex = 5;
            // 
            // textBoxLastValue
            // 
            this.textBoxLastValue.Location = new System.Drawing.Point(959, 36);
            this.textBoxLastValue.Name = "textBoxLastValue";
            this.textBoxLastValue.ReadOnly = true;
            this.textBoxLastValue.Size = new System.Drawing.Size(40, 22);
            this.textBoxLastValue.TabIndex = 7;
            // 
            // textBoxRobotName
            // 
            this.textBoxRobotName.Enabled = false;
            this.textBoxRobotName.Location = new System.Drawing.Point(717, 36);
            this.textBoxRobotName.Name = "textBoxRobotName";
            this.textBoxRobotName.ReadOnly = true;
            this.textBoxRobotName.Size = new System.Drawing.Size(100, 22);
            this.textBoxRobotName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(842, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Value ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(625, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rounds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(625, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // pictureBoxOinside
            // 
            this.pictureBoxOinside.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOinside.Image")));
            this.pictureBoxOinside.Location = new System.Drawing.Point(1060, 18);
            this.pictureBoxOinside.Name = "pictureBoxOinside";
            this.pictureBoxOinside.Size = new System.Drawing.Size(109, 80);
            this.pictureBoxOinside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOinside.TabIndex = 9;
            this.pictureBoxOinside.TabStop = false;
            this.pictureBoxOinside.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxOInside_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1056, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Object Inside";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeBetweenRounsToolStripMenuItem,
            this.timeBetweenInstructionsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // timeBetweenRounsToolStripMenuItem
            // 
            this.timeBetweenRounsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IntervalRounds});
            this.timeBetweenRounsToolStripMenuItem.Name = "timeBetweenRounsToolStripMenuItem";
            this.timeBetweenRounsToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.timeBetweenRounsToolStripMenuItem.Text = "Time between Rouns";
            // 
            // IntervalRounds
            // 
            this.IntervalRounds.Name = "IntervalRounds";
            this.IntervalRounds.Size = new System.Drawing.Size(100, 27);
            this.IntervalRounds.Text = "1000";
            // 
            // timeBetweenInstructionsToolStripMenuItem
            // 
            this.timeBetweenInstructionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IntervalInst});
            this.timeBetweenInstructionsToolStripMenuItem.Name = "timeBetweenInstructionsToolStripMenuItem";
            this.timeBetweenInstructionsToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.timeBetweenInstructionsToolStripMenuItem.Text = "Time between Instructions";
            // 
            // IntervalInst
            // 
            this.IntervalInst.Name = "IntervalInst";
            this.IntervalInst.Size = new System.Drawing.Size(100, 27);
            this.IntervalInst.Text = "200";
            // 
            // Game_Wall_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1250, 819);
            this.Controls.Add(this.pictureBoxOinside);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLastValue);
            this.Controls.Add(this.richTextBoxConsole);
            this.Controls.Add(this.textBoxNRounds);
            this.Controls.Add(this.textBoxRobotName);
            this.Controls.Add(this.pictureBoxAdvance);
            this.Controls.Add(this.pictureBoxstop);
            this.Controls.Add(this.pictureBoxPause);
            this.Controls.Add(this.pictureBoxDebug);
            this.Controls.Add(this.play);
            this.Controls.Add(this.panelInst);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game_Wall_E";
            this.Text = "Game_Wall_E";
            this.Load += new System.EventHandler(this.Game_Wall_E_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.panelMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDebug)).EndInit();
            this.panelInst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxstop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOinside)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox pictureBoxAdvance;
        private System.Windows.Forms.PictureBox pictureBoxDebug;
        private System.Windows.Forms.Panel panelInst;
        private System.Windows.Forms.PictureBox pictureBoxInst;
        private System.Windows.Forms.RichTextBox richTextBoxConsole;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBoxPause;
        private System.Windows.Forms.PictureBox pictureBoxstop;
        private System.Windows.Forms.TextBox textBoxNRounds;
        private System.Windows.Forms.TextBox textBoxLastValue;
        private System.Windows.Forms.TextBox textBoxRobotName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxOinside;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeBetweenRounsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox IntervalRounds;
        private System.Windows.Forms.ToolStripMenuItem timeBetweenInstructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox IntervalInst;
    }
}