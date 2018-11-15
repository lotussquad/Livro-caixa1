using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro.Model
{
    public class Config
    {
        private int Folha;
        private int Cont;

        public Config()
        {

        }

        public Config(int folha, int cont)
        {
            Folha1 = folha;
            Cont1 = cont;
        }

        public int Folha1 { get => Folha; set => Folha = value; }
        public int Cont1 { get => Cont; set => Cont = value; }
    }
}
