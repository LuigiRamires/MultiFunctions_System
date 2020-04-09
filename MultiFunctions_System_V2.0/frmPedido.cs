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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                double vUnitario, vTotal, total = 0;
                int qtd;
                string nProduto;

                nProduto = txtProduto.Text; //Atribui o texto do txtBox a variável
                qtd = Convert.ToInt32(txtQTD.Text); //Atribui o valor do txtBox a varíavel
                vUnitario = Convert.ToDouble(txtVUnit.Text); //Atribui o valor do txtBox a varíavel
                vTotal = qtd * vUnitario; //Faz a conta para calcular o valor total DAQUELE produto

                dgvPedido.Rows.Add(nProduto, qtd, vUnitario, vTotal); // Ele avisa que no: dataGridView chamado dgvPedido será adicionado uma linha com o Nome, Quantidade, Valor por unidade e o Valor Total do produto

                foreach (DataGridViewRow row in dgvPedido.Rows) // Para cada linha do DataGridView nas linhas do dgvPedido então
                {
                    total += Convert.ToDouble(row.Cells["clmTotal"].Value); // Some a variável *total* o valor que está na coluna chamada "clmTotal" de TODAS AS LINHAS
                }

                txtValorTotal.Text = Convert.ToDouble(total).ToString("C"); // Altere o valor do txtValorTotal para o valor somado dentro do Foreach e automaticamente identificando o valor como moeda
            }
            catch
            {
                MessageBox.Show("Informe os valores corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Após verificar se é possível executar a ação, caso não seja possível é exibida uma mensagem de erro pedindo para que sejam adicionados os campos em falta.
            }
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPedido.RowCount; i++)
            {
                dgvPedido.Rows[i].DataGridView.Columns.Clear();
            }
            txtProduto.Clear();
            txtQTD.Clear();
            txtVUnit.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtQTD.Clear();
            txtVUnit.Clear();
        }

        private void pctSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModo_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.DimGray)
            {
                this.BackColor = Color.Honeydew;
                txtProduto.ForeColor = Color.Black;
                txtQTD.ForeColor = Color.Black;
                txtValorTotal.ForeColor = Color.Black;
                txtVUnit.ForeColor = Color.Black;
            }
            else if (this.BackColor == Color.Honeydew)
            {
                this.BackColor = Color.DimGray;
                txtProduto.ForeColor = Color.White;
                txtQTD.ForeColor = Color.White;
                txtValorTotal.ForeColor = Color.White;
                txtVUnit.ForeColor = Color.White;
            }
        }

        private void txtVUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar))) // Se for letra ou espaço em branco então não será digitado
                e.Handled = true;
        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar))) // Se for um número então não será digitado
                e.Handled = true;
        }
    }
}
