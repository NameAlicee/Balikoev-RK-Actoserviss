using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoservice
{
    public partial class Form1 : Form
    {
        string Line, path = @"C:\Users\gabon\source\repos\Autoservice\Autoservice\Resources\clients.txt";
        string[] array;
        int linesCnt;
        int CurrentRow;
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            linesCnt = File.ReadAllLines(path).Length;
            array = new string[linesCnt];
            filltable(comboBox1.SelectedIndex, comboBox2.SelectedIndex);
        }
        public void filltable(int index, int sort)
        {
            if (index == 0) index = 10;
            if (index == 1) index = 50;
            if (index == 2) index = 100;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < index; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = i + 1;
                dataGridView1[1, i].Value = "Пол";
                dataGridView1[2, i].Value = "Имя";
                dataGridView1[3, i].Value = "Фамилия";
                dataGridView1[4, i].Value = "Отчество";
                dataGridView1[5, i].Value = "Дата рождения";
                dataGridView1[6, i].Value = "Телефон";
                dataGridView1[7, i].Value = "Email";
                dataGridView1[8, i].Value = "Дата добавления";
                dataGridView1[9, i].Value = "Дата последнего посещения";
                dataGridView1[10, i].Value = "Количество посещений";
                dataGridView1[11, i].Value = "Теги";
            }

            if (sort == 0) dataGridView1.Sort(dataGridView1.Columns[0],ListSortDirection.Ascending);
            if (sort == 1) dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button2.BackColor = Color.FromArgb(255, 156, 26);
            button2.ForeColor = Color.White;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 secondform = new Form2();
            secondform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button1.BackColor = Color.FromArgb(255, 156, 26);
            button1.ForeColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filltable(comboBox1.SelectedIndex, comboBox2.SelectedIndex);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            filltable(comboBox1.SelectedIndex, comboBox2.SelectedIndex);
        }
    }
}
