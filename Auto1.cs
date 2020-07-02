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
    public partial class Auto1 : Form
    {
        public Auto1()
        {
            InitializeComponent();
            ShowAuto();
        }
        void ShowAuto()
        {
            listViewAuto1.Items.Clear();
            foreach (Auto factory in Program.wftDb.Auto)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id_Auto.ToString(), factory.Model, factory.Color.ToString(),factory.State_Number,
                    factory.Year_of_issue.ToString(),factory.Price.ToString()
                });
                item.Tag = factory;
                listViewAuto1.Items.Add(item);
            }
            listViewAuto1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxColor.SelectedItem != null)
            {
                Auto priceSet = new Auto();
                priceSet.Model = textBoxModel.Text;
                priceSet.State_Number = Convert.ToString(textBoxState_Number.Text);
                priceSet.Year_of_issue = Convert.ToDateTime(textBoxYear_of_issue.Text);
                priceSet.Price = Convert.ToInt32(textBoxPrice.Text);


                if (comboBoxColor.SelectedIndex == 0)
                {
                    priceSet.Color = 0;
                }
                if (comboBoxColor.SelectedIndex == 1)
                {
                    priceSet.Color = 1;
                }
                if (comboBoxColor.SelectedIndex == 2)
                {
                    priceSet.Color = 2;
                }
                if (comboBoxColor.SelectedIndex == 3)
                {
                    priceSet.Color = 3;
                }
                Program.wftDb.Auto.Add(priceSet);
                Program.wftDb.SaveChanges();
                ShowAuto();
            }
        }

        private void listViewAuto1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAuto1.SelectedItems.Count == 1)
            {
               Auto factory = listViewAuto1.SelectedItems[0].Tag as Auto;
                textBoxModel.Text = factory.Model;
                textBoxState_Number.Text = factory.State_Number;
                textBoxYear_of_issue.Text = factory.Year_of_issue.ToString();
                textBoxPrice.Text = Convert.ToString(factory.Price);
                comboBoxColor.SelectedIndex = comboBoxColor.FindString(factory.Color.ToString());
            }
            else
            {
                textBoxModel.Text = "";
                textBoxState_Number.Text = "";
                textBoxYear_of_issue.Text = "";
                textBoxPrice.Text = "";
                comboBoxColor.SelectedItem = null;
            }
        }



        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAuto1.SelectedItems.Count == 1)
                {
                    Auto factory = listViewAuto1.SelectedItems[0].Tag as Auto;
                    Program.wftDb.Auto.Remove(factory);
                    Program.wftDb.SaveChanges();
                    ShowAuto();
                }
                textBoxModel.Text = "";
                textBoxState_Number.Text = "";
                textBoxYear_of_issue.Text = "";
                textBoxPrice.Text = "";
                comboBoxColor.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void textBoxaAuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsControl(number) && number != '.')
            {
                e.Handled = true;
            }

        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {

            if (listViewAuto1.SelectedItems.Count == 1)
            {
                Auto priceSet = listViewAuto1.SelectedItems[0].Tag as Auto;






                if (comboBoxColor.SelectedIndex == 0)
                {
                    priceSet.Model = textBoxModel.Text;
                    priceSet.State_Number = Convert.ToString(textBoxState_Number.Text);
                    priceSet.Year_of_issue = Convert.ToDateTime(textBoxYear_of_issue.Text);
                    priceSet.Price = Convert.ToInt32(textBoxPrice.Text);
                    priceSet.Color = 0;
                    Program.wftDb.SaveChanges();
                    ShowAuto();
                }
                if (comboBoxColor.SelectedIndex == 1)
                {
                    priceSet.Model = textBoxModel.Text;
                    priceSet.State_Number = Convert.ToString(textBoxState_Number.Text);
                    priceSet.Year_of_issue = Convert.ToDateTime(textBoxYear_of_issue.Text);
                    priceSet.Price = Convert.ToInt32(textBoxPrice.Text);
                    priceSet.Color = 1;
                    Program.wftDb.SaveChanges();
                    ShowAuto();
                }
                if (comboBoxColor.SelectedIndex == 2)
                {
                    priceSet.Model = textBoxModel.Text;
                    priceSet.State_Number = Convert.ToString(textBoxState_Number.Text);
                    priceSet.Year_of_issue = Convert.ToDateTime(textBoxYear_of_issue.Text);
                    priceSet.Price = Convert.ToInt32(textBoxPrice.Text);
                    priceSet.Color = 2;
                    Program.wftDb.SaveChanges();
                    ShowAuto();
                }
                if (comboBoxColor.SelectedIndex == 3)
                {
                    priceSet.Model = textBoxModel.Text;
                    priceSet.State_Number = Convert.ToString(textBoxState_Number.Text);
                    priceSet.Year_of_issue = Convert.ToDateTime(textBoxYear_of_issue.Text);
                    priceSet.Price = Convert.ToInt32(textBoxPrice.Text);
                    priceSet.Color = 3;
                    Program.wftDb.SaveChanges();
                    ShowAuto();
                }

            }
        }
    }
}
