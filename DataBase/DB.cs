using MySql.Data.MySqlClient;
using System;

namespace TrackerForm.DataBase
{
    public class DB
    {
        public DB()
        {
            {
                string host = "127.0.0.1:3306";
                string database = "habbitlist"; 
                string user = "root"; 
                string password = "password"; 

                string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user;

               
                MySqlConnection mysql_connection = new MySqlConnection(Connect);

                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = "SELECT `ID`, `Name` FROM `habbitlist` WHERE 1";

               
            }


        }
    }
}
