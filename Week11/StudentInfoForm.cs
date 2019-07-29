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
        
            // Write info from  student object to form labels
            LastNameDataLabel.Text = Program.student.LastName;
            FirstNameDataLabel.Text = Program.student.FirstName;
            DataLabel.Text = Program.student.studentId;
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
