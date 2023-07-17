
namespace HelicopterShooter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TimerforGame = new System.Windows.Forms.Timer(this.components);
            this.phealth = new System.Windows.Forms.ProgressBar();
            this.txtScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pausepicturebox = new System.Windows.Forms.PictureBox();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnrestart = new System.Windows.Forms.PictureBox();
            this.lblpause = new System.Windows.Forms.Label();
            this.pbhome = new System.Windows.Forms.PictureBox();
            this.pbresume = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.pillar1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pausepicturebox)).BeginInit();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbresume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerforGame
            // 
            this.TimerforGame.Enabled = true;
            this.TimerforGame.Interval = 20;
            this.TimerforGame.Tick += new System.EventHandler(this.TimerforGame_Tick);
            // 
            // phealth
            // 
            this.phealth.BackColor = System.Drawing.Color.Lime;
            this.phealth.ForeColor = System.Drawing.Color.Lime;
            this.phealth.Location = new System.Drawing.Point(119, 4);
            this.phealth.Name = "phealth";
            this.phealth.Size = new System.Drawing.Size(136, 25);
            this.phealth.TabIndex = 11;
            this.phealth.Value = 100;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.SkyBlue;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(2, 4);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(110, 29);
            this.txtScore.TabIndex = 12;
            this.txtScore.Text = "Score: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Player\'s Health";
            // 
            // pausepicturebox
            // 
            this.pausepicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pausepicturebox.BackgroundImage")));
            this.pausepicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pausepicturebox.Location = new System.Drawing.Point(262, 4);
            this.pausepicturebox.Name = "pausepicturebox";
            this.pausepicturebox.Size = new System.Drawing.Size(52, 35);
            this.pausepicturebox.TabIndex = 14;
            this.pausepicturebox.TabStop = false;
            this.pausepicturebox.Click += new System.EventHandler(this.pausepicturebox_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.DarkGray;
            this.panelmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelmenu.Controls.Add(this.btnrestart);
            this.panelmenu.Controls.Add(this.lblpause);
            this.panelmenu.Controls.Add(this.pbhome);
            this.panelmenu.Controls.Add(this.pbresume);
            this.panelmenu.Location = new System.Drawing.Point(440, 158);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(265, 207);
            this.panelmenu.TabIndex = 17;
            this.panelmenu.Visible = false;
            // 
            // btnrestart
            // 
            this.btnrestart.BackColor = System.Drawing.Color.Transparent;
            this.btnrestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrestart.BackgroundImage")));
            this.btnrestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrestart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnrestart.Image = ((System.Drawing.Image)(resources.GetObject("btnrestart.Image")));
            this.btnrestart.Location = new System.Drawing.Point(176, 95);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(60, 43);
            this.btnrestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnrestart.TabIndex = 17;
            this.btnrestart.TabStop = false;
            this.btnrestart.Visible = false;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // lblpause
            // 
            this.lblpause.AutoSize = true;
            this.lblpause.BackColor = System.Drawing.Color.Tomato;
            this.lblpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpause.Location = new System.Drawing.Point(58, 25);
            this.lblpause.Name = "lblpause";
            this.lblpause.Size = new System.Drawing.Size(147, 29);
            this.lblpause.TabIndex = 16;
            this.lblpause.Text = "Pause menu";
            this.lblpause.Visible = false;
            // 
            // pbhome
            // 
            this.pbhome.BackColor = System.Drawing.Color.Transparent;
            this.pbhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbhome.BackgroundImage")));
            this.pbhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbhome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbhome.Location = new System.Drawing.Point(20, 95);
            this.pbhome.Name = "pbhome";
            this.pbhome.Size = new System.Drawing.Size(60, 43);
            this.pbhome.TabIndex = 14;
            this.pbhome.TabStop = false;
            this.pbhome.Visible = false;
            this.pbhome.Click += new System.EventHandler(this.pbhome_Click);
            // 
            // pbresume
            // 
            this.pbresume.BackColor = System.Drawing.Color.Transparent;
            this.pbresume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbresume.BackgroundImage")));
            this.pbresume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbresume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbresume.Location = new System.Drawing.Point(101, 95);
            this.pbresume.Name = "pbresume";
            this.pbresume.Size = new System.Drawing.Size(60, 43);
            this.pbresume.TabIndex = 15;
            this.pbresume.TabStop = false;
            this.pbresume.Visible = false;
            this.pbresume.Click += new System.EventHandler(this.pbresume_Click);
            // 
            // pillar2
            // 
            this.pillar2.Image = global::HelicopterShooter.Properties.Resources.pillar;
            this.pillar2.Location = new System.Drawing.Point(333, 376);
            this.pillar2.Margin = new System.Windows.Forms.Padding(4);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(81, 247);
            this.pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar2.TabIndex = 18;
            this.pillar2.TabStop = false;
            this.pillar2.Tag = "pillar";
            // 
            // pillar1
            // 
            this.pillar1.Image = global::HelicopterShooter.Properties.Resources.pillar;
            this.pillar1.Location = new System.Drawing.Point(772, -9);
            this.pillar1.Margin = new System.Windows.Forms.Padding(4);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(81, 247);
            this.pillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar1.TabIndex = 19;
            this.pillar1.TabStop = false;
            this.pillar1.Tag = "pillar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 616);
            this.Controls.Add(this.pillar1);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.pausepicturebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.phealth);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pausepicturebox)).EndInit();
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbresume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerforGame;
        private System.Windows.Forms.ProgressBar phealth;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pausepicturebox;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.PictureBox btnrestart;
        private System.Windows.Forms.Label lblpause;
        private System.Windows.Forms.PictureBox pbhome;
        private System.Windows.Forms.PictureBox pbresume;
        private System.Windows.Forms.PictureBox pillar2;
        private System.Windows.Forms.PictureBox pillar1;
    }
}

