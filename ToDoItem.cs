using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseProject;

namespace TODOList
{
    public partial class ToDoItem : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public bool newItem = true;
        public int itemID;
        public string title = "";
        public string text = "";
        public DateTime deadline;

        public ToDoItem()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string objTitle = txtTitle.Text;
            string objText = txtToDo.Text;
            DateTime objDeadline = deadlinePicker.Value;
            


            if (objTitle.Equals(""))
            {
                MessageBox.Show("Please enter a Title");

            }
            else
            {

                SqlCommand insertCommand;
                
                insertCommand = new SqlCommand("insert into ToDoItems(Title, Text, Deadline) values(@title, @text, @deadline)");
                insertCommand.Parameters.AddWithValue("@title", objTitle);
                insertCommand.Parameters.AddWithValue("@text", objText);
                insertCommand.Parameters.AddWithValue("@deadline", objDeadline);
                



                int row = objDBAccess.executeQuery(insertCommand);

                if(row == 1)
                {
                    MessageBox.Show("Saved");

                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }
    }
}
