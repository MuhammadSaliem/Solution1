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
namespace Solution1.Module.BusinessObjects.uniDB
{

    public partial class course : XPBaseObject
    {
        string fcode;
        [Key]
        public string code
        {
            get { return fcode; }
            set { SetPropertyValue<string>(nameof(code), ref fcode, value); }
        }
        string fname;
        public string name
        {
            get { return fname; }
            set { SetPropertyValue<string>(nameof(name), ref fname, value); }
        }
        string fcredits;
        public string credits
        {
            get { return fcredits; }
            set { SetPropertyValue<string>(nameof(credits), ref fcredits, value); }
        }
        Instructor finstructor;
        [Association(@"courseReferencesInstructor")]
        public Instructor instructor
        {
            get { return finstructor; }
            set { SetPropertyValue<Instructor>(nameof(instructor), ref finstructor, value); }
        }
        string fsemster;
        public string semster
        {
            get { return fsemster; }
            set { SetPropertyValue<string>(nameof(semster), ref fsemster, value); }
        }
        [Association(@"studnetCoursesReferencescourse")]
        public XPCollection<studnetCourses> studnetCoursesCollection { get { return GetCollection<studnetCourses>(nameof(studnetCoursesCollection)); } }
        [Association(@"majorReferencescourse")]
        public XPCollection<major> majors { get { return GetCollection<major>(nameof(majors)); } }
        [Association(@"courseSectionReferencescourse"), Aggregated]
        public XPCollection<courseSection> courseSections { get { return GetCollection<courseSection>(nameof(courseSections)); } }
        [Association(@"courseTAsReferencescourse"), Aggregated]
        public XPCollection<courseTAs> courseTAsCollection { get { return GetCollection<courseTAs>(nameof(courseTAsCollection)); } }
    }

}