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

        public static void UpdateController(Model.Livro objetoLivro, int id)
        {
            Model.LivroDao.UpdateDao(objetoLivro, id);
        }

        public static List<Model.Livro> SelectAllController()
        {
            Model.Livro livro = new Model.Livro();
            List<Model.Livro> livros = new List<Model.Livro>();

            livros =  Model.LivroDao.SelectAllDao();
            return livros;
        }

        public static List<Model.Livro> SelectDataController(DateTime datasrc)
        {
            Model.Livro livro = new Model.Livro();
            List<Model.Livro> livros = new List<Model.Livro>();

            livros = Model.LivroDao.SelectDataDao(datasrc);
            return livros;
        }

        public static List<Model.Livro> SelectFolhaController(int folha)
        {
            Model.Livro livro = new Model.Livro();
            List<Model.Livro> livros = new List<Model.Livro>();

            livros = Model.LivroDao.SelectFolhaDao(folha);
            return livros;
        }

    }
}
