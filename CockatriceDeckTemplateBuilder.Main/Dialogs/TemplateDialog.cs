using CockatriceDeckTemplateBuilder.Main.Collections;
using CockatriceDeckTemplateBuilder.Main.Database.databasev2;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using TemplateItem = CockatriceDeckTemplateBuilder.Main.Database.databasev2.TemplateItem;

namespace CockatriceDeckTemplateBuilder.Main.Dialogs
{
    public partial class TemplateDialog : XtraForm
    {
        //readonly List<Database.databasev2.TemplateItem> TemplateItems;
        private CategoryEditorDialog _parent;
        public TemplateDialog(CategoryEditorDialog categoryEditor)
        {
            InitializeComponent();
            _parent= categoryEditor;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _parent.TemplateItems.Add(new TemplateItem(GlobalVariables.Application_Session) { Name = Txt_Name.Text, Description = Txt_Description.Text,Colors=Cmb_Colors.Text });
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TemplateDialog_Load(object sender, EventArgs e)
        {

        }

        private void Cmb_Colors_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
