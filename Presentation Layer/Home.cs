using MyDiary.Business_Logic_layer;
using MyDiary.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiary.Presentation_Layer
{
    public partial class Home : Form
    {
        string personName;
        string pictureName = "";
        string[] twelveMonths = { "Jan", "Feb", "Mar", "April", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private Panel eventPanel = new Panel();
        private Event selectedEvent = new Event();
        private Button done = new Button();
        public Home(string personName)
        {
            InitializeComponent();
            this.personName = personName;
            this.personNameLabel.Text = "Logged in as: " + personName;
            RefreshEvents(null, null);
            this.doneBtn.Click += RefreshEvents;
            this.removeEventBtn.Click += RefreshEvents;
            this.closeBtn.Click += this.EventPanel_Click;
            this.doneBtn.Click += this.EventPanel_Click;
        }

        void RefreshEvents(Object o, EventArgs e)
        {
            this.allEventsPanel.Controls.Clear();
            EventService eventService = new EventService();
            List<Event> allEventsList = eventService.GetEventList(this.personName);
            int i = 1;
            int startingRowPosition = 0;
            int startingColumnPosition = 0;
            foreach(Event ev in allEventsList)
            {
                Panel eventPanel = new Panel();
                eventPanel.ResumeLayout(false);
                eventPanel.SuspendLayout();
                Label calenderLabel = new Label();
                Label eventHeadLabel = new Label();
                Label eventBodyLabel = new Label();

                // calenderLabel
                // 
                if (ev.Importance == 2)
                {
                    calenderLabel.BackColor = System.Drawing.Color.Red;
                }
                else if (ev.Importance == 1)
                {
                    calenderLabel.BackColor = System.Drawing.Color.DarkSlateBlue;
                }
                else
                {
                    calenderLabel.BackColor = System.Drawing.Color.DarkCyan;
                }

                calenderLabel.Dock = System.Windows.Forms.DockStyle.Left;
                calenderLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                calenderLabel.ForeColor = System.Drawing.Color.White;
                calenderLabel.Location = new System.Drawing.Point(0, 0);
                calenderLabel.Name = "calenderLabel";
                calenderLabel.Size = new System.Drawing.Size(50, 50);
                calenderLabel.TabIndex = 0;
                calenderLabel.Text = ev.Time.Day+"\r\n"+twelveMonths[((int)ev.Time.Month)-1];
                calenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                calenderLabel.Click += new System.EventHandler(EventPanel_Click);

                // eventHeadLabel
                // 
                eventHeadLabel.Dock = System.Windows.Forms.DockStyle.Top;
                eventHeadLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                eventHeadLabel.Location = new System.Drawing.Point(50, 0);
                eventHeadLabel.Name = "eventHeadLabel";
                eventHeadLabel.Size = new System.Drawing.Size(200, 32);
                eventHeadLabel.TabIndex = 1;
                eventHeadLabel.Text = ev.Title;
                eventHeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                eventHeadLabel.Click += new System.EventHandler(EventPanel_Click);

                // eventBodyLabel
                // 
                eventBodyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
                eventBodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                eventBodyLabel.Location = new System.Drawing.Point(50, 32);
                eventBodyLabel.Name = "eventBodyLabel";
                eventBodyLabel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
                eventBodyLabel.Size = new System.Drawing.Size(200, 18);
                eventBodyLabel.TabIndex = 2;
                eventBodyLabel.Text = ev.Details;
                eventBodyLabel.Click += new System.EventHandler(EventPanel_Click);

                // eventPanel
                // 
                eventPanel.Controls.Add(eventBodyLabel);
                eventPanel.Controls.Add(eventHeadLabel);
                eventPanel.Controls.Add(calenderLabel);
                eventPanel.BackColor = System.Drawing.Color.Transparent;
                eventPanel.Location = new System.Drawing.Point(startingRowPosition, startingColumnPosition);
                eventPanel.Name = "eventPanel" + i++;
                eventPanel.Size = new System.Drawing.Size(250, 50);
                eventPanel.TabIndex = 4;
                startingColumnPosition += 50;

                this.allEventsPanel.Controls.Add(eventPanel);

                void EventPanel_Click(object sender, EventArgs q)
                {
                    /*if (this.addEventPanel.Visible)
                    {
                        this.addEventPanel.Visible = false;
                        this.addEventBtn.Enabled = true;
                        this.removeEventBtn.Enabled = true;
                        this.importanceBtn.Enabled = true;
                        this.modifyEventBtn.Enabled = true;
                    }*/
                    if (this.eventPanel != null)
                    {
                        this.eventPanel.BackColor = System.Drawing.Color.Transparent;
                    }
                    this.eventPanel = eventPanel;
                    this.selectedEvent = ev;
                    eventPanel.BackColor = System.Drawing.Color.Silver;
                    this.timeLabel.Text = ev.Time.ToString();
                    if(ev.LastModification != "")
                    {
                        this.modifiedTimeLabel.Text = "Last modified on: " + ev.LastModification;
                        this.modifiedTimeLabel.Visible = true;
                    }
                    else
                    {
                        this.modifiedTimeLabel.Visible = false;
                    }
                    eventTitleLabel.Text = ev.Title;
                    eventDetailsLabel.Text = ev.Details;
                    if(ev.PictureName != "")
                    {
                        this.pictureBox.Image = new Bitmap(ev.PictureName);
                        this.pictureBox.Visible = true;
                    }
                    else
                    {
                        this.pictureBox.Image = null;
                        this.pictureBox.Visible = false;
                    }
                    this.removeEventBtn.Enabled = true;
                    this.importanceBtn.Enabled = true;
                    this.modifyEventBtn.Enabled = true;
                }
            }
        }
        
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EventPanel_Click(object sender, EventArgs q)
        {
            if (this.eventPanel != null)
            {
                this.eventPanel.BackColor = System.Drawing.Color.Transparent;
            }
            eventDetailsLabel.Text = selectedEvent.Details;
            if (selectedEvent.PictureName != "")
            {
                this.pictureBox.Image = new Bitmap(selectedEvent.PictureName);
                this.pictureBox.Visible = true;
            }
            else
            {
                this.pictureBox.Image = null;
                this.pictureBox.Visible = false;
            }
            this.eventPanel.BackColor = System.Drawing.Color.Silver;
            this.addEventPanel.Visible = false;
            this.buttonsPanel.Enabled = true;
            this.allEventsPanel.Enabled = true;
            this.done = null;
        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            this.done = this.addEventBtn;
            this.addEventPanel.Visible = true;
            this.buttonsPanel.Enabled = true;
            this.allEventsPanel.Enabled = false;
            this.pictureBox.Visible = false;
            /*this.eventTitleLabel.Text = "";
            this.timeLabel.Text = "";
            this.modifiedTimeLabel.Text = "";*/
            this.eventTitleTextBox.Text = "";
            this.eventDetailsTextBox.Text = "";
            this.pictureNameLabel.Text = "Picture: ";
        }

        private void modifyEventBtn_Click(object sender, EventArgs e)
        {
            this.done = this.modifyEventBtn;
            this.addEventPanel.Visible = true;
            this.buttonsPanel.Enabled = true;
            this.allEventsPanel.Enabled = false;
            this.pictureBox.Visible = false;
            /*this.eventTitleLabel.Text = "";
            this.timeLabel.Text = "";
            this.modifiedTimeLabel.Text = "";*/
            this.eventTitleTextBox.Text = selectedEvent.Title;
            this.eventDetailsTextBox.Text = selectedEvent.Details;
            this.importanceComboBox.SelectedIndex = selectedEvent.Importance;
            this.pictureNameLabel.Text = "Picture: " + selectedEvent.PictureName;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            string personName = this.personName;
            string title = eventTitleTextBox.Text;
            string details = eventDetailsTextBox.Text;
            byte importance = (byte)this.importanceComboBox.SelectedIndex;
            string pictureName = this.pictureName;

            if (personName == "" || title == "" || details == "")
            {
                MessageBox.Show("You have to fill up all the fields");
                return;
            }
            else if (details.Length >= 800)
            {
                MessageBox.Show("Too long details. Please make it within 800 character");
                return;
            }
            
            if(this.done == this.addEventBtn)
            {
                if (AddNewEvent(personName, title, details, importance, pictureName) > 0)
                {
                    MessageBox.Show("Event added to diary successfully...");
                }
                else
                {
                    MessageBox.Show("Error adding event to your diary");
                }
            }
            else if(this.done == this.modifyEventBtn)
            {
                if (ModifyEvent(this.selectedEvent.Id, personName, title, details, importance, pictureName) > 0)
                {
                    MessageBox.Show("Event modified successfully...");
                }
                else
                {
                    MessageBox.Show("Error adding event to your diary");
                }
            }
        }

        private int AddNewEvent(string personName, string title, string details, byte importance, string pictureName)
        {
            EventService eventService = new EventService();
            int result = eventService.AddNewEvent(personName, title, details, importance, pictureName);
            return result;
        }

        private int ModifyEvent(int id, string personName, string title, string details, byte importance, string pictureName)
        {
            EventService eventService = new EventService();
            int result = eventService.ModifyEvent(id, personName, title, details, importance, pictureName);
            return result;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.addEventPanel.Visible = false;
            this.addEventBtn.Enabled = true;
            this.allEventsPanel.Enabled = true;
        }

        private void removeEventBtn_Click(object sender, EventArgs e)
        {
            if (RemoveEvent(selectedEvent.Id) > 0)
            {
                MessageBox.Show("Event removes successfully");
                this.timeLabel.Text = "";
                this.modifiedTimeLabel.Text = "";
                this.eventTitleLabel.Text = "";
                this.eventDetailsLabel.Text = "";
                this.pictureBox.Image = null;
                this.selectedEvent = null;
                this.removeEventBtn.Enabled = false;
                this.importanceBtn.Enabled = false;
                this.modifyEventBtn.Enabled = false;
            }
        }

        private int RemoveEvent(int id)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove event", "Delete Confirmation!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EventService eventService = new EventService();
                int result = eventService.RemoveEvent(id);
                return result;
            }
            else
            {
                return 0;
            }

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void addImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.pictureName = open.FileName;
                this.pictureNameLabel.Text = "Picture: " + open.FileName;
            }
        }
    }
}
