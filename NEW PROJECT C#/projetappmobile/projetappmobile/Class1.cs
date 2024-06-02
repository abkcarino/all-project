using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetappmobile
{
    internal class Class1
    {
        SqlConnection con = new SqlConnection();

        DataTable dt = new DataTable();

        SqlCommand com = new SqlCommand();

        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();

    }
}
