namespace AnrangoRamosLibrary
{
    partial class UCNud
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
            this.elnud = new System.Windows.Forms.NumericUpDown();
            this.ellabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.elnud)).BeginInit();
            this.SuspendLayout();
            // 
            // elnud
            // 
            this.elnud.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.elnud.Location = new System.Drawing.Point(83, 5);
            this.elnud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.elnud.Name = "elnud";
            this.elnud.Size = new System.Drawing.Size(145, 20);
            this.elnud.TabIndex = 0;
            // 
            // ellabel
            // 
            this.ellabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ellabel.Location = new System.Drawing.Point(3, 2);
            this.ellabel.Name = "ellabel";
            this.ellabel.Size = new System.Drawing.Size(74, 23);
            this.ellabel.TabIndex = 1;
            this.ellabel.Text = "LABEL";
            this.ellabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCNud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ellabel);
            this.Controls.Add(this.elnud);
            this.Name = "UCNud";
            this.Size = new System.Drawing.Size(231, 28);
            ((System.ComponentModel.ISupportInitialize)(this.elnud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown elnud;
        private System.Windows.Forms.Label ellabel;
    }
}
