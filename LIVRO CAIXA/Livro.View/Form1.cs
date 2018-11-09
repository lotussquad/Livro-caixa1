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
            string id = iddeleteTxt.Text;
            ClassController.DeleteController(id);
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Model.Livro objetoLivro2 = new Model.Livro(Convert.ToDateTime(datecalendarupdate.Text), eventupdateTxt.Text, Convert.ToInt32(livroupdateTxt.Text), Convert.ToInt32(folhaupdateTxt.Text), Convert.ToDecimal(receitasupdateTxt.Text), Convert.ToDecimal(despesasupdateTxt.Text));
            int id = Convert.ToInt32(idupdateTxt.Text);
            ClassController.UpdateController(objetoLivro2, id);
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClassController.SelectController();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void datecalendarselect_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
