using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Solution1.Module.BusinessObjects.uniDB
{

    public partial class courseTAs
    {
        public courseTAs(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
