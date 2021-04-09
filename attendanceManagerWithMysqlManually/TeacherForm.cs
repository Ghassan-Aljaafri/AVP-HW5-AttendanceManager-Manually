using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using attendanceManagerWithMysqlManually.DataBase;

namespace attendanceManagerWithMysqlManually
{
    public partial class TeacherForm : Form
    {
        public string id = "";
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            DBOperations.query = "SELECT * FROM attendance_manager.teachers";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            techerDGV.DataSource = DBOperations.Execute(DBOperations.cmd);
            Reset();
        }
        private void Reset()
        {
            teacherNameTextBox.Text = "";
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            DBOperations.query = "INSERT INTO attendance_manager.teachers (`name`) VALUES (@name);";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            DBOperations.cmd.Parameters.Clear();
            DBOperations.cmd.Parameters.AddWithValue("name", teacherNameTextBox.Text.Trim());
            DBOperations.Execute(DBOperations.cmd);
            techerDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT * FROM attendance_manager.teachers", DatabaseConnection.getConnection()));
            Reset();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DBOperations.query = "UPDATE attendance_manager.teachers SET `name` = @name WHERE `teachers`.`id` = @id;";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            DBOperations.cmd.Parameters.Clear();
            DBOperations.cmd.Parameters.AddWithValue("id", this.id);
            DBOperations.cmd.Parameters.AddWithValue("name", teacherNameTextBox.Text.Trim());
            DBOperations.Execute(DBOperations.cmd);
            techerDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT * FROM attendance_manager.teachers", DatabaseConnection.getConnection()));
            Reset();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DBOperations.query = "DELETE FROM attendance_manager.teachers WHERE `teachers`.`id` = @id ";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            DBOperations.cmd.Parameters.Clear();
            DBOperations.cmd.Parameters.AddWithValue("id", this.id);
            DBOperations.Execute(DBOperations.cmd);
            techerDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT * FROM attendance_manager.teachers", DatabaseConnection.getConnection()));
            Reset();
        }

        private void techerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = techerDGV.CurrentRow.Cells[0].Value.ToString();
            teacherNameTextBox.Text = techerDGV.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
