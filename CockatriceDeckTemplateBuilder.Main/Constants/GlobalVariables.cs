using CockatriceDeckTemplateBuilder.Main.Database.databasev2;
using DevExpress.Xpo;

namespace CockatriceDeckTemplateBuilder.Main.Collections
{
    public static class GlobalVariables {
        public static readonly UnitOfWork Application_Session = new UnitOfWork(ConnectionHelper.DefaultConnection);
    }

}
