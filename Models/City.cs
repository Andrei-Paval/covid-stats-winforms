using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }

        public City(int cityId, string cityName, string countryName)
        {
            this.CityId = cityId;
            this.CityName = cityName;
            this.CountryName = countryName;
        }

        public City(System.Data.DataRow lineDB)
        {
            this.CityId = Convert.ToInt32(lineDB["city_id"]);
            this.CityName = lineDB["city_name"].ToString();
            this.CountryName = lineDB["country_name"].ToString();
        }
    }
}