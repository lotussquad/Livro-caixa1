using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Data.Sql;


namespace Livro.Model
{
    public class LivroDao
    {

        public static void InsertDao(Model.Livro objetolivro)
        {
            Model.DataBase db = new Model.DataBase();

            db.OpenConnection();
                db.AddParameter("@data", objetolivro.Data, DbType.DateTime);
                db.AddParameter("@evento", objetolivro.Evento, DbType.String);
                db.AddParameter("@numlivro", objetolivro.NumLivro, DbType.Int32);
                db.AddParameter("@numfolha", objetolivro.NumFolha, DbType.Int32);
                db.AddParameter("@receitas", objetolivro.Receitas, DbType.Decimal);
                db.AddParameter("@despesas", objetolivro.Despesas, DbType.Decimal);
                db.ExecuteNoQuery("INSERT into Dados (Data, Evento, Livro, Folha, Receita, Despesas) values (@data, @evento, @numlivro, @numfolha, @receitas, @despesas)");
             
        }

        public static void DeleteDao(string id)
        {
            Model.DataBase db = new Model.DataBase();

            db.OpenConnection();
            db.AddParameter("@id", id, DbType.Int32);

            db.ExecuteNoQuery("DELETE from Dados WHERE ID = @id");


        }

        public static void UpdateDao(Model.Livro objetolivro, int id)
        {
            Model.DataBase db = new Model.DataBase();

            db.OpenConnection();
            db.AddParameter("@id", id, DbType.Int32);
            db.AddParameter("@data", objetolivro.Data, DbType.DateTime);
            db.AddParameter("@evento", objetolivro.Evento, DbType.String);
            db.AddParameter("@receitas", objetolivro.Receitas, DbType.Decimal);
            db.AddParameter("@despesas", objetolivro.Despesas, DbType.Decimal);

            db.ExecuteNoQuery("UPDATE Dados SET Data = @data, Evento = @evento, Receita = @receitas, Despesas = @despesas WHERE ID = @id");
        }

        public static List<Livro> SelectAllDao()
        {
            Model.DataBase db = new Model.DataBase();
            SQLiteDataReader dr;
            db.OpenConnection();
       
            dr = db.ExecuteReader("SELECT * FROM Dados");


            List<Livro> livros = new List<Livro>();

            while (dr.Read())
            {
                Livro livro = new Livro();
                livro.Data = Convert.ToDateTime(dr["Data"]);
                livro.Evento = Convert.ToString(dr["Evento"]);
                livro.NumLivro = Convert.ToInt32(dr["Livro"]);
                livro.NumFolha = Convert.ToInt32(dr["Folha"]);
                livro.Receitas = Convert.ToDecimal(dr["Receita"]);
                livro.Despesas = Convert.ToDecimal(dr["Despesas"]);
                livros.Add(livro);
            }

            return livros;
        }

        public static List<Livro> SelectDataDao(DateTime datasrc)
        {
            Model.DataBase db = new Model.DataBase();
            SQLiteDataReader dr;
            db.OpenConnection();
            db.AddParameter("@data", datasrc, DbType.DateTime);

            dr = db.ExecuteReader("SELECT * FROM Dados where Data = @Data");


            List<Livro> livros = new List<Livro>();

            while (dr.Read())
            {
                Livro livro = new Livro();
                livro.Data = Convert.ToDateTime(dr["Data"]);
                livro.Evento = Convert.ToString(dr["Evento"]);
                livro.NumLivro = Convert.ToInt32(dr["Livro"]);
                livro.NumFolha = Convert.ToInt32(dr["Folha"]);
                livro.Receitas = Convert.ToDecimal(dr["Receita"]);
                livro.Despesas = Convert.ToDecimal(dr["Despesas"]);
                livros.Add(livro);
            }

            return livros;
        }

        public static List<Livro> SelectFolhaDao(int folha)
        {
            Model.DataBase db = new Model.DataBase();
            SQLiteDataReader dr;
            db.OpenConnection();
            db.AddParameter("@folha", folha, DbType.Int32);

            dr = db.ExecuteReader("SELECT * FROM Dados where Folha = @folha");


            List<Livro> livros = new List<Livro>();

            while (dr.Read())
            {
                Livro livro = new Livro();
                livro.Data = Convert.ToDateTime(dr["Data"]);
                livro.Evento = Convert.ToString(dr["Evento"]);
                livro.NumLivro = Convert.ToInt32(dr["Livro"]);
                livro.NumFolha = Convert.ToInt32(dr["Folha"]);
                livro.Receitas = Convert.ToDecimal(dr["Receita"]);
                livro.Despesas = Convert.ToDecimal(dr["Despesas"]);
                livros.Add(livro);
            }

            return livros;
        }

    }
}
