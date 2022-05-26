namespace CockatriceDeckTemplateBuilder.Main.Dialogs
{
    partial class CategoryEditorDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryEditorDialog));
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            this.Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.Save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.Remove_CatItem = new DevExpress.XtraEditors.SimpleButton();
            this.Update_CatItem = new DevExpress.XtraEditors.SimpleButton();
            this.Add_CatItem = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Description = new DevExpress.XtraEditors.MemoEdit();
            this.errorText = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Cancel.ImageOptions.SvgImage")));
            this.Cancel.Location = new System.Drawing.Point(12, 322);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(82, 43);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Save.ImageOptions.SvgImage")));
            this.Save.Location = new System.Drawing.Point(239, 322);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(82, 43);
            this.Save.TabIndex = 20;
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Clicked);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Description";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 137);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Templates";
            // 
            // checkedListBoxControl1
            // 
            this.checkedListBoxControl1.CheckOnClick = true;
            this.checkedListBoxControl1.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.checkedListBoxControl1.ItemHeight = 45;
            this.checkedListBoxControl1.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("asdfasdf"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("asdfasdf"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("asdfasdf"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("asdfasd")});
            this.checkedListBoxControl1.Location = new System.Drawing.Point(89, 137);
            this.checkedListBoxControl1.Name = "checkedListBoxControl1";
            this.checkedListBoxControl1.Size = new System.Drawing.Size(182, 179);
            this.checkedListBoxControl1.TabIndex = 27;
            itemTemplateBase1.Columns.Add(tableColumnDefinition1);
            itemTemplateBase1.Columns.Add(tableColumnDefinition2);
            templatedItemElement1.FieldName = "Name";
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement1.Text = "Name";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ColumnIndex = 1;
            templatedItemElement2.FieldName = "Colors";
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement2.Name = "Colors";
            templatedItemElement2.Text = "Colors";
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Elements.Add(templatedItemElement2);
            itemTemplateBase1.Name = "TemplateItems";
            tableRowDefinition1.Length.Value = 15D;
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            this.checkedListBoxControl1.Templates.Add(itemTemplateBase1);
            this.checkedListBoxControl1.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkedListBoxControl1_ItemCheck);
            this.checkedListBoxControl1.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxControl1_SelectedIndexChanged);
            this.checkedListBoxControl1.CustomizeItem += new DevExpress.XtraEditors.CustomizeTemplatedItemEventHandler(this.checkedListBoxControl1_CustomizeItem);
            // 
            // Remove_CatItem
            // 
            this.Remove_CatItem.Appearance.Options.UseTextOptions = true;
            this.Remove_CatItem.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Remove_CatItem.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.Remove_CatItem.AppearanceDisabled.BackColor2 = System.Drawing.Color.Gray;
            this.Remove_CatItem.AppearanceDisabled.Options.UseBackColor = true;
            this.Remove_CatItem.AppearanceDisabled.Options.UseBorderColor = true;
            this.Remove_CatItem.AppearanceDisabled.Options.UseFont = true;
            this.Remove_CatItem.AppearanceDisabled.Options.UseForeColor = true;
            this.Remove_CatItem.AppearanceDisabled.Options.UseImage = true;
            this.Remove_CatItem.AppearanceDisabled.Options.UseTextOptions = true;
            this.Remove_CatItem.Enabled = false;
            this.Remove_CatItem.ImageOptions.Image = global::CockatriceDeckTemplateBuilder.Main.Properties.Resources.icons8_minus_32;
            this.Remove_CatItem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.Remove_CatItem.Location = new System.Drawing.Point(278, 234);
            this.Remove_CatItem.Name = "Remove_CatItem";
            this.Remove_CatItem.Size = new System.Drawing.Size(43, 42);
            this.Remove_CatItem.TabIndex = 26;
            this.Remove_CatItem.Click += new System.EventHandler(this.Remove_CatItem_Click);
            // 
            // Update_CatItem
            // 
            this.Update_CatItem.Appearance.Options.UseTextOptions = true;
            this.Update_CatItem.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Update_CatItem.Enabled = false;
            this.Update_CatItem.ImageOptions.Image = global::CockatriceDeckTemplateBuilder.Main.Properties.Resources.icons8_pencil_32;
            this.Update_CatItem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.Update_CatItem.Location = new System.Drawing.Point(278, 185);
            this.Update_CatItem.Name = "Update_CatItem";
            this.Update_CatItem.Size = new System.Drawing.Size(43, 42);
            this.Update_CatItem.TabIndex = 25;
            // 
            // Add_CatItem
            // 
            this.Add_CatItem.Appearance.Options.UseTextOptions = true;
            this.Add_CatItem.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Add_CatItem.ImageOptions.Image = global::CockatriceDeckTemplateBuilder.Main.Properties.Resources.icons8_plus___32;
            this.Add_CatItem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.Add_CatItem.Location = new System.Drawing.Point(278, 137);
            this.Add_CatItem.Name = "Add_CatItem";
            this.Add_CatItem.Size = new System.Drawing.Size(43, 42);
            this.Add_CatItem.TabIndex = 22;
            this.Add_CatItem.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(89, 24);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Txt_Name.Size = new System.Drawing.Size(182, 20);
            this.Txt_Name.TabIndex = 13;
            this.Txt_Name.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // Txt_Description
            // 
            this.Txt_Description.Location = new System.Drawing.Point(89, 50);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Size = new System.Drawing.Size(182, 81);
            this.Txt_Description.TabIndex = 17;
            // 
            // errorText
            // 
            this.errorText.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.errorText.Appearance.Options.UseForeColor = true;
            this.errorText.Appearance.Options.UseTextOptions = true;
            this.errorText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.errorText.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.errorText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.errorText.Location = new System.Drawing.Point(89, 4);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(182, 13);
            this.errorText.TabIndex = 28;
            this.errorText.Text = "labelControl4";
            this.errorText.Visible = false;
            // 
            // CategoryEditorDialog
            // 
            this.AcceptButton = this.Save;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(335, 377);
            this.ControlBox = false;
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.checkedListBoxControl1);
            this.Controls.Add(this.Remove_CatItem);
            this.Controls.Add(this.Update_CatItem);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Add_CatItem);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Txt_Description);
            this.EnableAcrylicAccent = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.False;
            this.IconOptions.ShowIcon = false;
            this.Name = "CategoryEditorDialog";
            this.ShowInTaskbar = false;
            this.ShowMdiChildCaptionInParentTitle = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Category";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Cancel;
        private DevExpress.XtraEditors.SimpleButton Save;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txt_Name;
        private DevExpress.XtraEditors.MemoEdit Txt_Description;
        private DevExpress.XtraEditors.SimpleButton Add_CatItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Update_CatItem;
        private DevExpress.XtraEditors.SimpleButton Remove_CatItem;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl errorText;
    }
}