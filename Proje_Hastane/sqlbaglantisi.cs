﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-D9BVTBR\\SQLEXPRESS;Initial Catalog=Hastane_Proje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
