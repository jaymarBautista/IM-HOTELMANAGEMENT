using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement_Information_Management_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void loadForm(Form form)
        {
             panel3.Controls.Clear();          
             form.TopLevel = false;          
             form.FormBorderStyle = FormBorderStyle.None; 
             form.Dock = DockStyle.Fill;      
             panel3.Controls.Add(form);
             panel3.Tag = form;
             form.BringToFront();              
             form.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            loadForm(new Form3());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            loadForm(new Form4());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            loadForm(new Form5());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            loadForm(new Form6());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
