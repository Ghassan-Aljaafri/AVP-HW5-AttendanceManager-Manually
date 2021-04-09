
namespace attendanceManagerWithMysqlManually
{
    partial class AttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.leaveTP = new System.Windows.Forms.DateTimePicker();
            this.startTP = new System.Windows.Forms.DateTimePicker();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.attendanceDGV = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.courseTableBtn = new System.Windows.Forms.Button();
            this.roomTableBtn = new System.Windows.Forms.Button();
            this.teacherTableBtn = new System.Windows.Forms.Button();
            this.courseCombo = new System.Windows.Forms.ComboBox();
            this.roomCombo = new System.Windows.Forms.ComboBox();
            this.teacherCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.teatcherNameLabel = new System.Windows.Forms.Label();
            this.leaveTimeLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.commentNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // leaveTP
            // 
            this.leaveTP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.leaveTP.Location = new System.Drawing.Point(606, 3);
            this.leaveTP.Name = "leaveTP";
            this.leaveTP.Size = new System.Drawing.Size(154, 23);
            this.leaveTP.TabIndex = 43;
            // 
            // startTP
            // 
            this.startTP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTP.Location = new System.Drawing.Point(355, 4);
            this.startTP.Name = "startTP";
            this.startTP.Size = new System.Drawing.Size(154, 23);
            this.startTP.TabIndex = 42;
            // 
            // dateDTP
            // 
            this.dateDTP.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDTP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDTP.Location = new System.Drawing.Point(110, 4);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(154, 23);
            this.dateDTP.TabIndex = 41;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(606, 127);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(154, 31);
            this.deleteBtn.TabIndex = 40;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // attendanceDGV
            // 
            this.attendanceDGV.AllowUserToAddRows = false;
            this.attendanceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attendanceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceDGV.Location = new System.Drawing.Point(15, 164);
            this.attendanceDGV.Name = "attendanceDGV";
            this.attendanceDGV.RowHeadersWidth = 62;
            this.attendanceDGV.Size = new System.Drawing.Size(724, 229);
            this.attendanceDGV.TabIndex = 39;
            this.attendanceDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendanceDGV_CellClick);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(355, 127);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(154, 31);
            this.updateBtn.TabIndex = 38;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(110, 127);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(154, 31);
            this.insertBtn.TabIndex = 37;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // courseTableBtn
            // 
            this.courseTableBtn.Location = new System.Drawing.Point(606, 64);
            this.courseTableBtn.Name = "courseTableBtn";
            this.courseTableBtn.Size = new System.Drawing.Size(154, 23);
            this.courseTableBtn.TabIndex = 36;
            this.courseTableBtn.Text = "Course Table";
            this.courseTableBtn.UseVisualStyleBackColor = true;
            this.courseTableBtn.Click += new System.EventHandler(this.courseTableBtn_Click);
            // 
            // roomTableBtn
            // 
            this.roomTableBtn.Location = new System.Drawing.Point(355, 64);
            this.roomTableBtn.Name = "roomTableBtn";
            this.roomTableBtn.Size = new System.Drawing.Size(154, 23);
            this.roomTableBtn.TabIndex = 35;
            this.roomTableBtn.Text = "Room Table";
            this.roomTableBtn.UseVisualStyleBackColor = true;
            this.roomTableBtn.Click += new System.EventHandler(this.roomTableBtn_Click);
            // 
            // teacherTableBtn
            // 
            this.teacherTableBtn.Location = new System.Drawing.Point(110, 64);
            this.teacherTableBtn.Name = "teacherTableBtn";
            this.teacherTableBtn.Size = new System.Drawing.Size(154, 23);
            this.teacherTableBtn.TabIndex = 34;
            this.teacherTableBtn.Text = "Teacher Table";
            this.teacherTableBtn.UseVisualStyleBackColor = true;
            this.teacherTableBtn.Click += new System.EventHandler(this.teacherTableBtn_Click);
            // 
            // courseCombo
            // 
            this.courseCombo.FormattingEnabled = true;
            this.courseCombo.Location = new System.Drawing.Point(606, 37);
            this.courseCombo.Name = "courseCombo";
            this.courseCombo.Size = new System.Drawing.Size(154, 21);
            this.courseCombo.TabIndex = 33;
            // 
            // roomCombo
            // 
            this.roomCombo.FormattingEnabled = true;
            this.roomCombo.Location = new System.Drawing.Point(355, 37);
            this.roomCombo.Name = "roomCombo";
            this.roomCombo.Size = new System.Drawing.Size(154, 21);
            this.roomCombo.TabIndex = 32;
            // 
            // teacherCombo
            // 
            this.teacherCombo.FormattingEnabled = true;
            this.teacherCombo.Location = new System.Drawing.Point(110, 37);
            this.teacherCombo.Name = "teacherCombo";
            this.teacherCombo.Size = new System.Drawing.Size(154, 21);
            this.teacherCombo.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Comment";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.Location = new System.Drawing.Point(515, 38);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(85, 16);
            this.courseLabel.TabIndex = 28;
            this.courseLabel.Text = "Course Name";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameLabel.Location = new System.Drawing.Point(271, 38);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(78, 16);
            this.roomNameLabel.TabIndex = 27;
            this.roomNameLabel.Text = "Room Name";
            // 
            // teatcherNameLabel
            // 
            this.teatcherNameLabel.AutoSize = true;
            this.teatcherNameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teatcherNameLabel.Location = new System.Drawing.Point(12, 42);
            this.teatcherNameLabel.Name = "teatcherNameLabel";
            this.teatcherNameLabel.Size = new System.Drawing.Size(92, 16);
            this.teatcherNameLabel.TabIndex = 26;
            this.teatcherNameLabel.Text = "Teacher Name";
            // 
            // leaveTimeLabel
            // 
            this.leaveTimeLabel.AutoSize = true;
            this.leaveTimeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveTimeLabel.Location = new System.Drawing.Point(515, 10);
            this.leaveTimeLabel.Name = "leaveTimeLabel";
            this.leaveTimeLabel.Size = new System.Drawing.Size(74, 16);
            this.leaveTimeLabel.TabIndex = 25;
            this.leaveTimeLabel.Text = "Leave Time";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLabel.Location = new System.Drawing.Point(270, 9);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(69, 16);
            this.startTimeLabel.TabIndex = 24;
            this.startTimeLabel.Text = "Start Time";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(12, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 16);
            this.dateLabel.TabIndex = 23;
            this.dateLabel.Text = "Date";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // commentNameTextBox
            // 
            this.commentNameTextBox.Location = new System.Drawing.Point(110, 100);
            this.commentNameTextBox.Name = "commentNameTextBox";
            this.commentNameTextBox.Size = new System.Drawing.Size(650, 20);
            this.commentNameTextBox.TabIndex = 44;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.commentNameTextBox);
            this.Controls.Add(this.leaveTP);
            this.Controls.Add(this.startTP);
            this.Controls.Add(this.dateDTP);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.attendanceDGV);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.courseTableBtn);
            this.Controls.Add(this.roomTableBtn);
            this.Controls.Add(this.teacherTableBtn);
            this.Controls.Add(this.courseCombo);
            this.Controls.Add(this.roomCombo);
            this.Controls.Add(this.teacherCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.teatcherNameLabel);
            this.Controls.Add(this.leaveTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.dateLabel);
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker leaveTP;
        private System.Windows.Forms.DateTimePicker startTP;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView attendanceDGV;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button courseTableBtn;
        private System.Windows.Forms.Button roomTableBtn;
        private System.Windows.Forms.Button teacherTableBtn;
        private System.Windows.Forms.ComboBox courseCombo;
        private System.Windows.Forms.ComboBox roomCombo;
        private System.Windows.Forms.ComboBox teacherCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Label teatcherNameLabel;
        private System.Windows.Forms.Label leaveTimeLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox commentNameTextBox;
    }
}

