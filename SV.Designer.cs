namespace MATH
{
    partial class SV
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
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCnc = new System.Windows.Forms.Button();
            this.lblRs = new System.Windows.Forms.Label();
            this.lblNm = new System.Windows.Forms.Label();
            this.txtNm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(116, 106);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCnc
            // 
            this.cmdCnc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCnc.Location = new System.Drawing.Point(197, 106);
            this.cmdCnc.Name = "cmdCnc";
            this.cmdCnc.Size = new System.Drawing.Size(75, 23);
            this.cmdCnc.TabIndex = 1;
            this.cmdCnc.Text = "&Cancelar";
            this.cmdCnc.UseVisualStyleBackColor = true;
            this.cmdCnc.Click += new System.EventHandler(this.cmdCnc_Click);
            // 
            // lblRs
            // 
            this.lblRs.Location = new System.Drawing.Point(12, 48);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(260, 51);
            this.lblRs.TabIndex = 2;
            this.lblRs.Text = "Pontuação, fase";
            // 
            // lblNm
            // 
            this.lblNm.AutoSize = true;
            this.lblNm.Location = new System.Drawing.Point(9, 9);
            this.lblNm.Name = "lblNm";
            this.lblNm.Size = new System.Drawing.Size(38, 13);
            this.lblNm.TabIndex = 3;
            this.lblNm.Text = "Nome:";
            // 
            // txtNm
            // 
            this.txtNm.Location = new System.Drawing.Point(12, 25);
            this.txtNm.Name = "txtNm";
            this.txtNm.Size = new System.Drawing.Size(260, 20);
            this.txtNm.TabIndex = 4;
            this.txtNm.Text = "Jogador";
            // 
            // SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.txtNm);
            this.Controls.Add(this.lblNm);
            this.Controls.Add(this.lblRs);
            this.Controls.Add(this.cmdCnc);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salvar jogo";
            this.Load += new System.EventHandler(this.SV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCnc;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.Label lblNm;
        private System.Windows.Forms.TextBox txtNm;
    }
}