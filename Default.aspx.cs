using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)     // Load this two lines of code only when the app is not loaded by okButton_Click
            {
                firstTextBox.Text = "M/D/YYYY";
                secondTextBox.Text = "M/D/YYYY";
            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {

         
           if(firstCalendar.SelectedDate > secondCalendar.SelectedDate)
            {
                result2Label.Text = firstCalendar.SelectedDate.Subtract(secondCalendar.SelectedDate).TotalDays.ToString();
            }
            else
            {
                result2Label.Text = secondCalendar.SelectedDate.Subtract(firstCalendar.SelectedDate).TotalDays.ToString();
            }
           
        }

        protected void firstTextBox_TextChanged(object sender, EventArgs e)
        {
            string first = firstTextBox.Text;
            //DateTime myvalue = DateTime.Parse(first);
            firstCalendar.SelectedDate = DateTime.Parse(first);
             firstCalendar.VisibleDate = firstCalendar.SelectedDate;
         
        }

        protected void secondTextBox_TextChanged(object sender, EventArgs e)
        {
            string second = secondTextBox.Text;
            secondCalendar.SelectedDate = DateTime.Parse(second);
            secondCalendar.VisibleDate = secondCalendar.SelectedDate;
        }
    }
}