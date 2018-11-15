using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livro.Model;

namespace Livro.Controller
{
    public static class ConfigController
    {
        public static int[] SelectCfg()
        {
            Model.ConfigDao cfg = new Model.ConfigDao();
            return Model.ConfigDao.SelectConfigDao();
        }

        public static void UpdateCfg(int cont, int folha)
        {
            Model.ConfigDao cfg = new Model.ConfigDao();
            Model.ConfigDao.UpdateConfigDao(cont, folha);
        }


    }
}
