//------------------------------------------------------------------------------
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
namespace Solution1.Module.BusinessObjects.uniDB
{

    public partial class courseTAs : XPBaseObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        course fcourse;
        [Association(@"courseTAsReferencescourse")]
        public course course
        {
            get { return fcourse; }
            set { SetPropertyValue<course>(nameof(course), ref fcourse, value); }
        }
        TA fTA;
        [Association(@"courseTAsReferencesTA")]
        public TA TA
        {
            get { return fTA; }
            set { SetPropertyValue<TA>(nameof(TA), ref fTA, value); }
        }
    }

}
