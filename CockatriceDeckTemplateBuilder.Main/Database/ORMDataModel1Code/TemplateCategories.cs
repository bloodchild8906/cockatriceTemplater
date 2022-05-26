using DevExpress.Xpo;
namespace CockatriceDeckTemplateBuilder.Main.Database.databasev2
{

    public partial class TemplateCategory
    {
        public TemplateCategory(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
