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
        
        SqlConnection con;
        SqlDataAdapter DataAdapter;
        SqlDataReader dr;
        SqlCommand cmd;
        ToDoItem tdItem = new ToDoItem();


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'toDoItems._ToDoItems' table. You can move, or remove it, as needed.
            this.toDoItemsTableAdapter.Fill(this.toDoItems._ToDoItems);
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NoteTakingApp;Integrated Security=True");
            DataAdapter = new SqlDataAdapter();
        }


        void ReloadForm()
        {
            this.toDoItemsTableAdapter.Fill(this.toDoItems._ToDoItems);

        }

        


        public int GetSelectedItem()
        {
            int ItemID;
            int rowNum = toDoItemList.CurrentCell.RowIndex;
            ItemID = Convert.ToInt32(toDoItemList.Rows[rowNum].Cells[0].Value);
            return ItemID;
        }



        private void newItembtn_Click(object sender, EventArgs e)
        {
            tdItem.itemID = 0;
            tdItem.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                int ItemID = GetSelectedItem();

                cmd = new SqlCommand("SELECT Title, Text, Deadline FROM ToDoItems WHERE ID = " + ItemID, con);
                dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    tdItem.itemID = ItemID;
                    tdItem.title = dr[0].ToString();
                    tdItem.text = dr[1].ToString();
                    tdItem.deadline = Convert.ToDateTime(dr[2]);
                    tdItem.txtTitle.Text = dr[0].ToString();
                    tdItem.txtToDo.Text = dr[1].ToString();
                    tdItem.deadlinePicker.Value = Convert.ToDateTime(dr[2]);
                    tdItem.Show();
                    this.Hide();
                }
                
            }
            catch
            {
                MessageBox.Show("Please Select An Item");
            }
            
        }

        private void toDoItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                int ItemIDInt = GetSelectedItem();
                int index = toDoItemList.CurrentCell.RowIndex;
                if (index > -1)
                {
                    Console.WriteLine(toDoItemList.Rows[index].ToString());
                    Console.WriteLine(toDoItemList.Rows[index].Cells[0].Value);
                    ItemIDInt = Convert.ToInt32(toDoItemList.Rows[index].Cells[0].Value);

                    cmd = new SqlCommand("DELETE FROM ToDoItems Where ID = " + ItemIDInt, con);
                    DataAdapter.UpdateCommand = cmd;
                    DataAdapter.UpdateCommand.ExecuteNonQuery();
                    ReloadForm();
                }

            }
            catch
            {
                MessageBox.Show("Please Select An Item");
            }
            con.Close();
        }
    }
}
