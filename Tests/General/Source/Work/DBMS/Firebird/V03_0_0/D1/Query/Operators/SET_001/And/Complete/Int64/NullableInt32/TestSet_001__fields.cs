﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 11.12.2020.
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Query.Operators.SET_001.And.Complete.Int64.NullableInt32{
////////////////////////////////////////////////////////////////////////////////

using T_DATA1=System.Int64;
using T_DATA2=System.Nullable<System.Int32>;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_001__fields

public static class TestSet_001__fields
{
 private const string c_NameOf__TABLE            ="TEST_MODIFY_ROW2";
 private const string c_NameOf__COL_DATA1        ="COL_BIGINT";
 private const string c_NameOf__COL_DATA2        ="COL2_INTEGER";

 private sealed class MyContext:TestBaseDbContext
 {
  [Table(c_NameOf__TABLE)]
  public sealed class TEST_RECORD
  {
   [Key]
   [Column("TEST_ID")]
   public System.Int64? TEST_ID { get; set; }

   [Column(c_NameOf__COL_DATA1)]
   public T_DATA1 COL_DATA1 { get; set; }

   [Column(c_NameOf__COL_DATA2)]
   public T_DATA2 COL_DATA2 { get; set; }
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
 public static void Test_00a01()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1 c_value1=2+4;
           T_DATA2 c_value2=1+2;

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     Assert.AreEqual
      (2,
       c_value1&c_value2);

     var recs=db.testTable.Where(r => (r.COL_DATA1&r.COL_DATA2)==2 && r.TEST_ID==testID);

     int nRecs=0;

     foreach(var r in recs)
     {
      Assert.AreEqual
       (0,
        nRecs);

      ++nRecs;

      Assert.IsTrue
       (r.TEST_ID.HasValue);

      Assert.AreEqual
       (testID,
        r.TEST_ID.Value);

      Assert.AreEqual
       (c_value1,
        r.COL_DATA1);

      Assert.AreEqual
       (c_value2,
        r.COL_DATA2);
     }//foreach r

     var sqlt
      =new TestSqlTemplate()
       .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
       .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
       .T("WHERE (BIN_AND(").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).T(") = 2) AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")");

     db.CheckTextOfLastExecutedCommand
      (sqlt);

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_00a01

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_00x01()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1 c_value1=3;
           T_DATA2 c_value2=1;

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     Assert.AreEqual
      (1,
       c_value1&c_value2&c_value2);

     var recs=db.testTable.Where(r => (r.COL_DATA1&r.COL_DATA2&r.COL_DATA2)==1 && r.TEST_ID==testID);

     int nRecs=0;

     foreach(var r in recs)
     {
      Assert.AreEqual
       (0,
        nRecs);

      ++nRecs;

      Assert.IsTrue
       (r.TEST_ID.HasValue);

      Assert.AreEqual
       (testID,
        r.TEST_ID.Value);

      Assert.AreEqual
       (c_value1,
        r.COL_DATA1);

      Assert.AreEqual
       (c_value2,
        r.COL_DATA2);
     }//foreach r

     var sqlt
      =new TestSqlTemplate()
       .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
       .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
       .T("WHERE (BIN_AND(BIN_AND(").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).T("), ").N("t",c_NameOf__COL_DATA2).T(") = 1) AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")");

     db.CheckTextOfLastExecutedCommand
      (sqlt);

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_00x01

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_00x02()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1 c_value1=3;
           T_DATA2 c_value2=1;

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     Assert.AreEqual
      (2,
       c_value1&(c_value2+c_value2));

     var recs=db.testTable.Where(r => (r.COL_DATA1&(r.COL_DATA2+r.COL_DATA2))==2 && r.TEST_ID==testID);

     try
     {
      foreach(var r in recs)
      {
       TestServices.ThrowSelectedRow();
      }

      TestServices.ThrowWeWaitError();
     }
     catch(lcpi.lib.structure.exceptions.t_invalid_operation_exception e)
     {
      CheckErrors.PrintException_OK(e);

      Assert.AreEqual
       (1,
        TestUtils.GetRecordCount(e));

      CheckErrors.CheckErrorRecord__sql_translator_err__unsupported_binary_operator_type_3
       (TestUtils.GetRecord(e,0),
        CheckErrors.c_src__EFCoreDataProvider__FB_Common__BinaryOperatorTranslatorProvider,
        Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.LcpiOleDb__ExpressionType.And,
        typeof(System.Int64),
        typeof(System.Double));
     }//catch
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_00x02

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_01a01__nullV2()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1 c_value1=3;

     System.Int64? testID=Helper__InsertRow(db,c_value1,null);

     var recs=db.testTable.Where(r => (r.COL_DATA1&r.COL_DATA2)==null && r.TEST_ID==testID);

     int nRecs=0;

     foreach(var r in recs)
     {
      Assert.AreEqual
       (0,
        nRecs);

      ++nRecs;

      Assert.IsTrue
       (r.TEST_ID.HasValue);

      Assert.AreEqual
       (testID,
        r.TEST_ID.Value);

      Assert.AreEqual
       (c_value1,
        r.COL_DATA1);

      Assert.IsNull
       (r.COL_DATA2);
     }//foreach r

     var sqlt
      =new TestSqlTemplate()
       .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
       .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
       .T("WHERE (").N("t",c_NameOf__COL_DATA2).IS_NULL().T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")");

     db.CheckTextOfLastExecutedCommand
      (sqlt);

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_01a01__nullV2

 //-----------------------------------------------------------------------
 private static System.Int64 Helper__InsertRow(MyContext db,
                                               T_DATA1   valueForColData1,
                                               T_DATA2   valueForColData2)
 {
  var newRecord=new MyContext.TEST_RECORD();

  newRecord.COL_DATA1 =valueForColData1;
  newRecord.COL_DATA2 =valueForColData2;

  db.testTable.Add(newRecord);

  db.SaveChanges();

  db.CheckTextOfLastExecutedCommand
   (new TestSqlTemplate()
     .T("INSERT INTO ").N(c_NameOf__TABLE).T(" (").N(c_NameOf__COL_DATA1).T(", ").N(c_NameOf__COL_DATA2).T(")").EOL()
     .T("VALUES (").P("p0").T(", ").P("p1").T(")").EOL()
     .T("RETURNING ").N("TEST_ID").EOL()
     .T("INTO ").P("p2").T(";"));

  Assert.IsTrue
   (newRecord.TEST_ID.HasValue);

  Console.WriteLine("TEST_ID: {0}",newRecord.TEST_ID.Value);

  return newRecord.TEST_ID.Value;
 }//Helper__InsertRow
};//class TestSet_001__fields

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Query.Operators.SET_001.And.Complete.Int64.NullableInt16
