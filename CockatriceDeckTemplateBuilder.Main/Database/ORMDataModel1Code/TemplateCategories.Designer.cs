﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CockatriceDeckTemplateBuilder.Main.Database.databasev2
{

    public partial class TemplateCategory : XPObject
    {

        string _name;
        public string Name
        {
            get { return _name; }
            set { SetPropertyValue<string>(nameof(Name), ref _name, value); }
        }
        string _description;

        public string Description
        {
            get { return _description; }
            set { SetPropertyValue<string>(nameof(Description), ref _description, value); }
        }
        [Association(@"TemplateItemReferencesTemplateCategories")]
        public IList<TemplateItem> TemplateItems=> GetList<TemplateItem>(nameof(TemplateItems));

    }

}
