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
    public partial class UCCmb : UserControl
    {
        public UCCmb()
        {
            InitializeComponent();
        }
        override public string Text
        {
            get { return elcmb.Text; }
            set { elcmb.Text = value.Trim(); }
        }
        public ComboBox ElCmb { get => elcmb; }
        public string Label
        {
            get { return ellabel.Text; }
            set { ellabel.Text = value.Trim(); }
        }
    }
}
