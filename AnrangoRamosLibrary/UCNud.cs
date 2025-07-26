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
    public partial class UCNud : UserControl
    {
        public UCNud()
        {
            InitializeComponent();
        }
        public decimal Value
        {
            get { return elnud.Value; }
            set { elnud.Value= value; }
        }
        public string Label
        {
            get { return ellabel.Text; }
            set { ellabel.Text = value.Trim(); }
        }
    }
}
