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
    public partial class Form1 : Form
    {
       public  MembershipList memberlist = new MembershipList();

        public Form1()
        {
            InitializeComponent();
        }
        
// operation for Add button on the form.
        private void addButton_Click(object sender, EventArgs e)
        {
            // opens new form which displays values to be enter
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

 // operation for delete button on the form.
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int i = listMembers.SelectedIndex;
            if(i!=-1)
            {
                Member m = memberlist[i];
                // confirmation before deleting the data.
                string message = "Are you sure you want to delete " + m.GetDisplayText() + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if(button == DialogResult.Yes)
                {
                    memberlist -= m;
                }
            }
        }

  // operation for exit button on form. 
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

  // operation when form is loaded.
        private void Form1_Load(object sender, EventArgs e)
        {
            //memberlist.changed += new MembershipList.changeHandler(handleChange);
            memberlist.write();
            fillMembersListBox();

            // wire event handler using lambda expression for adding members.
            memberlist.changed += memberlist =>
            {
                handleChange(memberlist);
            };
            
        }

  // method for handling change in the event.
        private void handleChange(MembershipList listMembers)
        {
           listMembers.save();
            fillMembersListBox();
        }

  // method to display values in ListBox.
        private void fillMembersListBox()
        {
            Member m;
            listMembers.Items.Clear();
            for (int i = 0; i < memberlist.count; i++)
            {
                m = memberlist[i];
                listMembers.Items.Add(m.GetDisplayText());
            }
        }
    }
}
