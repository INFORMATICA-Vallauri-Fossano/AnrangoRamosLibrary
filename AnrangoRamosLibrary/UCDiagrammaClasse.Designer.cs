namespace AnrangoRamosLibrary
{
    partial class UCDiagrammaClasse
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbAttributes = new System.Windows.Forms.GroupBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.grbMethods = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grbAttributes
            // 
            this.grbAttributes.Location = new System.Drawing.Point(-2, 29);
            this.grbAttributes.Name = "grbAttributes";
            this.grbAttributes.Size = new System.Drawing.Size(194, 100);
            this.grbAttributes.TabIndex = 1;
            this.grbAttributes.TabStop = false;
            this.grbAttributes.Text = "ATTRIBUTI";
            // 
            // lblClassName
            // 
            this.lblClassName.Location = new System.Drawing.Point(0, 0);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(192, 26);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.Text = "NOME CLASSE";
            this.lblClassName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbMethods
            // 
            this.grbMethods.Location = new System.Drawing.Point(-2, 135);
            this.grbMethods.Name = "grbMethods";
            this.grbMethods.Size = new System.Drawing.Size(194, 100);
            this.grbMethods.TabIndex = 2;
            this.grbMethods.TabStop = false;
            this.grbMethods.Text = "METODI";
            // 
            // UCDiagrammaClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.grbMethods);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.grbAttributes);
            this.Name = "UCDiagrammaClasse";
            this.Size = new System.Drawing.Size(190, 247);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbAttributes;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.GroupBox grbMethods;
    }
}
