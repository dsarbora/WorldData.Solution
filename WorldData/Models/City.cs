using System;
using MySql.Data.MySqlClient;
using WorldData;

namespace WorldDate.Models
{
    public class City
    {
        private int ID;
        private string Name;
        private string CountryCode;
        private string District;
        private int Population;

        public City(int cityId, string cityName, string countryCode, string district, int population)
        {
            ID = cityId;
            Name = cityName;
            CountryCode = countryCode;
            District = district;
            Population = population;
        }
        public static List<City> GetAll()
        {
            List<City> allCities = new List<City>{};
            MySqlConntection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM city;";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
                int cityId = rdr.GetInt32(0);
                string cityName = rdr.GetString(1);
                string countryCode = rdr.GetString(2);
                string district = rdr.GetString(3);
                int population = rdr.GetInt32(4);
                City newCity = new City(cityId, cityName, countryCode, district, population);
                allCities.Add(newCity);
            }
            conn.Close();
            if(conn!=null)
            {
                conn.Dispose();
            }
            return allCities;
    }
}