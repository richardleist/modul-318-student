using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class InputMailAddress : Form
    {
        public InputMailAddress()
        {
            InitializeComponent();
        }

        private void InputMailAddress_Load(object sender, EventArgs e)
        {

        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
