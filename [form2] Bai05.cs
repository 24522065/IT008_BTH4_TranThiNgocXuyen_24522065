using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class addNew_Form: Form
    {
        public addNew_Form()
        {
            InitializeComponent();
        }
        public student newStudent;
        private void addNew_Form_Load(object sender, EventArgs e)
        {

        }
    
        bool isValidInfo()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtScore.Text))
                isValid = false;

            foreach (char c in txtID.Text)
                if (!char.IsDigit(c))
                {
                    isValid = false;
                    txtID.Text = "";
                    break;
                }

            foreach (char c in txtName.Text)
                if (char.IsDigit(c))
                {
                    isValid = false;
                    txtName.Text = "";
                    break;
                }

            double temp;
            if (!double.TryParse(txtScore.Text, out temp) || temp < 0 || temp > 10)
            {
                txtScore.Text = "";
                isValid = false;
            }

            return isValid;
        }

        private void addNew_Button_Click(object sender, EventArgs e)
        {
            if (isValidInfo()) 
            {
                newStudent = new student(
                    txtID.Text,
                    txtName.Text,
                    cbKhoa.Text,
                    double.Parse(txtScore.Text)
                );

                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng điền lại các thông tin bị sai hoặc chưa được điền");
            }
        }
    }
}
