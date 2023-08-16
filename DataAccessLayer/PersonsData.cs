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
    public class PersonsData
    {
        private const int FIRST_TABLE = 0;
        private const int FIRST_LINE = 0;

        public static List<Person> GetPersons()
        {
            var result = new List<Person>();
            var ds = SqlDbHelper.ExecuteDataSet("select * from persons_31a_ap order by person_id",
                                                CommandType.Text);

            foreach (DataRow lineDb in ds.Tables[FIRST_TABLE].Rows)
            {
                var Person = new Person(lineDb);
                result.Add(Person);
            }

            return result;
        }

        public static Person GetPerson(int id)
        {
            Person result = null;
            var ds = SqlDbHelper.ExecuteDataSet(
                "select * from persons_31a_ap where person_id = :id",
                CommandType.Text,
                new OracleParameter(":id", OracleDbType.Int32, id, ParameterDirection.Input));

            if (ds.Tables[FIRST_TABLE].Rows.Count > 0)
            {
                DataRow lineDb = ds.Tables[FIRST_TABLE].Rows[FIRST_LINE];
                result = new Person(lineDb);
            }

            return result;
        }

        public static bool AddPerson(Person p)
        {
            return SqlDbHelper.ExecuteNonQuery(
                "insert into persons_31a_ap VALUES (:person_id, :full_name, :birth_date, " +
                ":comborbidities, :vaccine_doses)",
                CommandType.Text,
                new OracleParameter(":person_id", OracleDbType.Int64, p.PersonId,
                                    ParameterDirection.Input),
                new OracleParameter(":full_name", OracleDbType.Varchar2, p.FullName,
                                    ParameterDirection.Input),
                new OracleParameter(":birth_date", OracleDbType.Date, p.BirthDate,
                                    ParameterDirection.Input),
                new OracleParameter(":comborbidities", OracleDbType.Varchar2, p.Comorbidities,
                                    ParameterDirection.Input),
                new OracleParameter(":vaccine_doses", OracleDbType.Int64, p.VaccineDoses,
                                    ParameterDirection.Input)
            );
        }

        public static bool UpdatePerson(Person p)
        {
            return SqlDbHelper.ExecuteNonQuery(
                "UPDATE persons_31a_ap set full_name =:full_name, birth_date =:birth_date, " +
                "comorbidities =:comborbidities, vaccine_doses =:vaccine_doses " +
                "where person_id =:person_id",
                CommandType.Text,
                new OracleParameter(":person_id", OracleDbType.Int64, p.PersonId,
                                    ParameterDirection.Input),
                new OracleParameter(":full_name", OracleDbType.Varchar2, p.FullName,
                                    ParameterDirection.Input),
                new OracleParameter(":birth_date", OracleDbType.Date, p.BirthDate,
                                    ParameterDirection.Input),
                new OracleParameter(":comborbidities", OracleDbType.Varchar2, p.Comorbidities,
                                    ParameterDirection.Input),
                new OracleParameter(":vaccine_doses", OracleDbType.Int64, p.VaccineDoses,
                                    ParameterDirection.Input)
            );
        }

        public static bool DeletePerson(int person_id)
        {
            return SqlDbHelper.ExecuteNonQuery(
                "DELETE FROM persons_31a_ap WHERE person_id =:person_id", CommandType.Text,
                new OracleParameter(":person_id", OracleDbType.Int64, person_id,
                                    ParameterDirection.Input)
            );
        }
    }
}