using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Test
    {
        public int TestId { get; set; }
        public int CityId { get; set; }
        public int PersonId { get; set; }
        public DateTime TestDate { get; set; }
        public bool Positive { get; set; }

        public Test(int testId, int cityId, int personId, DateTime testDate, bool positive)
        {
            this.TestId = testId;
            this.CityId = cityId;
            this.PersonId = personId;
            this.TestDate = testDate;
            this.Positive = positive;
        }

        public Test(System.Data.DataRow lineDB)
        {
            this.TestId = Convert.ToInt32(lineDB["test_id"]);
            this.CityId = Convert.ToInt32(lineDB["city_id"]);
            this.PersonId = Convert.ToInt32(lineDB["person_id"]);
            DateTime dateTime = Convert.ToDateTime(lineDB["test_date"]);
            this.TestDate = dateTime;
            this.Positive = Convert.ToBoolean(lineDB["positive"]);
        }
    }
}