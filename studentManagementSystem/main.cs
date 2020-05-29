using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManagementSystem
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new addStudentForm().Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new studentList().Show();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new staticsForm().Show();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new updateDeleteStudent().Show();
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new manageStudentForm().Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new studentPrintForm().Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new addCourseForm().Show();
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new removeCourseForm().Show();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new editCourseForm().Show();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new editCourseForm().Show();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new printCourse().Show();
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new removeCourseForm().Show();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new manageScoreForm().Show();
        }

        private void avgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new avgScoreByCourse().Show();
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new printCourse().Show();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new addScore().Show();
        }

        private void sTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
