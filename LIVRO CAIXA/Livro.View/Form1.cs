using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Livro.Controller;
using Livro.Model;

namespace Livro.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deletBtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void relatorioBtn_Click(object sender, EventArgs e)
        {
            Print printForm = new Print();
            printForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Model.Livro objetoLivro = new Model.Livro(Convert.ToDateTime(datecalendarinsert.Text), eventinsertTxt.Text, Convert.ToInt32(livroinsertTxt.Text), Convert.ToInt32(folhainsertTxt.Text), Convert.ToDecimal(receitasinsertTxt.Text), Convert.ToDecimal(despesasinsertTxt.Text));

            ClassController.InsertController(objetoLivro);
        }

        private void despesasinsertTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
