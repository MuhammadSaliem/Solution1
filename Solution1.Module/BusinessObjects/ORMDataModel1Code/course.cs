using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace Solution1.Module.BusinessObjects.uniDB
{
    [DefaultClassOptions]
    public partial class course
    {
        public course(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
