using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Congratulate_BTN_Click(object sender, EventArgs e)
        {
            //now let's get the names from the textboxes
            string name1 = "";
            string name2 = "";
            string name3 = "";
            //let's put the name fetch inot a try block for security purposes
            try
            {
                //let's make sure the input for the first name is not empty
                if (Name1_TB.Text == "")
                {
                    //if so show a message box indicating the issue
                    MessageBox.Show("Error! Textbox for the first person's name cannot be empty! Try again!");
                    //return the method to skip the rest of the method
                    return;
                }
                else
                {
                    //let's make sure the name is all upper case
                    name1 = Name1_TB.Text.ToUpper();
                }
                    
                //let's make sure the input for the second name is not empty
                if (Name2_TB.Text == "")
                {
                    //show the message box with the error message
                    MessageBox.Show("Error! Textbox for the second person's name cannot be empty! Try again!");
                    //return the method to skip the rest of the method
                    return;
                }
                else
                {
                    //let's make sure the name is all upper case
                    name2 = Name2_TB.Text.ToUpper();
                }

                //let's make sure the input for the third name is not empty
                if (Name3_TB.Text == "")
                {
                    //show the error message in a message box
                    MessageBox.Show("Error! Textbox for the third person's name cannot be empty! Try again!");
                    //return the method to skip the rest of the method
                    return;
                }
                else
                {
                    //let's make sure the name is all upper case
                    name3 = Name3_TB.Text.ToUpper();
                }
            }
            //let's now catch any errors that happend to spring up in fetching the names
            catch
            {
                //show in message box that someting went wrong, that the input are invalid
                MessageBox.Show("Error! All or one of the names of the people is invalid! Please, try again!");
                //return the method to skip the rest of the method
                return;
            }


            //let's get today's date
            DateTime todaysDate = DateTime.Today;
            // let's assign the date object to a string variable
            string date = todaysDate.ToShortDateString();


            //let's now get the birthdates of each person
            DateTime birth_date1 = BirthDate1_TP.Value;
            DateTime birth_date2 = BirthDate2_TP.Value;
            DateTime birth_date3 = BirthDate3_TP.Value;

            //now we use the built-in method to get the total difference of days between the birthday
            //of each person and today's date; we will use the Parse method of Int to cut off the 
            //decimal part of the result and store the result to the respective textbox, with the name
            //included
            first_person_TB.Text = "Happy birthday, " + name1 + "! " +
                (Convert.ToInt32((todaysDate - birth_date1).TotalDays)).ToString() + " day(s) have passed since your birthday!";

            second_person_TB.Text = "Happy birthday, " + name2 + "! " +
                (Convert.ToInt32((todaysDate - birth_date2).TotalDays)).ToString() + " day(s) have passed since your birthday!";

            third_person_TB.Text = "Happy birthday, " + name3 + "! " +
                (Convert.ToInt32((todaysDate - birth_date3).TotalDays)).ToString() + " day(s) have passed since your birthday!";
        }
    }
}
