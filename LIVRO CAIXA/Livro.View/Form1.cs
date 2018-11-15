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
            this.reportViewer1.RefreshReport();
        }

        private void relatorioBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int livro = Convert.ToInt32(DateTime.Now.Year);
            int[] cfgEnd = new int[2];
            cfgEnd = ConfigController.SelectCfg();

            int cont = Convert.ToInt32(cfgEnd[0]);
            int folha = Convert.ToInt32(cfgEnd[1]);

            if (cont == 11)
            {
                cont = 1;
                folha = folha + 1;
            }

            Model.Livro objetoLivro = new Model.Livro(Convert.ToDateTime(datecalendarinsert.Text), eventinsertTxt.Text, livro, folha, Convert.ToDecimal(receitasinsertTxt.Text), Convert.ToDecimal(despesasinsertTxt.Text));
            ClassController.InsertController(objetoLivro);

            cont = cont + 1;
            
            ConfigController.UpdateCfg(cont, folha);
        }

        private void despesasinsertTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Model.Livro objetoLivro2 = new Model.Livro(Convert.ToDateTime(datecalendarupdate.Text), eventupdateTxt.Text, Convert.ToDecimal(receitasupdateTxt.Text), Convert.ToDecimal(despesasupdateTxt.Text));
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
            int numFolha = Convert.ToInt32(txtFolhaPrinter.Text);
            List<Model.Livro> pagePrint = new List<Model.Livro>();
            pagePrint = ClassController.SelectFolhaController(numFolha);

            using (var pd = new System.Drawing.Printing.PrintDocument())
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
                e.Graphics.DrawString("teste1 teste2 teste3 teste4 teste5 teste6\n " +
                    "teste6 teste5 teste4 teste3 teste2 teste1", font, brush, e.MarginBounds);

            }
        }



        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
