//Table which in DB should have column as img and it's datatype must is image

        SqlCommand cmd = new SqlCommand($"INSERT INTO [STU] (name, dob, hometown,gender,cricket,img) VALUES('{name}','{dob}','{hometown}','{gender}','{cricket}',@pic)", conn);
            MemoryStream ms = new MemoryStream();
 