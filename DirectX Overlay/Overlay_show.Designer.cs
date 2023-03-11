namespace DirectX_Overlay
{
    partial class TransparentBorderlessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransparentBorderlessForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbarCpu = new CircularProgressBar.CircularProgressBar();
            this.Rlbl = new System.Windows.Forms.Label();
            this.CText = new System.Windows.Forms.Label();
            this.CbarRam = new CircularProgressBar.CircularProgressBar();
            this.Rtext = new System.Windows.Forms.Label();
            this.Clbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CbarCpu);
            this.panel1.Controls.Add(this.Rlbl);
            this.panel1.Controls.Add(this.CText);
            this.panel1.Controls.Add(this.CbarRam);
            this.panel1.Controls.Add(this.Rtext);
            this.panel1.Controls.Add(this.Clbl);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 207);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CbarCpu
            // 
            this.CbarCpu.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("CbarCpu.AnimationFunction")));
            this.CbarCpu.AnimationSpeed = 500;
            this.CbarCpu.BackColor = System.Drawing.Color.Black;
            this.CbarCpu.Font = new System.Drawing.Font("Russo One", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CbarCpu.ForeColor = System.Drawing.Color.White;
            this.CbarCpu.InnerColor = System.Drawing.Color.Black;
            this.CbarCpu.InnerMargin = 2;
            this.CbarCpu.InnerWidth = -2;
            this.CbarCpu.Location = new System.Drawing.Point(3, 10);
            this.CbarCpu.MarqueeAnimationSpeed = 2000;
            this.CbarCpu.Name = "CbarCpu";
            this.CbarCpu.OuterColor = System.Drawing.Color.White;
            this.CbarCpu.OuterMargin = -10;
            this.CbarCpu.OuterWidth = 10;
            this.CbarCpu.ProgressColor = System.Drawing.Color.Lime;
            this.CbarCpu.ProgressWidth = 10;
            this.CbarCpu.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CbarCpu.Size = new System.Drawing.Size(121, 115);
            this.CbarCpu.StartAngle = 270;
            this.CbarCpu.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CbarCpu.SubscriptColor = System.Drawing.Color.Transparent;
            this.CbarCpu.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CbarCpu.SubscriptText = "";
            this.CbarCpu.SuperscriptColor = System.Drawing.Color.Transparent;
            this.CbarCpu.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CbarCpu.SuperscriptText = "";
            this.CbarCpu.TabIndex = 0;
            this.CbarCpu.Text = "%75";
            this.CbarCpu.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.CbarCpu.Value = 75;
            this.CbarCpu.Visible = false;
            // 
            // Rlbl
            // 
            this.Rlbl.AutoSize = true;
            this.Rlbl.BackColor = System.Drawing.Color.Black;
            this.Rlbl.Font = new System.Drawing.Font("Russo One", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rlbl.ForeColor = System.Drawing.Color.Black;
            this.Rlbl.Location = new System.Drawing.Point(206, 164);
            this.Rlbl.Name = "Rlbl";
            this.Rlbl.Size = new System.Drawing.Size(83, 34);
            this.Rlbl.TabIndex = 3;
            this.Rlbl.Text = "RAM";
            this.Rlbl.Visible = false;
            this.Rlbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // CText
            // 
            this.CText.AutoSize = true;
            this.CText.Font = new System.Drawing.Font("Russo One", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CText.ForeColor = System.Drawing.Color.Black;
            this.CText.Location = new System.Drawing.Point(50, 130);
            this.CText.Name = "CText";
            this.CText.Size = new System.Drawing.Size(23, 34);
            this.CText.TabIndex = 1;
            this.CText.Text = ":";
            this.CText.Visible = false;
            this.CText.Click += new System.EventHandler(this.label2_Click);
            // 
            // CbarRam
            // 
            this.CbarRam.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("CbarRam.AnimationFunction")));
            this.CbarRam.AnimationSpeed = 500;
            this.CbarRam.BackColor = System.Drawing.Color.Black;
            this.CbarRam.Font = new System.Drawing.Font("Russo One", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CbarRam.ForeColor = System.Drawing.Color.White;
            this.CbarRam.InnerColor = System.Drawing.Color.Black;
            this.CbarRam.InnerMargin = 2;
            this.CbarRam.InnerWidth = -2;
            this.CbarRam.Location = new System.Drawing.Point(187, 12);
            this.CbarRam.MarqueeAnimationSpeed = 2000;
            this.CbarRam.Name = "CbarRam";
            this.CbarRam.OuterColor = System.Drawing.Color.White;
            this.CbarRam.OuterMargin = -10;
            this.CbarRam.OuterWidth = 10;
            this.CbarRam.ProgressColor = System.Drawing.Color.Lime;
            this.CbarRam.ProgressWidth = 10;
            this.CbarRam.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CbarRam.Size = new System.Drawing.Size(121, 115);
            this.CbarRam.StartAngle = 270;
            this.CbarRam.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CbarRam.SubscriptColor = System.Drawing.Color.Transparent;
            this.CbarRam.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CbarRam.SubscriptText = "";
            this.CbarRam.SuperscriptColor = System.Drawing.Color.Transparent;
            this.CbarRam.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CbarRam.SuperscriptText = "";
            this.CbarRam.TabIndex = 4;
            this.CbarRam.Text = "%75";
            this.CbarRam.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.CbarRam.Value = 75;
            this.CbarRam.Visible = false;
            this.CbarRam.Click += new System.EventHandler(this.circularProgressBar2_Click);
            // 
            // Rtext
            // 
            this.Rtext.AutoSize = true;
            this.Rtext.Font = new System.Drawing.Font("Russo One", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtext.ForeColor = System.Drawing.Color.Black;
            this.Rtext.Location = new System.Drawing.Point(235, 130);
            this.Rtext.Name = "Rtext";
            this.Rtext.Size = new System.Drawing.Size(23, 34);
            this.Rtext.TabIndex = 0;
            this.Rtext.Text = ":";
            this.Rtext.Visible = false;
            // 
            // Clbl
            // 
            this.Clbl.AutoSize = true;
            this.Clbl.BackColor = System.Drawing.Color.Black;
            this.Clbl.Font = new System.Drawing.Font("Russo One", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clbl.ForeColor = System.Drawing.Color.Black;
            this.Clbl.Location = new System.Drawing.Point(24, 164);
            this.Clbl.Name = "Clbl";
            this.Clbl.Size = new System.Drawing.Size(76, 34);
            this.Clbl.TabIndex = 2;
            this.Clbl.Text = "CPU";
            this.Clbl.Visible = false;
            this.Clbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // TransparentBorderlessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(329, 209);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransparentBorderlessForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private CircularProgressBar.CircularProgressBar CbarCpu;
        private CircularProgressBar.CircularProgressBar CbarRam;
        private System.Windows.Forms.Label Rlbl;
        private System.Windows.Forms.Label CText;
        private System.Windows.Forms.Label Rtext;
        private System.Windows.Forms.Label Clbl;
    }
}

