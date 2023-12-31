using System;
using System.Windows.Forms;
using Models;
using DataAccessLayer;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Data;

namespace CovidStatistics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            case_resetTexts();
            test_resetTexts();
            person_resetTexts();
            city_resetTexts();
            loadCases();
            loadCities();
            loadPersons();
            loadTests();
        }

        private void casesButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = casesPage;
        }

        private void testsButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = testsPage;
        }

        private void personsButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = personsPage;
        }

        private void citiesButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = citiesPage;
        }

        private void casesPage_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void updateCaseButton_Click(object sender, EventArgs e)
        {
            if (validCase())
            {
                Case c = new Case(
                    Convert.ToInt32(case_id_textBox.Text),
                    Convert.ToInt32(test_id_textBox.Text),
                    Convert.ToInt32(infected_by_textBox.Text),
                    covid_variant_textBox.Text,
                    patient_state_textBox.Text,
                    severity_textBox.Text,
                    Convert.ToBoolean(hospitalized_textBox.Text)
                );

                CasesData.UpdateCase(c);
                case_resetTexts();
                loadCases();
            }
            else
            {
                caseMessageLabel.Text = "Invalid case";
            }
        }

        private void personsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex >= 0)
                return;
            var cells = personsDataGridView.Rows[e.RowIndex].Cells;
            if (cells.Count > 0)
            {
                person_resetTexts();
                person_person_id_textBox.Text = cells[0].Value.ToString();
                person_fullname_textBox.Text = cells[1].Value.ToString();
                person_birth_date_textBox.Text = cells[2].Value.ToString();
                person_comorbidities_textBox.Text = cells[3].Value.ToString();
                person_vaccine_doses_textBox.Text = cells[4].Value.ToString();
            }
        }

        private void citiesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex >= 0)
                return;
            var cells = citiesDataGridView.Rows[e.RowIndex].Cells;
            if (cells.Count > 0)
            {
                city_resetTexts();
                city_city_id_textBox.Text = cells[0].Value.ToString();
                city_city_name_textBox.Text = cells[1].Value.ToString();
                city_country_name_textBox.Text = cells[2].Value.ToString();
            }
        }

        private void testsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex >= 0)
                return;
            var cells = testsDataGridView.Rows[e.RowIndex].Cells;
            if (cells.Count > 0)
            {
                test_resetTexts();
                test_test_id_textBox.Text = cells[0].Value.ToString();
                test_city_id_textBox.Text = cells[1].Value.ToString();
                test_person_id_textBox.Text = cells[2].Value.ToString();
                test_date_textBox.Text = cells[3].Value.ToString();
                positive_textBox.Text = cells[4].Value.ToString();
            }
        }

        private void casesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex >= 0)
                return;
            var cells = casesDataGridView.Rows[e.RowIndex].Cells;
            if (cells.Count > 0)
            {
                case_resetTexts();
                case_id_textBox.Text = cells["case_id"].Value.ToString();
                test_id_textBox.Text = cells["test_id"].Value.ToString();
                infected_by_textBox.Text = cells["infected_by"].Value.ToString();
                ;
                covid_variant_textBox.Text = cells["covid_variant"].Value.ToString();
                ;
                hospitalized_textBox.Text = cells["hospitalized"].Value.ToString();
                ;
                patient_state_textBox.Text = cells["patient_state"].Value.ToString();
                ;
                severity_textBox.Text = cells["severity"].Value.ToString();
            }
        }

        private void loadCases()
        {
            casesDataGridView.Rows.Clear();
            var cases = CasesData.GetCases();
            foreach (var c in cases)
                if (c.PatientState != "recovered")
                {
                    casesDataGridView.Rows.Add(
                        c.CaseId, c.TestId, c.InfectedBy, c.CovidVariant,
                        c.PatientState, c.Severity, c.Hospitalized);
                }
        }

        private void loadTests()
        {
            testsDataGridView.Rows.Clear();
            var tests = TestsData.GetTests();
            foreach (var t in tests)
            {
                testsDataGridView.Rows.Add(t.TestId, t.CityId, t.PersonId,
                                           t.TestDate.ToString("dd/MM/yyyy"), t.Positive);
            }
        }

        private void loadCities()
        {
            citiesDataGridView.Rows.Clear();
            var cities = CitiesData.GetCities();
            foreach (var c in cities)
            {
                citiesDataGridView.Rows.Add(c.CityId, c.CityName, c.CountryName);
            }
        }

        private void loadPersons()
        {
            personsDataGridView.Rows.Clear();
            var persons = PersonsData.GetPersons();
            foreach (var person in persons)
            {
                personsDataGridView.Rows.Add(person.PersonId, person.FullName,
                                             person.BirthDate.ToString("dd/MM/yyyy"),
                                             person.Comorbidities, person.VaccineDoses);
            }
        }

        private void deleteCaseButton_Click(object sender, EventArgs e)
        {
            int case_id = 0;
            if (int.TryParse(case_id_textBox.Text, out case_id))
            {
                Case c = CasesData.GetCase(case_id);
                c.PatientState = "recovered";
                CasesData.UpdateCase(c);
                case_resetTexts();
                loadCases();
            }
        }

        private void caseResetButton_Click(object sender, EventArgs e)
        {
            case_resetTexts();
        }

        private void showAllActiveCasesButton_Click(object sender, EventArgs e)
        {
            case_resetTexts();
            loadCases();
        }

        private void showAllTestsButton_Click(object sender, EventArgs e)
        {
            test_resetTexts();
            loadTests();
        }

        bool validTest()
        {
            int test_id;
            int city_id;
            int person_id;
            DateTime test_date = new DateTime();
            bool positive;

            if (!int.TryParse(test_test_id_textBox.Text, out test_id))
            {
                testMessageLabel.Text = "Invalid test_id";
                return false;
            }

            if (!int.TryParse(test_city_id_textBox.Text, out city_id))
            {
                testMessageLabel.Text = "Invalid city_id";
                return false;
            }

            if (!int.TryParse(test_person_id_textBox.Text, out person_id))
            {
                testMessageLabel.Text = "Invalid person_id";
                return false;
            }

            if (!DateTime.TryParse(test_date_textBox.Text, out test_date))
            {
                testMessageLabel.Text = "Invalid test_date";
                return false;
            }

            if (!Boolean.TryParse(positive_textBox.Text, out positive))
            {
                testMessageLabel.Text = "Invalid positive";
                return false;
            }

            List<Test> tests = TestsData.GetTests();
            foreach (var t in tests)
            {
                if (t.TestId == test_id)
                {
                    testMessageLabel.Text = "test_id already exists";
                    return false;
                }
            }

            List<Person> persons = PersonsData.GetPersons();
            bool found = false;
            foreach (var p in persons)
            {
                if (p.PersonId == person_id)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                testMessageLabel.Text = "person_id not found";
                return false;
            }

            List<City> cities = CitiesData.GetCities();
            found = false;
            foreach (var c in cities)
            {
                if (c.CityId == city_id)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                testMessageLabel.Text = "city_id not found";
                return false;
            }

            return true;
        }

        bool validPerson()
        {
            int person_id;
            string fullname;
            DateTime birth_date = new DateTime();
            int vaccine_doses;

            if (!int.TryParse(person_person_id_textBox.Text, out person_id))
            {
                personMessageLabel.Text = "Invalid person_id";
                return false;
            }

            if (string.IsNullOrEmpty(person_fullname_textBox.Text))
            {
                personMessageLabel.Text = "Invalid fullname";
                return false;
            }
            else
            {
                fullname = person_fullname_textBox.Text;
            }

            if (!DateTime.TryParse(person_birth_date_textBox.Text, out birth_date))
            {
                personMessageLabel.Text = "Invalid birth_date";
                return false;
            }

            if (!int.TryParse(person_vaccine_doses_textBox.Text, out vaccine_doses))
            {
                personMessageLabel.Text = "Invalid vaccine_doses";
                return false;
            }

            List<Person> persons = PersonsData.GetPersons();
            foreach (Person person in persons)
            {
                if (person.PersonId == person_id)
                {
                    personMessageLabel.Text = "person_id already exists";
                    return false;
                }
            }

            if (vaccine_doses < 0)
            {
                personMessageLabel.Text = "invalid vaccine_doses";
                return false;
            }

            return true;
        }

        bool validCity()
        {
            int city_id;
            if (!int.TryParse(city_city_id_textBox.Text, out city_id))
            {
                cityMessageLabel.Text = "Invalid city_id";
                return false;
            }

            List<City> cities = CitiesData.GetCities();
            foreach (City c in cities)
            {
                if (c.CityId == city_id)
                {
                    cityMessageLabel.Text = "city_id already exists";
                    return false;
                }
            }

            if (string.IsNullOrEmpty(city_city_name_textBox.Text))
            {
                cityMessageLabel.Text = "Invalid city_name";
                return false;
            }

            if (string.IsNullOrEmpty(city_country_name_textBox.Text))
            {
                cityMessageLabel.Text = "Invalid country_name";
                return false;
            }

            return true;
        }

        bool validCase()
        {
            var cases = CasesData.GetCases();
            if (!int.TryParse(case_id_textBox.Text, out _))
                return false;
            if (!int.TryParse(test_id_textBox.Text, out _))
                return false;
            if (!int.TryParse(infected_by_textBox.Text, out _))
                return false;
            if (string.IsNullOrEmpty(covid_variant_textBox.Text))
                return false;
            if (string.IsNullOrEmpty(patient_state_textBox.Text))
                return false;
            if (string.IsNullOrEmpty(severity_textBox.Text))
                return false;
            if (!bool.TryParse(hospitalized_textBox.Text, out _))
                return false;

            int infected_by = Convert.ToInt32(infected_by_textBox.Text);
            string covid_variant = covid_variant_textBox.Text;
            string severity = severity_textBox.Text;
            string patient_state = patient_state_textBox.Text;

            if (infected_by == -1)
                return true;

            bool found = false;
            foreach (Case c in cases)
            {
                if (c.CaseId == infected_by && c.InfectedBy != infected_by)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
                return false;

            return true;
        }

        void case_resetTexts()
        {
            caseMessageLabel.Text = "";
            case_id_textBox.Text = "";
            test_id_textBox.Text = "";
            infected_by_textBox.Text = "";
            covid_variant_textBox.Text = "";
            hospitalized_textBox.Text = "";
            patient_state_textBox.Text = "";
            severity_textBox.Text = "";
        }

        void test_resetTexts()
        {
            testMessageLabel.Text = "";

            test_test_id_textBox.Text = "";
            test_city_id_textBox.Text = "";
            test_person_id_textBox.Text = "";
            test_date_textBox.Text = "";
            positive_textBox.Text = "";
        }

        void person_resetTexts()
        {
            personMessageLabel.Text = "";
            person_person_id_textBox.Text = "";
            person_fullname_textBox.Text = "";
            person_birth_date_textBox.Text = "";
            person_comorbidities_textBox.Text = "";
            person_vaccine_doses_textBox.Text = "";
        }

        void city_resetTexts()
        {
            cityMessageLabel.Text = "";

            city_city_id_textBox.Text = "";
            city_city_name_textBox.Text = "";
            city_country_name_textBox.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            person_resetTexts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test_resetTexts();
        }

        private void showAllCitiesButton_Click(object sender, EventArgs e)
        {
            city_resetTexts();
            loadCities();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            city_resetTexts();
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void showAllPersonsButton_Click(object sender, EventArgs e)
        {
            person_resetTexts();
            loadPersons();
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            if (validTest())
            {
                Test t = new Test(
                    Convert.ToInt32(test_test_id_textBox.Text),
                    Convert.ToInt32(test_city_id_textBox.Text),
                    Convert.ToInt32(test_person_id_textBox.Text),
                    Convert.ToDateTime(test_date_textBox.Text),
                    Convert.ToBoolean(positive_textBox.Text)
                );
                TestsData.AddTest(t);
                test_resetTexts();
                loadTests();

                if (t.Positive)
                {
                    List<Case> cases = CasesData.GetCases();
                    int maxCaseId = 0;
                    foreach (var caz in cases)
                    {
                        if (caz.CaseId > maxCaseId)
                        {
                            maxCaseId = caz.CaseId;
                        }
                    }

                    Case c = new Case(
                        maxCaseId + 1,
                        t.TestId,
                        -1,
                        " ",
                        " ",
                        " ",
                        false
                    );
                    CasesData.AddCase(c);
                    case_resetTexts();
                    loadCases();
                }
            }
        }

        private void deleteTestButton_Click(object sender, EventArgs e)
        {
            int test_id = 0;
            if (!int.TryParse(test_test_id_textBox.Text, out test_id))
            {
                testMessageLabel.Text = "Invalid test_id";
                return;
            }

            List<Test> tests = TestsData.GetTests();
            bool found = false;
            foreach (var t in tests)
            {
                if (t.TestId == test_id)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                testMessageLabel.Text = "test_id not found";
                return;
            }

            List<Case> cases = CasesData.GetCases();
            foreach (var c in cases)
            {
                if (c.TestId == test_id)
                {
                    testMessageLabel.Text = "This test cannot be deleted";
                    return;
                }
            }

            TestsData.DeleteTest(test_id);
            test_resetTexts();
            loadTests();
        }

        private void addCityButton_Click(object sender, EventArgs e)
        {
            if (validCity())
            {
                City c = new City(
                    Convert.ToInt32(city_city_id_textBox.Text),
                    city_city_name_textBox.Text,
                    city_country_name_textBox.Text
                );
                CitiesData.AddCity(c);
                city_resetTexts();
                loadCities();
            }
        }

        private void deleteCityButton_Click(object sender, EventArgs e)
        {
            int city_id = 0;
            if (!int.TryParse(city_city_id_textBox.Text, out city_id))
            {
                cityMessageLabel.Text = "Invalid city_id";
                return;
            }

            List<City> cities = CitiesData.GetCities();
            bool found = false;
            foreach (var city in cities)
            {
                if (city.CityId == city_id)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                cityMessageLabel.Text = "city_id not found";
                return;
            }

            List<Test> tests = TestsData.GetTests();
            foreach (var t in tests)
            {
                if (t.CityId == city_id)
                {
                    cityMessageLabel.Text = "This city cannot be deleted";
                    return;
                }
            }

            CitiesData.DeleteCity(city_id);
            city_resetTexts();
            loadCities();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            if (validPerson())
            {
                Person p = new Person(
                    Convert.ToInt32(person_person_id_textBox.Text),
                    person_fullname_textBox.Text,
                    Convert.ToDateTime(person_birth_date_textBox.Text),
                    person_comorbidities_textBox.Text,
                    Convert.ToInt32(person_vaccine_doses_textBox.Text)
                );
                PersonsData.AddPerson(p);
                person_resetTexts();
                loadPersons();
            }
        }

        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            int person_id;

            if (!int.TryParse(person_person_id_textBox.Text, out person_id))
            {
                personMessageLabel.Text = "Invalid person_id";
                return;
            }

            List<Person> persons = PersonsData.GetPersons();
            bool found = false;
            foreach (Person person in persons)
            {
                if (person.PersonId == person_id)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                personMessageLabel.Text = "person_id not found";
                return;
            }

            List<Test> tests = TestsData.GetTests();
            foreach (var t in tests)
            {
                if (t.PersonId == person_id)
                {
                    personMessageLabel.Text = "This person cannot be deleted";
                    return;
                }
            }

            PersonsData.DeletePerson(person_id);
            person_resetTexts();
            loadPersons();
        }

        private void casesPerCityButton_Click(object sender, EventArgs e)
        {
            citiesStatsData.Columns.Clear();
            citiesStatsData.Rows.Clear();
            citiesStatsData.ColumnCount = 2;
            citiesStatsData.Columns[0].HeaderCell.Value = "City name";
            citiesStatsData.Columns[1].HeaderCell.Value = "Number of cases";

            string sql =
                "select city_name, count(case_id) " +
                "from cities_31a_ap cities, cases_31a_ap cases, tests_31a_ap tests " +
                "where cities.city_id = tests.city_id and tests.test_id = cases.test_id " +
                "group by city_name";
            var ds = SqlDbHelper.ExecuteDataSet(
                sql,
                CommandType.Text,
                new OracleParameter()
            );
            foreach (DataRow line in ds.Tables[0].Rows)
            {
                citiesStatsData.Rows.Add(line[0], line[1]);
            }
        }

        private void percentageOfPositiveTestsButton_Click(object sender, EventArgs e)
        {
            citiesStatsData.Columns.Clear();
            citiesStatsData.Rows.Clear();
            citiesStatsData.ColumnCount = 2;
            citiesStatsData.Columns[0].HeaderCell.Value = "City name";
            citiesStatsData.Columns[1].HeaderCell.Value = "Number of tests";

            string sql = "select city_name, count(test_id) " +
                         "from cities_31a_ap cities, tests_31a_ap tests " +
                         "where cities.city_id = tests.city_id " +
                         "group by city_name";
            var ds = SqlDbHelper.ExecuteDataSet(
                sql,
                CommandType.Text,
                new OracleParameter()
            );
            foreach (DataRow line in ds.Tables[0].Rows)
            {
                citiesStatsData.Rows.Add(line[0], line[1]);
            }
        }

        private void hospitalizedPerCityButton_Click(object sender, EventArgs e)
        {
            citiesStatsData.Columns.Clear();
            citiesStatsData.Rows.Clear();
            citiesStatsData.ColumnCount = 2;
            citiesStatsData.Columns[0].HeaderCell.Value = "City name";
            citiesStatsData.Columns[1].HeaderCell.Value = "Number of hospitalized cases";

            string sql =
                "select city_name, count(cases.case_id) from cities_31a_ap cities, tests_31a_ap tests, cases_31a_ap cases where cities.city_id = tests.city_id and tests.test_id = cases.test_id and cases.hospitalized = 1 group by city_name";
            var ds = SqlDbHelper.ExecuteDataSet(
                sql,
                CommandType.Text,
                new OracleParameter()
            );
            foreach (DataRow line in ds.Tables[0].Rows)
            {
                citiesStatsData.Rows.Add(line[0], line[1]);
            }
        }

        private void numberOfVaccinatedPerCityButton_Click(object sender, EventArgs e)
        {
            citiesStatsData.Columns.Clear();
            citiesStatsData.Rows.Clear();
            citiesStatsData.ColumnCount = 2;
            citiesStatsData.Columns[0].HeaderCell.Value = "City name";
            citiesStatsData.Columns[1].HeaderCell.Value = "Number of vaccinated patients";

            string sql =
                "select city_name, (select count(*) from persons_31a_ap persons, tests_31a_ap  tests where tests.city_id = cities.city_id and cities.city_id  = persons.person_id and positive = 1 and vaccine_doses > 0 group by city_name) from cities_31a_ap cities";
            var ds = SqlDbHelper.ExecuteDataSet(
                sql,
                CommandType.Text,
                new OracleParameter()
            );
            foreach (DataRow line in ds.Tables[0].Rows)
            {
                citiesStatsData.Rows.Add(line[0], line[1]);
            }
        }

        private void peopleByDosesButton_Click(object sender, EventArgs e)
        {
            personsDataGrid.Columns.Clear();
            personsDataGrid.Rows.Clear();
            personsDataGrid.ColumnCount = 2;
            personsDataGrid.Columns[0].HeaderCell.Value = "Number of vaccine";
            personsDataGrid.Columns[1].HeaderCell.Value = "Number of persons";

            string sql =
                "select vaccine_doses, count(*) from persons_31a_ap group by vaccine_doses";
            var ds = SqlDbHelper.ExecuteDataSet(
                sql,
                CommandType.Text,
                new OracleParameter()
            );
            foreach (DataRow line in ds.Tables[0].Rows)
            {
                personsDataGrid.Rows.Add(line[0], line[1]);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            personsDataGrid.Columns.Clear();
            personsDataGrid.Rows.Clear();
            personsDataGrid.ColumnCount = 2;
            personsDataGrid.Columns[0].HeaderCell.Value = "Number of doses";
            personsDataGrid.Columns[1].HeaderCell.Value = "Number of cases";

            string sql =
                "select vaccine_doses, count(*) from persons_31a_ap p, tests_31a_ap t where t.person_id = p.person_id and positive = 1 group by vaccine_doses";
            var ds = SqlDbHelper.ExecuteDataSet(
                sql,
                CommandType.Text,
                new OracleParameter()
            );
            foreach (DataRow line in ds.Tables[0].Rows)
            {
                personsDataGrid.Rows.Add(line[0], line[1]);
            }
        }

        private void casesByComorbiditiesButton_Click(object sender, EventArgs e)
        {
            personsDataGrid.Columns.Clear();
            personsDataGrid.Rows.Clear();
            personsDataGrid.ColumnCount = 2;
            personsDataGrid.Columns[0].HeaderCell.Value = "Comorbidity";
            personsDataGrid.Columns[1].HeaderCell.Value = "Number of cases";

            string sql =
                "select comorbidities, count(test_id) from persons_31a_ap p, tests_31a_ap t where t.person_id = p.person_id and positive = 1 group by comorbidities";
            var ds = SqlDbHelper.ExecuteDataSet(
                sql,
                CommandType.Text,
                new OracleParameter()
            );
            foreach (DataRow line in ds.Tables[0].Rows)
            {
                personsDataGrid.Rows.Add(line[0], line[1]);
            }
        }

        private void testsPerMonthButton_Click(object sender, EventArgs e)
        {
            testsDataGrid.Columns.Clear();
            testsDataGrid.Rows.Clear();
            testsDataGrid.ColumnCount = 2;
            testsDataGrid.Columns[0].HeaderCell.Value = "Month of 2021";
            testsDataGrid.Columns[1].HeaderCell.Value = "Number of tests";

            string sql =
                "select to_char(test_date, 'mm') as m, count(*) from tests_31a_ap where to_char(test_date, 'yyyy') = '2021' group by to_char(test_date, 'mm') order by to_char(test_date, 'mm')";
            var ds = SqlDbHelper.ExecuteDataSet(
                sql,
                CommandType.Text,
                new OracleParameter()
            );
            foreach (DataRow line in ds.Tables[0].Rows)
            {
                testsDataGrid.Rows.Add(line[0], line[1]);
            }
        }

        private void casesBySeverityButton_Click(object sender, EventArgs e)
        {
            casesDataGrid.Columns.Clear();
            casesDataGrid.Rows.Clear();
            casesDataGrid.ColumnCount = 2;
            casesDataGrid.Columns[0].HeaderCell.Value = "Severity";
            casesDataGrid.Columns[1].HeaderCell.Value = "Number of cases";

            string sql = "select severity, count(*) from cases_31a_ap group by severity";
            var ds = SqlDbHelper.ExecuteDataSet(
                sql,
                CommandType.Text,
                new OracleParameter()
            );
            foreach (DataRow line in ds.Tables[0].Rows)
            {
                casesDataGrid.Rows.Add(line[0], line[1]);
            }
        }

        private void casesByPatientStateButton_Click(object sender, EventArgs e)
        {
            string sql = "select patient_state, count(*) from cases_31a_ap group by patient_state";

            casesDataGrid.Columns.Clear();
            casesDataGrid.Rows.Clear();
            casesDataGrid.ColumnCount = 2;
            casesDataGrid.Columns[0].HeaderCell.Value = "Patient state";
            casesDataGrid.Columns[1].HeaderCell.Value = "Number of cases";

            var ds = SqlDbHelper.ExecuteDataSet(
                sql,
                CommandType.Text,
                new OracleParameter()
            );
            foreach (DataRow line in ds.Tables[0].Rows)
            {
                casesDataGrid.Rows.Add(line[0], line[1]);
            }
        }

        private void casesByVariantButton_Click(object sender, EventArgs e)
        {
            string sql = "select covid_variant, count(*) from cases_31a_ap group by covid_variant";

            casesDataGrid.Columns.Clear();
            casesDataGrid.Rows.Clear();
            casesDataGrid.ColumnCount = 2;
            casesDataGrid.Columns[0].HeaderCell.Value = "Patient state";
            casesDataGrid.Columns[1].HeaderCell.Value = "Number of cases";

            var ds = SqlDbHelper.ExecuteDataSet(
                sql,
                CommandType.Text,
                new OracleParameter()
            );
            foreach (DataRow line in ds.Tables[0].Rows)
            {
                casesDataGrid.Rows.Add(line[0], line[1]);
            }
        }
    }
}