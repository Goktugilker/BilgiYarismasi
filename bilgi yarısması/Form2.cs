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

namespace bilgi_yarısması
{
    public partial class Form2 : Form
    {
        int zaman = 15;
        int puan = 0;
        int sayac = 0;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source = sql server adı; Initial Catalog = soru; Integrated Security = True");
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sayac++;
            zaman = 16;
            if (sayac == 1)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                button5.Text = ("SONRAKİ");
            }
            if (sayac == 2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 3) {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * From soru3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read()) {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * From soru4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 5)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * From soru5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 6)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * From soru6 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 7)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * From soru7 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 8)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * From soru8 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 9)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * From soru9 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 10)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * From soru10 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 11)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                button5.Visible = false;
                timer1.Stop();
                label5.Visible = true;
                label5.Text = puan.ToString();
                label6.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
            }
            button5.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (lbldogru.Text == button1.Text)
            {
                puan += 30;
                label2.Text = puan.ToString();

            }
            else
            {
                puan -= 10;
                label2.Text = puan.ToString();
            }
            button5.Enabled=true;
            button5_Click(sender, e);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbldogru.Text == button2.Text)
            {
                puan += 30;
                label2.Text = puan.ToString();

            }
            else
            {
                puan -= 10;
                label2.Text = puan.ToString();
            }
            button5.Enabled = true;
            button5_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbldogru.Text == button3.Text)
            {
                puan += 30;
                label2.Text = puan.ToString();

            }
            else
            {
                puan -= 10;
                label2.Text = puan.ToString();
            }
            button5.Enabled = true;
            button5_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbldogru.Text == button4.Text)
            {
                puan += 30;
                label2.Text = puan.ToString();

            }
            else
            {
                puan -= 10;
                label2.Text = puan.ToString();
            }
            button5.Enabled=true;
            button5_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            label3.Text = zaman.ToString();
            if(zaman == 0)
            {
                timer1.Stop();
                button5.Enabled = true;
                button5_Click(sender, e);
                puan -= 10;
                label2.Text = puan.ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = zaman.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           label6.Visible = false;
            label5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button5.Visible = true;
            button5.Enabled = true;
            sayac = 0;
            puan = 0;
            label2.Text = puan.ToString();
            zaman = 15;
            label3.Text = zaman.ToString();
            textBox1.Clear();
            button1.Text = "A";
            button2.Text = "B";
            button3.Text = "C";
            button4.Text = "D";
            button5.Text = "BAŞLA";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 menü = new Form1();
            menü.Show();
            this.Hide();
        }
    }
}
