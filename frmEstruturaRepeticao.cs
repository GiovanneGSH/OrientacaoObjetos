using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmEstruturaRepeticao : Form
    {

        //Método construtor da classe
        public frmEstruturaRepeticao()
        {
            InitializeComponent();
            //executa o método carrega combo
            carregaCombo();
        }

        private void btnCarregaEstado_Click(object sender, EventArgs e)
        {
            //executa o método carrega combo
            carregaCombo();

        }
        //criando o método construtor
        public void carregaCombo()
        {

            cbbEstados.Items.Clear();
            cbbEstados.Items.Add("Santo Amaro");
            cbbEstados.Items.Add("Capão Redondo");
            cbbEstados.Items.Add("São Luiz");
            cbbEstados.Items.Add("Jardim Angela");
            cbbEstados.Items.Add("Jardim Jacira");
            cbbEstados.Items.Add("Jardim Nakamura");
            cbbEstados.Items.Add("Capelinha");
            cbbEstados.Items.Add("Vila Remo");
            cbbEstados.Items.Add("Piraporinha");
            cbbEstados.Items.Add("Campo Grande");
            cbbEstados.Items.Add("Campo Limpo");


        }



    }
}
