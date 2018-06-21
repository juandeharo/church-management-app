using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //need for system processing

namespace ChurchManagementApplication
{
    public partial class frmMemberQuery : Form
    {
        frmDashboard callingForm;

        //Declare lists
        public BindingList<Member> members = new BindingList<Member>();
        public BindingList<Member> loadedmembers = new BindingList<Member>();
        public frmMemberQuery(frmDashboard f)
        {
            InitializeComponent();
            callingForm = f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Call forms
            LoadMemberFromFile();
            bindSrcMember.DataSource = members;
            dgvMembers.DataSource = bindSrcMember;
            bindNavMember.BindingSource = bindSrcMember;
            LoadTestData();
            ChangeFormResolution();
        }
        private void ChangeFormResolution()
        {
            int formWidth = 1250;
            int formHeigth = 750;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Size = new System.Drawing.Size(formWidth, formHeigth);
            this.CenterToScreen();
        }

        private void LoadTestData()
        {
            //Enter in preloaded data
            txtLastName.Text = "Floyd";
            txtMaritalStatus.Text = "Married";
            txtMemberType.Text = "Attender";
            txtAgeClassificattion.Text = "Young Teens";
        }
        private void LoadMemberFromFile()
        {
            //////Create FileStream  object (myFile)w / FileMode OPENORCREATE, w / FileAccess READ
            ////FileStream inFile = new FileStream("members.csv", FileMode.OpenOrCreate, FileAccess.Read);

            ////Create StreamReader object(reader)
            //StreamReader reader = new StreamReader(inFile);

            ////Declare a string array(e.g.fieldValues) to hold all of the values of a single record
            //string[] fieldValues;

            ////Header - read the header record and ignore it
            //string inputStr = reader.ReadLine();

            ////Lead read(i.e.read first record) – if your file has a header row then you need 2 initial reads
            //inputStr = reader.ReadLine();

            ////Loop while record not null
            //while (inputStr != null)
            //{
            //    //split the record using delimiter into the fieldValuesarray
            //    fieldValues = inputStr.Split(',');

            //    //create an empty domain object
            //    Member m = new Member();

            //    //update each field of the domain object
            //    m.MemberID = Convert.ToInt32(fieldValues[0]);
            //    m.LastName = fieldValues[1];
            //    m.FirstName = fieldValues[2];
            //    m.Honorific = fieldValues[3];
            //    m.Gender = fieldValues[4];
            //    m.BirthDate = Convert.ToDateTime(fieldValues[5]);
            //    m.MaritalStatus = fieldValues[6];
            //    m.Address = fieldValues[7];
            //    m.City = fieldValues[8];
            //    m.State = fieldValues[9];
            //    m.Zip = Convert.ToInt32(fieldValues[10]);
            //    m.Phone = fieldValues[11];
            //    m.Email = fieldValues[12];
            //    m.MemberType = fieldValues[13];
            //    if (fieldValues[14] != "")
            //    {
            //        m.MembershipDate = Convert.ToDateTime(fieldValues[14]);
            //    }
            //    m.AttendanceBeginDate = Convert.ToDateTime(fieldValues[15]);
            //    m.AttendanceLastDate = Convert.ToDateTime(fieldValues[16]);

            //    //add this domain object to the list of domain objects
            //    members.Add(m);

            //    //read next record
            //    inputStr = reader.ReadLine();
            //}

            //End loop
            foreach (Member aMember in callingForm.member)
            {
                members.Add(aMember);

            }
            ////Close reader
            //reader.Close();

            ////Close myFile
            //inFile.Close();
        }
        private void ClearFilter()
        {
            //Resetting the data grid view
            dgvMembers.DataSource = bindSrcMember;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //Call data validation and Show message for invalid data
            dataValidation();
            if (dataValidation() == false)
            {
                MessageBox.Show("Please input valid data types!");
            }

            var filteredMembers =
                from m in members
                select m;

            //Filter data if it is checked
            if (chkLastName.Checked == true)
            {
                filteredMembers = filteredMembers.Where(m => m.LastName == txtLastName.Text);
            }
            if (chkMaritalStatus.Checked == true)
            {
                filteredMembers = filteredMembers.Where(m => m.MaritalStatus == txtMaritalStatus.Text);
            }
            if (chkMemberType.Checked == true)
            {
                filteredMembers = filteredMembers.Where(m => m.MemberType == txtMemberType.Text);
            }

            //Calculate Age classification
            if (chkAgeClassification.Checked == true)
            {
                switch (txtAgeClassificattion.Text)
                {
                    case "Infant":
                        filteredMembers = filteredMembers.Where(m => m.BirthDate > DateTime.Today.AddYears(-1));
                        break;
                    case "Toddler":
                        filteredMembers = filteredMembers.Where(m => m.BirthDate >= DateTime.Today.AddYears(-3) && m.BirthDate < DateTime.Today.AddYears(-1));
                        break;
                    case "Preschooler":
                        filteredMembers = filteredMembers.Where(m => m.BirthDate >= DateTime.Today.AddYears(-6) && m.BirthDate < DateTime.Today.AddYears(-3));
                        break;
                    case "Middle Childhood":
                        filteredMembers = filteredMembers.Where(m => m.BirthDate >= DateTime.Today.AddYears(-12) && m.BirthDate < DateTime.Today.AddYears(-6));
                        break;
                    case "Young Teens":
                        filteredMembers = filteredMembers.Where(m => m.BirthDate >= DateTime.Today.AddYears(-15) && m.BirthDate < DateTime.Today.AddYears(-12));
                        break;
                    case "Teenagers":
                        filteredMembers = filteredMembers.Where(m => m.BirthDate >= DateTime.Today.AddYears(-18) && m.BirthDate < DateTime.Today.AddYears(-15));
                        break;
                    case "Young Adults":
                        filteredMembers = filteredMembers.Where(m => m.BirthDate >= DateTime.Today.AddYears(-25) && m.BirthDate < DateTime.Today.AddYears(-18));
                        break;
                    case "Adults":
                        filteredMembers = filteredMembers.Where(m => m.BirthDate >= DateTime.Today.AddYears(-65) && m.BirthDate < DateTime.Today.AddYears(-25));
                        break;
                    case "Seniors":
                        filteredMembers = filteredMembers.Where(m => m.BirthDate >= DateTime.Today.AddYears(-65));
                        break;
                    case "Unknown":
                        filteredMembers = filteredMembers.Where(m => m.BirthDate == new DateTime(1, 1, 1));
                        break;
                }
            }
            //Sort data based off of selection--Ascending
            if (chkAttendDate.Checked == true)
            {
                filteredMembers = filteredMembers.Where(m => m.AttendanceBeginDate >= mcalDateRangePicker.SelectionStart && m.AttendanceBeginDate <= mcalDateRangePicker.SelectionEnd);
            }
            if (chkAscending.Checked == true && lstSortMember.SelectedIndex >= 0)
            {
                switch (lstSortMember.SelectedItem.ToString())
                {
                    case "MemberID":
                        filteredMembers = filteredMembers.OrderBy(m => m.MemberID);
                        break;
                    case "Last Name":
                        filteredMembers = filteredMembers.OrderBy(m => m.LastName);
                        break;
                    case "First Name":
                        filteredMembers = filteredMembers.OrderBy(m => m.FirstName);
                        break;
                    case "Honorofic":
                        filteredMembers = filteredMembers.OrderBy(m => m.Honorific);
                        break;
                    case "Gender":
                        filteredMembers = filteredMembers.OrderBy(m => m.Gender);
                        break;
                    case "Birth Date":
                        filteredMembers = filteredMembers.OrderBy(m => m.BirthDate);
                        break;
                    case "Marital Status":
                        filteredMembers = filteredMembers.OrderBy(m => m.MaritalStatus);
                        break;
                    case "Address":
                        filteredMembers = filteredMembers.OrderBy(m => m.Address);
                        break;
                    case "City":
                        filteredMembers = filteredMembers.OrderBy(m => m.City);
                        break;
                    case "State":
                        filteredMembers = filteredMembers.OrderBy(m => m.State);
                        break;
                    case "Zip":
                        filteredMembers = filteredMembers.OrderBy(m => m.Zip);
                        break;
                    case "Phone":
                        filteredMembers = filteredMembers.OrderBy(m => m.Phone);
                        break;
                    case "Member Type":
                        filteredMembers = filteredMembers.OrderBy(m => m.Phone);
                        break;
                    case "Membership Date":
                        filteredMembers = filteredMembers.OrderBy(m => m.Phone);
                        break;
                    case "Attendance Begin Date":
                        filteredMembers = filteredMembers.OrderBy(m => m.Phone);
                        break;
                    case "Attendance Last Date":
                        filteredMembers = filteredMembers.OrderBy(m => m.Phone);
                        break;
                }
            }

            //Sort data in descending order if selected
            if (chkDescending.Checked == true && lstSortMember.SelectedIndex >= 0)
            {
                switch (lstSortMember.SelectedItem.ToString())
                {
                    case "MemberID":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.MemberID);
                        break;
                    case "Last Name":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.LastName);
                        break;
                    case "First Name":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.FirstName);
                        break;
                    case "Honorofic":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.Honorific);
                        break;
                    case "Gender":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.Gender);
                        break;
                    case "Birth Date":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.BirthDate);
                        break;
                    case "Marital Status":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.MaritalStatus);
                        break;
                    case "Address":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.Address);
                        break;
                    case "City":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.City);
                        break;
                    case "State":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.State);
                        break;
                    case "Zip":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.Zip);
                        break;
                    case "Phone":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.Phone);
                        break;
                    case "Member Type":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.Phone);
                        break;
                    case "Membership Date":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.Phone);
                        break;
                    case "Attendance Begin Date":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.Phone);
                        break;
                    case "Attendance Last Date":
                        filteredMembers = filteredMembers.OrderByDescending(m => m.Phone);
                        break;
                }
            }
            //Instantiating loaded members and filtering
            BindingList<Member> loadedMember = new BindingList<Member>(filteredMembers.ToList());
            bindSrcMember.DataSource = loadedMember;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the form
            bindSrcMember.DataSource = members;
            txtLastName.Text = "";
            txtMaritalStatus.Text = "";
            txtMemberType.Text = "";
            txtAgeClassificattion.Text = "";
            chkAgeClassification.Checked = false;
            chkAscending.Checked = false;
            chkAttendDate.Checked = false;
            chkDescending.Checked = false;
            chkLastName.Checked = false;
            chkMaritalStatus.Checked = false;
            chkMemberType.Checked = false;
            mcalDateRangePicker.SelectionStart = DateTime.Today;
            mcalDateRangePicker.SelectionEnd = DateTime.Today;
            lstSortMember.SelectedItem = null;
        }
        private bool dataValidation()
        {
            //Check that entered data is valid not including numbers
            bool isValid = true;
            if ((txtAgeClassificattion.Text.All(Char.IsNumber)) || (txtLastName.Text.All(Char.IsNumber)) || (txtMaritalStatus.Text.All(Char.IsNumber)) ||
                (txtMemberType.Text.All(Char.IsNumber)))
            {
                isValid = false;
            }

            //Check that entered data is valid and doesn't include empty textboxes
            if ((txtAgeClassificattion.Text == "") || (txtLastName.Text == "") || (txtMaritalStatus.Text == "") ||
                (txtMemberType.Text == ""))
            {
                isValid = false;
            }
            return isValid;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}