using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bai05
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addNew_Menu_Click(object sender, EventArgs e)
        {
            addNew_Click(sender, e);
        }

        private void exit_Menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int count = 1;
        public student newStudent;

        private void addNew_Click(object sender, EventArgs e)
        {
            addNew_Form addStudent = new addNew_Form();
            this.Hide();
            addStudent.ShowDialog();
            if (addStudent.newStudent != null)
                studentInfoList.Rows.Add(count++.ToString(), addStudent.newStudent.ID, addStudent.newStudent.name, addStudent.newStudent.apartment, addStudent.newStudent.score.ToString());
            this.Show();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchBox.Text.ToLower();

            foreach (DataGridViewRow row in studentInfoList.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    string name = row.Cells[2].Value.ToString().ToLower();
                    row.Visible = name.Contains(keyword);
                }
            }
        }
    }
}

