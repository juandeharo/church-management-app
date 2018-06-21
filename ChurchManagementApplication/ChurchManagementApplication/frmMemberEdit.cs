using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChurchManagementApplication
{
    public partial class frmMemberEdit : Form
    {
        frmDashboard callingform;


        //Fields
        int rowNum;
        int rowNum1;
        int pos;
        int pos1;
        int posNext;
        int posPrev;

        //Binding List
        //public BindingList<Member> member = new BindingList<Member>();
        //public BindingList<Contributions> contribution = new BindingList<Contributions>();
        public List<Member> RemoveMembers = new List<Member>();

        public frmMemberEdit(frmDashboard f)
        {
            InitializeComponent();
            callingform = f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadMembersFromFile();
            BindMemberListToDataGrid();

            dataGridView1.CurrentCell = null;

            rowNum = dataGridView1.CurrentCellAddress.Y;
            pos = rowNum;
            posNext = rowNum + 1;
            posPrev = rowNum - 1;

            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "";

            dtpBirthDate.Value = new DateTime(2000, 1, 1);
            dtpMembershipDate.Value = new DateTime(2000, 1, 1);

            dtpMembershipDate.Format = DateTimePickerFormat.Custom;
            dtpMembershipDate.CustomFormat = "";




            dtpBeginDate.Value = new DateTime(2000, 1, 1);
            dtpLastDate.Value = new DateTime(2000, 1, 1);
            ChangeFormResolution();
        }
        private void ChangeFormResolution()
        {
            int formWidth = 750;
            int formHeigth = 580;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Size = new System.Drawing.Size(formWidth, formHeigth);
            this.CenterToScreen();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            rowNum = dataGridView1.CurrentCellAddress.Y;
            pos = rowNum;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (Member aMember in callingform.member)
                {

                    txtMemberID.Text = "";
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    cmbBoxTitle.Text = "";
                    cmbBoxGender.Text = "";
                    cmbMaritalStatus.Text = "";
                    txtAddress.Text = "";
                    txtCity.Text = "";
                    cmbState.Text = "";
                    txtZip.Text = "";
                    txtPhoneNumber.Text = "";
                    txtEmail.Text = "";
                    cmbMemberType.Text = "";





                    txtMemberID.Text += callingform.member[pos].MemberID;
                    txtLastName.Text += callingform.member[pos].LastName;
                    txtFirstName.Text += callingform.member[pos].FirstName;
                    cmbBoxTitle.Text += callingform.member[pos].Honorific;
                    cmbBoxGender.Text += callingform.member[pos].Gender;
                    dtpBirthDate.Value = callingform.member[pos].BirthDate;
                    cmbMaritalStatus.Text += callingform.member[pos].MaritalStatus;
                    txtAddress.Text += callingform.member[pos].Address;
                    txtCity.Text += callingform.member[pos].City;
                    cmbState.Text += callingform.member[pos].State;
                    txtZip.Text += callingform.member[pos].Zip;
                    if (callingform.member[pos].Phone != null)
                    {
                        txtPhoneNumber.Text = Convert.ToString(callingform.member[pos].Phone);
                    }
                    if (callingform.member[pos].Email != null)
                    {
                        txtEmail.Text += callingform.member[pos].Email;
                    }

                    cmbMemberType.Text += callingform.member[pos].MemberType;
                    if (callingform.member[pos].MembershipDate.Year > 1800)
                    {
                        dtpMembershipDate.Value = callingform.member[pos].MembershipDate;
                    }
                   
                    dtpBeginDate.Value = callingform.member[pos].AttendanceBeginDate;
                    dtpLastDate.Value = callingform.member[pos].AttendanceLastDate;



                }


            }
            else
            {
                MessageBox.Show("Please Select a Member!");
            }
        }
    
        private void btnNext_Click(object sender, EventArgs e)
        {
            rowNum = dataGridView1.CurrentCellAddress.Y;
            pos = rowNum;
            posNext = rowNum + 1;

            if (posNext > dataGridView1.Rows.Count - 1)
            {
                 MessageBox.Show("End of List!");
            }
            else
            {
                foreach (Member aMember in callingform.member)
                {
                    if (aMember != null)
                    {
                        txtMemberID.Text = "";
                        txtLastName.Text = "";
                        txtFirstName.Text = "";
                        cmbBoxTitle.Text = "";
                        cmbBoxGender.Text = "";
                        //dtpBirthDate.Text = "";
                        cmbMaritalStatus.Text = "";
                        txtAddress.Text = "";
                        txtCity.Text = "";
                        cmbState.Text = "";
                        txtZip.Text = "";
                        txtPhoneNumber.Text = "";
                        txtEmail.Text = "";
                        cmbMemberType.Text = "";
                        //dtpMembershipDate.Text = "";
                        //dtpBeginDate.Text = "";
                        //dtpLastDate.Text = "";



                        txtMemberID.Text += callingform.member[posNext].MemberID;
                        txtLastName.Text += callingform.member[posNext].LastName;
                        txtFirstName.Text += callingform.member[posNext].FirstName;
                        cmbBoxTitle.Text += callingform.member[posNext].Honorific;
                        cmbBoxGender.Text += callingform.member[posNext].Gender;
                        if (dtpBirthDate.Value != null)
                        {
                            dtpBirthDate.Value = callingform.member[posNext].BirthDate;
                        }
                        cmbMaritalStatus.Text += callingform.member[posNext].MaritalStatus;
                        txtAddress.Text += callingform.member[posNext].Address;
                        txtCity.Text += callingform.member[posNext].City;
                        cmbState.Text += callingform.member[posNext].State;
                        txtZip.Text += callingform.member[posNext].Zip;
                        txtPhoneNumber.Text += callingform.member[posNext].Phone;
                        txtEmail.Text += callingform.member[posNext].Email;
                        cmbMemberType.Text += callingform.member[posNext].MemberType;

                        
                        if (callingform.member[posNext].MembershipDate.Year >1800)
                        {
                            dtpMembershipDate.Value = callingform.member[posNext].MembershipDate;
                        }
                        else
                        {
                            dtpMembershipDate.Value = new DateTime(2000, 1, 1);
                             
                        }
                        
                        dtpBeginDate.Value = callingform.member[posNext].AttendanceBeginDate;
                        dtpLastDate.Value = callingform.member[posNext].AttendanceLastDate;

                    }

                    else
                    {
                        MessageBox.Show("End of List!");
                    }

                    dataGridView1.Rows[posNext].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[posNext].Cells[0];
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtMemberID.Text == "")
            {
                MessageBox.Show("Error! Please Select a Current Member!");
            }
            else
            {
                for (int i = 1; i < callingform.member.Count(); i++)
                {

                    if (callingform.member[i].MemberID == Convert.ToInt32(txtMemberID.Text))
                    {

                        callingform.member[i].LastName = txtLastName.Text;
                        callingform.member[i].FirstName = txtFirstName.Text;
                        callingform.member[i].Honorific = cmbBoxTitle.Text;
                        callingform.member[i].Gender = cmbBoxGender.Text;
                        callingform.member[i].BirthDate = dtpBirthDate.Value;
                        callingform.member[i].MaritalStatus = cmbMaritalStatus.Text;
                        callingform.member[i].Address = txtAddress.Text;
                        callingform.member[i].City = txtCity.Text;
                        callingform.member[i].State = cmbState.Text;
                        callingform.member[i].Zip = Convert.ToInt32(txtZip.Text);
                        if (txtPhoneNumber.Text != "")
                        {
                            callingform.member[i].Phone = Convert.ToString(txtPhoneNumber.Text);
                        }
                        if (txtEmail.Text != "")
                        {
                            callingform.member[i].Email = txtEmail.Text;
                        }
                        callingform.member[i].MemberType = cmbMemberType.Text;
                        if (dtpMembershipDate.Value != null)
                        {
                            callingform.member[i].MembershipDate = dtpMembershipDate.Value;
                        }
                        callingform.member[i].AttendanceBeginDate = dtpBeginDate.Value;
                        callingform.member[i].AttendanceLastDate = dtpLastDate.Value;

                        MessageBox.Show("Member " + callingform.member[i].MemberID + " Successfully Updated!");


                    }
                }
            }

                SaveToFile();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Member newMember = new Member();


            if(newMember.MemberID == Convert.ToInt32(txtMemberID.Text))
            {
                MessageBox.Show("That Member Already Exists!");
            }
            else
            {
                newMember.MemberID = Convert.ToInt32(txtMemberID.Text);
                newMember.LastName = txtLastName.Text;
                newMember.FirstName = txtFirstName.Text;
                newMember.Honorific = cmbBoxTitle.Text;
                newMember.Gender = cmbBoxGender.Text;
                newMember.BirthDate = dtpBirthDate.Value;
                newMember.MaritalStatus = cmbMaritalStatus.Text;
                newMember.Address = txtAddress.Text;
                newMember.City = txtCity.Text;
                newMember.State = cmbState.Text;
                newMember.Zip = Convert.ToInt32(txtZip.Text);
                if (txtPhoneNumber.Text != "")
                {
                    newMember.Phone = Convert.ToString(txtPhoneNumber.Text);
                }
                if (txtEmail.Text != "")
                {
                    newMember.Email = txtEmail.Text;
                }
                newMember.MemberType = cmbMemberType.Text;
                if (dtpMembershipDate.Value != null)
                {
                    newMember.MembershipDate = dtpMembershipDate.Value;
                }
                newMember.AttendanceBeginDate = dtpBeginDate.Value;
                newMember.AttendanceLastDate = dtpLastDate.Value;

                //Add to list
                callingform.member.Add(newMember);
                MessageBox.Show("Member " + newMember.MemberID + " Successfully Added!");

                SaveToFile();
            }

        }

        private void loadMembersFromFile()
        {
            //Create FileStream Object (Members)
            //FileStream inFile = new FileStream("members.csv", FileMode.OpenOrCreate, FileAccess.ReadWrite);


            ////Create StreamReader object(reader)
            //StreamReader reader = new StreamReader(inFile);

            ////Declare a string array (fieldValues) to hold all of the values of a single record
            //string[] fieldValues;

            ////Header - read the header record and ignore it
            //string inputStr = reader.ReadLine();
            //inputStr = reader.ReadLine();

            ////Loop while record not null
            //while (inputStr != null)
            //{
            //    //split the record using delimiter into the fieldValuesArray
            //    fieldValues = inputStr.Split(',');

            //    //create an empty domain object
            //    Member aMember = new Member();

            //    //update each field of the domain object
            //    aMember.MemberID = Convert.ToInt32(fieldValues[0]);
            //    aMember.LastName = fieldValues[1];
            //    aMember.FirstName = fieldValues[2];
            //    aMember.Honorific = fieldValues[3];
            //    aMember.Gender = fieldValues[4];
            //    aMember.BirthDate = Convert.ToDateTime(fieldValues[5]);
            //    aMember.MaritalStatus = fieldValues[6];
            //    aMember.Address = fieldValues[7];
            //    aMember.City = fieldValues[8];
            //    aMember.State = fieldValues[9];
            //    aMember.Zip = Convert.ToInt32(fieldValues[10]);
            //    if (fieldValues[11] != "")
            //    {
            //        aMember.Phone = Convert.ToString(fieldValues[11]);
            //    }

            //    if (fieldValues[12] != "")
            //    {
            //        aMember.Email = fieldValues[12];
            //    }
            //    aMember.MemberType = fieldValues[13];

            //    if (fieldValues[14] != "")
            //    {
            //        aMember.MembershipDate = Convert.ToDateTime(fieldValues[14]);
            //    }
            //    aMember.AttendanceBeginDate = Convert.ToDateTime(fieldValues[15]);
            //    aMember.AttendanceLastDate = Convert.ToDateTime(fieldValues[16]);

            //    //add this domain object ot the list of domain objects
            //    callingform.member.Add(aMember);

            //    //read next record
            //    inputStr = reader.ReadLine();
            ////}


        }


  
        private void BindMemberListToDataGrid()
        {
            //set the data source for the bindingsource
            bindMemberInfo.DataSource = callingform.member;

            //set the data source for the data grid
            dataGridView1.DataSource = bindMemberInfo;

            //select full row
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        private void SaveToFile()
        {
            FileStream outFile = new FileStream("members.csv", FileMode.Create, FileAccess.Write);

            string DELIM = ",";
            string outputStr = "";

            StreamWriter writer = new StreamWriter(outFile);


            writer.WriteLine(outputStr);


            foreach (Member aMember in callingform.member)
            {


                outputStr = aMember.MemberID + DELIM + aMember.LastName + DELIM +
                    aMember.FirstName + DELIM + aMember.Honorific + DELIM + aMember.Gender +
                    DELIM + aMember.BirthDate + DELIM + aMember.MaritalStatus + DELIM + aMember.Address
                    + DELIM + aMember.City + DELIM + aMember.State + DELIM + aMember.Zip + DELIM +
                    aMember.Phone + DELIM + aMember.Email + DELIM + aMember.MemberType + DELIM +
                    aMember.MembershipDate + DELIM + aMember.AttendanceBeginDate + DELIM + aMember.AttendanceLastDate;

                writer.WriteLine(outputStr);

            }

            writer.Close();
            outFile.Close();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            rowNum = dataGridView1.CurrentCellAddress.Y;
            pos = rowNum;
            posPrev = rowNum - 1;

            if (posPrev == -1)
            {
                MessageBox.Show("Beginning of List!");
            }
            else
            {


                foreach (Member aMember in callingform.member)
                {
                    if (aMember != null)
                    {
                        txtMemberID.Text = "";
                        txtLastName.Text = "";
                        txtFirstName.Text = "";
                        cmbBoxTitle.Text = "";
                        cmbBoxGender.Text = "";
                        //dtpBirthDate.Text = "";
                        cmbMaritalStatus.Text = "";
                        txtAddress.Text = "";
                        txtCity.Text = "";
                        cmbState.Text = "";
                        txtZip.Text = "";
                        txtPhoneNumber.Text = "";
                        txtEmail.Text = "";
                        cmbMemberType.Text = "";
                        //dtpMembershipDate.Text = "";
                        //dtpBeginDate.Text = "";
                        //dtpLastDate.Text = "";



                        txtMemberID.Text += callingform.member[posPrev].MemberID;
                        txtLastName.Text += callingform.member[posPrev].LastName;
                        txtFirstName.Text += callingform.member[posPrev].FirstName;
                        cmbBoxTitle.Text += callingform.member[posPrev].Honorific;
                        cmbBoxGender.Text += callingform.member[posPrev].Gender;
                        dtpBirthDate.Value = callingform.member[posPrev].BirthDate;
                        cmbMaritalStatus.Text += callingform.member[posPrev].MaritalStatus;
                        txtAddress.Text += callingform.member[posPrev].Address;
                        txtCity.Text += callingform.member[posPrev].City;
                        cmbState.Text += callingform.member[posPrev].State;
                        txtZip.Text += callingform.member[posPrev].Zip;
                        txtPhoneNumber.Text += callingform.member[posPrev].Phone;

                        txtEmail.Text += callingform.member[posPrev].Email;
                        cmbMemberType.Text += callingform.member[posPrev].MemberType;
                        if (callingform.member[posPrev].MembershipDate.Year > 1800)
                        {
                            dtpMembershipDate.Value = callingform.member[posPrev].MembershipDate;
                        }
                        else
                        {
                            dtpMembershipDate.Value = new DateTime(2000, 1, 1);


                            dtpBeginDate.Value = callingform.member[posPrev].AttendanceBeginDate;
                            dtpLastDate.Value = callingform.member[posPrev].AttendanceLastDate;

                        }


                        dataGridView1.Rows[posPrev].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[posPrev].Cells[0];
                    }
                }
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            int firstRow = dataGridView1.Rows.GetFirstRow(0);
            dataGridView1.ClearSelection();

            dataGridView1.Rows[firstRow].Selected = true;

            //dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
            dataGridView1.Focus();

            foreach (Member aMember in callingform.member)
            {
                if (aMember != null)
                {
                    txtMemberID.Text = "";
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    cmbBoxTitle.Text = "";
                    cmbBoxGender.Text = "";
                    //dtpBirthDate.Text = "";
                    cmbMaritalStatus.Text = "";
                    txtAddress.Text = "";
                    txtCity.Text = "";
                    cmbState.Text = "";
                    txtZip.Text = "";
                    txtPhoneNumber.Text = "";
                    txtEmail.Text = "";
                    cmbMemberType.Text = "";
                    //dtpMembershipDate.Text = "";
                    //dtpBeginDate.Text = "";
                    //dtpLastDate.Text = "";



                    txtMemberID.Text += callingform.member[firstRow].MemberID;
                    txtLastName.Text += callingform.member[firstRow].LastName;
                    txtFirstName.Text += callingform.member[firstRow].FirstName;
                    cmbBoxTitle.Text += callingform.member[firstRow].Honorific;
                    cmbBoxGender.Text += callingform.member[firstRow].Gender;
                    dtpBirthDate.Value = callingform.member[firstRow].BirthDate;
                    cmbMaritalStatus.Text += callingform.member[firstRow].MaritalStatus;
                    txtAddress.Text += callingform.member[firstRow].Address;
                    txtCity.Text += callingform.member[firstRow].City;
                    cmbState.Text += callingform.member[firstRow].State;
                    txtZip.Text += callingform.member[firstRow].Zip;
                    txtPhoneNumber.Text += callingform.member[firstRow].Phone;
                    txtEmail.Text += callingform.member[firstRow].Email;
                    cmbMemberType.Text += callingform.member[firstRow].MemberType;
                    dtpMembershipDate.Value = callingform.member[firstRow].MembershipDate;
                    dtpBeginDate.Value = callingform.member[firstRow].AttendanceBeginDate;
                    dtpLastDate.Value = callingform.member[firstRow].AttendanceLastDate;
                }
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            int lastRow = dataGridView1.Rows.GetLastRow(0);
            dataGridView1.ClearSelection();

            dataGridView1.Rows[lastRow].Selected = true;
            dataGridView1.Focus();

            foreach (Member aMember in callingform.member)
            {
                if (aMember != null)
                {
                    txtMemberID.Text = "";
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    cmbBoxTitle.Text = "";
                    cmbBoxGender.Text = "";
                    //dtpBirthDate.Text = "";
                    cmbMaritalStatus.Text = "";
                    txtAddress.Text = "";
                    txtCity.Text = "";
                    cmbState.Text = "";
                    txtZip.Text = "";
                    txtPhoneNumber.Text = "";
                    txtEmail.Text = "";
                    cmbMemberType.Text = "";
                    //dtpMembershipDate.Text = "";
                    //dtpBeginDate.Text = "";
                    //dtpLastDate.Text = "";



                    txtMemberID.Text += callingform.member[lastRow].MemberID;
                    txtLastName.Text += callingform.member[lastRow].LastName;
                    txtFirstName.Text += callingform.member[lastRow].FirstName;
                    cmbBoxTitle.Text += callingform.member[lastRow].Honorific;
                    cmbBoxGender.Text += callingform.member[lastRow].Gender;
                    dtpBirthDate.Value = callingform.member[lastRow].BirthDate;
                    cmbMaritalStatus.Text += callingform.member[lastRow].MaritalStatus;
                    txtAddress.Text += callingform.member[lastRow].Address;
                    txtCity.Text += callingform.member[lastRow].City;
                    cmbState.Text += callingform.member[lastRow].State;
                    txtZip.Text += callingform.member[lastRow].Zip;
                    txtPhoneNumber.Text += callingform.member[lastRow].Phone;
                    txtEmail.Text += callingform.member[lastRow].Email;
                    cmbMemberType.Text += callingform.member[lastRow].MemberType;
                    dtpMembershipDate.Value = callingform.member[lastRow].MembershipDate;
                    dtpBeginDate.Value = callingform.member[lastRow].AttendanceBeginDate;
                    dtpLastDate.Value = callingform.member[lastRow].AttendanceLastDate;
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMemberID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            cmbBoxTitle.Text = "";
            cmbBoxGender.Text = "";
            //dtpBirthDate.Text = "";
            cmbMaritalStatus.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            cmbState.Text = "";
            txtZip.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            cmbMemberType.Text = "";

            dataGridView1.ClearSelection(); 
        }
    }
}
