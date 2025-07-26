namespace AnrangoRamosLibrary
{
    partial class UCTxt
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
            this.eltextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ellabel
            // 
            this.ellabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ellabel.Location = new System.Drawing.Point(3, 0);
            this.ellabel.Name = "ellabel";
            this.ellabel.Size = new System.Drawing.Size(74, 23);
            this.ellabel.TabIndex = 0;
            this.ellabel.Text = "LABEL";
            this.ellabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eltextbox
            // 
            this.eltextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eltextbox.Location = new System.Drawing.Point(83, 3);
            this.eltextbox.Name = "eltextbox";
            this.eltextbox.Size = new System.Drawing.Size(145, 20);
            this.eltextbox.TabIndex = 1;
            // 
            // UCTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eltextbox);
            this.Controls.Add(this.ellabel);
            this.Name = "UCTxt";
            this.Size = new System.Drawing.Size(231, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ellabel;
        private System.Windows.Forms.TextBox eltextbox;
    }
}
