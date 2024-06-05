using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=MOHAMAD\MSSQLSERVERR;Initial Catalog=GameStore;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gameStoreDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStoreDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.gameStoreDataSet.Product);

        }

        private void product_btn_Click(object sender, EventArgs e)
        {
            Product_panel.BringToFront();
        }

 

        private void Close_btn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

     

        private void Delete_product_btn_Click(object sender, EventArgs e)
        {

        }

        private void ADD_product_btn_Click(object sender, EventArgs e)
        {
              
                Con.Open();
                cmd = new SqlCommand("insert into Product values (@Product_code,@Product_name,@Product_price,@Publisher_ID,@Category)", Con);
                cmd.Parameters.AddWithValue("@Product_code", int.Parse(PRcode_textBox.Text));
                cmd.Parameters.AddWithValue("@Product_name", PR_name_textBox.Text);
                cmd.Parameters.AddWithValue("@Product_price", decimal.Parse(PR_price_textBox.Text));
                cmd.Parameters.AddWithValue("@Publisher_ID", int.Parse(PR_Publisherid_textBox.Text));
                cmd.Parameters.AddWithValue("@Category", Category_comboBox.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Product Saved Successfully");
        }
        
    }
}
