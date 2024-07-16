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

namespace parctice1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string query = "SELECT * FROM users";
            MakeQuery(query);
        }

        private DataTable MakeQuery(string query)
        {
            DataTable dt = new DataTable();
            string cs = "data source=DESKTOP-GQFNJTT;" +
                "initial catalog=login_demo;" +
                "user id=sa;password=1234";
            using(SqlConnection conn = new SqlConnection(cs))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
                    conn.Open();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                catch(Exception ex) 
                {
                    MessageBox.Show("error" + ex );
                }
            }
            return dt;
        }



    }
}
