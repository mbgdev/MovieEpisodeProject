using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FacadeLayer.Connection
{
    internal class DbConnection
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-T9KCH5P;Initial Catalog=DbAkademiFilmDizi;Integrated Security=True;");
    }
}
