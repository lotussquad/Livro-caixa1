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
            LoadPrinters();
        }

        private void relatorioBtn_Click(object sender, EventArgs e)
        {

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
            List<Model.Livro> livro = new List<Model.Livro>();
            livro =  ClassController.SelectAllController();

            dataGridView1.DataSource = livro;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void datecalendarselect_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime datasrc = Convert.ToDateTime(DateTime.Now.Year +"/"+ DateTime.Now.Month +"/"+ DateTime.Now.Day);

            List<Model.Livro> livro = new List<Model.Livro>();
            livro = ClassController.SelectDataController(datasrc);

             dataGridView1.DataSource = livro;
        }

        public void LoadPrinters()
        {
            foreach (var impressora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                selectImpressora.Items.Add(impressora);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (var pd= new System.Drawing.Printing.PrintDocument())
            {
                pd.PrinterSettings.PrinterName = selectImpressora.SelectedItem.ToString();
                pd.PrintPage += printDocument1_PrintPage;
                pd.Print();

            }
        }

        public List<Model.Livro> print = new List<Model.Livro>();

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (var font = new Font("Times New Roman", 14))
            using (var brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString("teste", font, brush, e.MarginBounds);
            }
        }
    }
}
