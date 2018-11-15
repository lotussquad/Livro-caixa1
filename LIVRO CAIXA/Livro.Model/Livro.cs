using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro.Model
{
    public class Livro
    {
        private string id;
        private DateTime data;
        private string evento;
        private int numLivro;
        private int numFolha;
        private decimal receitas;
        private decimal despesas;

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public string Evento
        {
            get
            {
                return evento;
            }

            set
            {
                evento = value;
            }
        }

        public int NumLivro
        {
            get
            {
                return numLivro;
            }

            set
            {
                numLivro = value;
            }
        }

        public int NumFolha
        {
            get
            {
                return numFolha;
            }

            set
            {
                numFolha = value;
            }
        }

        public decimal Receitas
        {
            get
            {
                return receitas;
            }

            set
            {
                receitas = value;
            }
        }

        public decimal Despesas
        {
            get
            {
                return despesas;
            }

            set
            {
                despesas = value;
            }
        }

        public Livro()
        {

        }


        public Livro(DateTime data, string evento, int numLivro, int numFolha, decimal receitas, decimal despesas)
        {
            this.Data = data;
            this.Evento = evento;
            this.NumLivro = numLivro;
            this.NumFolha = numFolha;
            this.Receitas = receitas;
            this.Despesas = despesas;
        }

        public Livro(string evento, int numLivro, int numFolha, decimal receitas, decimal despesas)
        {
            this.evento = evento;
            this.numLivro = numLivro;
            this.numFolha = numFolha;
            this.receitas = receitas;
            this.despesas = despesas;
        }

        public Livro(DateTime data, string evento, decimal receitas, decimal despesas)
        {
            this.Data = data;
            this.Evento = evento;
            this.Receitas = receitas;
            this.Despesas = despesas;
        }

        public Livro(string id, DateTime data, string evento, int numLivro, int numFolha, decimal receitas, decimal despesas)
        {
            this.id = id;
            this.data = data;
            this.evento = evento;
            this.numLivro = numLivro;
            this.numFolha = numFolha;
            this.receitas = receitas;
            this.despesas = despesas;
        }
    }
}
