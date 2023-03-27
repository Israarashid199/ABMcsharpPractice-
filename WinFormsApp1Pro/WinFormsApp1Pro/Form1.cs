using System;

namespace WinFormsApp1Pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DMLQueries("Select");
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DMLQueries("Insert");
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DMLQueries("Update");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DMLQueries("Delete");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DMLQueries("Exit");
        }

        public void DMLQueries(string e)
        {
            try
            {
                if (e == "Select")
                {
                    MessageBox.Show("Select");
                }
                else if (e == "Insert")
                {
                    MessageBox.Show("Insert");
                }
                else if (e == "Update")
                {
                    MessageBox.Show("Update");
                }
                else if (e == "Delete")
                {
                    MessageBox.Show("Delete");
                }
                else
                {
                    MessageBox.Show("Exit");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }

  
}