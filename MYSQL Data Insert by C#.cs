using MySql.Data.MySqlClient;

            string servConf = "server=localhost; uid=root; pwd='';database=test";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = servConf;

            conn.Close();