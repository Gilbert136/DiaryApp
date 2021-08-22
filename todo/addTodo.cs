using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace todo
{
    public partial class addTodo : UserControl
    {
        public addTodo(String TextData, String Date)
        {
            InitializeComponent();
            label2.Text = TextData;
            label5.Text = Date;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addTodo_Load(object sender, EventArgs e)
        {

        }

        private void addTodo_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
