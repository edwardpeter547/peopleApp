namespace Contacts
{
    public partial class Form1 : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        public Form1()
        {
            InitializeComponent();
            LoadPeople();
        }

        private void LoadPeople()
        {
            people = AccessSqliteData.LoadPeople();
            WriteDataListBox();
        }

        private void WriteDataListBox()
        {
            lbperson.DataSource = null;
            lbperson.DataSource = people;
            lbperson.DisplayMember = "FullName";
        }

        private void InsertPerson(PersonModel person)
        {
            AccessSqliteData.InsertPerson(person);
            LoadPeople();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string family = txtfamily.Text;

            PersonModel person = new PersonModel();
            person.Name = name;
            person.Family = family;

            AccessSqliteData.InsertPerson(person);
            LoadPeople();

        }
    }
}
