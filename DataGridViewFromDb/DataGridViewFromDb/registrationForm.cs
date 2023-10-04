
using System.Data.SqlClient;

namespace DataGridViewFromDb
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int roll_Number = Int32.Parse(textBox1.Text);
                string name = textBox2.Text;
                int tamil = Int32.Parse(textBox3.Text);
                int english = Int32.Parse(textBox4.Text);
                int maths = Int32.Parse(textBox5.Text);
                int science = Int32.Parse(textBox6.Text);
                int s_science = Int32.Parse(textBox7.Text);
                int total = tamil + english + maths + science + s_science;
                int avg = total / 5;
                string result = "Fail";

                if (tamil >= 35 && english >= 35 && maths >= 35 && science >= 35 && s_science >= 35)
                {

                    result = "Pass";
                }

                label9.Text = "Result";
                textBox8.Text = total.ToString();
                label10.Text = "Percentage";
                textBox9.Text = avg.ToString();
                label11.Text = "Total";
                textBox10.Text = result;

                //try
                //{
                //    if (textBox1.Text != "")
                //    {
                //        string qry;
                //        string str;
                //        str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jayap\\source\\repos\\DataGridViewFromDb\\DataGridViewFromDb\\StudentMarks.mdf;Integrated Security=True";
                //        SqlConnection conn = new SqlConnection(str);
                //        conn.Open();
                //        qry = "insert into StudentsMarksTbl(rollNum,name,tamil,english,maths,science,s_science) values ('" + Int32.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + Int32.Parse(textBox3.Text) + "','" + Int32.Parse(textBox4.Text) + "','" + Int32.Parse(textBox5.Text) + "','" + Int32.Parse(textBox6.Text) + "','" + Int32.Parse(textBox7.Text) + "'," + Int32.Parse(textBox8.Text) + "," + Int32.Parse(textBox9.Text) + "," + Int32.Parse(textBox10.Text) + ")";
                //        SqlCommand cmd = new SqlCommand(qry, conn);
                //        cmd.ExecuteNonQuery();
                //        MessageBox.Show("Student Record Saves Successfully");
                //        textBox1.Clear();
                //        textBox2.Clear();
                //        textBox3.Clear();
                //        textBox4.Clear();
                //        textBox5.Clear();
                //        textBox6.Clear();
                //        textBox7.Clear();
                //    }
                //    else
                //    {
                //        MessageBox.Show("All Fields Are Required");
                //    }

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex + "Data Not Inserted");
                //}

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex + "DB ShoutDown");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void registrationForm_Load(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    string qry;
                    string str;
                    str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jayap\\source\\repos\\DataGridViewFromDb\\DataGridViewFromDb\\StudentMarks.mdf;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(str);
                    conn.Open();
                    qry = "insert into StudentsMarksTbl(rollNum,name,tamil,english,maths,science,s_science,total,percentage,result ) values ('" + Int32.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + Int32.Parse(textBox3.Text) + "','" + Int32.Parse(textBox4.Text) + "','" + Int32.Parse(textBox5.Text) + "','" + Int32.Parse(textBox6.Text) + "','" + Int32.Parse(textBox7.Text) + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    cmd.ExecuteNonQuery();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                  //  label9.Text = "";
                   // label10.Text = "";
                  //  label11.Text = "";
                }
                else
                {
                    MessageBox.Show("All Fields Are Required");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Data Not Inserted");
            }
        }
    }
}
