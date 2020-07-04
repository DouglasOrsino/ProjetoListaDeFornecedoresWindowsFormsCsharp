using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaDotNet.ProjetoExemplo.WindowsForms.UI
{
    public partial class FFormularioInicial : Form
    {
        public FFormularioInicial()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Desconsiderar este parametro, cliquei sem querer duas vezes no dataGridView
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor();

            if(txtNomeDoFornecedor.Text != string.Empty)
            {
                fornecedor.NomeDoFornecedor = txtNomeDoFornecedor.Text;

            } else if (txtEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = txtEndereco.Text;

            } else if (txtNomeDoContato.Text != string.Empty)
            {
                fornecedor.NomeDoContato = txtNomeDoContato.Text;

            } else if (txtTelefone.Text != string.Empty)
            {
                fornecedor.Telefone = txtTelefone.Text;
            }

            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            listaFornecedores.Add(fornecedor);

            dgvFornecedores.DataSource = listaFornecedores;
        }
    }
}
