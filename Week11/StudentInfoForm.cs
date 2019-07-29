using System;
using System.IO;
using System.Windows.Forms;

namespace Week11
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void StudentInfoForm_Activated(object sender, EventArgs e)
        {
            try
            {
                //open your stream to read
                using (StreamReader inputStream = 
                    new StreamReader(File.Open("Student.txt", FileMode.Open)))
            {
                //reading stuff to file
                Program.student.FirstName = inputStream.ReadLine();
                Program.student.studentId = inputStream.ReadLine();
                Program.student.LastName = inputStream.ReadLine();
                
                //Close file
                inputStream.Close();
                //Dispose of memory
                inputStream.Dispose();

                    // Write info from  student object to form labels
                    LastNameDataLabel.Text = Program.student.LastName;
                    FirstNameDataLabel.Text = Program.student.FirstName;
                    DataLabel.Text = Program.student.studentId;
            }

            }
            catch (IOException exception)
            {

                MessageBox.Show("Error: " + exception.Message, "File I/O Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }

        private void StudentInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
