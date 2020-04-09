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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
         //   frmSplash splash = new frmSplash();
         //   splash.ShowDialog();
        }

        private void tmrRelogio_Tick(object sender, EventArgs e)
        {
            tssHora.Text = DateTime.Now.ToString("HH:mm:ss");
            tssData.Text = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy");
        }

        private void tsbCalculadora_Click(object sender, EventArgs e)
        {
            prcAplicativos.StartInfo.FileName = "Calc.exe";
            prcAplicativos.Start();
        }

        private void tsbBlocoDeNotas_Click(object sender, EventArgs e)
        {
            prcAplicativos.StartInfo.FileName = "Notepad.exe";
            prcAplicativos.Start();
        }

        private void tsbWord_Click(object sender, EventArgs e)
        {
            prcAplicativos.StartInfo.FileName = "Winword.exe";
            prcAplicativos.Start();
        }

        private void tsbPaint_Click(object sender, EventArgs e)
        {
            prcAplicativos.StartInfo.FileName = "mspaint.exe";
            prcAplicativos.Start();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaixaSobre cs = new CaixaSobre();
            //cs.Show(); (Pessoa pode usar outro formulário enquanto este está aberto)
            cs.ShowDialog(); //(Pessoa NÃO usa outro formulário enquanto este estiver aberto) 
        }

        private void dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDados dados = new frmDados();
            dados.ShowDialog();
        }

        private void tsbPedidos_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido();
            pedido.ShowDialog();
        }
    }
}
