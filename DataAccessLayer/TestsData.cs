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
    public class TestsData
    {
        private const int FIRST_TABLE = 0;
        private const int FIRST_LINE = 0;

        public static List<Test> GetTests()
        {
            var result = new List<Test>();
            var ds = SqlDbHelper.ExecuteDataSet("select * from tests_31a_ap order by test_id",
                                                CommandType.Text);

            foreach (DataRow lineDb in ds.Tables[FIRST_TABLE].Rows)
            {
                var Test = new Test(lineDb);
                result.Add(Test);
            }

            return result;
        }

        public static Test GetTest(int id)
        {
            Test result = null;
            var ds = SqlDbHelper.ExecuteDataSet("select * from tests_31a_ap where test_id = :id",
                                                CommandType.Text,
                                                new OracleParameter(":id", OracleDbType.Int32, id,
                                                    ParameterDirection.Input));

            if (ds.Tables[FIRST_TABLE].Rows.Count > 0)
            {
                DataRow lineDb = ds.Tables[FIRST_TABLE].Rows[FIRST_LINE];
                result = new Test(lineDb);
            }

            return result;
        }

        public static bool AddTest(Test t)
        {
            return SqlDbHelper.ExecuteNonQuery(
                "insert into tests_31a_ap VALUES (:test_id, :city_id, :person_id, " +
                ":test_date, :positive)",
                CommandType.Text,
                new OracleParameter(":test_id", OracleDbType.Int64, t.TestId,
                                    ParameterDirection.Input),
                new OracleParameter(":city_id", OracleDbType.Int64, t.CityId,
                                    ParameterDirection.Input),
                new OracleParameter(":person_id", OracleDbType.Int64, t.PersonId,
                                    ParameterDirection.Input),
                new OracleParameter(":test_date", OracleDbType.Date, t.TestDate,
                                    ParameterDirection.Input),
                new OracleParameter(":positive", OracleDbType.Int32, t.Positive,
                                    ParameterDirection.Input)
            );
        }

        public static bool UpdateTest(Test t)
        {
            return SqlDbHelper.ExecuteNonQuery(
                "UPDATE tests_31a_ap set city_id =:city_id, person_id =:person_id, " +
                "test_date =:test_date, positive =:positive where test_id =:test_id",
                CommandType.Text,
                new OracleParameter(":test_id", OracleDbType.Int64, t.TestId,
                                    ParameterDirection.Input),
                new OracleParameter(":city_id", OracleDbType.Int64, t.CityId,
                                    ParameterDirection.Input),
                new OracleParameter(":person_id", OracleDbType.Int64, t.PersonId,
                                    ParameterDirection.Input),
                new OracleParameter(":test_date", OracleDbType.Date, t.TestDate,
                                    ParameterDirection.Input),
                new OracleParameter(":positive", OracleDbType.Int32, t.Positive,
                                    ParameterDirection.Input)
            );
        }

        public static bool DeleteTest(int testId)
        {
            return SqlDbHelper.ExecuteNonQuery(
                "DELETE FROM tests_31a_ap WHERE test_id =:test_id", CommandType.Text,
                new OracleParameter(":test_id", OracleDbType.Int64, testId,
                                    ParameterDirection.Input)
            );
        }
    }
}