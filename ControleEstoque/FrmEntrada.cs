using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class FrmEntrada : ControleEstoque.FrmBase
    {
        public FrmEntrada()
        {
            InitializeComponent();
        }

        private void bntConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta c = new FrmConsulta();
            c.ShowDialog();
            if (c.idProduto!=0)
            {
                textBoxProduto.Text = c.idProduto.ToString();
                textBoxProduto.Focus();
            }
        }

        private void textBoxProduto_Leave(object sender, EventArgs e)
        {
            Model get = new Model();
            DtoProduto produto = get.GetProdutoId(int.Parse(textBoxProduto.Text));
            textBoxNomeProduto.Text = produto.nome;
        }

        private void textBoxUnitario_Leave(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(textBoxQuantidade.Text) * decimal.Parse(textBoxUnitario.Text);
            textBoxTotal.Text = total.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                Model model = new Model();
                DtoEntradaProduto entrada = new DtoEntradaProduto();
                entrada.idproduto = int.Parse(textBoxProduto.Text);
                entrada.qteproduto = int.Parse(textBoxQuantidade.Text);
                entrada.vlrunitario = decimal.Parse(textBoxUnitario.Text);
                entrada.vlrtotal = decimal.Parse(textBoxTotal.Text);
                entrada.dtentrada = DateTime.Now;
                if (textBoxId.Text != String.Empty)
                {
                    entrada.id = int.Parse(textBoxId.Text);

                }
                else
                {
                    model.SetEntradaProduto(entrada);

                }
                //CarregarGrid2();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //public void CarregarGrid2()
            //{
            //    Model get = new Model();
            //    List<DtoEntradaProduto> EntProd = get.ListEntradaProdutos();
            //    this.dataGridView10.DataSource = EntProd;
            //    this.dataGridView10.Refresh();


            //}
        }
    }
}
