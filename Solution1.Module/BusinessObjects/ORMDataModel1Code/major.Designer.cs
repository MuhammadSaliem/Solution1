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

    public partial class major : XPBaseObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        string fname;
        public string name
        {
            get { return fname; }
            set { SetPropertyValue<string>(nameof(name), ref fname, value); }
        }
        Instructor fprogramDirector;
        public Instructor programDirector
        {
            get { return fprogramDirector; }
            set { SetPropertyValue<Instructor>(nameof(programDirector), ref fprogramDirector, value); }
        }
        school fschool;
        [Association(@"majorReferencesschool")]
        public school school
        {
            get { return fschool; }
            set { SetPropertyValue<school>(nameof(school), ref fschool, value); }
        }
        course fcourse;
        [Association(@"majorReferencescourse")]
        public course course
        {
            get { return fcourse; }
            set { SetPropertyValue<course>(nameof(course), ref fcourse, value); }
        }
    }

}
