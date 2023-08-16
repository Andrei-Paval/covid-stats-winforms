using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Comorbidities { get; set; }
        public int VaccineDoses { get; set; }

        public Person(int personId, string fullName, DateTime birthDate,
                      string comorbidities, int vaccineDoses = 0)
        {
            this.PersonId = personId;
            this.FullName = fullName;
            this.BirthDate = birthDate;
            this.Comorbidities = comorbidities;
            this.VaccineDoses = vaccineDoses;
        }

        public Person(System.Data.DataRow lineDB)
        {
            this.PersonId = Convert.ToInt32(lineDB["person_id"]);
            this.FullName = lineDB["full_name"].ToString();
            DateTime dateTime = Convert.ToDateTime(lineDB["birth_date"]);
            this.BirthDate = dateTime;
            this.Comorbidities = lineDB["comorbidities"].ToString();
            this.VaccineDoses = Convert.ToInt32(lineDB["vaccine_doses"]);
        }
    }
}