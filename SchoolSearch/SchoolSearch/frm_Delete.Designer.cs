namespace SchoolSearch
{
    partial class frm_Delete
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
            this.bt_Add = new System.Windows.Forms.Button();
            this.tb_TLastName = new System.Windows.Forms.TextBox();
            this.tb_TFirstName = new System.Windows.Forms.TextBox();
            this.tb_Bus = new System.Windows.Forms.TextBox();
            this.tb_Classroom = new System.Windows.Forms.TextBox();
            this.tb_Grade = new System.Windows.Forms.TextBox();
            this.tb_SecondName = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.lb_TLast_Name = new System.Windows.Forms.Label();
            this.lb_TFirstName = new System.Windows.Forms.Label();
            this.lb_Bus = new System.Windows.Forms.Label();
            this.lb_Classroom = new System.Windows.Forms.Label();
            this.lb_Grade = new System.Windows.Forms.Label();
            this.lb_SecondName = new System.Windows.Forms.Label();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Add.Location = new System.Drawing.Point(315, 281);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(120, 34);
            this.bt_Add.TabIndex = 29;
            this.bt_Add.Text = "Видалити";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // tb_TLastName
            // 
            this.tb_TLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_TLastName.Location = new System.Drawing.Point(258, 233);
            this.tb_TLastName.Name = "tb_TLastName";
            this.tb_TLastName.Size = new System.Drawing.Size(177, 30);
            this.tb_TLastName.TabIndex = 28;
            // 
            // tb_TFirstName
            // 
            this.tb_TFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_TFirstName.Location = new System.Drawing.Point(258, 197);
            this.tb_TFirstName.Name = "tb_TFirstName";
            this.tb_TFirstName.Size = new System.Drawing.Size(177, 30);
            this.tb_TFirstName.TabIndex = 27;
            // 
            // tb_Bus
            // 
            this.tb_Bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Bus.Location = new System.Drawing.Point(258, 161);
            this.tb_Bus.Name = "tb_Bus";
            this.tb_Bus.Size = new System.Drawing.Size(177, 30);
            this.tb_Bus.TabIndex = 26;
            this.tb_Bus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Bus_KeyPress);
            // 
            // tb_Classroom
            // 
            this.tb_Classroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Classroom.Location = new System.Drawing.Point(258, 125);
            this.tb_Classroom.Name = "tb_Classroom";
            this.tb_Classroom.Size = new System.Drawing.Size(177, 30);
            this.tb_Classroom.TabIndex = 25;
            this.tb_Classroom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Classroom_KeyPress);
            // 
            // tb_Grade
            // 
            this.tb_Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Grade.Location = new System.Drawing.Point(258, 89);
            this.tb_Grade.Name = "tb_Grade";
            this.tb_Grade.Size = new System.Drawing.Size(177, 30);
            this.tb_Grade.TabIndex = 24;
            this.tb_Grade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Grade_KeyPress);
            // 
            // tb_SecondName
            // 
            this.tb_SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_SecondName.Location = new System.Drawing.Point(258, 53);
            this.tb_SecondName.Name = "tb_SecondName";
            this.tb_SecondName.Size = new System.Drawing.Size(177, 30);
            this.tb_SecondName.TabIndex = 23;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_FirstName.Location = new System.Drawing.Point(258, 17);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(177, 30);
            this.tb_FirstName.TabIndex = 22;
            // 
            // lb_TLast_Name
            // 
            this.lb_TLast_Name.AutoSize = true;
            this.lb_TLast_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lb_TLast_Name.Location = new System.Drawing.Point(7, 238);
            this.lb_TLast_Name.Name = "lb_TLast_Name";
            this.lb_TLast_Name.Size = new System.Drawing.Size(204, 25);
            this.lb_TLast_Name.TabIndex = 21;
            this.lb_TLast_Name.Text = "Прізвище викладача:";
            // 
            // lb_TFirstName
            // 
            this.lb_TFirstName.AutoSize = true;
            this.lb_TFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lb_TFirstName.Location = new System.Drawing.Point(7, 202);
            this.lb_TFirstName.Name = "lb_TFirstName";
            this.lb_TFirstName.Size = new System.Drawing.Size(152, 25);
            this.lb_TFirstName.TabIndex = 20;
            this.lb_TFirstName.Text = "Ім\'я викладача:";
            // 
            // lb_Bus
            // 
            this.lb_Bus.AutoSize = true;
            this.lb_Bus.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lb_Bus.Location = new System.Drawing.Point(7, 166);
            this.lb_Bus.Name = "lb_Bus";
            this.lb_Bus.Size = new System.Drawing.Size(172, 25);
            this.lb_Bus.TabIndex = 19;
            this.lb_Bus.Text = "Номер маршруту:";
            // 
            // lb_Classroom
            // 
            this.lb_Classroom.AutoSize = true;
            this.lb_Classroom.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lb_Classroom.Location = new System.Drawing.Point(7, 130);
            this.lb_Classroom.Name = "lb_Classroom";
            this.lb_Classroom.Size = new System.Drawing.Size(132, 25);
            this.lb_Classroom.TabIndex = 18;
            this.lb_Classroom.Text = "Номер класу:";
            // 
            // lb_Grade
            // 
            this.lb_Grade.AutoSize = true;
            this.lb_Grade.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lb_Grade.Location = new System.Drawing.Point(7, 94);
            this.lb_Grade.Name = "lb_Grade";
            this.lb_Grade.Size = new System.Drawing.Size(60, 25);
            this.lb_Grade.TabIndex = 17;
            this.lb_Grade.Text = "Клас:";
            // 
            // lb_SecondName
            // 
            this.lb_SecondName.AutoSize = true;
            this.lb_SecondName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lb_SecondName.Location = new System.Drawing.Point(7, 58);
            this.lb_SecondName.Name = "lb_SecondName";
            this.lb_SecondName.Size = new System.Drawing.Size(185, 25);
            this.lb_SecondName.TabIndex = 16;
            this.lb_SecondName.Text = "Прізвище студента:";
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lb_FirstName.Location = new System.Drawing.Point(7, 22);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(133, 25);
            this.lb_FirstName.TabIndex = 15;
            this.lb_FirstName.Text = "Ім\'я студента:";
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Reset.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Reset.Location = new System.Drawing.Point(7, 281);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(120, 34);
            this.bt_Reset.TabIndex = 30;
            this.bt_Reset.Text = "Очистка";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // frm_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(447, 324);
            this.Controls.Add(this.bt_Reset);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.tb_TLastName);
            this.Controls.Add(this.tb_TFirstName);
            this.Controls.Add(this.tb_Bus);
            this.Controls.Add(this.tb_Classroom);
            this.Controls.Add(this.tb_Grade);
            this.Controls.Add(this.tb_SecondName);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.lb_TLast_Name);
            this.Controls.Add(this.lb_TFirstName);
            this.Controls.Add(this.lb_Bus);
            this.Controls.Add(this.lb_Classroom);
            this.Controls.Add(this.lb_Grade);
            this.Controls.Add(this.lb_SecondName);
            this.Controls.Add(this.lb_FirstName);
            this.Name = "frm_Delete";
            this.Text = "Delete Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.TextBox tb_TLastName;
        private System.Windows.Forms.TextBox tb_TFirstName;
        private System.Windows.Forms.TextBox tb_Bus;
        private System.Windows.Forms.TextBox tb_Classroom;
        private System.Windows.Forms.TextBox tb_Grade;
        private System.Windows.Forms.TextBox tb_SecondName;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.Label lb_TLast_Name;
        private System.Windows.Forms.Label lb_TFirstName;
        private System.Windows.Forms.Label lb_Bus;
        private System.Windows.Forms.Label lb_Classroom;
        private System.Windows.Forms.Label lb_Grade;
        private System.Windows.Forms.Label lb_SecondName;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.Button bt_Reset;
    }
}