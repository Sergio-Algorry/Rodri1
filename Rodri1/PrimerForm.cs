using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rodri1
{
    public partial class PrimerForm : Form
    {
        public PrimerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text =System.Convert.ToString( 
                    System.Convert.ToInt32(txtA.Text )
                    + System.Convert.ToInt32(txtB.Text)
                );
        }
    }
}
