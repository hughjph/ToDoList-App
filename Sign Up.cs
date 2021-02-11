using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseProject;

namespace TODOList
{

    

    public partial class Form1 : Form
    {
        DBAccess objDBAccess = new DBAccess();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            /*
            string username = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;            string country = txtCountry.Text;

            if (username.Equals(""))
            {
                MessageBox.Show("Please enter your user name.");
            }
            else if (email.Equals(""))
            {
                MessageBox.Show("Please enter your email.");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Please enter your password.");
            }
            else if (country.Equals("-Please Select A Country-"))
            {
                MessageBox.Show("Please enter your country.");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Users(Name,Email,Password,Country) values(@username, @email, @password, @country)");
                insertCommand.Parameters.AddWithValue("@userName", username);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@password", password);
                insertCommand.Parameters.AddWithValue("@country", country);

                int row = objDBAccess.executeQuery(insertCommand);

                if(row == 1)
                {
                    MessageBox.Show("Account Created Successfully");

                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'toDoItems._ToDoItems' table. You can move, or remove it, as needed.
            this.toDoItemsTableAdapter.Fill(this.toDoItems._ToDoItems);

        }

        private void newItembtn_Click(object sender, EventArgs e)
        {
            ToDoItem tdItem = new ToDoItem();
            tdItem.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NoteTakingApp;Integrated Security=True");
            SqlDataReader dr;
            SqlCommand cmd;


            ToDoItem tdItem = new ToDoItem();


            con.Open();

            int index = toDoItemList.CurrentCell.RowIndex;
            if(index > -1)
            {
                Console.WriteLine(toDoItemList.Rows[index].ToString());
            }

            index += 1;

            cmd = new SqlCommand("SELECT Title, Text, Deadline FROM ToDoItems WHERE ID = " + index, con);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Console.WriteLine(dr[0].ToString());
                Console.WriteLine(dr[1].ToString());
                Console.WriteLine(dr[2].ToString());
                tdItem.itemID = index;
                tdItem.title = dr[0].ToString();
                tdItem.text = dr[1].ToString();
                tdItem.deadline = Convert.ToDateTime(dr[2]);
                tdItem.txtTitle.Text = dr[0].ToString();
                tdItem.txtToDo.Text = dr[1].ToString();
                tdItem.deadlinePicker.Value = Convert.ToDateTime(dr[2]);
                tdItem.Show();
            }

        }
    }
}
