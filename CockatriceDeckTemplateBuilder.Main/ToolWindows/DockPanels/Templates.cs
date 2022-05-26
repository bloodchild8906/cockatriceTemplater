using CockatriceDeckTemplateBuilder.Main.Collections;
using CockatriceDeckTemplateBuilder.Main.Database.databasev2;
using CockatriceDeckTemplateBuilder.Main.Dialogs;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.ViewInfo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace CockatriceDeckTemplateBuilder.Main.ToolWindows.DockPanels
{
    public delegate void TemplateItemDoubleClickHandler(TemplateItem e);
    public delegate void TemplateCategoryDoubleClickHandler(TemplateCategory e);
    public partial class Templates : XtraUserControl
    {
        public event TemplateItemDoubleClickHandler TemplateItemDoubleClickEvent;
        public event TemplateCategoryDoubleClickHandler TemplateCategoryDoubleClickEvent;

        private List<TemplateCategory> _list;

        XPCollection<TemplateCategory> _getRecords;
        private DockPanel _dockPanel;

        public Templates() => InitializeComponent();

        public List<TemplateCategory> TemplateCategories;
        public TemplateCategory TemplateCategory;

        private TreeListNode _currentNode;
        private TreeListColumn _currentColumn;



        public void LoadControl(DockManager dockManager)
        {
            var control = this;
            control.Dock = DockStyle.Fill;
            _dockPanel = dockManager.AddPanel(control, DockingStyle.Left, "Categories");
            _dockPanel.MinimumSize = new System.Drawing.Size(253, 0);
            LoadTemplates();
        }


        #region Construct Tree
        private void LoadTemplates()
        {
            if (_list is null)
                _list = new List<TemplateCategory>();
            _list.Clear();
            if (_getRecords == null)
            {
                _getRecords = new XPCollection<TemplateCategory>(GlobalVariables.Application_Session);
                TemplateCategories = _getRecords.ToList();
            }
            else
            {
                _getRecords.Reload();

            }
            foreach (var item in _getRecords)
            {
                if (_list is null) _list = new List<TemplateCategory>();
                _list.Add(item);
            }
            if (treeList != null)
            {
                _dockPanel?.Update();
                init();
            }
            simpleButton3.Enabled = false;
            simpleButton4.Enabled = false;
            _currentNode = null;
            _currentColumn = null;
        }

        private void CreateColumns()
        {
            treeList.BeginUpdate();
            TreeListColumn col1 = treeList.Columns.Add();
            col1.FieldName = "Name";
            col1.Caption = "Categories";
            col1.AllNodesSummary = true;
            col1.VisibleIndex = 0;
            treeList.EndUpdate();
        }

        private void CreateNodes()
        {
            treeList.BeginUnboundLoad();
            TreeListNode parentForRootNodes = null;
            TreeListNode rootNode = null;
            _list?.ForEach(category =>
            {
                rootNode = treeList.AppendNode(new object[] { category.Name }, parentForRootNodes);
                category.TemplateItems.ToList().ForEach(templateItem =>
                {
                    treeList.AppendNode(new object[] { templateItem.Name }, rootNode);
                });
            });
            treeList.EndUnboundLoad();
        }

        private void ResetTree()
        {
            treeList.ClearNodes();
            treeList.Columns.Clear();
        }
        private void init()
        {
            ResetTree();
            CreateColumns();
            CreateNodes();
        }
        private void ToolTipController1_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl is TreeList tree)
            {
                var hit = tree.CalcHitInfo(e.ControlMousePosition);
                if (hit.HitInfoType == HitInfoType.Cell)
                {
                    object cellInfo = new TreeListCellToolTipInfo(hit.Node, hit.Column, null);
                    var nodeValue = hit?.Node.GetValue(hit.Column)?.ToString() ?? "";
                    if (string.IsNullOrEmpty(nodeValue)) return;
                    if (hit.Node.ParentNode != null)
                        e.Info = new ToolTipControlInfo(cellInfo,
                            _list.FirstOrDefault(node => node.Name == hit.Node.ParentNode.GetValue(hit.Column).ToString())
                            .TemplateItems.FirstOrDefault(node => node.Name == nodeValue).Description);
                    if (hit.Node.ParentNode == null)
                        e.Info = new ToolTipControlInfo(cellInfo, _list.FirstOrDefault(node => node.Name == nodeValue).Description);

                }
            }
        }
        private void CategoryWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTemplates();
        }
        #endregion



        private void TreeListNodeDoubleClick(object sender, EventArgs e)
        {
            var info = treeList.CalcHitInfo(treeList.PointToClient(MousePosition));
            Debug.WriteLine(info.Node.ParentNode == null);
            if (info.Node.ParentNode != null)
            {
                TemplateItemDoubleClickEvent?
                    .Invoke(
                        _list.FirstOrDefault(node => node.Name == info.Node.ParentNode.GetValue(info.Column).ToString())
                        .TemplateItems.FirstOrDefault(node => node.Name == info.Node.GetValue(info.Column).ToString())
                        );
            }
            if (info.Node.ParentNode == null)
            {
                TemplateCategoryDoubleClickEvent?
                     .Invoke(_list.FirstOrDefault(node => node.Name == info.Node.GetValue(info.Column).ToString()));
            }
        }

        private void CreateButtonClicked(object sender, EventArgs e)
        {
            var catwindow = new CategoryEditorDialog(DialogMode.Create, _list);
            catwindow.FormClosed += CategoryWindow_FormClosed;
            catwindow.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //get the selected cell
            var index_ref = _list.FirstOrDefault(templateCategory => templateCategory.Name == _currentNode.GetValue(_currentColumn).ToString());
            var index = _list.IndexOf(index_ref);
            var catwindow = new CategoryEditorDialog(DialogMode.Edit, _list, index);

            catwindow.FormClosed += CategoryWindow_FormClosed;
            catwindow.ShowDialog();

        }

        private void treeList_RowClick(object sender, RowClickEventArgs e)
        {
            _currentNode = e.Node;
            if (e.HitInfo.Column != null)
                _currentColumn = e.HitInfo.Column;

            simpleButton3.Enabled = _currentNode.HasChildren || _currentNode.ParentNode == null && _currentColumn != null;
            simpleButton4.Enabled = _currentNode.HasChildren || _currentNode.ParentNode == null && _currentColumn != null;


        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Are you sure you want to delete this category? doing so will delete all the templates under it.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                _getRecords.Session.BeginTransaction();
                TemplateCategory = _getRecords.FirstOrDefault(templateCategory => templateCategory.Name == _currentNode.GetValue(_currentColumn).ToString());
                TemplateCategory.TemplateItems.ToList().ForEach(item => item.Delete());
                _getRecords.Session.Delete(TemplateCategory);
                _getRecords.Session.Save(TemplateCategories);
                _getRecords.Session.CommitTransaction();
                LoadTemplates();

            }

        }

        private void treeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {

        }
    }
}
