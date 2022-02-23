/*using System.Data;

using MySql.Data.MySqlClient;

namespace Pokedex
{
    class PokemonDB
    {
        //the connection
        MySqlConnection _con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=pokemon_db");


        //return the connection
        public MySqlConnection GetConnection
        {
            get
            {
                return _con;
            }
        }

        //open the connection
        public void OpenConnection()
        {
            if(_con.State == ConnectionState.Closed)
            {
                _con.Open();
            }
        }


        //close the connection
        public void CloseConnection()
        {
            if(_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
        }
    }
}*/