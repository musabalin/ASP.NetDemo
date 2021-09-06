using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=MUSA-BALIN\SQLEXPRESS;Initial Catalog=Dbo_YazOkulu;Integrated Security=True");
    }
}
