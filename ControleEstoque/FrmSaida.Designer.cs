
namespace ControleEstoque
{
    partial class FrmSaida
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
            this.labe1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVlrSaida = new System.Windows.Forms.TextBox();
            this.textBoxQntSaida = new System.Windows.Forms.TextBox();
            this.textBoxIdProd = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.bntConsulta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntNovo
            // 
            this.bntNovo.FlatAppearance.BorderSize = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(52, 162);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(62, 13);
            this.labe1.TabIndex = 2;
            this.labe1.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor";
            // 
            // textBoxVlrSaida
            // 
            this.textBoxVlrSaida.Location = new System.Drawing.Point(148, 188);
            this.textBoxVlrSaida.Name = "textBoxVlrSaida";
            this.textBoxVlrSaida.Size = new System.Drawing.Size(100, 20);
            this.textBoxVlrSaida.TabIndex = 4;
            // 
            // textBoxQntSaida
            // 
            this.textBoxQntSaida.Location = new System.Drawing.Point(148, 159);
            this.textBoxQntSaida.Name = "textBoxQntSaida";
            this.textBoxQntSaida.Size = new System.Drawing.Size(100, 20);
            this.textBoxQntSaida.TabIndex = 5;
            // 
            // textBoxIdProd
            // 
            this.textBoxIdProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxIdProd.Location = new System.Drawing.Point(148, 133);
            this.textBoxIdProd.Name = "textBoxIdProd";
            this.textBoxIdProd.Size = new System.Drawing.Size(33, 20);
            this.textBoxIdProd.TabIndex = 6;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // bntConsulta
            // 
            this.bntConsulta.Location = new System.Drawing.Point(187, 129);
            this.bntConsulta.Name = "bntConsulta";
            this.bntConsulta.Size = new System.Drawing.Size(29, 27);
            this.bntConsulta.TabIndex = 7;
            this.bntConsulta.Text = "...";
            this.bntConsulta.UseVisualStyleBackColor = true;
            this.bntConsulta.Click += new System.EventHandler(this.bntConsulta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo produto";
            // 
            // FrmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntConsulta);
            this.Controls.Add(this.textBoxIdProd);
            this.Controls.Add(this.textBoxQntSaida);
            this.Controls.Add(this.textBoxVlrSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labe1);
            this.Name = "FrmSaida";
            this.Text = "Saida de Produtos";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.labe1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBoxVlrSaida, 0);
            this.Controls.SetChildIndex(this.textBoxQntSaida, 0);
            this.Controls.SetChildIndex(this.textBoxIdProd, 0);
            this.Controls.SetChildIndex(this.bntConsulta, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVlrSaida;
        private System.Windows.Forms.TextBox textBoxQntSaida;
        private System.Windows.Forms.TextBox textBoxIdProd;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button bntConsulta;
        private System.Windows.Forms.Label label3;
    }
}
