using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SchoolSearch
{
    public partial class frm_Delete : Form
    {
        public frm_Delete()
        {
            InitializeComponent();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (tb_SecondName.Text == "" || tb_FirstName.Text == "" || tb_Grade.Text == "" || tb_Classroom.Text
                == "" || tb_Bus.Text == "" || tb_TLastName.Text == "" || tb_TFirstName.Text == "")
            {
                MessageBox.Show("Поле не заполнено!");
            }
            else
            {
                string Student = tb_SecondName.Text + "," + tb_FirstName.Text + "," + tb_Grade.Text + "," + tb_Classroom.Text
                + "," + tb_Bus.Text + "," + tb_TLastName.Text + "," + tb_TFirstName.Text;
                string[] inventoryData = File.ReadAllLines("students.txt"); //считываем каждую строку файла в массив строк
                List<string> inventoryDataList = inventoryData.ToList(); //преобразовываем массив в список
                if (inventoryDataList.Remove(Student)) //удалять строку, если найдена такая
                {
                    File.WriteAllLines("students.txt", inventoryDataList.ToArray()); //перезаписываем файл с оставшимися строками из списка
                    MessageBox.Show("Успешно удалено!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Совпадений не найдено!");
                    Close();
                }
            }
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

        private void tb_Bus_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            tb_SecondName.Text = "";
            tb_FirstName.Text = "";
            tb_Grade.Text = "";
            tb_Classroom.Text = "";
            tb_Bus.Text = "";
            tb_TLastName.Text = "";
            tb_TFirstName.Text = "";
        }
    }
}
