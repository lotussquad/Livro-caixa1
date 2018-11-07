using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livro.Model;
using System.Data;
using System.Data.Sql;

namespace Livro.Controller
{
    public class ClassController
    {
        public static void InsertController(Model.Livro objetoLivro)
        {
            Model.LivroDao.InsertDao(objetoLivro);
        }

        public static void DeleteController(string id)
        {
            Model.LivroDao.DeleteDao(id);
        }

        public static void UpdateController(Model.Livro objetoLivro, string id)
        {
            Model.LivroDao.UpdateDao(objetoLivro, id);
        }

        public static void SelectController(DateTime calendar)
        {
            return Model.LivroDao.SelectDao(calendar);
        }


    }
}
