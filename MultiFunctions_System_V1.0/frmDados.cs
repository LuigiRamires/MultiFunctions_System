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
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string nome = Convert.ToString(txtNome.Text);
                dgvDados.Rows.Add(codigo, nome);
                txtCodigo.Clear();
                txtNome.Clear();
            }
            catch
            {
                MessageBox.Show("Informe os valores corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
