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

    public partial class phone : XPBaseObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        string fphoneNumber;
        public string phoneNumber
        {
            get { return fphoneNumber; }
            set { SetPropertyValue<string>(nameof(phoneNumber), ref fphoneNumber, value); }
        }
        TA fTA;
        [Association(@"phoneReferencesTA")]
        [System.ComponentModel.Browsable(false)]
        public TA TA
        {
            get { return fTA; }
            set { SetPropertyValue<TA>(nameof(TA), ref fTA, value); }
        }
        Instructor fInstructor;
        [Association(@"phoneReferencesInstructor")]
        [System.ComponentModel.Browsable(false)]
        public Instructor Instructor
        {
            get { return fInstructor; }
            set { SetPropertyValue<Instructor>(nameof(Instructor), ref fInstructor, value); }
        }
        student fstudent;
        [Association(@"phoneReferencesstudent")]
        [System.ComponentModel.Browsable(false)]
        public student student
        {
            get { return fstudent; }
            set { SetPropertyValue<student>(nameof(student), ref fstudent, value); }
        }
    }

}
