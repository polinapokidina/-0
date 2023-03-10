using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр__0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !IstNames.Items.Contains(txtName.Text))
                IstNames.Items.Add(txtName.Text);
        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' pressed.");
                switch (e.KeyChar)
                {
                    case (char)49:
                    case (char)52:
                    case (char)55:
                        MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' consumed.");
                        e.Handled = true;
                        break;
                }
            }
        }
        private void button1_MouseEnter(object sender, EventArgs e) =>
          Cursor.Hide();
        private void button1_MouseLeave(object sender, EventArgs e) =>
            Cursor.Show();

        private void button1_Click(object sender, EventArgs e) =>
            Cursor.Position = PointToScreen(button2.Location);
        private void button2_Click(object sender, EventArgs e) =>
            Cursor.Position = PointToScreen(button1.Location);
        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

        }
        button1.Text = "&Print"
        button1.Text = "Print && Close"
    }
}
