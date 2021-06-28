namespace MATH
{
    partial class GM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GM));
            this.tmR = new System.Windows.Forms.Timer(this.components);
            this.picAst1 = new System.Windows.Forms.PictureBox();
            this.picAst = new System.Windows.Forms.ImageList(this.components);
            this.picCen = new System.Windows.Forms.ImageList(this.components);
            this.lblPn = new System.Windows.Forms.Label();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblFs = new System.Windows.Forms.Label();
            this.lblNv = new System.Windows.Forms.Label();
            this.picAst2 = new System.Windows.Forms.PictureBox();
            this.picAst3 = new System.Windows.Forms.PictureBox();
            this.picAst4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAst1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAst2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAst3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAst4)).BeginInit();
            this.SuspendLayout();
            // 
            // tmR
            // 
            this.tmR.Tick += new System.EventHandler(this.tmR_Tick);
            // 
            // picAst1
            // 
            this.picAst1.BackColor = System.Drawing.Color.Transparent;
            this.picAst1.InitialImage = null;
            this.picAst1.Location = new System.Drawing.Point(137, 53);
            this.picAst1.Name = "picAst1";
            this.picAst1.Size = new System.Drawing.Size(10, 10);
            this.picAst1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAst1.TabIndex = 0;
            this.picAst1.TabStop = false;
            this.picAst1.Click += new System.EventHandler(this.picAst1_Click);
            // 
            // picAst
            // 
            this.picAst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("picAst.ImageStream")));
            this.picAst.TransparentColor = System.Drawing.Color.Transparent;
            this.picAst.Images.SetKeyName(0, "asteroide_1.png");
            this.picAst.Images.SetKeyName(1, "asteroide_2.png");
            this.picAst.Images.SetKeyName(2, "asteroide_3.png");
            this.picAst.Images.SetKeyName(3, "asteroide_4.png");
            // 
            // picCen
            // 
            this.picCen.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("picCen.ImageStream")));
            this.picCen.TransparentColor = System.Drawing.Color.Transparent;
            this.picCen.Images.SetKeyName(0, "stage_one.png");
            this.picCen.Images.SetKeyName(1, "stage_two.png");
            // 
            // lblPn
            // 
            this.lblPn.BackColor = System.Drawing.Color.Transparent;
            this.lblPn.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPn.ForeColor = System.Drawing.Color.Red;
            this.lblPn.Location = new System.Drawing.Point(506, 24);
            this.lblPn.Name = "lblPn";
            this.lblPn.Size = new System.Drawing.Size(56, 29);
            this.lblPn.TabIndex = 5;
            this.lblPn.Text = "PONTOS\r\n0";
            this.lblPn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEn
            // 
            this.lblEn.BackColor = System.Drawing.Color.Transparent;
            this.lblEn.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEn.ForeColor = System.Drawing.Color.Red;
            this.lblEn.Location = new System.Drawing.Point(505, 53);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(57, 29);
            this.lblEn.TabIndex = 6;
            this.lblEn.Text = "ENERGIA\r\n100";
            this.lblEn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFs
            // 
            this.lblFs.BackColor = System.Drawing.Color.Transparent;
            this.lblFs.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFs.ForeColor = System.Drawing.Color.Red;
            this.lblFs.Location = new System.Drawing.Point(505, 90);
            this.lblFs.Name = "lblFs";
            this.lblFs.Size = new System.Drawing.Size(57, 29);
            this.lblFs.TabIndex = 7;
            this.lblFs.Text = "FASE\r\n1";
            this.lblFs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNv
            // 
            this.lblNv.BackColor = System.Drawing.Color.Transparent;
            this.lblNv.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNv.ForeColor = System.Drawing.Color.Red;
            this.lblNv.Location = new System.Drawing.Point(506, 119);
            this.lblNv.Name = "lblNv";
            this.lblNv.Size = new System.Drawing.Size(57, 29);
            this.lblNv.TabIndex = 8;
            this.lblNv.Text = "NÍVEL\r\n1";
            this.lblNv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picAst2
            // 
            this.picAst2.BackColor = System.Drawing.Color.Transparent;
            this.picAst2.InitialImage = ((System.Drawing.Image)(resources.GetObject("picAst2.InitialImage")));
            this.picAst2.Location = new System.Drawing.Point(270, 161);
            this.picAst2.Name = "picAst2";
            this.picAst2.Size = new System.Drawing.Size(11, 10);
            this.picAst2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAst2.TabIndex = 9;
            this.picAst2.TabStop = false;
            this.picAst2.Click += new System.EventHandler(this.picAst2_Click);
            // 
            // picAst3
            // 
            this.picAst3.BackColor = System.Drawing.Color.Transparent;
            this.picAst3.InitialImage = null;
            this.picAst3.Location = new System.Drawing.Point(320, 323);
            this.picAst3.Name = "picAst3";
            this.picAst3.Size = new System.Drawing.Size(10, 11);
            this.picAst3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAst3.TabIndex = 10;
            this.picAst3.TabStop = false;
            this.picAst3.Click += new System.EventHandler(this.picAst3_Click);
            // 
            // picAst4
            // 
            this.picAst4.BackColor = System.Drawing.Color.Transparent;
            this.picAst4.InitialImage = null;
            this.picAst4.Location = new System.Drawing.Point(99, 277);
            this.picAst4.Name = "picAst4";
            this.picAst4.Size = new System.Drawing.Size(10, 11);
            this.picAst4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAst4.TabIndex = 11;
            this.picAst4.TabStop = false;
            this.picAst4.Click += new System.EventHandler(this.picAst4_Click);
            // 
            // GM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::MATH.Properties.Resources.stage_one;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 442);
            this.Controls.Add(this.picAst4);
            this.Controls.Add(this.picAst3);
            this.Controls.Add(this.picAst2);
            this.Controls.Add(this.lblNv);
            this.Controls.Add(this.lblFs);
            this.Controls.Add(this.lblEn);
            this.Controls.Add(this.lblPn);
            this.Controls.Add(this.picAst1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "GM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GM";
            this.Load += new System.EventHandler(this.GM_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GM_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picAst1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAst2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAst3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAst4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAst1;
        private System.Windows.Forms.Timer tmR;
        private System.Windows.Forms.ImageList picAst;
        private System.Windows.Forms.ImageList picCen;
        private System.Windows.Forms.Label lblPn;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblFs;
        private System.Windows.Forms.Label lblNv;
        private System.Windows.Forms.PictureBox picAst2;
        private System.Windows.Forms.PictureBox picAst3;
        private System.Windows.Forms.PictureBox picAst4;
    }
}