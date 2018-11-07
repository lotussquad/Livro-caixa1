using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro.Model
{
    public class Livro
    {
        private int id;
        private DateTime data;
        private string evento;
        private int numLivro;
        private int numFolha;
        private decimal receitas;
        private decimal despesas;

        public Livro(int id, DateTime data, string evento, int numLivro, int numFolha, decimal receitas, decimal despesas)
        {
            this.Id = id;
            this.Data = data;
            this.Evento = evento;
            this.NumLivro = numLivro;
            this.NumFolha = numFolha;
            this.Receitas = receitas;
            this.Despesas = despesas;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Evento { get => evento; set => evento = value; }
        public int NumLivro { get => numLivro; set => numLivro = value; }
        public int NumFolha { get => numFolha; set => numFolha = value; }
        public decimal Receitas { get => receitas; set => receitas = value; }
        public decimal Despesas { get => despesas; set => despesas = value; }
    }

}
