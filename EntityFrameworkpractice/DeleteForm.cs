using EntityFrameworkpractice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityFrameworkpractice
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                String itemName = textBox1.Text.Trim();

            try
            {
                ContactsModel context = new ContactsModel();
                ContactsTable itemToDelete = context.ContactsTable.FirstOrDefault(x => x.name== itemName);
                if (itemToDelete != null)
                {
                    context.ContactsTable.Remove(itemToDelete);
                    context.SaveChanges();
                    MessageBox.Show("刪除完成");
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("找不到要刪除的項目");
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
        }
    }
}
