using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula06_Ex01
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (pbrCarregamento.Value < 100)
            {
                pbrCarregamento.Value += 10;
            }
            else
            {
                timer1.Enabled = false;
                frmLogin login = new frmLogin();
                login.ShowDialog();
                this.Close();
            }*/
        }
    }
}
