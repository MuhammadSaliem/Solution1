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

    public partial class studnetCourses : XPBaseObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        student fstudent;
        [Association(@"studnetCoursesReferencesstudent")]
        public student student
        {
            get { return fstudent; }
            set { SetPropertyValue<student>(nameof(student), ref fstudent, value); }
        }
        course fcourse;
        [Association(@"studnetCoursesReferencescourse")]
        public course course
        {
            get { return fcourse; }
            set { SetPropertyValue<course>(nameof(course), ref fcourse, value); }
        }
        courseSection fsection;
        public courseSection section
        {
            get { return fsection; }
            set { SetPropertyValue<courseSection>(nameof(section), ref fsection, value); }
        }
    }

}
