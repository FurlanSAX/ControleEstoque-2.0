using ControleEstoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class FrmSaida : ControleEstoque.FrmBase
    {
        public FrmSaida()
        {
            InitializeComponent();
        }

        private void bntConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta c = new FrmConsulta();
            c.ShowDialog();
            if (c.idProduto != 0)
            {
                textBoxIdProd.Text = c.idProduto.ToString();
                textBoxIdProd.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
                Model model = new Model();
                DtoSaidaProduto saida = new DtoSaidaProduto();
                saida.qteproduto = int.Parse(textBoxQntSaida.Text);
                model.SaidaProd(saida);
            }
    }
}
