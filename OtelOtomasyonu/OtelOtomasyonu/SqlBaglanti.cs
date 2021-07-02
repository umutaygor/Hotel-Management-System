using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OtelOtomasyonu
{
    public class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Server=.;Database=OtelOtomasyonu; trusted_connection=true");
            baglan.Open();
            return baglan;
        }
    }
}
