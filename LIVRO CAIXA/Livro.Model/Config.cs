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

        public int Folha1
        {
            get
            {
                return Folha;
            }

            set
            {
                Folha = value;
            }
        }

        public int Cont1
        {
            get
            {
                return Cont;
            }

            set
            {
                Cont = value;
            }
        }

        public Config()
        {

        }

        public Config(int folha, int cont)
        {
            Folha1 = folha;
            Cont1 = cont;
        }

    }
}
