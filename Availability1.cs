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
    public partial class Availability1 : Form
    {
        public Availability1()
        {
            InitializeComponent();
            ShowInfo();
            ShowAuto();
            ShowFirms();
        }
        void ShowInfo()
        {
            listViewAvailability1.Items.Clear();
            foreach (Availability factory in Program.wftDb.Availability)
            {


                if (factory.Availability1 == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id.ToString(),factory.Id_Firms.ToString(),factory.Id_Auto.ToString() ,"В наличии",
                });
                    item.Tag = factory;
                    listViewAvailability1.Items.Add(item);
                }
                else if (factory.Availability1 == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id.ToString(),factory.Id_Firms.ToString(),factory.Id_Auto.ToString() ,"Не в наличии",
                });
                    item.Tag = factory;
                    listViewAvailability1.Items.Add(item);


                }
                listViewAvailability1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Availability priceSet = new Availability();
            priceSet.Id_Firms = Convert.ToInt32(comboBoxId_Firms.SelectedItem.ToString().Split('.')[0]);
            priceSet.Id_Auto = Convert.ToInt32(comboBoxId_Auto.SelectedItem.ToString().Split('.')[0]);
            if (comboBoxAvailability.SelectedIndex == 0)
            {
                priceSet.Availability1 = 0;
            }
            if (comboBoxAvailability.SelectedIndex == 1)
            {
                priceSet.Availability1 = 1;
            }
            Program.wftDb.Availability.Add(priceSet);
            Program.wftDb.SaveChanges();
            ShowInfo();
        }

        private void listViewAvailability1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAvailability1.SelectedItems.Count == 1)
            {
                Availability factory = listViewAvailability1.SelectedItems[0].Tag as Availability;
                comboBoxAvailability.SelectedIndex = comboBoxAvailability.FindString(factory.Availability1.ToString());
                comboBoxId_Auto.SelectedIndex = comboBoxId_Auto.FindString(factory.Id_Auto.ToString());
                comboBoxId_Firms.SelectedIndex = comboBoxId_Firms.FindString(factory.Firms.ToString());

            }
            else
            {
                comboBoxAvailability.SelectedItem = null;
                comboBoxId_Auto.SelectedItem = null;
                comboBoxId_Firms.SelectedItem = null;
            }
        }
        
        
        void ShowAuto()
        {
            comboBoxId_Auto.Items.Clear();
            foreach (Auto factory in Program.wftDb.Auto)
            {
                string[] item = { factory.Id_Auto.ToString() + ".", factory.Model + ".", factory.State_Number.ToString() };
                comboBoxId_Auto.Items.Add(string.Join("", item));
            }
        }
        void ShowFirms()
        {
            comboBoxId_Firms.Items.Clear();
            foreach (Firms factory in Program.wftDb.Firms)
            {
                string[] item = { factory.Id_Firms.ToString() + ".", factory.Name + ".",  };
                comboBoxId_Firms.Items.Add(string.Join("", item));
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAvailability1.SelectedItems.Count == 1)
            {
                Availability factory = listViewAvailability1.SelectedItems[0].Tag as Availability;

                factory.Id_Firms = Convert.ToInt32(comboBoxId_Firms.SelectedItem.ToString().Split('.')[0]);
                factory.Id_Auto = Convert.ToInt32(comboBoxId_Auto.SelectedItem.ToString().Split('.')[0]);


                if (comboBoxAvailability.SelectedIndex == 0)
                {
                    factory.Availability1 = 0;
                }
                if (comboBoxAvailability.SelectedIndex == 1)
                {
                    factory.Availability1 = 1;
                }
                else
                {
                    comboBoxAvailability.Text = null;
                    comboBoxId_Auto.Text = null;
                    comboBoxId_Firms.Text = null;
                 
                    Program.wftDb.SaveChanges();
                    ShowInfo();
                }

            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAvailability1.SelectedItems.Count == 1)
                {
                    Availability factory = listViewAvailability1.SelectedItems[0].Tag as Availability;
                    Program.wftDb.Availability.Remove(factory);
                    Program.wftDb.SaveChanges();
                    ShowInfo();
                }
                comboBoxAvailability.Text = null;
                comboBoxId_Auto.Text = null;
                comboBoxId_Firms.Text = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
