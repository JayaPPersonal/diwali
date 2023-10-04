
using System.Data.SqlClient;
namespace DataGridViewFromDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string qry;
                string str;
                str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jayap\\source\\repos\\DataGridViewFromDb\\DataGridViewFromDb\\StudentMarks.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                qry = "select*from StudentsMarksTbl";
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                }
                dr.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex + "DB ShoutDown");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registrationForm regform = new registrationForm();
            regform.Show();
            
        }
    }
}