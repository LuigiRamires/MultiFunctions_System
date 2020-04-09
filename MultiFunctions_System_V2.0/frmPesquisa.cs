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
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome;
                double telefone;

                nome = txtNome.Text;
                telefone = Convert.ToDouble(txtTelefone.Text);

                dgvCadastro.Rows.Add(nome, telefone);
            }
            catch
            {
                MessageBox.Show("Informe os valores corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Após verificar se é possível executar a ação, caso não seja possível é exibida uma mensagem de erro pedindo para que sejam adicionados os campos em falta.
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisar = txtPesquisar.Text.ToLower();

            foreach (DataGridViewRow row in dgvCadastro.Rows)
            {
                if (row.Cells["clmNome"].Value != null)
                {
                    if (row.Cells["clmNome"].Value.ToString().ToLower().Equals(pesquisar))
                    {
                        row.Selected = true;
                        MessageBox.Show("Uma pessoa foi achada! E a linha foi selecionada.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Não conseguimos encontrar nenhuma pessoa em nosso sistema.", "Oh... não.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
