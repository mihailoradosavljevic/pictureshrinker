namespace WindowsFormsApplication1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.smanjibutton2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dvaputabutton2 = new System.Windows.Forms.Button();
            this.osamputamanjebutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.spremantoolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.uradjenotoolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ucitaj sliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(695, 20);
            this.textBox1.TabIndex = 1;
            // 
            // smanjibutton2
            // 
            this.smanjibutton2.Location = new System.Drawing.Point(114, 156);
            this.smanjibutton2.Name = "smanjibutton2";
            this.smanjibutton2.Size = new System.Drawing.Size(75, 75);
            this.smanjibutton2.TabIndex = 2;
            this.smanjibutton2.Text = "smanji 4x";
            this.smanjibutton2.UseVisualStyleBackColor = true;
            this.smanjibutton2.Click += new System.EventHandler(this.smanjibutton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(317, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dvaputabutton2
            // 
            this.dvaputabutton2.Location = new System.Drawing.Point(12, 156);
            this.dvaputabutton2.Name = "dvaputabutton2";
            this.dvaputabutton2.Size = new System.Drawing.Size(75, 133);
            this.dvaputabutton2.TabIndex = 4;
            this.dvaputabutton2.Text = "smanji 2x";
            this.dvaputabutton2.UseVisualStyleBackColor = true;
            this.dvaputabutton2.Click += new System.EventHandler(this.dvaputabutton2_Click);
            // 
            // osamputamanjebutton2
            // 
            this.osamputamanjebutton2.Location = new System.Drawing.Point(219, 156);
            this.osamputamanjebutton2.Name = "osamputamanjebutton2";
            this.osamputamanjebutton2.Size = new System.Drawing.Size(75, 40);
            this.osamputamanjebutton2.TabIndex = 5;
            this.osamputamanjebutton2.Text = "smanji 8x";
            this.osamputamanjebutton2.UseVisualStyleBackColor = true;
            this.osamputamanjebutton2.Click += new System.EventHandler(this.osamputamanjebutton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime i putanja originalne slike";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ime i putanja umanjene slike";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(695, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spremantoolStripStatusLabel1,
            this.uradjenotoolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(717, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // spremantoolStripStatusLabel1
            // 
            this.spremantoolStripStatusLabel1.Name = "spremantoolStripStatusLabel1";
            this.spremantoolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
            this.spremantoolStripStatusLabel1.Text = "Spreman";
            // 
            // uradjenotoolStripProgressBar1
            // 
            this.uradjenotoolStripProgressBar1.Name = "uradjenotoolStripProgressBar1";
            this.uradjenotoolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.uradjenotoolStripProgressBar1.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 388);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.osamputamanjebutton2);
            this.Controls.Add(this.dvaputabutton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.smanjibutton2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Picture Shrinker      -       Umanjivac Slika     -     jpg, bmp,gif,png";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button smanjibutton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dvaputabutton2;
        private System.Windows.Forms.Button osamputamanjebutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel spremantoolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar uradjenotoolStripProgressBar1;
    }
}

