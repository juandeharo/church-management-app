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
    public partial class frmContributionQuery : Form
    {
        frmDashboard callingForm;

        //Declaring lists
        public BindingList<Contribution> contributions = new BindingList<Contribution>();
        public BindingList<Contribution> loadedContributions = new BindingList<Contribution>();
        public frmContributionQuery(frmDashboard f)
        {
            InitializeComponent();
            callingForm = f;
        }
        private void LoadContributionsFromFile()
        {
            //Create FileStream  object (myFile)w / FileMode OPENORCREATE, w / FileAccess READ
            FileStream inFile = new FileStream("contributions.csv", FileMode.OpenOrCreate, FileAccess.Read);

            //Create StreamReader object(reader)
            StreamReader reader = new StreamReader(inFile);

            //Declare a string array(e.g.fieldValues) to hold all of the values of a single record
            string[] fieldValues;

            //Header - read the header record and ignore it
            string inputStr = reader.ReadLine();

            //Lead read(i.e.read first record) – if your file has a header row then you need 2 initial reads
            inputStr = reader.ReadLine();

            //Loop while record not null
            while (inputStr != null)
            {
                //split the record using delimiter into the fieldValuesarray
                fieldValues = inputStr.Split(',');

                //create an empty domain object
                Contribution c = new Contribution();

                //update each field of the domain object
                c.ContributionNo = Convert.ToInt32(fieldValues[0]);
                c.MemberID = Convert.ToInt32(fieldValues[1]);
                c.ContributionDate = Convert.ToDateTime(fieldValues[2]);
                c.Amount = Convert.ToDouble(fieldValues[3]);
                c.Method = fieldValues[4];
                if (fieldValues[5] != "")
                {
                    c.CheckNo = Convert.ToInt32(fieldValues[5]);
                }
                c.DesignatedFund = fieldValues[6];


                //add this domain object to the list of domain objects
                contributions.Add(c);

                //read next record
                inputStr = reader.ReadLine();
            }

            //End loop

            //Close reader
            reader.Close();

            //Close myFile
            inFile.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Call forms
            LoadContributionsFromFile();
            bindSrcCont.DataSource = contributions;
            dgvContributions.DataSource = bindSrcCont;
            bindNavCont.BindingSource = bindSrcCont;
            txtFund.Text = "";
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


        private void ClearFilter()
        {
            //Resetting the data grid
            dgvContributions.DataSource = bindSrcCont;
        }

        private void btnFilterCont_Click(object sender, EventArgs e)
        {
            //Call the data validation method and show message box for invalid entries
            DataValidation();
            if (DataValidation() == false)
            {
                MessageBox.Show("Please enter valid data types!");
            }

            var filteredContributions =
                from c in contributions
                select c;

            //filter the data if cheked
            if (chkMemberCont.Checked == true)
            {
                filteredContributions = filteredContributions.Where(c => c.MemberID == Convert.ToInt32(txtMemberCont.Text));
            }
            if (chkFund.Checked == true)
            {
                filteredContributions = filteredContributions.Where(c => c.DesignatedFund == txtFund.Text);
            }
            if (chkDate.Checked == true)
            {
                filteredContributions = filteredContributions.Where(c => c.ContributionDate >= mcalDateRangePickerCont.SelectionStart && c.ContributionDate <= mcalDateRangePickerCont.SelectionEnd);
            }
            //sort in ascending order
            if (chkAscendingCont.Checked == true && lstSortCont.SelectedIndex >= 0)
            {
                switch (lstSortCont.SelectedItem.ToString())
                {
                    case "Contribution No":
                        filteredContributions = filteredContributions.OrderBy(c => c.ContributionNo);
                        break;
                    case "Member ID":
                        filteredContributions = filteredContributions.OrderBy(c => c.MemberID);
                        break;
                    case "Contribution Date":
                        filteredContributions = filteredContributions.OrderBy(c => c.ContributionDate);
                        break;
                    case "Amount":
                        filteredContributions = filteredContributions.OrderBy(c => c.Amount);
                        break;
                    case "Method":
                        filteredContributions = filteredContributions.OrderBy(c => c.Method);
                        break;
                    case "Check No":
                        filteredContributions = filteredContributions.OrderBy(c => c.CheckNo);
                        break;
                    case "Designated Fund":
                        filteredContributions = filteredContributions.OrderBy(c => c.DesignatedFund);
                        break;
                }
                //sort in descending order
                if (chkDescendingCont.Checked == true && lstSortCont.SelectedIndex >= 0)
                {
                    switch (lstSortCont.SelectedItem.ToString())
                    {
                        case "Contribution No":
                            filteredContributions = filteredContributions.OrderByDescending(c => c.ContributionNo);
                            break;
                        case "Member ID":
                            filteredContributions = filteredContributions.OrderByDescending(c => c.MemberID);
                            break;
                        case "Contribution Date":
                            filteredContributions = filteredContributions.OrderByDescending(c => c.ContributionDate);
                            break;
                        case "Amount":
                            filteredContributions = filteredContributions.OrderByDescending(c => c.Amount);
                            break;
                        case "Method":
                            filteredContributions = filteredContributions.OrderByDescending(c => c.Method);
                            break;
                        case "Check No":
                            filteredContributions = filteredContributions.OrderByDescending(c => c.CheckNo);
                            break;
                        case "Designated Fund":
                            filteredContributions = filteredContributions.OrderByDescending(c => c.DesignatedFund);
                            break;
                    }
                }
            }
            //instantiating loaded contributions then filtering
                BindingList<Contribution> loadedContributions = new BindingList<Contribution>(filteredContributions.ToList());
                bindSrcCont.DataSource = loadedContributions;         
        }

        private void btnClearCont_Click(object sender, EventArgs e)
        {
            //Clear out contents/selections
            bindSrcCont.DataSource = contributions;
            txtFund.Text = "";
            txtMemberCont.Text = "";
            chkAscendingCont.Checked = false;
            chkDate.Checked = false;
            chkDescendingCont.Checked = false;
            chkFund.Checked = false;
            chkMemberCont.Checked = false;
            mcalDateRangePickerCont.SelectionStart = DateTime.Today;
            mcalDateRangePickerCont.SelectionEnd = DateTime.Today;
        }
        private bool DataValidation()
        {
            //check for valid data
            bool isValid = true;
            if ((txtMemberCont.Text.All(Char.IsLetter)) || (txtFund.Text.All(Char.IsLetter)))
            {
                isValid = false;
            }
            if ((txtMemberCont.Text == "") || (txtFund.Text == ""))
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

