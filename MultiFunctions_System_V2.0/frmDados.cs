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
    public partial class frmDados : Form
    {
        public frmDados()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dgvDados.Rows.Add(txtCodigo.Text, txtNome.Text);
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            dgvDados.Rows.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvDados.Rows.RemoveAt(dgvDados.CurrentRow.Cells[0].RowIndex);
        }
    }
}
