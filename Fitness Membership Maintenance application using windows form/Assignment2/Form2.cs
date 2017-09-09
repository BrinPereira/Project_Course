using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form2 : Form
    {
        Form1 p_form;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form) : this()
        {
                p_form = form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    
    // method for save button. after saving , data is tranfer to member Maintianence form.
        private void btn_save_Click(object sender, EventArgs e)
        {
            Member m = new Member();

            // checking validation for FirstName.
            if (!Validator.IsPresent(txtFirstName))
                return;
            else
                m.FirstName = txtFirstName.Text;

            // checking validation for LasttName.
            if (!Validator.IsPresent(txtLastName))
                return;
            else
                m.LastName = txtLastName.Text;

            // checking validation for Email.
            if (Validator.IsPresent(txtEmail))
               {
                if (Validator.IsValidEmail(txtEmail))
                    m.Email = txtEmail.Text;
                else
                {
                    txtEmail.Clear();
                    return;
                }
            }
            p_form.memberlist += m;
            Close();
        }

    // method for button cancel.
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
