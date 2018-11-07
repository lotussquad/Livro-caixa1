using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro.Model
{
    public class Livro
    {
        private DateTime data;
        private string evento;
        private string numLivro;
        private string numFolha;
        private string receitas;
        private string despesas;

        public Livro()
        {

        }

        public Livro(DateTime data, string evento, string numLivro, string numFolha, string receitas, string despesas)
        {
            this.Data = data;
            this.Evento = evento;
            this.NumLivro = numLivro;
            this.NumFolha = numFolha;
            this.Receitas = receitas;
            this.Despesas = despesas;
        }

        public DateTime Data { get => data; set => data = value; }
        public string Evento { get => evento; set => evento = value; }
        public string NumLivro { get => numLivro; set => numLivro = value; }
        public string NumFolha { get => numFolha; set => numFolha = value; }
        public string Receitas { get => receitas; set => receitas = value; }
        public string Despesas { get => despesas; set => despesas = value; }
    }
}
