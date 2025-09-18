using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                Arrays a = new Arrays();
                for (int i = 0; i < a.Length; i++)
                {
                    string type;
                    if (a.GetPrecipitations()[i] == 0)
                        type = "Нічого";
                    else if (a.GetTemperatures()[i] > 0)
                        type = "Дощ";
                    else
                        type = "Сніг";

                    dataGridView1.Rows.Add(a.GetTemperatures()[i].ToString(), type);
                }
                var result = a.PrecipitationSum;
                label2.Text = "Дощ: " + result.Item1.ToString();
                label3.Text = "Сніг: " + result.Item2.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
