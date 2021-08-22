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
    public partial class addTodoList : Form
    {
        public addTodoList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public TodoData Display() {
            TodoData newData = new TodoData();
            newData.Text = richTextBox1.Text;
            newData.date_created = dateTimePicker1.Value;
            return newData;
        }
    }
}
