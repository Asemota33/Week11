using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the mainforms closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the exit menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBox.ShowDialog();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDatabaseDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.testDatabaseDataSet.StudentTable);

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.studentInfoForm.Show();
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            studentSaveFileDialog.FileName = "Student.txt";
            studentSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            studentSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open file dialog - Modal Form
            var result = studentSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                //open file to write
                using (StreamWriter outputStream = new StreamWriter
                    (File.Open(studentSaveFileDialog.FileName, FileMode.Create)))
                {
                    //writing stuff to file

                    outputStream.WriteLine(Program.student.studentId);
                    outputStream.WriteLine(Program.student.FirstName);
                    outputStream.WriteLine(Program.student.LastName);
                    //Close file
                    outputStream.Close();
                    //Dispose of memory
                    outputStream.Dispose();
                }
                MessageBox.Show("File Saved", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void studentTableDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // aliases
            var rowIndex = studentTableDataGridView.CurrentCell.RowIndex;
            var rows = studentTableDataGridView.Rows;
            var cells = rows[rowIndex].Cells;
            var columnCount = studentTableDataGridView.ColumnCount;

            studentTableDataGridView.Rows[rowIndex].Selected = true;

            string outputString = string.Empty;
            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value.ToString() + " ";
            }
            selectionLabel.Text = outputString;

            //Program.student.id = int.Parse(cells[(int)StudentField.ID].Value.ToString());
            Program.student.studentId = cells[(int)StudentField.STUDENT_ID].Value.ToString();
            Program.student.FirstName = cells[(int)StudentField.FIRST_NAME].Value.ToString();
            Program.student.LastName = cells[(int)StudentField.LAST_NAME].Value.ToString();
        }
    }
}
