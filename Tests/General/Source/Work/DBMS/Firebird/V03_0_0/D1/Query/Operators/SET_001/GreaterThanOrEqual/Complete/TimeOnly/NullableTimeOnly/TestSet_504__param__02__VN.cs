﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 13.05.2021.
using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Query.Operators.SET_001.GreaterThanOrEqual.Complete.TimeOnly.NullableTimeOnly{
////////////////////////////////////////////////////////////////////////////////

using T_DATA1  =System.TimeOnly;
using T_DATA2  =System.Nullable<System.TimeOnly>;

using T_DATA1_U=System.TimeOnly;
using T_DATA2_U=System.TimeOnly;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_504__param__02__VN

public static class TestSet_504__param__02__VN
{
 private const string c_NameOf__TABLE            ="DUAL";

 private sealed class MyContext:TestBaseDbContext
 {
  [Table(c_NameOf__TABLE)]
  public sealed class TEST_RECORD
  {
   [Key]
   [Column("ID")]
   public System.Int32? TEST_ID { get; set; }
  };//class TEST_RECORD

  //----------------------------------------------------------------------
  public DbSet<TEST_RECORD> testTable { get; set; }

  //----------------------------------------------------------------------
  public MyContext(xdb.OleDbTransaction tr)
   :base(tr)
  {
  }//MyContext
 };//class MyContext

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_001()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     T_DATA1 vv1=new T_DATA1_U(12,14,34).Add(new System.TimeSpan(1000*1233)).Add(new System.TimeSpan(900));
     T_DATA2 vv2=null;

     var recs=db.testTable.Where(r => vv1 /*OP{*/ >= /*}OP*/ vv2);

     foreach(var r in recs)
     {
      TestServices.ThrowSelectedRow();
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE NULL"));
    }//using db

    tr.Commit();
   }//using tr
  }//using cn
 }//Test_001

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_002()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     T_DATA1 vv1=new T_DATA1_U(12,14,34).Add(new System.TimeSpan(1000*1233)).Add(new System.TimeSpan(900));
     T_DATA2 vv2=null;

     var recs=db.testTable.Where(r => !(vv1 /*OP{*/ >= /*}OP*/ vv2));

     foreach(var r in recs)
     {
      TestServices.ThrowSelectedRow();
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE NULL"));
    }//using db

    tr.Commit();
   }//using tr
  }//using cn
 }//Test_002
};//class TestSet_504__param__02__VN

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Query.Operators.SET_001.GreaterThanOrEqual.Complete.TimeOnly.NullableTimeOnly
