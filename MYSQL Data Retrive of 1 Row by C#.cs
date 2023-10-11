using MySql.Data.MySqlClient;

            string servConf = "server=localhost; uid=root; pwd='';database=test";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = servConf;
            try {conn.Open();}
            catch(MySqlException e){showMessage(e.ToString());}
            
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `user` WHERE id='{5}'", conn);
            MySqlDataReader r = cmd.ExecuteReader();
            r.Read();
            
