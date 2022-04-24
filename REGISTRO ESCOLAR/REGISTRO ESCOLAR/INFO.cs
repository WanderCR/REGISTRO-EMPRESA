using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace REGISTRO_ESCOLAR
{
    internal class INFO
    {
      public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-MQ36IKR;DATABASE=REGISTRO_EMPRESA;integrated security=true");
            cn.Open();
            return cn;




        }
}
}
