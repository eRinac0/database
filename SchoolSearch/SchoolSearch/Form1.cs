using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SchoolSearch
{

    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

       
            try
            {
                StreamReader file = new StreamReader("students.txt");
                file.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Close();
            }
        }

       private class Student 
        {
            string StLastName;
            string StFirstName;
            int Grade; 
            int Classroom; 
            int Bus; 
            string TLastName; 
            string TFirstName;

            public Student(string SetStLastName, string SetStFirstName, int SetGrade, int SetClassroom,
                int SetBus, string SetTLastName, string SetTFirstName)
            {
                StLastName = SetStLastName;
                StFirstName = SetStFirstName;
                Grade = SetGrade;
                Classroom = SetClassroom;
                Bus = SetBus;
                TLastName = SetTLastName;
                TFirstName = SetTFirstName;
            }

            public string PrintAllIformationOfStudent()
            {
                string FullInformationOfStudent = "Прізвище студента: " + StLastName + '\r' + '\n' + "Ім'я студента: " + StFirstName + '\r' + '\n' + "Класс: " +
                    Grade + '\r' + '\n' + "Номер классу: " + Classroom + '\r' + '\n' + "Номер маршруту: " + Bus + '\r' + '\n' + "Прізвище викладача: " +
                    TLastName + '\r' + '\n' + "Ім'я викладача: " + TFirstName;
                return FullInformationOfStudent;
            }

        }

        private void bt_AllInformationAboutAllStudents_Click(object sender, EventArgs e)
        {
            tb_Result.Clear(); 
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch(); 
            string line; 
            StreamReader file = new StreamReader("students.txt"); 
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null) 
            {
                string[] parts = line.Split(','); 

                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];

                Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus,
                    NewTLastName, NewTFirstName);

                tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                numbers++; 
            }
            clock.Stop();
            file.Close(); 
            tb_Time.Text = Convert.ToString(clock.Elapsed); 
            tb_Numbers.Text = Convert.ToString(numbers);

        }

        private void bt_FirstName_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string NameNeed = tb_FirstName.Text;
            tb_FirstName.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewStFirstName == NameNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade,
                        NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text +
                        NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_SecondName_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string NameNeed = tb_SecondName.Text;
            tb_SecondName.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewStLastName == NameNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_Grade_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            int GradeNeed = Convert.ToInt32(tb_Grade.Text);
            tb_Grade.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewGrade == GradeNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void tb_Grade_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tb_Classroom_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void bt_Classroom_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            int ClassroomNeed = Convert.ToInt32(tb_Classroom.Text);
            tb_Classroom.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewClassroom == ClassroomNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void tb_Bus_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void bt_Bus_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            int BusNeed = Convert.ToInt32(tb_Bus.Text);
            tb_Bus.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewBus == BusNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_TFirstName_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string TFirstNameNeed = tb_TFirstName.Text;
            tb_TFirstName.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewTFirstName == TFirstNameNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_TSecondName_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_Time.Clear();
            Stopwatch clock = new Stopwatch();
            string TSecondNameNeed = tb_TSecondName.Text;
            tb_TSecondName.Clear();
            string line;
            StreamReader file = new StreamReader("students.txt");
            int numbers = 0;
            clock.Start();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string NewStLastName = parts[0];
                string NewStFirstName = parts[1];
                int NewGrade = Int32.Parse(parts[2]);
                int NewClassroom = Int32.Parse(parts[3]);
                int NewBus = Int32.Parse(parts[4]);
                string NewTLastName = parts[5];
                string NewTFirstName = parts[6];
                if (NewTLastName == TSecondNameNeed)
                {
                    Student NewStudent = new Student(NewStLastName, NewStFirstName, NewGrade, NewClassroom, NewBus, NewTLastName, NewTFirstName);
                    tb_Result.Text = tb_Result.Text + NewStudent.PrintAllIformationOfStudent() + '\r' + '\n' + '\r' + '\n';
                    numbers++;
                }
            }
            clock.Stop();
            file.Close();
            tb_Time.Text = Convert.ToString(clock.Elapsed);
            tb_Numbers.Text = Convert.ToString(numbers);
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            frm_Add Window_Add = new frm_Add(); 
            Window_Add.ShowDialog(); 
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            frm_Delete Window_Delete = new frm_Delete();
            Window_Delete.ShowDialog(); 
        }

        private void bt_ResetAll_Click(object sender, EventArgs e)
        {
            tb_FirstName.Text = "";
            tb_SecondName.Text = "";
            tb_Grade.Text = "";
            tb_Classroom.Text = "";
            tb_Bus.Text = "";
            tb_TFirstName.Text = "";
            tb_TSecondName.Text = "";
            tb_Numbers.Text = "";
            tb_Time.Text = "";
            tb_Result.Text = "";
        }
    }
}