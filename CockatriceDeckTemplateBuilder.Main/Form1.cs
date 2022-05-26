using CockatriceDeckTemplateBuilder.Main.Collections;
using CockatriceDeckTemplateBuilder.Main.Database.databasev2;
using CockatriceDeckTemplateBuilder.Main.Dialogs;
using CockatriceDeckTemplateBuilder.Main.ToolWindows;
using CockatriceDeckTemplateBuilder.Main.ToolWindows.DockPanels;
using DevExpress.DataAccess.DataFederation;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CockatriceDeckTemplateBuilder.Main
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DockPanel cdb;

        List<DockPanel> tabbed_docs=new List<DockPanel>();
        
        public Form1()
        {
            InitializeComponent();
            cdb = new CardDataBase().LoadControl(dockManager);
            tabbed_docs.Add(cdb);

        }

        private void Configuration_ItemClick(object sender, ItemClickEventArgs e)
        {
            _ = new Settings().ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            new Templates().LoadControl(dockManager);
        }
    }
}