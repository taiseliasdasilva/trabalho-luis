namespace ControleTrocaOleo
{
    partial class frmControleTroca
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
            this.lblData = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblOleo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblValorLitro = new System.Windows.Forms.Label();
            this.lblQuantidadeLitro = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dtpDataTroca = new System.Windows.Forms.DateTimePicker();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbOleo = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.txtValorLitro = new System.Windows.Forms.TextBox();
            this.txtQtdLitro = new System.Windows.Forms.TextBox();
            this.txtVlrTotal = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(35, 43);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 23);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(35, 95);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(85, 23);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblOleo
            // 
            this.lblOleo.AutoSize = true;
            this.lblOleo.Location = new System.Drawing.Point(35, 155);
            this.lblOleo.Name = "lblOleo";
            this.lblOleo.Size = new System.Drawing.Size(63, 23);
            this.lblOleo.TabIndex = 2;
            this.lblOleo.Text = "Óleo:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(35, 216);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(110, 23);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(35, 273);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(61, 23);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(35, 328);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(117, 23);
            this.lblFabricante.TabIndex = 5;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // lblValorLitro
            // 
            this.lblValorLitro.AutoSize = true;
            this.lblValorLitro.Location = new System.Drawing.Point(426, 43);
            this.lblValorLitro.Name = "lblValorLitro";
            this.lblValorLitro.Size = new System.Drawing.Size(119, 23);
            this.lblValorLitro.TabIndex = 6;
            this.lblValorLitro.Text = "Valor Litro:";
            // 
            // lblQuantidadeLitro
            // 
            this.lblQuantidadeLitro.AutoSize = true;
            this.lblQuantidadeLitro.Location = new System.Drawing.Point(426, 95);
            this.lblQuantidadeLitro.Name = "lblQuantidadeLitro";
            this.lblQuantidadeLitro.Size = new System.Drawing.Size(179, 23);
            this.lblQuantidadeLitro.TabIndex = 7;
            this.lblQuantidadeLitro.Text = "Quantidade Litro:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(342, 155);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(121, 23);
            this.lblValorTotal.TabIndex = 8;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(342, 216);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(145, 23);
            this.lblEmailCliente.TabIndex = 9;
            this.lblEmailCliente.Text = "Email Cliente:";
            this.lblEmailCliente.Click += new System.EventHandler(this.lblEmailCliente_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(490, 267);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(141, 35);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(414, 328);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(141, 35);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(583, 328);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(141, 35);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dtpDataTroca
            // 
            this.dtpDataTroca.Location = new System.Drawing.Point(104, 35);
            this.dtpDataTroca.Name = "dtpDataTroca";
            this.dtpDataTroca.Size = new System.Drawing.Size(316, 31);
            this.dtpDataTroca.TabIndex = 13;
            this.dtpDataTroca.ValueChanged += new System.EventHandler(this.dtpDataTroca_ValueChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(126, 87);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(294, 31);
            this.cmbCliente.TabIndex = 14;
            // 
            // cmbOleo
            // 
            this.cmbOleo.FormattingEnabled = true;
            this.cmbOleo.Location = new System.Drawing.Point(104, 147);
            this.cmbOleo.Name = "cmbOleo";
            this.cmbOleo.Size = new System.Drawing.Size(232, 31);
            this.cmbOleo.TabIndex = 15;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(151, 208);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(185, 31);
            this.cmbCategoria.TabIndex = 16;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(104, 265);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(232, 31);
            this.cmbTipo.TabIndex = 17;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(158, 320);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(178, 31);
            this.cmbFabricante.TabIndex = 18;
            // 
            // txtValorLitro
            // 
            this.txtValorLitro.Location = new System.Drawing.Point(551, 35);
            this.txtValorLitro.Name = "txtValorLitro";
            this.txtValorLitro.Size = new System.Drawing.Size(176, 31);
            this.txtValorLitro.TabIndex = 19;
            // 
            // txtQtdLitro
            // 
            this.txtQtdLitro.Location = new System.Drawing.Point(611, 87);
            this.txtQtdLitro.Name = "txtQtdLitro";
            this.txtQtdLitro.Size = new System.Drawing.Size(116, 31);
            this.txtQtdLitro.TabIndex = 20;
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.Location = new System.Drawing.Point(469, 147);
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.ReadOnly = true;
            this.txtVlrTotal.Size = new System.Drawing.Size(258, 31);
            this.txtVlrTotal.TabIndex = 21;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(493, 208);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(234, 31);
            this.txtEmailCliente.TabIndex = 22;
            // 
            // frmControleTroca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 390);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtVlrTotal);
            this.Controls.Add(this.txtQtdLitro);
            this.Controls.Add(this.txtValorLitro);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbOleo);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dtpDataTroca);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblQuantidadeLitro);
            this.Controls.Add(this.lblValorLitro);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblOleo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblData);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmControleTroca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Serviço - Troca de Óleo";
            this.Load += new System.EventHandler(this.frmControleTroca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblOleo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblValorLitro;
        private System.Windows.Forms.Label lblQuantidadeLitro;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DateTimePicker dtpDataTroca;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbOleo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.TextBox txtValorLitro;
        private System.Windows.Forms.TextBox txtQtdLitro;
        private System.Windows.Forms.TextBox txtVlrTotal;
        private System.Windows.Forms.TextBox txtEmailCliente;
    }
}