using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livro.Model;
using System.Data;
using System.Data.SQLite;
using System.Data.Sql;

namespace Livro.Model
{
    public class ConfigDao
    {
        public static int[] SelectConfigDao()
        {
            Model.DataBase db = new Model.DataBase();
            SQLiteDataReader dr;
            db.OpenConnection();

            dr = db.ExecuteReader("SELECT * FROM Config");
            int[] tot = new int[2];

            while (dr.Read())
            {

                tot[0] = Convert.ToInt32(dr["Cont"]);
                tot[1] = Convert.ToInt32(dr["Folha"]);
            }

            return tot;
        }

        public static void UpdateConfigDao(int cont, int folha)
        {
            Model.DataBase db = new Model.DataBase();

            db.OpenConnection();
            db.AddParameter("@cont", cont, DbType.Int32);
            db.AddParameter("@folha", folha, DbType.Int32);

            db.ExecuteNoQuery("UPDATE Config SET Cont = @cont, Folha = @folha");
        }

    }
}
