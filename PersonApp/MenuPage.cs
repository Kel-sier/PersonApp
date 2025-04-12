using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApp
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from text boxes
                string name = txtName.Text;
                int age = Convert.ToInt32(txtAge.Text);
                string address = txtAddress.Text;

                // Create a Person object
                Person person = new Person(name, age, address);

                // Display details in the list box
                lstDetails.Items.Add(person.GetDetails());

                // Clear the text boxes after adding
                ClearTextBoxes();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid age (numbers only).", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from text boxes
                string name = txtName.Text;
                int age = Convert.ToInt32(txtAge.Text);
                string address = txtAddress.Text;
                string studentID = txtStudentID.Text;

                if (string.IsNullOrWhiteSpace(studentID))
                {
                    MessageBox.Show("Please enter a Student ID.", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create a Student object
                Student student = new Student(name, age, address, studentID);

                // Display details in the list box
                lstDetails.Items.Add(student.GetDetails());

                // Clear the text boxes after adding
                ClearTextBoxes();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid age (numbers only).", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            txtName.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtStudentID.Clear();
            txtName.Focus();
        }
    }
}
