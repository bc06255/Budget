﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Budget
{

    class Connection
    {
        public String connectionString = "Data Source=DESKTOP-PG47RQQ; Initial Catalog=Budget; Integrated Security=True;";
        public String getConnection()
        {
            return connectionString;
        }
    }

   
}
