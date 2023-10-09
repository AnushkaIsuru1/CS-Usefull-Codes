using MySql.Data.MySqlClient;

            string servConf = "server=localhost; uid=root; pwd='';database=test";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = servConf;
            try {conn.Open();}
            catch(MySqlException e){showMessage(e.ToString());}
            
            string sql = $"INSERT INTO `user`( `nm`, `snm`, `un`, `pw`, `addr`) VALUES ('{nm}', '{snm}', '{un}', '{pw}', '{addr}');";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {

            }

            conn.Close();