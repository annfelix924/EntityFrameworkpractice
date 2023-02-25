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
    public partial class ReviseForm : Form
    {
        public ReviseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedId = int.Parse(textBox1.Text); 
            try
            {
                ContactsModel context = new ContactsModel();
                ContactsTable data = context.ContactsTable.FirstOrDefault(x => x.Id == selectedId);
                if (data != null)
                {
                    data.name = textBox2.Text.Trim();
                    data.quantity = textBox3.Text.Trim();
                    data.price = textBox4.Text.Trim();
                    data.type = textBox5.Text.Trim();
                    context.SaveChanges();
                    MessageBox.Show("修改完成");
                    ClearTextBoxes();
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
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
