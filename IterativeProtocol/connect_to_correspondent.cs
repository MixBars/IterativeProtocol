using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IterativeProtocol
{
    public partial class connect_to_correspondent : Form
    {
        public connect_to_correspondent()
        {
            InitializeComponent();
        }

        private void connect_to_correspondent_Load(object sender, EventArgs e)
        {

        }

        private void connect_to_correspondent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form newForm = Application.OpenForms[0];
            newForm.Show();
        }
    }
}
