using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchManagementApplication
{
    public partial class frmMinisterSuggestion : Form
    {
        //Declares Callingform variable
        frmChurchEvents callingForm;

        DateTime passedDate;
        string passedCity;
        int pos;

        public string passedMinisterFN;
        public string passedMinisterLN;
        public int passedPhone;

        public frmMinisterSuggestion()
        {
            InitializeComponent();
        }

        private void ChangeFormResolution()
        {
            int formWidth = 500;
            int formHeigth = 440;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Size = new System.Drawing.Size(formWidth, formHeigth);
            this.CenterToScreen();
        }

        public frmMinisterSuggestion(frmChurchEvents f)
        {
            InitializeComponent();
            //Says that frmChurchEvents is the Calling form
            callingForm = f;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMinisterSuggestion_Load(object sender, EventArgs e)
        {
            
            ChangeFormResolution();
            RetrieveInfoFromForm1();
            RetrieveValidMinisters();

        }   
        private void RetrieveInfoFromForm1()
        {
            txtDateSelected.Text = callingForm.selectedDate.ToShortDateString();
            txtCitySelected.Text = callingForm.selectedCity.ToString();


        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Set txtMinister on other form to the Name of Minister Chosen 
            pos = dgvMinister.CurrentCellAddress.Y;

          
            passedMinisterLN = Convert.ToString(dgvMinister.Rows[pos].Cells[0].Value);
            passedMinisterFN = Convert.ToString(dgvMinister.Rows[pos].Cells[1].Value);
            passedPhone =  Convert.ToInt32(dgvMinister.Rows[pos].Cells[3].Value);
            //Form1


            this.Close();
        }

        private void RetrieveValidMinisters()
        {
            
            
            //Gets a list of ministers from frmChurchEvents where they exist in specified city
            var ValidMinisters = from m in callingForm.eventmember
                                 where m.MemberType == "Minister"
                                 && m.City == (txtCitySelected.Text)
                                 //select m;
                                 select new
                                 {
                                     m.LastName,
                                     m.FirstName,
                                     m.City,
                                     m.Phone,
                                     m.Address,
                                     m.MemberType
                                 };
           
            if(ValidMinisters.ToList().Count > 0 )
            {
                bindSrcMinisters.DataSource = ValidMinisters.ToList();
                dgvMinister.DataSource = bindSrcMinisters;
            }
         else
            {
                MessageBox.Show("There are no valid ministers available in " + txtCitySelected.Text+ "\n on: " + txtDateSelected.Text );
                this.Close();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            RetrieveValidMinisters();
        }
    }
}
