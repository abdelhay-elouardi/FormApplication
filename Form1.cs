using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string con = @"Data Source=ABDE\SQLEXPRESS;Initial Catalog=ConnectionDB;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(con);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        public void show()
        {
            cmbBox.Items.Clear();
            cmd.Connection = cnx;
            cmd.CommandText = "select * from FORM";
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cnx.Open();
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                cmbBox.Items.Add("Name : " + dr["name"]);
                cmbBox.Items.Add("Id   : " + dr["id"].ToString());

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnSelect.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
            cmbBox.Enabled = true;
            textID.Enabled = false;
            textName.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnID_Click(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnName_Click(object sender, EventArgs e)
        {

        }
        
        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender , EventArgs e)
        {
            this.Text = "Add";
            textID.Clear();
            textName.Clear();
            show();
            btnAdd.Enabled = false;
            btnSelect.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
            cmbBox.Enabled = false;
            textID.Enabled = true;
            textName.Enabled = true;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Text = "Edit";
            btnAdd.Enabled = false;
            btnSelect.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            cmbBox.Enabled = true;
            textID.Enabled = true;
            textName.Enabled = true;

           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

    }
}
