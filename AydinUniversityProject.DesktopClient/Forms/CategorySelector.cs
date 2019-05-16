using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ScreenShareOpsComplexManagers;

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TeachLearnDesktop.Items;

namespace TeachLearnDesktop
{
    public partial class CategorySelector : Form
    {
        int currentUserID = -1;
        ScreenShareOpsComplexManager screenShareManager;
        public CategorySelector(int currentUserID)
        {
            InitializeComponent();

            this.currentUserID = currentUserID;
            screenShareManager = new ScreenShareOpsComplexManager();

        }

        private void CategorySelector_Load(object sender, EventArgs e)
        {
            if (currentUserID != -1)
            {

                Dictionary<int, string> categoryDictionary = screenShareManager.GetAllLessons();
                List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
                categoryDictionary.Add(0, "Random");

                foreach (var dict in categoryDictionary)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = dict.Value;
                    item.Value = dict.Key;

                    comboBoxItems.Add(item);
                }
                categoryComboBox.DataSource = comboBoxItems;

            }
            else
            {
                labelError1.Visible = true;
                labelError2.Visible = true;

                btnSubmitCategory.Enabled = false;
                categoryComboBox.Enabled = false;
            }
        }

        private void btnSubmitCategory_Click(object sender, EventArgs e)
        {
            if (currentUserID != -1)
            {
                int categoryID = (categoryComboBox.SelectedValue as ComboBoxItem).Value;

                this.Hide();
                ConnectionNameForm cs = new ConnectionNameForm(currentUserID, categoryID);
                cs.FormClosed += (s, args) => this.Close();
                cs.Show();
            }
        }

        private void CategorySelector_FormClosed(object sender, FormClosedEventArgs e)
        {
        //    if (string.Equals((sender as Button).Name, "CloseButton"))
        //    {
        //        screenShareManager.LogOff(currentUserID);
        //    }
        }
    }
}
