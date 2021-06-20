using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Solution1.Module.BusinessObjects.uniDB
{
    [DefaultProperty("name")]
    public partial class major
    {
        public major(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
