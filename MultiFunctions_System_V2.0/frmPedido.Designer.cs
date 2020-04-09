namespace Aula06_Ex01
{
    partial class frmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtVUnit = new System.Windows.Forms.TextBox();
            this.txtQTD = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.clmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.pctModoDia = new System.Windows.Forms.PictureBox();
            this.btnModo = new System.Windows.Forms.Button();
            this.btnLimparLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModoDia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(60, 28);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(65, 18);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnitario.Location = new System.Drawing.Point(27, 58);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(98, 18);
            this.lblValorUnitario.TabIndex = 1;
            this.lblValorUnitario.Text = "Valor unitário:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(38, 88);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(87, 18);
            this.lblQtd.TabIndex = 2;
            this.lblQtd.Text = "Quantidade:";
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.White;
            this.txtProduto.Location = new System.Drawing.Point(131, 29);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(156, 20);
            this.txtProduto.TabIndex = 3;
            this.txtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduto_KeyPress);
            // 
            // txtVUnit
            // 
            this.txtVUnit.Location = new System.Drawing.Point(131, 59);
            this.txtVUnit.Name = "txtVUnit";
            this.txtVUnit.Size = new System.Drawing.Size(81, 20);
            this.txtVUnit.TabIndex = 4;
            this.txtVUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVUnit_KeyPress);
            // 
            // txtQTD
            // 
            this.txtQTD.Location = new System.Drawing.Point(131, 89);
            this.txtQTD.Name = "txtQTD";
            this.txtQTD.Size = new System.Drawing.Size(81, 20);
            this.txtQTD.TabIndex = 5;
            this.txtQTD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVUnit_KeyPress);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(626, 25);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(120, 44);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(626, 75);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 44);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProduto,
            this.clmVUnitario,
            this.clmQtd,
            this.clmTotal});
            this.dgvPedido.Location = new System.Drawing.Point(30, 144);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(716, 257);
            this.dgvPedido.TabIndex = 8;
            // 
            // clmProduto
            // 
            this.clmProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmProduto.HeaderText = "Produto";
            this.clmProduto.Name = "clmProduto";
            this.clmProduto.ReadOnly = true;
            // 
            // clmVUnitario
            // 
            this.clmVUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmVUnitario.HeaderText = "V. Unitário";
            this.clmVUnitario.Name = "clmVUnitario";
            this.clmVUnitario.ReadOnly = true;
            // 
            // clmQtd
            // 
            this.clmQtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmQtd.HeaderText = "QTD";
            this.clmQtd.Name = "clmQtd";
            this.clmQtd.ReadOnly = true;
            // 
            // clmTotal
            // 
            this.clmTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(589, 418);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(156, 20);
            this.txtValorTotal.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(505, 418);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 18);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Valor total:";
            // 
            // pctSair
            // 
            this.pctSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctSair.BackgroundImage")));
            this.pctSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctSair.Location = new System.Drawing.Point(764, -1);
            this.pctSair.Name = "pctSair";
            this.pctSair.Size = new System.Drawing.Size(34, 31);
            this.pctSair.TabIndex = 11;
            this.pctSair.TabStop = false;
            this.pctSair.Click += new System.EventHandler(this.pctSair_Click_1);
            // 
            // pctModoDia
            // 
            this.pctModoDia.BackgroundImage = global::Aula06_Ex01.Properties.Resources.Modo_Dia;
            this.pctModoDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctModoDia.Location = new System.Drawing.Point(2, 418);
            this.pctModoDia.Name = "pctModoDia";
            this.pctModoDia.Size = new System.Drawing.Size(34, 31);
            this.pctModoDia.TabIndex = 12;
            this.pctModoDia.TabStop = false;
            // 
            // btnModo
            // 
            this.btnModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModo.Location = new System.Drawing.Point(491, 25);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(120, 44);
            this.btnModo.TabIndex = 13;
            this.btnModo.Text = "Modo";
            this.btnModo.UseVisualStyleBackColor = true;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparLista.Location = new System.Drawing.Point(491, 75);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(120, 44);
            this.btnLimparLista.TabIndex = 14;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.btnModo);
            this.Controls.Add(this.pctModoDia);
            this.Controls.Add(this.pctSair);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtQTD);
            this.Controls.Add(this.txtVUnit);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.lblProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModoDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtVUnit;
        private System.Windows.Forms.TextBox txtQTD;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.PictureBox pctModoDia;
        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.Button btnLimparLista;
    }
}