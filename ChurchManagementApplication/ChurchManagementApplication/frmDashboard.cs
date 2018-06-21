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
using System.Windows.Forms.DataVisualization.Charting;

namespace ChurchManagementApplication
{
    public partial class frmDashboard : Form
    {
        public BindingList<Member> member = new BindingList<Member>();
        public BindingList<Contribution> contributions = new BindingList<Contribution>();
        public BindingList<Event> EventList = new BindingList<Event>();


        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

            loadMembersFromFile();
            loadContributionsFromFile();
            DisplayChartMemberType();
            DisplayChartMemberGender();
            DisplayChartMemberStatus();
            DisplayChartMemberCity();
            DisplayChartMemberAges();
            DisplayChartMinisterToMemberRatio();
            DisplayChartContributionsPerCause();
            DisplayChartMemberAdditions();
            DisplayChartContributionMethod();
            DisplayChartContributionsDate();
            ChangeFormResolution();
        }
        private void ChangeFormResolution()
        {
            int formWidth = 1200;
            int formHeigth = 800;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Size = new System.Drawing.Size(formWidth, formHeigth);
            this.CenterToScreen();
        }

        private void loadContributionsFromFile()
        {
            //Create FileStream Object (Contributions)
            FileStream inFile = new FileStream("contributions.csv", FileMode.OpenOrCreate, FileAccess.ReadWrite);


            //Create StreamReader object(reader)
            StreamReader reader = new StreamReader(inFile);

            //Declare a string array (fieldValues) to hold all of the values of a single record
            string[] fieldValues;

            //Header - read the header record and ignore it
            string inputStr = reader.ReadLine();
            inputStr = reader.ReadLine();

            //Loop while record not null
            while (inputStr != null)
            {
                //split the record using delimiter into the fieldValuesArray
                fieldValues = inputStr.Split(',');

                //create an empty domain object
                Contribution aContribution = new Contribution();

                //update each field of the domain object
                aContribution.ContributionNo = Convert.ToInt32(fieldValues[0]);
                aContribution.MemberID = Convert.ToInt32(fieldValues[1]);
                aContribution.ContributionDate = Convert.ToDateTime(fieldValues[2]);
                aContribution.Amount = Convert.ToDouble(fieldValues[3]);
                aContribution.Method = (fieldValues[4]);
                if (Convert.ToString(fieldValues[5]) != "")
                {
                    aContribution.CheckNo = Convert.ToInt32(fieldValues[5]);
                }
                aContribution.DesignatedFund = (fieldValues[6]);

                //add this domain object ot the list of domain objects
                contributions.Add(aContribution);

                //read next record
                inputStr = reader.ReadLine();
            }
        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {
            frmChurchEvents f = new frmChurchEvents(this);
            f.ShowDialog();

        }

        private void btnSortFilter_Click(object sender, EventArgs e)
        {
            frmMemberQuery f = new frmMemberQuery(this);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmMemberEdit f = new frmMemberEdit(this);
            f.ShowDialog();
        }

        private void btnSortFilterContributions_Click(object sender, EventArgs e)
        {
            frmContributionQuery f = new frmContributionQuery(this);
            f.ShowDialog();
        }

        private void DisplayChartMemberType()
        {
            //1 - define the data series
            chartMemberType.Series.Clear();
            chartMemberType.Series.Add("Type");

            //2 - format the chart
            chartMemberType.Series["Type"].ChartType = SeriesChartType.Pie;
            chartMemberType.BackColor = Color.Plum;
            chartMemberType.ChartAreas[0].BackColor = Color.Transparent;
            chartMemberType.Legends.Clear(); //removes the legend

            // - 3chart calculations
            var queryMemberType = from m in member
                                  where (m.MemberType == "Attender" || m.MemberType == "Minister" ||
                                  m.MemberType == "Visitor" || m.MemberType == "Contract" || m.MemberType == "Archived" ||
                                  m.MemberType == "Member" || m.MemberType == "Staff" || m.MemberType == "Dependent")
                                  orderby m.MemberType
                                  group m by m.MemberType into grpMemberType
                                  select new
                                  {
                                      grpMemberType.Key,
                                      CountMemberType = grpMemberType.Select(m => m.MemberType).Count()
                                  };

            //4 = add the data points
            foreach (var group in queryMemberType)
            {
                chartMemberType.Series["Type"].Points.AddXY(group.Key, group.CountMemberType);
            }

        }

        private void DisplayChartMemberGender()
        {
            //1 - define the data series
            chartMemberGender.Series.Clear();
            chartMemberGender.Series.Add("Male");
            chartMemberGender.Series.Add("Female");

            //2 - format the chart
            chartMemberGender.Series["Male"].ChartType = SeriesChartType.Column;
            chartMemberGender.Series["Male"].Color = System.Drawing.Color.Blue;
            chartMemberGender.Series["Female"].ChartType = SeriesChartType.Column;
            chartMemberGender.Series["Female"].Color = System.Drawing.Color.Green;
            chartMemberGender.BackColor = Color.Plum;
            chartMemberGender.ChartAreas[0].BackColor = Color.Plum;
            chartMemberGender.Legends.Clear();

            // - 3 chart calculations           
            var queryMemberMale = from m in member
                                  where (m.MemberType == "Staff" || m.MemberType == "Minister" ||
                                  m.MemberType == "Member") && (m.Gender == "M")
                                  orderby m.Gender
                                  group m by m.MemberType into grpMemberMale
                                  select new
                                  {
                                      grpMemberMale.Key,
                                      CountMemberMale = grpMemberMale.Select(m => m.Gender).Count()
                                  };

            var queryMemberFemale = from m in member
                                    where (m.MemberType == "Staff" || m.MemberType == "Minister" ||
                                    m.MemberType == "Member") && (m.Gender == "F")
                                    orderby m.Gender
                                    group m by m.MemberType into grpMemberFemale
                                    select new
                                    {
                                        grpMemberFemale.Key,
                                        CountMemberFemale = grpMemberFemale.Select(m => m.Gender).Count()
                                    };

            //4 = add the data points
            foreach (var group in queryMemberMale)
            {
                chartMemberGender.Series["Male"].Points.AddXY(group.Key, group.CountMemberMale);
            }

            foreach (var group in queryMemberFemale)
            {
                chartMemberGender.Series["Female"].Points.AddXY(group.Key, group.CountMemberFemale);
            }
        }

        private void DisplayChartMemberStatus()
        {
            //1 - define the data series
            chartMemberStatus.Series.Clear();
            chartMemberStatus.Series.Add("Status");

            //2 - format the chart
            chartMemberStatus.Series["Status"].ChartType = SeriesChartType.Pie;
            chartMemberStatus.BackColor = Color.Transparent;
            chartMemberStatus.Legends.Clear();
            chartMemberStatus.ChartAreas[0].BackColor = Color.Transparent;

            // - 3 chart calculations
            var queryMemberStatus = from m in member
                                    where (m.MaritalStatus == "Divorced" || m.MaritalStatus == "Married" ||
                                    m.MaritalStatus == "Unknown" || m.MaritalStatus == "Not applicable" ||
                                    m.MaritalStatus == "Separated" || m.MaritalStatus == "Widowed" || m.MaritalStatus == "Single")
                                    orderby m.MaritalStatus
                                    group m by m.MaritalStatus into grpMemberStatus
                                    select new
                                    {
                                        grpMemberStatus.Key,
                                        CountMemberStatus = grpMemberStatus.Select(m => m.MaritalStatus).Count()
                                    };
            //4 = add the data points
            foreach (var group in queryMemberStatus)
            {
                chartMemberStatus.Series["Status"].Points.AddXY(group.Key, group.CountMemberStatus);
            }

            //5 - format the data points
            chartMemberStatus.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
        }

        private void DisplayChartMemberCity()
        {
            //1 - define the data series
            chartMemberCity.Series.Clear();
            chartMemberCity.Series.Add("City");

            //2 - format chart
            chartMemberCity.Series["City"].ChartType = SeriesChartType.Column;
            chartMemberCity.Series["City"].Color = Color.Red;
            chartMemberCity.Legends.Clear();
            chartMemberCity.BackColor = Color.Plum;
            chartMemberCity.ChartAreas[0].BackColor = Color.Plum;

            //3 - do chart calculations
            var queryCity = from m in member
                            where (m.State == "TX")
                            orderby m.City
                            group m by m.City into grpCity
                            select new
                            {
                                grpCity.Key,
                                CountMemberCity = grpCity.Select(m => m.City).Count()
                            };
            //4 = add the data points
            foreach (var group in queryCity)
            {
                chartMemberCity.Series["City"].Points.AddXY(group.Key, group.CountMemberCity);

            }

            //5 - format the chart
            chartMemberCity.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartMemberCity.Series["City"].Points[0].AxisLabel = "Axtell";
            //chartMemberCity.Series["City"].Points[1].AxisLabel = "";
        }

        private void DisplayChartMemberAges()
        {
            int YoungOnesCount = 0;
            int MiddleAgedCount = 0;
            int ElderlyCount = 0;

            //1 - define the data series
            chartMemberAges.Series.Clear();
            chartMemberAges.Series.Add("Ages");

            //2 - format chart
            chartMemberAges.Series["Ages"].ChartType = SeriesChartType.Column;
            chartMemberAges.Series["Ages"].Color = Color.Red;
            chartMemberAges.Legends.Clear();
            chartMemberAges.ChartAreas[0].BackColor = Color.Plum;
            chartMemberAges.BackColor = Color.Plum;
            chartMemberAges.ChartAreas[0].AxisY.Maximum = 60;
            chartMemberAges.ChartAreas[0].AxisX.Title = "Age Range";  //x-axis title
            chartMemberAges.ChartAreas[0].AxisY.Title = "No. of Members";  //y-axis title
            chartMemberAges.Series["Ages"].Label = "#VALY"; //show the value of Y on every Point


            //3 - do chart calculations
            foreach (Member m in member)
            {
                var todayz = DateTime.Today;
                var agez = todayz.Year - m.BirthDate.Year;
                if (m.BirthDate > todayz.AddYears(-agez)) agez--;

                if (agez <= 25)
                {
                    YoungOnesCount++;
                }

                else if (agez <= 60)
                {
                    MiddleAgedCount++;
                }

                else if (agez <= 110)
                {
                    ElderlyCount++;
                }
            }

            //4 = add the data points
            chartMemberAges.Series["Ages"].Points.AddXY(1, YoungOnesCount);
            chartMemberAges.Series["Ages"].Points.AddXY(2, MiddleAgedCount);
            chartMemberAges.Series["Ages"].Points.AddXY(3, ElderlyCount);

            //5 - format the chart
            // format the x axis
            chartMemberAges.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;

            // format the Y axis
            chartMemberAges.ChartAreas[0].AxisY.MajorTickMark.Interval = 10;

            //rename numerical values on the x-axis
            chartMemberAges.Series["Ages"].Points[0].AxisLabel = "0-25";
            chartMemberAges.Series["Ages"].Points[1].AxisLabel = "25-60";
            chartMemberAges.Series["Ages"].Points[2].AxisLabel = "60-100";
            chartMemberAges.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.WordWrap;

        }

        private void DisplayChartMinisterToMemberRatio()
        {
            //1 - define the data series
            chartMinisterToMember.Series.Clear();
            chartMinisterToMember.Series.Add("MemberType");

            //2 - format the chart
            chartMinisterToMember.Series["MemberType"].ChartType = SeriesChartType.Pie;
            chartMinisterToMember.BackColor = Color.Plum;
            chartMinisterToMember.ChartAreas[0].BackColor = Color.Plum;
            chartMinisterToMember.Legends.Clear();

            //3 - chart calculations           
            var queryMemberToMinisterRatio = from m in member
                                             where (m.MemberType == "Minister" || m.MemberType == "Member")
                                             orderby m.MemberType
                                             group m by m.MemberType into grpMemberRatio
                                             select new
                                             {
                                                 grpMemberRatio.Key,
                                                 CountMemberRatio = grpMemberRatio.Select(m => m.MemberType).Count()
                                             };
            //4 = add the data points
            foreach (var group in queryMemberToMinisterRatio)
            {
                chartMinisterToMember.Series["MemberType"].Points.AddXY(group.Key, group.CountMemberRatio);
            }

            ////5 - format the data points
            //chartMemberType.Series["Type"].Points.Add() 
        }

        private void DisplayChartMemberAdditions() //please have mercy, this is a total conondrum... SANCHEZ TRIED FOR 40 MINS, GRADER PERSON (more like, GREATER person)
        {
            //1 - define the data series
            chartMemberAdditions.Series.Clear();
            chartMemberAdditions.Series.Add("Additions");

            //2 - format the chart
            chartMemberAdditions.Series["Additions"].ChartType = SeriesChartType.Line;
            chartMemberAdditions.Legends.Clear();
            chartMemberAdditions.BackColor = Color.Plum;
            chartMemberAdditions.ChartAreas[0].BackColor = Color.Plum;

            //3 - do chart calculations
            var queryMemberAddition = from m in member
                                      where m.MemberType == "Member"
                                      orderby m.MembershipDate descending
                                      group m by m.MembershipDate.Year into grpDateAdded
                                      select new
                                      {
                                          grpDateAdded.Key,
                                          CountYearAdded = grpDateAdded.Select(m => m.MembershipDate).Count()
                                      };

            //4 - add data points to the chart
            foreach (var group in queryMemberAddition)
            {
                chartMemberAdditions.Series["Additions"].Points.AddXY(group.Key, group.CountYearAdded);
            }

            //5 - format the chart
            // format the x axis

            chartMemberAdditions.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartMemberAdditions.ChartAreas[0].AxisX.Interval = 10;

            // format the Y axis
            chartMemberAdditions.ChartAreas[0].AxisY.Maximum = 3;
            chartMemberAdditions.ChartAreas[0].AxisY.Interval = 1;
        } 

        private void DisplayChartContributionsPerCause() //wont diplay
        {
            //1 - define the data series
            chartContributionsPerCause.Series.Clear();
            chartContributionsPerCause.Series.Add("Contributions");

            //2 - format the chart
            chartContributionsPerCause.Series["Contributions"].ChartType = SeriesChartType.Column;
            chartContributionsPerCause.BackColor = Color.Plum;
            chartContributionsPerCause.ChartAreas[0].BackColor = Color.Plum;
            chartContributionsPerCause.Legends.Clear(); //removes the legend

            //3 - chart calculations
            var queryDesignatedFund = from c in contributions
                                      where (c.DesignatedFund == "Building Fund" || c.DesignatedFund == "Church Planting" ||
                                      c.DesignatedFund == "Food Bank" || c.DesignatedFund == "General Fund" ||
                                      c.DesignatedFund == "Missions" || c.DesignatedFund == "Restricted-Youth" ||
                                      c.DesignatedFund == "Tithes")
                                      orderby c.DesignatedFund
                                      group c by c.DesignatedFund into grpDesignatedFund
                                      select new
                                      {
                                          grpDesignatedFund.Key,
                                          SumAmount = grpDesignatedFund.Select(c => c.Amount).Sum()
                                      };


            //4 - add the data points
            foreach (var group in queryDesignatedFund)
            {
                chartContributionsPerCause.Series["Contributions"].Points.AddXY(group.Key, group.SumAmount);
            }
        }

        private void DisplayChartContributionMethod() //wont display
        {
            //1 - define the data series
            chartContributionMethod.Series.Clear();
            chartContributionMethod.Series.Add("Method");

            //2 format the chart
            chartContributionMethod.Series["Method"].ChartType = SeriesChartType.Pie;
            chartContributionMethod.Legends.Clear();
            chartContributionMethod.BackColor = Color.Plum;
            chartContributionMethod.ChartAreas[0].BackColor = Color.Plum;
            //colors stuff

            //3 - chart calculations
            var queryMethodContribution = from c in contributions

                                          orderby c.Method
                                          group c by c.Method into grpContMethod
                                          select new
                                          {
                                              grpContMethod.Key,
                                              SumContMethod = grpContMethod.Select(c => c.Amount).Sum()
                                          };
            foreach (var group in queryMethodContribution)
            {
                chartContributionMethod.Series["Method"].Points.AddXY(group.Key, group.SumContMethod);
            }


        }

        private void DisplayChartContributionsDate()
        {
            //1 - define data series
            chartContributionsDate.Series.Clear();
            chartContributionsDate.Series.Add("ContDates");

            //2 - format the charts
            chartContributionsDate.Series["ContDates"].ChartType = SeriesChartType.Line;
            chartContributionsDate.Legends.Clear();
            chartContributionsDate.BackColor = Color.Plum;
            chartContributionsDate.ChartAreas[0].BackColor = Color.Plum;

            //3 - chart calculations
            var queryContributionDate = from c in contributions
                                    where c.DesignatedFund == "General Fund"
                                    orderby c.ContributionDate descending
                                    group c by c.ContributionDate into grpContDate
                                    select new
                                    {
                                        grpContDate.Key,
                                        SumDateAmount = grpContDate.Select(c => c.Amount).Sum()
                                    };
            //4 - add data points
            foreach (var group in queryContributionDate)
            {
                chartContributionsDate.Series["ContDates"].Points.AddXY(group.Key, group.SumDateAmount);
            }
        }

        private void loadMembersFromFile()
        {
            //MAYBE REMOVE AND RECIEVE INFO FROM LIST PASSED FROM MAIN FORM

            //Create FileStream Object (Members)
            FileStream inFile = new FileStream("members.csv", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //Create StreamReader object(reader)
            StreamReader reader = new StreamReader(inFile);

            //Declare a string array (fieldValues) to hold all of the values of a single record
            string[] fieldValues;

            //Header - read the header record and ignore it
            string inputStr = reader.ReadLine();
            inputStr = reader.ReadLine();

            //Loop while record not null
            while (inputStr != null)
            {
                //split the rocrd using delimiter into the fieldValuesArray
                fieldValues = inputStr.Split(',');

                //create an empty domain object
                Member aMember = new Member();

                //update each field of the domain object
                aMember.MemberID = Convert.ToInt32(fieldValues[0]);
                aMember.LastName = fieldValues[1];
                aMember.FirstName = fieldValues[2];
                aMember.Honorific = fieldValues[3];
                aMember.Gender = fieldValues[4];
                aMember.BirthDate = Convert.ToDateTime(fieldValues[5]);
                aMember.MaritalStatus = fieldValues[6];
                aMember.Address = fieldValues[7];
                aMember.City = fieldValues[8];
                
                aMember.State = fieldValues[9];
                aMember.Zip = Convert.ToInt32(fieldValues[10]);
               
                if (Convert.ToInt64(aMember.Phone) != null)
                {
                    aMember.Phone = fieldValues[11];
                }
                else
                {
                    aMember.Phone = "0";
                }

                aMember.Email = fieldValues[12];


                aMember.AttendanceBeginDate = Convert.ToDateTime(fieldValues[15]);
                aMember.AttendanceLastDate = Convert.ToDateTime(fieldValues[16]);

                aMember.MemberType = fieldValues[13];

                if (Convert.ToDateTime(fieldValues[14]) > new  DateTime(1800,1,1))
                {
                    aMember.MembershipDate = Convert.ToDateTime(fieldValues[14]);
                }
                else
                {
                    aMember.MembershipDate = new DateTime(2000, 1, 1);
                }
                
                
                //add this domain object ot the list of domain objects
                member.Add(aMember);

                //read next record
                inputStr = reader.ReadLine();


            }


        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm(this);
            f.ShowDialog();
        }

        private void btnEditContributions_Click(object sender, EventArgs e)
        {
            frmContributionEdit f = new frmContributionEdit(this);
            f.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
