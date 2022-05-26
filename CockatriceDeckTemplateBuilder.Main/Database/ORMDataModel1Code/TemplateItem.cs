using DevExpress.Xpo;
namespace CockatriceDeckTemplateBuilder.Main.Database.databasev2
{

    public partial class TemplateItem
    {
        public TemplateItem(Session session) : base(session) { }
        public TemplateItem() : base() { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
