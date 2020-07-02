using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosalon
{
    public partial class Firms1 : Form
    {
        public Firms1()
        {
            InitializeComponent();
            ShowFirms1();
        }
        void ShowFirms1()
        {
            listViewFirms1.Items.Clear();
            foreach (Firms factory in Program.wftDb.Firms)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id_Firms.ToString(), factory.Name, factory.Address,factory.Phone,factory.Maill
                });
                item.Tag = factory;
                listViewFirms1.Items.Add(item);
            }
            listViewFirms1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Firms priceSet = new Firms();
            priceSet.Name = textBoxName.Text;
            priceSet.Phone = textBoxPhone.Text;
            priceSet.Maill = textBoxMaill.Text;
            priceSet.Address = textBoxAddress.Text;




            Program.wftDb.Firms.Add(priceSet);
            Program.wftDb.SaveChanges();
            ShowFirms1();
        }

        private void listViewFirms1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFirms1.SelectedItems.Count == 1)
            {
                label1.Text = "Средняя цена";
                Firms factory = listViewFirms1.SelectedItems[0].Tag as Firms;
                textBoxName.Text = factory.Name;
                textBoxPhone.Text = factory.Phone;
                textBoxMaill.Text = factory.Maill;
                textBoxAddress.Text = factory.Address;
                int sum = 0;
                int gai = 0;
                listViewAuto.Items.Clear();
                foreach (Availability auto in Program.wftDb.Availability)
                {

                    if(auto.Id_Firms==factory.Id_Firms)
                    {
                        sum += auto.Auto.Price;
                        gai += 1;
                        ListViewItem item = new ListViewItem(new string[]
                        {
                    auto.Id_Auto.ToString(),auto.Auto.Model,auto.Auto.Price.ToString()
                        });
                        item.Tag = auto;
                        listViewAuto.Items.Add(item);
                    }

                }
                label1.Text += " " + Convert.ToString(sum / gai);

                listViewAuto.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }
            else

            {
                label1.Text = "Средняя цена";
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxMaill.Text = "";
                textBoxAddress.Text = "";
                listViewAuto.Items.Clear();
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewFirms1.SelectedItems.Count == 1)
            {
                Firms factory = listViewFirms1.SelectedItems[0].Tag as Firms;

                factory.Name = textBoxName.Text;
                factory.Phone = textBoxPhone.Text;
                factory.Maill = textBoxMaill.Text;
                factory.Address = textBoxAddress.Text;


                Program.wftDb.SaveChanges();
                ShowFirms1();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFirms1.SelectedItems.Count == 1)
                {
                    Firms factory = listViewFirms1.SelectedItems[0].Tag as Firms;
                    Program.wftDb.Firms.Remove(factory);
                    Program.wftDb.SaveChanges();
                    ShowFirms1();
                }
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxMaill.Text = "";
                textBoxAddress.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void textBoxDeid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsControl(number) && number != '.')
            {
                e.Handled = true;
            }
        }

        private void listViewAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
