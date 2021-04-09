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
    public partial class AttendanceForm : Form
    {
        public string id = "";
        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            DBOperations.query = "SELECT attendance_management.id, courses.name AS Course, rooms.name AS Room, teachers.name AS Teacher, attendance_management.date, attendance_management.start_time, attendance_management.leave_time, attendance_management.comment FROM `attendance_manager`.`attendance_management`,`attendance_manager`.`teachers`,`attendance_manager`.`rooms`,`attendance_manager`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            attendanceDGV.DataSource = DBOperations.Execute(DBOperations.cmd);
            Fill_combo();
            Reset();
        }
        private void Reset()
        {
            dateDTP.Text = "";
            startTP.Text = "";
            leaveTP.Text = "";
            teacherCombo.SelectedIndex = -1;
            teacherCombo.ResetText();
            courseCombo.SelectedIndex = -1;
            courseCombo.ResetText();
            roomCombo.SelectedIndex = -1;
            roomCombo.ResetText();
            commentNameTextBox.Text = "";
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            DBOperations.query = "INSERT INTO attendance_manager.attendance_management (`date`, `start_time`, `leave_time`, `teacher_id`, `room_id`, `course_id`, `comment`) VALUES (@date, @start_time, @leave_time, @teacher_id, @room_id, @course_id, @comment);";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            DBOperations.cmd.Parameters.Clear();
            DBOperations.cmd.Parameters.AddWithValue("date", dateDTP.Text.Trim());
            DBOperations.cmd.Parameters.AddWithValue("start_time", startTP.Text.Trim());
            DBOperations.cmd.Parameters.AddWithValue("leave_time", leaveTP.Text.Trim());
            DBOperations.cmd.Parameters.AddWithValue("teacher_id", teacherCombo.SelectedValue.ToString());
            DBOperations.cmd.Parameters.AddWithValue("room_id", roomCombo.SelectedValue.ToString());
            DBOperations.cmd.Parameters.AddWithValue("course_id", courseCombo.SelectedValue.ToString());
            DBOperations.cmd.Parameters.AddWithValue("comment", commentNameTextBox.Text.Trim());
            DBOperations.Execute(DBOperations.cmd);
            attendanceDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `attendance_manager`.`attendance_management`,`attendance_manager`.`teachers`,`attendance_manager`.`rooms`,`attendance_manager`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id", DatabaseConnection.getConnection()));
        }

        private void attendanceDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Reset();
            this.id = attendanceDGV.CurrentRow.Cells[0].Value.ToString();
            courseCombo.SelectedIndex = courseCombo.FindString(attendanceDGV.CurrentRow.Cells[1].Value.ToString());
            roomCombo.SelectedIndex = roomCombo.FindString(attendanceDGV.CurrentRow.Cells[2].Value.ToString());
            teacherCombo.SelectedIndex = teacherCombo.FindString(attendanceDGV.CurrentRow.Cells[3].Value.ToString());
            dateDTP.Value = DateTime.Parse(attendanceDGV.CurrentRow.Cells[4].Value.ToString());
            startTP.Value = DateTime.Parse(attendanceDGV.CurrentRow.Cells[5].Value.ToString());
            leaveTP.Value = DateTime.Parse(attendanceDGV.CurrentRow.Cells[6].Value.ToString());
            commentNameTextBox.Text = attendanceDGV.CurrentRow.Cells[7].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DBOperations.query = "UPDATE attendance_manager.attendance_management SET `date` = @date, `start_time` = @start_time, `leave_time` = @leave_time, `teacher_id` = @teacher_id, `room_id` = @room_id, `course_id` = @course_id, `comment` = @comment WHERE `attendance_management`.`id` = @id; ";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            DBOperations.cmd.Parameters.Clear();
            DBOperations.cmd.Parameters.AddWithValue("id", this.id);
            DBOperations.cmd.Parameters.AddWithValue("date", dateDTP.Text.Trim());
            DBOperations.cmd.Parameters.AddWithValue("start_time", startTP.Text.Trim());
            DBOperations.cmd.Parameters.AddWithValue("leave_time", leaveTP.Text.Trim());
            DBOperations.cmd.Parameters.AddWithValue("teacher_id", teacherCombo.SelectedValue.ToString());
            DBOperations.cmd.Parameters.AddWithValue("room_id", roomCombo.SelectedValue.ToString());
            DBOperations.cmd.Parameters.AddWithValue("course_id", courseCombo.SelectedValue.ToString());
            DBOperations.cmd.Parameters.AddWithValue("comment", commentNameTextBox.Text.Trim());
            DBOperations.Execute(DBOperations.cmd);
            attendanceDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `attendance_manager`.`attendance_management`,`attendance_manager`.`teachers`,`attendance_manager`.`rooms`,`attendance_manager`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id", DatabaseConnection.getConnection()));
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DBOperations.query = "DELETE FROM attendance_manager.attendance_management WHERE `attendance_management`.`id` = @id  ";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            DBOperations.cmd.Parameters.Clear();
            DBOperations.cmd.Parameters.AddWithValue("id", this.id);
            DBOperations.Execute(DBOperations.cmd);
            attendanceDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `attendance_manager`.`attendance_management`,`attendance_manager`.`teachers`,`attendance_manager`.`rooms`,`attendance_manager`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id", DatabaseConnection.getConnection()));
        }
        private void Fill_combo()
        {
            DBOperations.query = "SELECT * FROM attendance_manager.teachers";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            teacherCombo.ValueMember = "id";
            teacherCombo.DisplayMember = "name";
            DataTable dt_teacher = DBOperations.Execute(DBOperations.cmd);
            teacherCombo.DataSource = dt_teacher;
            DBOperations.query = "SELECT * FROM attendance_manager.courses";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            courseCombo.ValueMember = "id";
            courseCombo.DisplayMember = "name";
            DataTable dt_course = DBOperations.Execute(DBOperations.cmd);
            courseCombo.DataSource = dt_course;
            DBOperations.query = "SELECT * FROM attendance_manager.rooms";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            roomCombo.ValueMember = "id";
            roomCombo.DisplayMember = "name";
            DataTable dt_room = DBOperations.Execute(DBOperations.cmd);
            roomCombo.DataSource = dt_room;
        }

        private void teacherTableBtn_Click(object sender, EventArgs e)
        {
            TeacherForm teacher = new TeacherForm();
            teacher.ShowDialog();
            Fill_combo();
            DBOperations.query = "DELETE FROM attendance_manager.attendance_management WHERE teacher_id NOT IN (SELECT teachers.id FROM attendance_manager.teachers)";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            attendanceDGV.DataSource = DBOperations.Execute(DBOperations.cmd);
            attendanceDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `attendance_manager`.`attendance_management`,`attendance_manager`.`teachers`,`attendance_manager`.`rooms`,`attendance_manager`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id", DatabaseConnection.getConnection()));
            Reset();
        }

        private void roomTableBtn_Click(object sender, EventArgs e)
        {
            RoomFrom room = new RoomFrom();
            room.ShowDialog();
            Fill_combo();
            DBOperations.query = "DELETE FROM attendance_manager.attendance_management WHERE room_id NOT IN (SELECT rooms.id FROM attendance_manager.rooms)";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            attendanceDGV.DataSource = DBOperations.Execute(DBOperations.cmd);
            attendanceDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `attendance_manager`.`attendance_management`,`attendance_manager`.`teachers`,`attendance_manager`.`rooms`,`attendance_manager`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id", DatabaseConnection.getConnection()));
            Reset();
        }

        private void courseTableBtn_Click(object sender, EventArgs e)
        {
            CourseForm course = new CourseForm();
            course.ShowDialog();
            Fill_combo();
            DBOperations.query = "DELETE FROM attendance_manager.attendance_management WHERE course_id NOT IN (SELECT courses.id FROM attendance_manager.courses)";
            DBOperations.cmd = new MySqlCommand(DBOperations.query, DatabaseConnection.getConnection());
            attendanceDGV.DataSource = DBOperations.Execute(DBOperations.cmd);
            attendanceDGV.DataSource = DBOperations.Execute(DBOperations.cmd = new MySqlCommand(DBOperations.query = "SELECT attendance_management.id,courses.name AS Course,rooms.name AS Room,teachers.name AS Teacher,attendance_management.date,attendance_management.start_time,attendance_management.leave_time FROM `attendance_manager`.`attendance_management`,`attendance_manager`.`teachers`,`attendance_manager`.`rooms`,`attendance_manager`.`courses` WHERE teachers.id = attendance_management.teacher_id AND rooms.id = attendance_management.room_id AND courses.id = attendance_management.course_id", DatabaseConnection.getConnection()));
            Reset();
        }
    }
}
