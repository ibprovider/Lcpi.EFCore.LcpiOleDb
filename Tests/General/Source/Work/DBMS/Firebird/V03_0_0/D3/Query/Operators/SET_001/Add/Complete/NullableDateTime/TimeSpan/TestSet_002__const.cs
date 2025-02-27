﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 27.11.2020.
using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Operators.SET_001.Add.Complete.NullableDateTime.TimeSpan{
////////////////////////////////////////////////////////////////////////////////

using T_DATA1   =System.Nullable<System.DateTime>;
using T_DATA2   =System.TimeSpan;
using T_RESULT  =System.Nullable<System.DateTime>;

using T_DATA1_U =System.DateTime;
using T_DATA2_U =System.TimeSpan;
using T_RESULT_U=System.DateTime;

using DB_TABLE=LocalDbObjNames.TEST_MODIFY_ROW2;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_002__const

public static class TestSet_002__const
{
 private const string c_NameOf__TABLE            =DB_TABLE.Name;
 private const string c_NameOf__COL_DATA1        ="COL_TIMESTAMP";
 private const string c_NameOf__COL_DATA2        =DB_TABLE.Columns.COL2_for_TimeSpan;

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
     T_DATA1 c_value1=new T_DATA1_U(2020,11,27);
     T_DATA2 c_value2=new T_DATA2_U(14,12,11);

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     Assert.AreEqual
      (new System.DateTime(2020,11,27,14,12,11),
       c_value1+new System.TimeSpan(14,12,11));

     var recs=db.testTable.Where(r => (r.COL_DATA1+(T_DATA2)new T_DATA2_U(14,12,11))==(T_RESULT)new T_RESULT_U(2020,11,27,14,12,11) && r.TEST_ID==testID);

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
       .T("WHERE (DATEADD(MILLISECOND,1000 * CAST(51131.0000 AS NUMERIC(18,4)),").N("t",c_NameOf__COL_DATA1).T(") = timestamp '2020-11-27 14:12:11') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")");

     db.CheckTextOfLastExecutedCommand
      (sqlt);

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_001

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_002__ms()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     T_DATA1 c_value1=new T_DATA1_U(2020,11,27);
     T_DATA2 c_value2=new T_DATA2_U(14,12,11);

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     Assert.AreEqual
      (new System.DateTime(2020,11,27,14,12,11,13),
       c_value1+new System.TimeSpan(0,14,12,11,13));

     var recs=db.testTable.Where(r => (r.COL_DATA1+(T_DATA2)new T_DATA2_U(0,14,12,11,13))==(T_RESULT)new T_RESULT_U(2020,11,27,14,12,11,13) && r.TEST_ID==testID);

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

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (DATEADD(MILLISECOND,1000 * CAST(51131.0130 AS NUMERIC(18,4)),").N("t",c_NameOf__COL_DATA1).T(") = timestamp '2020-11-27 14:12:11.013') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_002__ms

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_003__mcs()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     T_DATA1 c_value1=new T_DATA1_U(2020,11,27);
     T_DATA2 c_value2=new T_DATA2_U(14,12,11)+new T_DATA2_U(1000);

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     Assert.AreEqual
      (new System.DateTime(2020,11,27,14,12,11)+new System.TimeSpan(1000),
       c_value1+c_value2);

     var recs=db.testTable.Where(r => (r.COL_DATA1+(T_DATA2)(new T_DATA2_U(14,12,11)+new T_DATA2_U(1000)))==((T_RESULT)new T_RESULT_U(2020,11,27,14,12,11)+new System.TimeSpan(1000)) && r.TEST_ID==testID);

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

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (DATEADD(MILLISECOND,1000 * CAST(51131.0001 AS NUMERIC(18,4)),").N("t",c_NameOf__COL_DATA1).T(") = timestamp '2020-11-27 14:12:11.0001') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_003__mcs

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
};//class TestSet_002__const

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Operators.SET_001.Add.Complete.NullableDateTime.TimeSpan
