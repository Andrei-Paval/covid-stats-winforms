using Models;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class CitiesData
    {
        private const int FIRST_TABLE = 0;
        private const int FIRST_LINE = 0;

        public static List<City> GetCities()
        {
            var result = new List<City>();
            var ds = SqlDbHelper.ExecuteDataSet("select * from cities_31a_ap order by city_id",
                                                CommandType.Text);

            foreach (DataRow lineBD in ds.Tables[FIRST_TABLE].Rows)
            {
                var city = new City(lineBD);
                result.Add(city);
            }

            return result;
        }

        public static City GetCity(int id)
        {
            City result = null;
            var ds = SqlDbHelper.ExecuteDataSet("select * from cities_31a_ap where city_id = :id",
                                                CommandType.Text,
                                                new OracleParameter(
                                                    ":id", OracleDbType.Int32, id,
                                                    ParameterDirection.Input));

            if (ds.Tables[FIRST_TABLE].Rows.Count > 0)
            {
                DataRow lineBD = ds.Tables[FIRST_TABLE].Rows[FIRST_LINE];
                result = new City(lineBD);
            }

            return result;
        }

        public static bool AddCity(City c)
        {
            return SqlDbHelper.ExecuteNonQuery(
                "insert into cities_31a_ap VALUES (:city_id, :city_name, :country_name)",
                CommandType.Text,
                new OracleParameter(":city_id", OracleDbType.Int64, c.CityId,
                                    ParameterDirection.Input),
                new OracleParameter(":city_name", OracleDbType.Varchar2, c.CityName,
                                    ParameterDirection.Input),
                new OracleParameter(":country_name", OracleDbType.Varchar2, c.CountryName,
                                    ParameterDirection.Input)
            );
        }

        public static bool UpdateCity(City c)
        {
            return SqlDbHelper.ExecuteNonQuery(
                "UPDATE cities_31a_ap set city_name =:city_name, country_name =:country_name " +
                "where city_id =:city_id",
                CommandType.Text,
                new OracleParameter(":city_id", OracleDbType.Int64, c.CityId,
                                    ParameterDirection.Input),
                new OracleParameter(":city_name", OracleDbType.Varchar2, c.CityName,
                                    ParameterDirection.Input),
                new OracleParameter(":country_name", OracleDbType.Varchar2, c.CountryName,
                                    ParameterDirection.Input)
            );
        }

        public static bool DeleteCity(int city_id)
        {
            return SqlDbHelper.ExecuteNonQuery(
                "DELETE FROM cities_31a_ap WHERE city_id =:city_id", CommandType.Text,
                new OracleParameter(":city_id", OracleDbType.Int64, city_id,
                                    ParameterDirection.Input)
            );
        }
    }
}