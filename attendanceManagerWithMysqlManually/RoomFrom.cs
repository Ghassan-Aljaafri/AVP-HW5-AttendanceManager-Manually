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
    public partial class RoomFrom : Form
    {
        public string id = "";
        public RoomFrom()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            DBOperations.query = "SELECT * FROM attendance_manager.rooms";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            roomDGV.DataSource = DBOperations.Execute(DBOperations.cmd);
            Reset();
        }

        private void Reset()
        {
            roomNameTextBox.Text = "";
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            DBOperations.query = "INSERT INTO attendance_manager.rooms (`name`) VALUES (@name);";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            DBOperations.cmd.Parameters.Clear();
            DBOperations.cmd.Parameters.AddWithValue("name", roomNameTextBox.Text.Trim());
            DBOperations.Execute(DBOperations.cmd);
            roomDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT * FROM attendance_manager.rooms", DatabaseConnection.getConnection()));
            Reset();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DBOperations.query = "UPDATE attendance_manager.rooms SET `name` = @name WHERE `rooms`.`id` = @id; ";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            DBOperations.cmd.Parameters.Clear();
            DBOperations.cmd.Parameters.AddWithValue("id", this.id);
            DBOperations.cmd.Parameters.AddWithValue("name", roomNameTextBox.Text.Trim());
            DBOperations.Execute(DBOperations.cmd);
            roomDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT * FROM attendance_manager.rooms", DatabaseConnection.getConnection()));
            Reset();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DBOperations.query = "DELETE FROM attendance_manager.rooms WHERE `rooms`.`id` = @id ";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            DBOperations.cmd.Parameters.Clear();
            DBOperations.cmd.Parameters.AddWithValue("id", this.id);
            DBOperations.Execute(DBOperations.cmd);
            roomDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT * FROM attendance_manager.rooms", DatabaseConnection.getConnection()));
            Reset();
        }

        private void roomDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = roomDGV.CurrentRow.Cells[0].Value.ToString();
            roomNameTextBox.Text = roomDGV.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
