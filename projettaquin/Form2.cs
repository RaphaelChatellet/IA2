using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projettaquin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {

            } 
         }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[][] entrepot = new string[25][];
            entrepot[0] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[1] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[2] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[3] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[4] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[5] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[6] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[7] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[8] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[9] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[10] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[11] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[12] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[13] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[14] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[15] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[16] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[17] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[18] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[19] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[20] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[21] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[22] = new string[] { "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0", "0", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "0" };
            entrepot[23] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            entrepot[24] = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };

            //DataTable dt = new DataTable();

            dataGridView1.Name = "Tableau";
            dataGridView1.Size = new Size(1050, 552);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;

            for (int i = 0; i < 25; i++)
            {
                dataGridView1.Columns.Add("_" + i, i.ToString());
            }

            for (int i = 0; i < 25; i++)
            {
                dataGridView1.Rows.Add(entrepot[i]);
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
