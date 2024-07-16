using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace parctice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string cs = "data source=DESKTOP-GQFNJTT;" +
                "initial catalog=login_demo;" +
                "user id=sa;password=1234";
            string user_name = textBox_userName.Text;
            string password = textBox_passord.Text;
            string query = $"SELECT * FROM users WHERE userName = '{user_name}' AND password ='{password}'";
            SqlCommand cmd = new SqlCommand(query);
            using(SqlConnection conn = new SqlConnection(cs))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    conn.Open();
                    adapter.Fill(dataTable);
                    if(dataTable.Rows.Count > 0)
                    {
                        this.Close();
                        Form2 form2 = new Form2();
                        form2.Show();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid user name or password" + ex);
                }
            }
        }
    }
}
