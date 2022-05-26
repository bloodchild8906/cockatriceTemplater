using CockatriceDeckTemplateBuilder.Main.Collections;
using CockatriceDeckTemplateBuilder.Main.Database.databasev2;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TableLayout;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CockatriceDeckTemplateBuilder.Main.Dialogs
{
    public partial class CategoryEditorDialog : DevExpress.XtraEditors.XtraForm
    {
        public List<TemplateItem> TemplateItems;
        public List<TemplateCategory> TemplateCategories;
        public TemplateCategory TemplateCategory;
        private DialogMode _mode;
        public CategoryEditorDialog(DialogMode mode, List<TemplateCategory> templateCategories = null, int? index = null)
        {
            InitializeComponent();
            _mode = mode;
            if (mode == DialogMode.Create)
                TemplateItems = new List<TemplateItem>();
            else if (mode == DialogMode.Edit)
            {
                if (index == null) throw new ArgumentNullException("index must be set to the index of the item being edited");
                TemplateItems = templateCategories[index.Value].TemplateItems.ToList();
                TemplateCategory = templateCategories[index.Value];
                Txt_Name.Text = TemplateCategory.Name;
                Txt_Description.Text = TemplateCategory.Description;
                checkedListBoxControl1.DataSource = TemplateCategory.TemplateItems ?? new List<TemplateItem>();
            }
            TemplateCategories = templateCategories;
            checkedListBoxControl1.DataSource = TemplateItems;
            checkedListBoxControl1.DisplayMember = "Name";
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (TemplateCategories is null || TemplateCategories.Count == 0) return;
            if (
                TemplateCategories.FirstOrDefault(category => category.Name == Txt_Name.Text) != null &&
                TemplateCategories.FirstOrDefault(category => category.Name == Txt_Name.Text).Name != TemplateCategory.Name
                )
            {
                errorText.Visible = true;
                errorText.Text = "There is already a category with this name";
                Txt_Name.Properties.Appearance.BorderColor = Color.FromArgb(245, 100, 100);
                Save.Enabled = false;
            }
            else
            {
                Txt_Name.Properties.Appearance.BorderColor = DefaultAppearance.BorderColor;
                Save.Enabled = true;
                errorText.Visible = false;
                errorText.Text = "";

            }
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            if (_mode == DialogMode.Create)
            {
                var save = new TemplateCategory(GlobalVariables.Application_Session)
                {
                    Name = Txt_Name.Text,
                    Description = Txt_Description.Text
                };
                save.TemplateItems?.Clear();
                TemplateItems?.ForEach(item => save.TemplateItems.Add(item));

                save.Save();
                GlobalVariables.Application_Session.CommitChanges();
            }
            if (_mode == DialogMode.Edit)
            {
                TemplateCategory.Name = Txt_Name.Text;
                TemplateCategory.Description = Txt_Description.Text;
                TemplateCategory.TemplateItems?.Clear();
                TemplateItems?.ForEach(item => TemplateCategory.TemplateItems.Add(item));
                TemplateCategory.Save();
                GlobalVariables.Application_Session.CommitChanges();
            }
            Close();
            Dispose();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            new TemplateDialog(this).ShowDialog();
        }
        private void Remove_CatItem_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Are you sure you want to Remove The selected items", "Remove Category Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                checkedListBoxControl1.CheckedItems.OfType<TemplateItem>().ToList()?.ForEach(item => TemplateItems.Remove(item));
            checkedListBoxControl1.DataSource = TemplateItems;
            checkedListBoxControl1.Update();
        }

        private void checkedListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (checkedListBoxControl1.CheckedIndices.Count > 0)
            {
                if (checkedListBoxControl1.CheckedIndices.Count == 1) Update_CatItem.Enabled = true;
                if (checkedListBoxControl1.CheckedIndices.Count > 1) Update_CatItem.Enabled = false;
                Remove_CatItem.Enabled = true;
            }
            else
            {
                Remove_CatItem.Enabled = false;
                Update_CatItem.Enabled = false;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void checkedListBoxControl1_CustomizeItem(object sender, CustomizeTemplatedItemEventArgs e)
        {
            var row = e.DataItem as TemplateItem;
            string name = row.Name;
            string colors = row.Colors?.ToString()??"";
            e.TemplatedItem.Elements["Colors"].Text = colors;
            e.TemplatedItem.Elements["Name"].Text = name;
        }
    }
}
public enum DialogMode { Edit, Create, None }
