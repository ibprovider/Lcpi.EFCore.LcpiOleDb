﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 06.10.2021.
using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Operators.SET_001.Subtract.Complete.DateTime.DateTime{
////////////////////////////////////////////////////////////////////////////////

using T_DATA1   =System.DateTime;
using T_DATA2   =System.DateTime;
using T_RESULT  =System.TimeSpan;

using T_DATA1_U =System.DateTime;
using T_DATA2_U =System.DateTime;
using T_RESULT_U=System.TimeSpan;

using DB_TABLE=LocalDbObjNames.TEST_MODIFY_ROW2;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_002__const

public static class TestSet_002__const
{
 private const string c_NameOf__TABLE            =DB_TABLE.Name;
 private const string c_NameOf__COL_DATA1        =DB_TABLE.Columns.COL_for_DateTime;
 private const string c_NameOf__COL_DATA2        =DB_TABLE.Columns.COL2_for_DateTime;

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
     T_DATA1 c_value1=new T_DATA1_U(2021,10,06,14,21,7,123);
     T_DATA2 c_value2=new T_DATA2_U(2021,10,05, 1, 2,3,  4);

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     var recs=db.testTable.Where(r => (r.COL_DATA1-(T_DATA2)new T_DATA2_U(2021,10,5,1,2,3,4))==(T_RESULT)(new T_RESULT_U(1,13,19,4,119)) && r.TEST_ID==testID);

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
        .T("WHERE ((DATEDIFF(MILLISECOND,timestamp '2021-10-05 01:02:03.004',").N("t",c_NameOf__COL_DATA1).T(") * 0.001) = CAST(134344.1190 AS NUMERIC(18,4))) AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

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
 public static void Test_001__revert()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     T_DATA1 c_value1=new T_DATA2_U(2021,10,05, 1, 2,3,  4);
     T_DATA2 c_value2=new T_DATA1_U(2021,10,06,14,21,7,123);

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     var recs=db.testTable.Where(r => (r.COL_DATA1-(T_DATA2)new T_DATA1_U(2021,10,06,14,21,7,123))==(T_RESULT)(new T_RESULT_U()-new T_RESULT_U(1,13,19,4,119)) && r.TEST_ID==testID);

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
        .T("WHERE ((DATEDIFF(MILLISECOND,timestamp '2021-10-06 14:21:07.123',").N("t",c_NameOf__COL_DATA1).T(") * 0.001) = CAST(-134344.1190 AS NUMERIC(18,4))) AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_001__revert

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
     T_DATA1 c_value1=new T_DATA1_U(2020,11,27,14,12,11);
     T_DATA2 c_value2=new T_DATA2_U(2020,11,26,1,2,3).AddTicks(1000+1);

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     //long v_ticks2
     // =new c_value2.Ticks;

     const long c_ticks2
      =637419493230001001;

     Assert.AreEqual
      (c_ticks2,
       c_value2.Ticks);

     var recs=db.testTable.Where(r => (r.COL_DATA1-(T_DATA2)new T_DATA2_U(c_ticks2))==((T_RESULT)new T_RESULT_U(1,13,10,7,0)+new T_RESULT_U(9999000)) && r.TEST_ID==testID);

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
        .T("WHERE ((DATEDIFF(MILLISECOND,timestamp '2020-11-26 01:02:03.0001',").N("t",c_NameOf__COL_DATA1).T(") * 0.001) = CAST(133807.9999 AS NUMERIC(18,4))) AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

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
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Operators.SET_001.Subtract.Complete.DateTime.DateTime
