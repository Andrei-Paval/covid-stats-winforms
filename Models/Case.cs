using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Case
    {
        public int CaseId { get; set; }
        public int TestId { get; set; }
        public int InfectedBy { get; set; }
        public string CovidVariant { get; set; }
        public string PatientState { get; set; }
        public string Severity { get; set; }
        public bool Hospitalized { get; set; }

        public Case(int caseId, int testId, int infectedBy, string covidVariant,
                    string patientState, string severity, bool hospitalized)
        {
            this.CaseId = caseId;
            this.TestId = testId;
            this.InfectedBy = infectedBy;
            this.CovidVariant = covidVariant;
            this.PatientState = patientState;
            this.Severity = severity;
            this.Hospitalized = hospitalized;
        }

        public Case(System.Data.DataRow lineDB)
        {
            this.CaseId = Convert.ToInt32(lineDB["case_id"]);
            this.TestId = Convert.ToInt32(lineDB["test_id"]);
            if (lineDB["infected_by"].Equals(System.DBNull.Value))
            {
                this.InfectedBy = -1;
            }
            else
            {
                this.InfectedBy = Convert.ToInt32(lineDB["infected_by"]);
            }

            this.CovidVariant = lineDB["covid_variant"].ToString();
            this.PatientState = lineDB["patient_state"].ToString();
            this.Severity = lineDB["severity"].ToString();
            this.Hospitalized = Convert.ToBoolean(lineDB["hospitalized"]);
        }
    }
}