using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnrangoRamosLibrary
{
    public partial class UCLabel : UserControl
    {
        public Label label {  get=>lbl; set=>lbl=value; }
        public string Value {  get; set; }
        override public string Text
        {
            get => lbl.Text;
            set => lbl.Text = value;
        }
        public UCLabel()
        {
            InitializeComponent();
            lbl.Size= new System.Drawing.Size(this.Width, this.Height);
            lbl.Text = "Ciao sono una label custom";
        }
        public UCLabel(string testo,int width,int height)
        {
            InitializeComponent();
            lbl.Size = new System.Drawing.Size(width, height);
            lbl.Text = testo;
        }
    }
}
