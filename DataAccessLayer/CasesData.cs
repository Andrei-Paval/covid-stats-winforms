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
    public static class CasesData
    {
        private const int FIRST_TABLE = 0;
        private const int FIRST_LINE = 0;

        public static List<Case> GetCases()
        {
            var result = new List<Case>();
            var ds = SqlDbHelper.ExecuteDataSet("select * from cases_31a_ap order by case_id",
                                                CommandType.Text);

            foreach (DataRow lineBD in ds.Tables[FIRST_TABLE].Rows)
            {
                var caz = new Case(lineBD);
                result.Add(caz);
            }

            return result;
        }

        public static Case GetCase(int id)
        {
            Case result = null;
            var ds = SqlDbHelper.ExecuteDataSet("select * from cases_31a_ap where case_id = :id",
                                                CommandType.Text,
                                                new OracleParameter(
                                                    ":id", OracleDbType.Int32, id,
                                                    ParameterDirection.Input));

            if (ds.Tables[FIRST_TABLE].Rows.Count > 0)
            {
                DataRow lineBD = ds.Tables[FIRST_TABLE].Rows[FIRST_LINE];
                result = new Case(lineBD);
            }

            return result;
        }

        public static void DeleteCase(int id)
        {
            SqlDbHelper.ExecuteNonQuery(
                "delete from cases_31a_ap where case_id =:case_id", CommandType.Text,
                new OracleParameter(":case_id", OracleDbType.Int64, id, ParameterDirection.Input)
            );
        }

        public static bool AddCase(Case c)
        {
            if (c.InfectedBy == -1)
            {
                return SqlDbHelper.ExecuteNonQuery(
                    "insert into cases_31a_ap (case_id, test_id, covid_variant, patient_state, " +
                    "severity, hospitalized) VALUES (:case_id, :test_id, :covid_variant, " +
                    ":patient_state, :severity, :hospitalized)",
                    CommandType.Text,
                    new OracleParameter(":case_id", OracleDbType.Int64, c.CaseId,
                                        ParameterDirection.Input),
                    new OracleParameter(":test_id", OracleDbType.Int64, c.TestId,
                                        ParameterDirection.Input),
                    new OracleParameter(":covid_variant", OracleDbType.Varchar2, c.CovidVariant,
                                        ParameterDirection.Input),
                    new OracleParameter(":patient_state", OracleDbType.Varchar2, c.PatientState,
                                        ParameterDirection.Input),
                    new OracleParameter(":severity", OracleDbType.Varchar2, c.Severity,
                                        ParameterDirection.Input),
                    new OracleParameter(":hospitalized", OracleDbType.Int64, c.Hospitalized,
                                        ParameterDirection.Input)
                );
            }
            else
            {
                return SqlDbHelper.ExecuteNonQuery(
                    "insert into cases_31a_ap VALUES (:case_id, :test_id, :infected_by, " +
                    ":covid_variant, :patient_state, :severity, :hospitalized)",
                    CommandType.Text,
                    new OracleParameter(":case_id", OracleDbType.Int64, c.CaseId,
                                        ParameterDirection.Input),
                    new OracleParameter(":test_id", OracleDbType.Int64, c.TestId,
                                        ParameterDirection.Input),
                    new OracleParameter(":infected_by", OracleDbType.Int64, c.InfectedBy,
                                        ParameterDirection.Input),
                    new OracleParameter(":covid_variant", OracleDbType.Varchar2, c.CovidVariant,
                                        ParameterDirection.Input),
                    new OracleParameter(":patient_state", OracleDbType.Varchar2, c.PatientState,
                                        ParameterDirection.Input),
                    new OracleParameter(":severity", OracleDbType.Varchar2, c.Severity,
                                        ParameterDirection.Input),
                    new OracleParameter(":hospitalized", OracleDbType.Int64, c.PatientState,
                                        ParameterDirection.Input)
                );
            }
        }

        public static bool UpdateCase(Case c)
        {
            if (c.InfectedBy != -1)
            {
                return SqlDbHelper.ExecuteNonQuery(
                    "UPDATE cases_31a_ap set test_id =:test_id, infected_by =:infected_by, " +
                    "covid_variant =:covid_variant, patient_state =:patient_state, " +
                    "severity =:severity, hospitalized =:hospitalized where case_id =:case_id",
                    CommandType.Text,
                    new OracleParameter(":case_id", OracleDbType.Int64, c.CaseId,
                                        ParameterDirection.Input),
                    new OracleParameter(":test_id", OracleDbType.Int64, c.TestId,
                                        ParameterDirection.Input),
                    new OracleParameter(":infected_by", OracleDbType.Int64, c.InfectedBy,
                                        ParameterDirection.Input),
                    new OracleParameter(":covid_variant", OracleDbType.Varchar2, c.CovidVariant,
                                        ParameterDirection.Input),
                    new OracleParameter(":patient_state", OracleDbType.Varchar2, c.PatientState,
                                        ParameterDirection.Input),
                    new OracleParameter(":severity", OracleDbType.Varchar2, c.Severity,
                                        ParameterDirection.Input),
                    new OracleParameter(":hospitalized", OracleDbType.Int64, c.Hospitalized,
                                        ParameterDirection.Input)
                );
            }
            else
            {
                return SqlDbHelper.ExecuteNonQuery(
                    "UPDATE cases_31a_ap set test_id =:test_id, covid_variant =:covid_variant, " +
                    "patient_state =:patient_state, severity =:severity, " +
                    "hospitalized =:hospitalized where case_id =:case_id",
                    CommandType.Text,
                    new OracleParameter(":case_id", OracleDbType.Int64, c.CaseId,
                                        ParameterDirection.Input),
                    new OracleParameter(":test_id", OracleDbType.Int64, c.TestId,
                                        ParameterDirection.Input),
                    new OracleParameter(":covid_variant", OracleDbType.Varchar2, c.CovidVariant,
                                        ParameterDirection.Input),
                    new OracleParameter(":patient_state", OracleDbType.Varchar2, c.PatientState,
                                        ParameterDirection.Input),
                    new OracleParameter(":severity", OracleDbType.Varchar2, c.Severity,
                                        ParameterDirection.Input),
                    new OracleParameter(":hospitalized", OracleDbType.Int64, c.Hospitalized,
                                        ParameterDirection.Input)
                );
            }
        }
    }
}