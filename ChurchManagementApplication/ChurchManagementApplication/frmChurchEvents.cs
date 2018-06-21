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

//Chris Waters


namespace ChurchManagementApplication
{
    public partial class frmChurchEvents : Form
    {

        frmDashboard callingForm;


        public DateTime selectedDate;
        public string selectedCity;
        public string selectedEvent;
        public BindingList<Event> EventList = new BindingList<Event>();      
        

       
        //Remove for final
        //RETRIEVE MEMBER FROM PARENT FORM
        public BindingList<Member> eventmember = new BindingList<Member>();

        public BindingList<Member> ValidMembers = new BindingList<Member>();
        public BindingList<Member> storedCities = new BindingList<Member>();
        public List<Event> EventstoRemove = new List<Event>();

        public frmChurchEvents(frmDashboard f)
        {
            InitializeComponent();
            callingForm = f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Methods to run on Form Load       
            ChangeFormResolution();
            //LoadTestData();
            loadMembersFromFile();
            LoadEventsList();  
            BoldStoredEvents();
            monthCalendar1.UpdateBoldedDates();
            LoadCitiesToComboBox();
        }

        private void loadMembersFromFile()
        {
            #region OldMembers Load
            ////MAYBE REMOVE AND RECIEVE INFO FROM LIST PASSED FROM MAIN FORM

            ////Create FileStream Object (Members)
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
            //    //split the rocrd using delimiter into the fieldValuesArray
            //    fieldValues = inputStr.Split(',');

            //    //create an empty domain object
            //Member aMember = new Member();

            //update each field of the domain object
            //aMember.MemberID = Convert.ToInt32(callingForm.member);
            //aMember.LastName = fieldValues[1];
            //aMember.FirstName = fieldValues[2];
            //aMember.Honorific = fieldValues[3];
            //aMember.Gender = fieldValues[4];
            //aMember.BirthDate = Convert.ToDateTime(fieldValues[5]);
            //aMember.MaritalStatus = fieldValues[6];
            //aMember.Address = fieldValues[7];
            //aMember.City = fieldValues[8];

            //aMember.State = fieldValues[9];
            //aMember.Zip = Convert.ToInt32(fieldValues[10]);

            //aMember.AttendanceBeginDate = Convert.ToDateTime(fieldValues[15]);
            //aMember.AttendanceLastDate = Convert.ToDateTime(fieldValues[16]);

            //aMember.MemberType = fieldValues[13];

            //add this domain object ot the list of domain objects

            foreach (Member aMember in callingForm.member)
            {
                eventmember.Add(aMember);

            }
                

            //    //read next record
            //    inputStr = reader.ReadLine();


            //}
            #endregion
            LoadCitiesToComboBox();
        }

        private void LoadCitiesToComboBox()        
        {
            //Populates Combo box with Cities that exist within the Member Class
            foreach (Member m in eventmember)
            {
                if (!cboCity.Items.Contains(m.City))
                {
                    cboCity.Items.Add(m.City);
                }
            }

        }

        private void ChangeFormResolution()
        {
            int formWidth = 550;
            int formHeigth = 440;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Size = new System.Drawing.Size(formWidth, formHeigth);
            this.CenterToScreen();
        }     

        public void RetrieveValidMinisters()
        {
            //LINQ Query to find every Minister within a selected city
            //and retrieve appropriate Information
            var ValidMinisters = from m in callingForm.member
                                 where m.MemberType == "Minister"
                                 && m.City.Contains(cboCity.SelectedItem.ToString()) 
                                 select new
                                 {
                                     m.LastName,
                                     m.FirstName,
                                     m.Phone,
                                     m.Address,
                                     m.MemberType
                                 };

        }      

        private void BoldStoredEvents()
        {
            //If an Event exists in EventList then Bold its date on the MonthCalander
            foreach (Event ev in EventList)
            {
                monthCalendar1.AddBoldedDate(Convert.ToDateTime(ev.EventDate));

            }
            

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string startDate;
            string endDate;

            //Determine the SELECTION start & end dates -format with ToString("MM/dd/yy")
            startDate = monthCalendar1.SelectionStart.ToShortDateString();
            endDate = monthCalendar1.SelectionEnd.ToShortDateString();

            //Display the selected date(s) in the Textbox
            if (startDate == endDate)
            {
                txtDate.Text = startDate;
            }
            else
            {
                txtDate.Text = startDate + " - " + endDate;
            }
        }

        private void LoadTestData()
        {
            cboCity.SelectedItem = "Waco";
            txtAddress.Text = "2410 S 2nd Street";
            txtEventName.Text = "Youth Ministry";

        }

        
        
        #region Load_And_Save_Methods              


        private void SaveEventsToCSV()
        {
            //Save Events List to Events.csv File
            FileStream outFile = new FileStream("Events.csv", FileMode.Create, FileAccess.Write);
            string outputStr = "";
            string DELIM = ",";

            StreamWriter writer = new StreamWriter(outFile);

            foreach (Event ev in EventList)
            {
                outputStr = ev.EventDate + DELIM + ev.EventName + DELIM +
                    ev.Description + DELIM + ev.City + DELIM + ev.Address +
                    DELIM + ev.Minister + DELIM + ev.MinisterLN + DELIM +
                    ev.PhoneNum;
                writer.WriteLine(outputStr);
            }

            writer.Close();
            outFile.Close();

        
    }

        private void LoadEventsList()
        {
            //Load EventsList from Events.csv
            string inputStr;
            string[] fieldValues;
            const char DELIM = ',';         
            Event ev = new Event();

            FileStream inFile = new FileStream("Events.csv",
            FileMode.OpenOrCreate, FileAccess.Read);     //creates new or reads from 1st record
            StreamReader reader = new StreamReader(inFile);

            inputStr = reader.ReadLine();

            //Skip header row
            //inputStr = reader.ReadLine();

            while (inputStr != null)
            {
                fieldValues = inputStr.Split(DELIM);   //separate & stored record in a string array

                ev = new Event();   //create a new student object each time it loops!

                //Fill object
                ev.EventDate = fieldValues[0];
                ev.EventName = fieldValues[1];
                ev.Description = fieldValues[2];
                ev.City = fieldValues[3];
                ev.Address = fieldValues[4];
                ev.Minister = fieldValues[5];
                ev.MinisterLN = fieldValues[6];
                ev.PhoneNum = Convert.ToInt32(fieldValues[7]);

                EventList.Add(ev);    //add the new student to the list
                                       //call a method to display the new DATE  ON THE CALENDER

                inputStr = reader.ReadLine();   //read the next record
            }
            reader.Close();
            inFile.Close();
        }
        
        
        #endregion

        private void ClearAllBoxes()
        {
            //Clears all textboxes
            txtDate.Text = "";
            txtEventName.Text = "";
            txtDesc.Text = "";
            cboCity.Text = "";
            txtAddress.Text = "";
            txtMinisterName.Text = "";
            txtLastName.Text = "";
            txtCellPhone.Text = "";
        }       

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            string strOutput = "";
            string strEvName ="";

            //If a selected date is bolded...
            if (monthCalendar1.BoldedDates.Contains(monthCalendar1.SelectionStart))
            {
                //Query to retrive Info of Bolded event 
                var dateInfo = from ev in EventList
                                 where ev.EventDate == monthCalendar1.SelectionStart.ToShortDateString()
                                 select ev;                

                //Store the Events Information in formatted string
                foreach (var ev in dateInfo)
                {

                    strOutput = "Event Date:  ".PadRight(17) + ev.EventDate + "\nEvent:  ".PadRight(22) +
                                     ev.EventName + "\nDescription:  ".PadRight(18) +
                                     ev.Description + "\nCity:  ".PadRight(24) +
                                     ev.City + "\nAddress:  ".PadRight(20) +
                                     ev.Address + "\nMinister:  ".PadRight(20) +
                                     ev.Minister + " " + ev.MinisterLN + "\nPhoneNum:  ".PadRight(15) +
                                     ev.PhoneNum.ToString() + "\n\n-------------------------------\n\nWould you like to edit this event?"
                                     ;
                    strEvName = ev.EventName;

                }
        //Message Box prompt Containing The Events Information + Asks user if they would like to edit the event
                if (MessageBox.Show(strOutput, "Event Info: " + strEvName, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Loads events information into Textboxes 
                    foreach(var lev in dateInfo)
                    {
                        txtEventName.Text = lev.EventName;
                        txtDesc.Text = lev.Description;
                        cboCity.SelectedItem = lev.City;
                        txtAddress.Text = lev.Address;
                        txtMinisterName.Text = lev.Minister;
                        txtLastName.Text = lev.MinisterLN;
                        txtCellPhone.Text = lev.PhoneNum.ToString();
                    }

                }
                

            }

        }

        #region ButtonMethods

        private void btnRemoveMinister_Click(object sender, EventArgs e)
        {
            //Clears Ministers information from textbox
            //STILL REQUIRES SUBMIT TO BE PRESSED
            if (txtMinisterName.Text != "")
            {
                txtMinisterName.Text = "";
            }

            if (txtLastName.Text != "")
            {
                txtLastName.Text = "";
            }
            if(txtCellPhone.Text != "")
            {
                txtCellPhone.Text = "";
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears out text boxes
            ClearAllBoxes();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Saves Events list to file

            SaveEventsToCSV();

        }

        private void btnSubmit_Click(object sender, EventArgs e)

        {
            if (txtDate.Text == "")
            {
                MessageBox.Show("Please select a date\non the calender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboCity.SelectedItem == null)
            {
                MessageBox.Show("Please select a city", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Instantiate new event object
                Event ev = new Event();

                string selDate = txtDate.Text;
                string selEvent = txtEventName.Text;
                //check if selected date is in system

                //LINQ to see if There is a matching event in the List based on 
                //if the date and event name in the txtboxes matches an event in Eventlist
                //Returns the event's information  
                var IndexExistingEvent = from ee in EventList
                                         where ee.EventDate == selDate &&
                                         ee.EventName == selEvent
                                         select ee;
                //Adds the LINQ query result to a List to 
                EventstoRemove = IndexExistingEvent.ToList();

                //If the Query result has a event that met the criteria
                if (IndexExistingEvent.Count() > 0)
                {

                    //Fill the Instance of Event
                    ev.EventDate = txtDate.Text;
                    monthCalendar1.AddBoldedDate(Convert.ToDateTime(ev.EventDate));
                    ev.EventName = txtEventName.Text;
                    ev.Description = txtDesc.Text;
                    ev.City = cboCity.SelectedItem.ToString();
                    ev.Address = txtAddress.Text;
                    ev.Minister = txtMinisterName.Text;
                    ev.MinisterLN = txtLastName.Text;
                    if (txtCellPhone.Text != "")
                    {
                        ev.PhoneNum = Convert.ToInt32(txtCellPhone.Text);
                    }


                    //Loop to find the index of the Event to replace
                    for (int i = 0; i < EventList.Count(); i++)
                    {
                        //If eventlist at index of i finds the matching event date
                        //Replace old event with Upated event
                        if (EventList[i].EventDate == ev.EventDate)
                        {
                            EventList.RemoveAt(i);
                            EventList.Insert(i, ev);
                            MessageBox.Show("Event " + ev.EventName + " Successfully Updated!");
                        }
                    }
                }

                //If No event exists at that Date with the same event name, then Create new event
                else
                {
                    //Create New Event Instance


                    ev.EventDate = txtDate.Text;
                    monthCalendar1.AddBoldedDate(Convert.ToDateTime(ev.EventDate));

                    ev.EventName = txtEventName.Text;

                    ev.Description = txtDesc.Text;
                    ev.City = cboCity.SelectedItem.ToString();

                    ev.Address = txtAddress.Text;

                    ev.Minister = txtMinisterName.Text;
                    ev.MinisterLN = txtLastName.Text;

                    if (txtCellPhone.Text != "")
                    {
                        ev.PhoneNum = Convert.ToInt32(txtCellPhone.Text);
                    }
                    //Add to new list
                    EventList.Add(ev);
                    //Notify event was created successfully
                    MessageBox.Show("Event " + ev.EventName + " Successfully Created!");
                }
                //Update Month Calanders flagged events
                monthCalendar1.UpdateBoldedDates();
            }
        }

        private void btnRecommendedMinisters_Click(object sender, EventArgs e)
        {
            //Error Catches if invalid Date And Or City
            if (txtDate.Text == "")
            {
                MessageBox.Show("Please select a valid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboCity.Text == "")
            {
                MessageBox.Show("Please enter a valid city name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Retrieve Valid Ministers from Member List and Pass all the info to frmMinisterSuggestion 
                RetrieveValidMinisters();

                //Pulls Date and City data
                selectedDate = Convert.ToDateTime(txtDate.Text);
                selectedCity = cboCity.SelectedItem.ToString();


                //Opens a new form and passes frmChurchEvents info to it
                frmMinisterSuggestion f = new frmMinisterSuggestion(this);
                f.ShowDialog();


                txtMinisterName.Text = f.passedMinisterFN;
                txtLastName.Text = f.passedMinisterLN;
                txtCellPhone.Text = f.passedPhone.ToString();


            }

        }

        #endregion

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
