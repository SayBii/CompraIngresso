using CompraIngresso.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraIngresso.View
{
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();
        }
        Ingresso ingresso = new Ingresso();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txt_valor.Text);
            int quantidade = Convert.ToInt32(txt_qt.Text);
            lbl_resul.Text = ingresso.Calcular( valor, quantidade).ToString();
        }
    }
}
