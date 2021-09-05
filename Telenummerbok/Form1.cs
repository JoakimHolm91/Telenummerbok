using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telenummerbok
{
    public partial class Form1 : Form
    {
        Phonebook phonebook = new Phonebook();

        public Form1()
        {
            this.BackgroundImage = Properties.Resources.phone_book;
            InitializeComponent();
        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            //Check if name is valid
            if(ValidateName(firstNameTxt.Text, lastNameTxt.Text))
            {
                //Check if number is valid
                if(ValidateNumber(numberTxt.Text)) {
                    //Add person to phonebook
                    phonebook.AddNewPerson(firstNameTxt.Text.Trim(), lastNameTxt.Text.Trim(), numberTxt.Text.Trim());
                    //Clear values in text boxes after adding a person
                    numberTxt.Clear();
                    firstNameTxt.Clear();
                    lastNameTxt.Clear();
                    FillListBox();
                }
            }
        }

        private void listPersonsBtn_Click(object sender, EventArgs e)
        {
            //Clears the listbox and fills with current persons phonebook arraylist
            FillListBox();
        }

        private void removePersonBtn_Click(object sender, EventArgs e)
        {
            //Remove selected person from listbox and phonebook array
            String [] personInfo = phonebookListBox.SelectedItem.ToString().Split(' ');
            phonebook.RemovePerson(personInfo[0], personInfo[1]);
            FillListBox();
        }
        private void FillListBox()
        {
            //Clear box of old data
            phonebookListBox.Items.Clear();
            //List all people in box
            foreach (Person p in phonebook.GetArrayList())
            {
                phonebookListBox.Items.Add($"{p.GetFirstName()} {p.GetLastName()} {p.GetPhoneNumber()}");
            }
        }

        public static String ShowDialog (String text, String caption)
        {
            //Create dialog window
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Width = 500, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            //Returns newly entered string value
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        private Boolean ValidateName(String firstName, String lastName)
        {
            //Check length of first name
            if (firstNameTxt.Text.Length < 3)
            {
                String promptValue = ShowDialog("Förnamn måste vara minst 3 bokstäver", "Felaktigt namn");
                firstNameTxt.Text = promptValue;
                return false;
            }
            //Check length of last name
            else if (lastNameTxt.Text.Length < 3)
            {
                String promptValue = ShowDialog("Efternamn måste vara minst 3 bokstäver", "Felaktigt namn");
                lastNameTxt.Text = promptValue;
                return false;
            }
            //Check if name already exists in phonebook
            foreach (Person p in phonebook.GetArrayList())
            {
                if (p.GetFirstName().ToLower().Equals(firstNameTxt.Text.ToLower().Trim()) && p.GetLastName().ToLower().Equals(lastNameTxt.Text.ToLower().Trim()))
                {
                    String promptValue = ShowDialog("Namnet finns redan inlagt", "Existerande namn");
                    String[] newName = promptValue.Split(' ');
                    if (newName.Length > 1)
                    {
                        firstNameTxt.Text = newName[0];
                        lastNameTxt.Text = newName[1];
                    }
                    else
                    {
                        firstNameTxt.Clear();
                        lastNameTxt.Clear();
                    }
                    return false;
                }
            }
            return true;
        }
        private Boolean ValidateNumber(String number)
        {
            //Regex for swedish phone number
            Regex numberRx = new Regex(@"^(([+]46)\s*(7)|07)[02369]\s*(\d{4})\s*(\d{3})$");
            try
            {
                if(numberRx.IsMatch(number))
                {
                    return true;
                } 
                else
                {
                    String promptValue = ShowDialog("Numret är inte ett korrekt svenskt nummer EX: 0731234567", "Felaktigt nummer");
                    numberTxt.Text = promptValue;
                    return false;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return false;
            }
            
        }
    }
}
