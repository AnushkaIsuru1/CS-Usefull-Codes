using MySql.Data.MySqlClient;

            string servConf = "server=localhost; uid=root; pwd='';database=test";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = servConf;
            try {conn.Open();}
            catch(MySqlException e){showMessage(e.ToString());}
            
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Addrow(st, reader["id"].ToString(), reader["nm"].ToString(), reader["snm"].ToString(), reader["un"].ToString(), reader["addr"].ToString());               
            }
