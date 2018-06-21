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
    public partial class frmContributionEdit : Form
    {
        frmDashboard callingForm;
        
        //Fields
        int rowNum;
        int rowNum1;
        int pos;
        int pos1;
        int posNext;
        int posPrev;

        //Lists
        //public BindingList<Contributions> contribution = new BindingList<Contributions>();
        public List<Contribution> RemoveMembers = new List<Contribution>();

        public frmContributionEdit(frmDashboard f)
        {
            InitializeComponent();
            callingForm = f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadContributionsFromFile();
            BindContributionListToDataGrid();

            dataGridView1.CurrentCell = null;

            rowNum = dataGridView1.CurrentCellAddress.Y;
            pos = rowNum;
            posNext = rowNum + 1;
            posPrev = rowNum - 1;

            dtpContributionDate.Value = new DateTime(2000, 1, 1);
            ChangeFormResolution();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            rowNum = dataGridView1.CurrentCellAddress.Y;
            pos = rowNum;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (Contribution aContribution in callingForm.contributions)
                {
                    txtContributionNo.Text = "";
                    txtMemberID.Text = "";
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    txtAmount.Text = "";
                    txtMethod.Text = "";
                    txtCheckNo.Text = "";
                    cmbDesignatedFund.Text = "";



                    txtContributionNo.Text += callingForm.contributions[pos].ContributionNo;
                    txtMemberID.Text += callingForm.contributions[pos].MemberID;
                    //txtLastName.Text += member[pos].LastName;
                    //txtFirstName.Text += member[pos].FirstName;
                    dtpContributionDate.Value = callingForm.contributions[pos].ContributionDate;
                    txtAmount.Text += callingForm.contributions[pos].Amount;
                    txtMethod.Text += callingForm.contributions[pos].Method;
                    txtCheckNo.Text = callingForm.contributions[pos].CheckNo.ToString();
                    cmbDesignatedFund.Text += callingForm.contributions[pos].DesignatedFund;
                }
            }
            else
            {
                MessageBox.Show("Please select a contribution!", "Error");
            }


        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text == "")
            {
                MessageBox.Show("Error! Please Select a Member's Contribution!");
            }
            else
            {
                for (int i = 1; i < callingForm.contributions.Count(); i++)
                {

                    if (callingForm.contributions[i].ContributionNo == Convert.ToInt32(txtContributionNo.Text))
                    {
                        callingForm.contributions[i].MemberID = Convert.ToInt32(txtMemberID.Text);
                        //member[i].LastName = txtLastName.Text;
                        //member[i].FirstName = txtFirstName.Text;
                        callingForm.contributions[i].ContributionDate = dtpContributionDate.Value;
                        callingForm.contributions[i].Amount = Convert.ToDouble(txtAmount.Text);
                        callingForm.contributions[i].Method = txtMethod.Text;
                        if (txtCheckNo.Text != "")
                        {
                            callingForm.contributions[i].CheckNo = Convert.ToInt32(txtCheckNo.Text);
                        }
                        callingForm.contributions[i].DesignatedFund = cmbDesignatedFund.Text;


                        MessageBox.Show("Member " + callingForm.contributions[i].MemberID + "'s Contribution Successfully Updated!");


                    }
                }


                SaveToFile();
            }
        }


        private void btnAddContribution_Click(object sender, EventArgs e)
        {
            Contribution newContribution = new Contribution();

            //if (newContribution.ContributionNo = "")
            //{
            //    MessageBox.Show("Please Enter a Contribution #");

            //}
            //else if (newContribution.ContributionNo == Convert.ToInt32(txtContributionNo.Text))
            //{

            //    MessageBox.Show("That Contribution Already Exists!");
            //}
            //else
            //{
            newContribution.ContributionNo = Convert.ToInt32(txtContributionNo);
            newContribution.MemberID = Convert.ToInt32(txtMemberID.Text);
            //member[i].LastName = txtLastName.Text;
            //member[i].FirstName = txtFirstName.Text;
            newContribution.ContributionDate = dtpContributionDate.Value;
            newContribution.Amount = Convert.ToDouble(txtAmount.Text);
            newContribution.Method = txtMethod.Text;
            if (txtCheckNo.Text != "")
            {
                newContribution.CheckNo = Convert.ToInt32(txtCheckNo.Text);
            }
            newContribution.DesignatedFund = cmbDesignatedFund.Text;


            MessageBox.Show("Contribution # " + newContribution.ContributionNo + " Successfully Added!");

            SaveToFile();
            //}





        }

        private void loadContributionsFromFile()
        {
           


        }

        private void BindContributionListToDataGrid()
        {
            //set the data source for the bindingsource
            bindingContributionInfo.DataSource = callingForm.contributions;

            //set the data source for the data grid
            dataGridView1.DataSource = bindingContributionInfo;

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


            foreach (Contribution aContribution in callingForm.contributions)
            {


                outputStr = aContribution.ContributionNo + DELIM + aContribution.MemberID + DELIM +
                    //aMember.LastName + DELIM + aMember.FirstName + DELIM + 
                    aContribution.ContributionDate + DELIM + aContribution.Amount +
                    DELIM + aContribution.Method + DELIM + aContribution.CheckNo + DELIM + aContribution.DesignatedFund;


                writer.WriteLine(outputStr);

            }

            writer.Close();
            outFile.Close();
        }

        private void ChangeFormResolution()
        {
            int formWidth = 750;
            int formHeigth = 520;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Size = new System.Drawing.Size(formWidth, formHeigth);
            this.CenterToScreen();
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
                foreach (Contribution aContribution in callingForm.contributions)
                {
                    txtContributionNo.Text = "";
                    txtMemberID.Text = "";
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    txtAmount.Text = "";
                    txtMethod.Text = "";
                    txtCheckNo.Text = "";
                    cmbDesignatedFund.Text = "";



                    txtContributionNo.Text += callingForm.contributions[pos].ContributionNo;
                    txtMemberID.Text += callingForm.contributions[pos].MemberID;
                    //txtLastName.Text += member[pos].LastName;
                    //txtFirstName.Text += member[pos].FirstName;
                    dtpContributionDate.Value = callingForm.contributions[pos].ContributionDate;
                    txtAmount.Text += callingForm.contributions[pos].Amount;
                    txtMethod.Text += callingForm.contributions[pos].Method;
                    txtCheckNo.Text = callingForm.contributions[pos].CheckNo.ToString();
                    cmbDesignatedFund.Text += callingForm.contributions[pos].DesignatedFund;
                }
                dataGridView1.Rows[posNext].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[posNext].Cells[0];

            }

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


                foreach (Contribution aContribution in callingForm.contributions)
                {
                    if (aContribution != null)
                    {
                             txtContributionNo.Text = "";
                            txtMemberID.Text = "";
                            txtLastName.Text = "";
                            txtFirstName.Text = "";
                            txtAmount.Text = "";
                            txtMethod.Text = "";
                            txtCheckNo.Text = "";
                            cmbDesignatedFund.Text = "";



                            txtContributionNo.Text += callingForm.contributions[pos].ContributionNo;
                            txtMemberID.Text += callingForm.contributions[pos].MemberID;
                            //txtLastName.Text += member[pos].LastName;
                            //txtFirstName.Text += member[pos].FirstName;
                            dtpContributionDate.Value = callingForm.contributions[pos].ContributionDate;
                            txtAmount.Text += callingForm.contributions[pos].Amount;
                            txtMethod.Text += callingForm.contributions[pos].Method;
                            txtCheckNo.Text = callingForm.contributions[pos].CheckNo.ToString();
                            cmbDesignatedFund.Text += callingForm.contributions[pos].DesignatedFund;

                        }


                        dataGridView1.Rows[posPrev].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[posPrev].Cells[0];
                    }



                }
            }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            int firstRow = dataGridView1.Rows.GetFirstRow(0);
            dataGridView1.ClearSelection();
            dataGridView1.Rows[firstRow].Selected = true;        
            dataGridView1.Focus();

            foreach (Contribution aContribution in callingForm.contributions)
            {
                txtContributionNo.Text = "";
                txtMemberID.Text = "";
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtAmount.Text = "";
                txtMethod.Text = "";
                txtCheckNo.Text = "";
                cmbDesignatedFund.Text = "";



                txtContributionNo.Text += callingForm.contributions[firstRow].ContributionNo;
                txtMemberID.Text += callingForm.contributions[firstRow].MemberID;
                //txtLastName.Text += member[pos].LastName;
                //txtFirstName.Text += member[pos].FirstName;
                dtpContributionDate.Value = callingForm.contributions[firstRow].ContributionDate;
                txtAmount.Text += callingForm.contributions[firstRow].Amount;
                txtMethod.Text += callingForm.contributions[firstRow].Method;
                txtCheckNo.Text = callingForm.contributions[firstRow].CheckNo.ToString();
                cmbDesignatedFund.Text += callingForm.contributions[firstRow].DesignatedFund;
            }


        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            int lastRow = dataGridView1.Rows.GetLastRow(0);
            dataGridView1.ClearSelection();

            dataGridView1.Rows[lastRow].Selected = true;
            dataGridView1.Focus();

            foreach (Contribution aContribution in callingForm.contributions)
            {
                txtContributionNo.Text = "";
                txtMemberID.Text = "";
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtAmount.Text = "";
                txtMethod.Text = "";
                txtCheckNo.Text = "";
                cmbDesignatedFund.Text = "";



                txtContributionNo.Text += callingForm.contributions[lastRow].ContributionNo;
                txtMemberID.Text += callingForm.contributions[lastRow].MemberID;
                //txtLastName.Text += member[pos].LastName;
                //txtFirstName.Text += member[pos].FirstName;
                dtpContributionDate.Value = callingForm.contributions[lastRow].ContributionDate;
                txtAmount.Text += callingForm.contributions[lastRow].Amount;
                txtMethod.Text += callingForm.contributions[lastRow].Method;
                txtCheckNo.Text = callingForm.contributions[lastRow].CheckNo.ToString();
                cmbDesignatedFund.Text += callingForm.contributions[lastRow].DesignatedFund;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtContributionNo.Text = "";
            txtMemberID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtAmount.Text = "";
            txtMethod.Text = "";
            txtCheckNo.Text = "";
            cmbDesignatedFund.Text = "";

            dataGridView1.ClearSelection();
        }
    }

    }
