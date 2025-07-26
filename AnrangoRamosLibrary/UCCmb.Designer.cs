namespace AnrangoRamosLibrary
{
    partial class UCCmb
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ellabel = new System.Windows.Forms.Label();
            this.elcmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ellabel
            // 
            this.ellabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ellabel.Location = new System.Drawing.Point(3, 0);
            this.ellabel.Name = "ellabel";
            this.ellabel.Size = new System.Drawing.Size(104, 23);
            this.ellabel.TabIndex = 0;
            this.ellabel.Text = "LABEL";
            this.ellabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elcmb
            // 
            this.elcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elcmb.FormattingEnabled = true;
            this.elcmb.Location = new System.Drawing.Point(113, 2);
            this.elcmb.Name = "elcmb";
            this.elcmb.Size = new System.Drawing.Size(115, 21);
            this.elcmb.TabIndex = 1;
            // 
            // UCCmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.elcmb);
            this.Controls.Add(this.ellabel);
            this.Name = "UCCmb";
            this.Size = new System.Drawing.Size(231, 28);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ellabel;
        private System.Windows.Forms.ComboBox elcmb;
    }
}
