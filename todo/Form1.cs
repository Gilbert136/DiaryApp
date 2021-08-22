using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace todo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTodoList todoList = new addTodoList();
            TodoData nData = new TodoData();
            todoList.ShowDialog();
            DBconn.insertData(todoList.Display());

            if (DBconn.getData().Count <= 3)
            {
                this.Size = new Size(284, 530);
            }
            else {
                this.Size = new Size(303, 530);
            }

            panel4.Controls.Clear();
            DBconn.getData().Reverse();
            for (int i = 0; i < DBconn.getData().Count; i++ )
            {
                addTodo UC = new addTodo(DBconn.getData()[i].Text, DBconn.getData()[i].date_created.ToString());
                UC.Name = "3" + i;
                UC.Location = new Point(0, i * 115);
                panel4.Controls.Add(UC);
            }


        }

        private void addControlToPanel(Control c)
        {
            
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addTodo3_Load(object sender, EventArgs e)
        {

        }
    }
}
