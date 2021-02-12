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
        
        SqlConnection con;
        SqlDataAdapter DataAdapter;
        SqlDataReader dr;
        SqlCommand cmd;
        public bool newItem = true;
        public int? itemID;
        public string title = "";
        public string text = "";
        public DateTime deadline;
        Form1 MainPage;


        public ToDoItem()
        {
            InitializeComponent();
        }

        void InitializeVariables()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NoteTakingApp;Integrated Security=True");
            DataAdapter = new SqlDataAdapter();
            MainPage = new Form1();
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            InitializeVariables();

            string objTitle = txtTitle.Text;
            string objText = txtToDo.Text;
            DateTime objDeadline = deadlinePicker.Value;
            


            if (objTitle.Equals(""))
            {
                MessageBox.Show("Please enter a Title");

            } else if(itemID.Equals(0))
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NoteTakingApp;Integrated Security=True");
                try
                {
                    con.Open();
                    cmd = new SqlCommand("insert into ToDoItems(Title, Text, Deadline) values(@title, @text, @deadline)");
                    cmd.Parameters.AddWithValue("@title", objTitle);
                    cmd.Parameters.AddWithValue("@text", objText);
                    cmd.Parameters.AddWithValue("@deadline", objDeadline);


                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("WrittenData");

                    MessageBox.Show("Saved");
                    MainPage.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                try
                {        
                    con.Open();

                    cmd = new SqlCommand("UPDATE ToDoItems Set Title='" + objTitle + "' WHERE ID = " + itemID, con);
                    DataAdapter.UpdateCommand = cmd;
                    DataAdapter.UpdateCommand.ExecuteNonQuery();

                    cmd = new SqlCommand("UPDATE ToDoItems Set text='" + objText + "' WHERE ID = " + itemID, con);
                    DataAdapter.UpdateCommand = cmd;
                    DataAdapter.UpdateCommand.ExecuteNonQuery();

                    cmd = new SqlCommand($"UPDATE ToDoItems Set Deadline=@deadline WHERE ID = " + itemID, con);
                    cmd.Parameters.AddWithValue("@deadline", objDeadline);
                    DataAdapter.UpdateCommand = cmd;
                    DataAdapter.UpdateCommand.ExecuteNonQuery();

                    cmd.Dispose();
                    con.Close();

                    MessageBox.Show("Saved!");
                    MainPage.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Error!");
                }


            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            InitializeVariables();
            MainPage.Show();
            this.Hide();
        }
    }
}
