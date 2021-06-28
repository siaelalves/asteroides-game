namespace MATH
{
    partial class AST
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
            this.lblIn = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblSr = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.BackColor = System.Drawing.Color.Transparent;
            this.lblIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIn.Font = new System.Drawing.Font("Kristen ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.ForeColor = System.Drawing.Color.Yellow;
            this.lblIn.Location = new System.Drawing.Point(230, 213);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(138, 51);
            this.lblIn.TabIndex = 0;
            this.lblIn.Text = "Iniciar";
            this.lblIn.Click += new System.EventHandler(this.lblIn_Click);
            this.lblIn.MouseLeave += new System.EventHandler(this.lblIn_MouseLeave);
            this.lblIn.MouseHover += new System.EventHandler(this.lblIn_MouseHover);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.BackColor = System.Drawing.Color.Transparent;
            this.lblOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOp.Font = new System.Drawing.Font("Kristen ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.ForeColor = System.Drawing.Color.Yellow;
            this.lblOp.Location = new System.Drawing.Point(217, 264);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(162, 51);
            this.lblOp.TabIndex = 1;
            this.lblOp.Text = "Opções";
            this.lblOp.Click += new System.EventHandler(this.lblOp_Click);
            this.lblOp.MouseLeave += new System.EventHandler(this.lblOp_MouseLeave);
            this.lblOp.MouseHover += new System.EventHandler(this.lblOp_MouseHover);
            // 
            // lblSr
            // 
            this.lblSr.AutoSize = true;
            this.lblSr.BackColor = System.Drawing.Color.Transparent;
            this.lblSr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSr.Font = new System.Drawing.Font("Kristen ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSr.ForeColor = System.Drawing.Color.Yellow;
            this.lblSr.Location = new System.Drawing.Point(251, 315);
            this.lblSr.Name = "lblSr";
            this.lblSr.Size = new System.Drawing.Size(92, 51);
            this.lblSr.TabIndex = 2;
            this.lblSr.Text = "Sair";
            this.lblSr.Click += new System.EventHandler(this.lblSr_Click);
            this.lblSr.MouseLeave += new System.EventHandler(this.lblSr_MouseLeave);
            this.lblSr.MouseHover += new System.EventHandler(this.lblSr_MouseHover);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.BackColor = System.Drawing.Color.Transparent;
            this.lblCnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCnt.Font = new System.Drawing.Font("Kristen ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnt.ForeColor = System.Drawing.Color.Yellow;
            this.lblCnt.Location = new System.Drawing.Point(200, 366);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(208, 51);
            this.lblCnt.TabIndex = 3;
            this.lblCnt.Text = "Continuar";
            this.lblCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCnt.Visible = false;
            this.lblCnt.Click += new System.EventHandler(this.lblCnt_Click);
            this.lblCnt.MouseLeave += new System.EventHandler(this.lblCnt_MouseLeave);
            this.lblCnt.MouseHover += new System.EventHandler(this.lblCnt_MouseHover);
            // 
            // AST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::MATH.Properties.Resources.opening;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 442);
            this.Controls.Add(this.lblCnt);
            this.Controls.Add(this.lblSr);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblIn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MATH";
            this.Load += new System.EventHandler(this.MATH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblSr;
        private System.Windows.Forms.Label lblCnt;
    }
}

