namespace Aula06_Ex01
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCalculadora = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBlocoDeNotas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbWord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPedidos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDados = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSistemaPesquisa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssProgramaTeste = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.prcAplicativos = new System.Diagnostics.Process();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicativosToolStripMenuItem,
            this.programasToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplicativosToolStripMenuItem
            // 
            this.aplicativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.blocoDeNotasToolStripMenuItem,
            this.wordToolStripMenuItem,
            this.paintToolStripMenuItem});
            this.aplicativosToolStripMenuItem.Name = "aplicativosToolStripMenuItem";
            this.aplicativosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.aplicativosToolStripMenuItem.Text = "&Aplicativos";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculadoraToolStripMenuItem.Image")));
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.calculadoraToolStripMenuItem.Text = "&Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.tsbCalculadora_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("blocoDeNotasToolStripMenuItem.Image")));
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.blocoDeNotasToolStripMenuItem.Text = "&Bloco de Notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.tsbBlocoDeNotas_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("wordToolStripMenuItem.Image")));
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.wordToolStripMenuItem.Text = "&Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.tsbWord_Click);
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paintToolStripMenuItem.Image")));
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.paintToolStripMenuItem.Text = "&Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.tsbPaint_Click);
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosTSM});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "&Programas";
            // 
            // dadosTSM
            // 
            this.dadosTSM.Name = "dadosTSM";
            this.dadosTSM.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.dadosTSM.Size = new System.Drawing.Size(181, 22);
            this.dadosTSM.Text = "Dados";
            this.dadosTSM.Click += new System.EventHandler(this.dadosToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCalculadora,
            this.toolStripSeparator1,
            this.tsbBlocoDeNotas,
            this.toolStripSeparator2,
            this.tsbWord,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.tsbPedidos,
            this.toolStripSeparator6,
            this.tsbDados,
            this.toolStripSeparator5,
            this.tsbSistemaPesquisa,
            this.toolStripSeparator7,
            this.tsbSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(642, 52);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCalculadora
            // 
            this.tsbCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalculadora.Image")));
            this.tsbCalculadora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalculadora.Name = "tsbCalculadora";
            this.tsbCalculadora.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbCalculadora.Size = new System.Drawing.Size(84, 49);
            this.tsbCalculadora.Text = "Calculadora";
            this.tsbCalculadora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCalculadora.Click += new System.EventHandler(this.tsbCalculadora_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // tsbBlocoDeNotas
            // 
            this.tsbBlocoDeNotas.Image = ((System.Drawing.Image)(resources.GetObject("tsbBlocoDeNotas.Image")));
            this.tsbBlocoDeNotas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBlocoDeNotas.Name = "tsbBlocoDeNotas";
            this.tsbBlocoDeNotas.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbBlocoDeNotas.Size = new System.Drawing.Size(101, 49);
            this.tsbBlocoDeNotas.Text = "Bloco de Notas";
            this.tsbBlocoDeNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBlocoDeNotas.Click += new System.EventHandler(this.tsbBlocoDeNotas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // tsbWord
            // 
            this.tsbWord.Image = ((System.Drawing.Image)(resources.GetObject("tsbWord.Image")));
            this.tsbWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWord.Name = "tsbWord";
            this.tsbWord.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.tsbWord.Size = new System.Drawing.Size(60, 49);
            this.tsbWord.Text = "Word";
            this.tsbWord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbWord.Click += new System.EventHandler(this.tsbWord_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.toolStripButton1.Size = new System.Drawing.Size(58, 49);
            this.toolStripButton1.Text = "Paint";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 52);
            // 
            // tsbPedidos
            // 
            this.tsbPedidos.Image = ((System.Drawing.Image)(resources.GetObject("tsbPedidos.Image")));
            this.tsbPedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPedidos.Name = "tsbPedidos";
            this.tsbPedidos.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.tsbPedidos.Size = new System.Drawing.Size(73, 49);
            this.tsbPedidos.Text = "Pedidos";
            this.tsbPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPedidos.Click += new System.EventHandler(this.tsbPedidos_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 52);
            // 
            // tsbDados
            // 
            this.tsbDados.Image = ((System.Drawing.Image)(resources.GetObject("tsbDados.Image")));
            this.tsbDados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDados.Name = "tsbDados";
            this.tsbDados.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.tsbDados.Size = new System.Drawing.Size(64, 49);
            this.tsbDados.Text = "Dados";
            this.tsbDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDados.Click += new System.EventHandler(this.dadosToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 52);
            // 
            // tsbSistemaPesquisa
            // 
            this.tsbSistemaPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("tsbSistemaPesquisa.Image")));
            this.tsbSistemaPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSistemaPesquisa.Name = "tsbSistemaPesquisa";
            this.tsbSistemaPesquisa.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.tsbSistemaPesquisa.Size = new System.Drawing.Size(77, 49);
            this.tsbSistemaPesquisa.Text = "Pesquisa";
            this.tsbSistemaPesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSistemaPesquisa.Click += new System.EventHandler(this.tsbSistemaPesquisa_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 52);
            // 
            // tsbSair
            // 
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.tsbSair.Size = new System.Drawing.Size(54, 49);
            this.tsbSair.Text = "Sair";
            this.tsbSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHora,
            this.tssData,
            this.tssProgramaTeste});
            this.statusStrip1.Location = new System.Drawing.Point(0, 196);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(642, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssHora
            // 
            this.tssHora.Name = "tssHora";
            this.tssHora.Size = new System.Drawing.Size(33, 17);
            this.tssHora.Text = "Hora";
            // 
            // tssData
            // 
            this.tssData.Name = "tssData";
            this.tssData.Size = new System.Drawing.Size(31, 17);
            this.tssData.Text = "Data";
            // 
            // tssProgramaTeste
            // 
            this.tssProgramaTeste.Name = "tssProgramaTeste";
            this.tssProgramaTeste.Size = new System.Drawing.Size(89, 17);
            this.tssProgramaTeste.Text = "Programa Teste";
            // 
            // tmrRelogio
            // 
            this.tmrRelogio.Enabled = true;
            this.tmrRelogio.Interval = 1000;
            this.tmrRelogio.Tick += new System.EventHandler(this.tmrRelogio_Tick);
            // 
            // prcAplicativos
            // 
            this.prcAplicativos.StartInfo.Domain = "";
            this.prcAplicativos.StartInfo.LoadUserProfile = false;
            this.prcAplicativos.StartInfo.Password = null;
            this.prcAplicativos.StartInfo.StandardErrorEncoding = null;
            this.prcAplicativos.StartInfo.StandardOutputEncoding = null;
            this.prcAplicativos.StartInfo.UserName = "";
            this.prcAplicativos.SynchronizingObject = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 218);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbCalculadora;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBlocoDeNotas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbWord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbDados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private System.Windows.Forms.ToolStripStatusLabel tssData;
        private System.Windows.Forms.ToolStripStatusLabel tssProgramaTeste;
        private System.Windows.Forms.Timer tmrRelogio;
        private System.Diagnostics.Process prcAplicativos;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem dadosTSM;
        private System.Windows.Forms.ToolStripButton tsbPedidos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbSistemaPesquisa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}

