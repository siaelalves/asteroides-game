namespace MATH
{
    partial class OPT
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
            this.txtNv = new System.Windows.Forms.ComboBox();
            this.chkSm = new System.Windows.Forms.CheckBox();
            this.lblNv = new System.Windows.Forms.Label();
            this.lblSm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(42, 79);
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
            this.cmdCnc.Location = new System.Drawing.Point(123, 79);
            this.cmdCnc.Name = "cmdCnc";
            this.cmdCnc.Size = new System.Drawing.Size(75, 23);
            this.cmdCnc.TabIndex = 1;
            this.cmdCnc.Text = "&Cancelar";
            this.cmdCnc.UseVisualStyleBackColor = true;
            this.cmdCnc.Click += new System.EventHandler(this.cmdCnc_Click);
            // 
            // txtNv
            // 
            this.txtNv.FormattingEnabled = true;
            this.txtNv.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil"});
            this.txtNv.Location = new System.Drawing.Point(77, 12);
            this.txtNv.Name = "txtNv";
            this.txtNv.Size = new System.Drawing.Size(121, 21);
            this.txtNv.TabIndex = 2;
            // 
            // chkSm
            // 
            this.chkSm.AutoSize = true;
            this.chkSm.Location = new System.Drawing.Point(77, 49);
            this.chkSm.Name = "chkSm";
            this.chkSm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSm.Size = new System.Drawing.Size(15, 14);
            this.chkSm.TabIndex = 3;
            this.chkSm.UseVisualStyleBackColor = true;
            // 
            // lblNv
            // 
            this.lblNv.AutoSize = true;
            this.lblNv.Location = new System.Drawing.Point(12, 20);
            this.lblNv.Name = "lblNv";
            this.lblNv.Size = new System.Drawing.Size(36, 13);
            this.lblNv.TabIndex = 4;
            this.lblNv.Text = "Nível:";
            // 
            // lblSm
            // 
            this.lblSm.AutoSize = true;
            this.lblSm.Location = new System.Drawing.Point(12, 50);
            this.lblSm.Name = "lblSm";
            this.lblSm.Size = new System.Drawing.Size(28, 13);
            this.lblSm.TabIndex = 5;
            this.lblSm.Text = "Som";
            // 
            // OPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 118);
            this.Controls.Add(this.lblSm);
            this.Controls.Add(this.lblNv);
            this.Controls.Add(this.chkSm);
            this.Controls.Add(this.txtNv);
            this.Controls.Add(this.cmdCnc);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções";
            this.Load += new System.EventHandler(this.OPT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCnc;
        private System.Windows.Forms.ComboBox txtNv;
        private System.Windows.Forms.CheckBox chkSm;
        private System.Windows.Forms.Label lblNv;
        private System.Windows.Forms.Label lblSm;
    }
}