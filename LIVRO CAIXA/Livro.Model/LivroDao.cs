﻿using System;
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
                db.ExecuteNoQuery("INSERT into Dados (ID, Data, Evento, Livro, Folha, Receitas, Despesas) values (@data, @evento, @numlivro, @numfolha, @receitas, @despesas)");
             
        }

        public static void DeleteDao(string id)
        {
            Model.DataBase db = new Model.DataBase();

            db.OpenConnection();
            db.AddParameter("@id", id, DbType.Int32);

            db.ExecuteNoQuery("DELETE from Dados WHERE ID = @id");


        }

        public static void UpdateDao(Model.Livro objetolivro, string id)
        {
            Model.DataBase db = new Model.DataBase();

            db.OpenConnection();
            db.AddParameter("@id", id, DbType.Int32);
            db.AddParameter("@data", objetolivro.Data, DbType.DateTime);
            db.AddParameter("@evento", objetolivro.Evento, DbType.String);
            db.AddParameter("@numlivro", objetolivro.NumLivro, DbType.Int32);
            db.AddParameter("@numfolha", objetolivro.NumFolha, DbType.Int32);
            db.AddParameter("@receitas", objetolivro.Receitas, DbType.Decimal);
            db.AddParameter("@despesas", objetolivro.Despesas, DbType.Decimal);

            db.ExecuteNoQuery("UPDATE Dados SET Data = @data, Evento = @evento, Livro = @numlivro, Folha = @numfolha, Receitas = @receitas, Despesas = @despesas WHERE ID = @id");
        }

        public SQLiteDataReader SelectDao(DateTime calendar)
        //{
            Model.DataBase db = new Model.DataBase();

            db.OpenConnection();
            db.AddParameter("@calendar", calendar, DbType.DateTime);

            return db.ExecuteReader("SELECT * FROM Config WHERE Data = @calendar");     
        }
    }
}
