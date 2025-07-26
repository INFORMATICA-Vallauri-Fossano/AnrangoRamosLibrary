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
    public partial class UCTxt : UserControl
    {
        public UCTxt()
        {
            InitializeComponent();
        }
        override public string Text
        {
            get { return eltextbox.Text; }
            set { eltextbox.Text = value.Trim(); }
        }
        public string Label
        {
            get { return ellabel.Text; }
            set { ellabel.Text = value.Trim(); }
        }
        
    }
}
