using System;
using System.Data;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;


        private void ToDoList_Load(object sender, EventArgs e)
        {
            // Create column
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            // point our datagridview to out datasource
            toDoListView.DataSource = todoList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            // everytime we click new, we clear the text fields
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;

            // Fill text fields with data from table
            titleTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // the try catch is added to avoid scenarios where the actual item may or may not be present there, and to avoid crashes
            try
            {
                // to delete the entire row
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                //if the entry already exists inside the grid, then use it to update the title and descriptions
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;
            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text, descriptionTextBox.Text);
            }

            // clear out fields after save
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            isEditing = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
