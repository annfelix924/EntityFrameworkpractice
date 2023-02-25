using EntityFrameworkpractice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityFrameworkpractice
{
    public partial class DemandForm : Form
    {
        public DemandForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedId = int.Parse(textBox1.Text); 
            try
            {
                ContactsModel context = new ContactsModel();
                List<ContactsTable> dataList = context.ContactsTable.Where(x => x.Id == selectedId).ToList();
                if (dataList.Count > 0)
                {
                    dataGridView1.DataSource = dataList;
                }
                else
                {
                    MessageBox.Show("找不到此商品");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤 {ex.ToString()}");
            }
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
        }
    }
}
