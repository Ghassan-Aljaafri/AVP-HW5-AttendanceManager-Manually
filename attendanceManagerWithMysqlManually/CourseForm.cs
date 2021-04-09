using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using attendanceManagerWithMysqlManually.DataBase;

namespace attendanceManagerWithMysqlManually
{
    public partial class CourseForm : Form

    {
        public string id = "";
        public CourseForm()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            courseNameTextBox.Text = "";
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            DBOperations.query = "SELECT * FROM attendance_manager.courses";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            courseDGV.DataSource = DBOperations.Execute(DBOperations.cmd);
            Reset();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            DBOperations.query = "INSERT INTO attendance_manager.courses (`name`) VALUES (@name);";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            DBOperations.cmd.Parameters.Clear();
            DBOperations.cmd.Parameters.AddWithValue("name", courseNameTextBox.Text.Trim());
            DBOperations.Execute(DBOperations.cmd);
            courseDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT * FROM attendance_manager.courses", DatabaseConnection.getConnection()));
            Reset();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DBOperations.query = "UPDATE attendance_manager.courses SET `name` = @name WHERE `courses`.`id` = @id; ";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            DBOperations.cmd.Parameters.Clear();
            DBOperations.cmd.Parameters.AddWithValue("id", this.id);
            DBOperations.cmd.Parameters.AddWithValue("name", courseNameTextBox.Text.Trim());
            DBOperations.Execute(DBOperations.cmd);
            courseDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT * FROM attendance_manager.courses", DatabaseConnection.getConnection()));
            Reset();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DBOperations.query = "DELETE FROM attendance_manager.courses WHERE `courses`.`id` = @id ";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            DBOperations.cmd.Parameters.Clear();
            DBOperations.cmd.Parameters.AddWithValue("id", this.id);
            DBOperations.Execute(DBOperations.cmd);
            courseDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT * FROM attendance_manager.courses", DatabaseConnection.getConnection()));
            Reset();
        }

        private void courseDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = courseDGV.CurrentRow.Cells[0].Value.ToString();
            courseNameTextBox.Text = courseDGV.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
