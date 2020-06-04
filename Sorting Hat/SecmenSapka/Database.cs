using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecmenSapka
{
    public class Database
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3P0R3GH;Initial Catalog=SecmenSapka;Integrated Security=True;MultipleActiveResultSets=True");
    }
}
