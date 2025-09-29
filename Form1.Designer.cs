namespace ToDoList
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            newButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            toDoListView = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.PowderBlue;
            label1.Font = new Font("Book Antiqua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(393, 104);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.Click += label1_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(25, 189);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(1719, 31);
            titleTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(25, 282);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(1719, 31);
            descriptionTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Book Antiqua", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 252);
            label2.Name = "label2";
            label2.Size = new Size(1719, 27);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Book Antiqua", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 156);
            label3.Name = "label3";
            label3.Size = new Size(1719, 30);
            label3.TabIndex = 4;
            label3.Text = "Title:";
            label3.Click += label3_Click;
            // 
            // newButton
            // 
            newButton.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newButton.Location = new Point(25, 359);
            newButton.Name = "newButton";
            newButton.Size = new Size(377, 74);
            newButton.TabIndex = 5;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // editButton
            // 
            editButton.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.Location = new Point(470, 359);
            editButton.Name = "editButton";
            editButton.Size = new Size(377, 74);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(913, 359);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(377, 74);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(1367, 359);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(377, 74);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            toDoListView.BackgroundColor = Color.White;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(25, 452);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 62;
            toDoListView.Size = new Size(1719, 567);
            toDoListView.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(470, 82);
            label4.Name = "label4";
            label4.Size = new Size(711, 27);
            label4.TabIndex = 10;
            label4.Text = "Make all your productivity dreams come true with the click of a button.\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(391, 35);
            label5.Name = "label5";
            label5.Size = new Size(40, 22);
            label5.TabIndex = 11;
            label5.Text = "TM";
            label5.Click += label5_Click;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1771, 1041);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(toDoListView);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "ToDoList";
            Text = "To Do List";
            Load += ToDoList_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label label2;
        private Label label3;
        private Button newButton;
        private Button editButton;
        private Button deleteButton;
        private Button saveButton;
        private DataGridView toDoListView;
        private Label label4;
        private Label label5;
    }
}
