﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 10.02.2021.
//
// (long)ROUND(double_column)
//
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

using xdbfunc=Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.DbFunctions;

using xEFCore_FB3=Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Query.CastAs.SET_001.Double.Int64{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE_VALUE=System.Double;
using T_TARGET_VALUE=System.Int64;

////////////////////////////////////////////////////////////////////////////////
//class TestSet__SQL___CastOfRound

public static class TestSet__SQL___CastOfRound
{
 private const string c_NameOf__TABLE="TEST_MODIFY_ROW2";

 private const string c_NameOf__COL_SOURCE="COL_DOUBLE";

 private const string c_NameOf__TARGET_SQL_TYPE=xEFCore_FB3.FB_V03_0_0__Consts.c_TypeOf_BIGINT_D1;

 private sealed class MyContext:TestBaseDbContext
 {
  [Table(c_NameOf__TABLE)]
  public sealed class TEST_RECORD
  {
   [Key]
   [Column("TEST_ID")]
   public System.Int64? TEST_ID { get; set; }

   [Column(c_NameOf__COL_SOURCE)]
   public T_SOURCE_VALUE COL_SOURCE { get; set; }
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
 public static void Test_001__m1_456()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource=-1.456;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource);

     var recs=db.testTable.Where(r => ((T_TARGET_VALUE)xdbfunc.DbMath.Round(r.COL_SOURCE)).Equals((T_TARGET_VALUE)(-1)) && r.TEST_ID==testID);

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
       (c_valueSource,
        r.COL_SOURCE);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (CAST(ROUND(").N("t",c_NameOf__COL_SOURCE).T(") AS "+c_NameOf__TARGET_SQL_TYPE+") = -1) AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_001__m1_456

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_002__m1_567()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource=-1.567;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource);

     var recs=db.testTable.Where(r => ((T_TARGET_VALUE)xdbfunc.DbMath.Round(r.COL_SOURCE)).Equals((T_TARGET_VALUE)(-2)) && r.TEST_ID==testID);

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
       (c_valueSource,
        r.COL_SOURCE);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (CAST(ROUND(").N("t",c_NameOf__COL_SOURCE).T(") AS "+c_NameOf__TARGET_SQL_TYPE+") = -2) AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_002__m1_567

 //-----------------------------------------------------------------------
 private static System.Int64 Helper__InsertRow(MyContext      db,
                                               T_SOURCE_VALUE valueForColSource)
 {
  var newRecord=new MyContext.TEST_RECORD();

  newRecord.COL_SOURCE =valueForColSource;

  db.testTable.Add(newRecord);

  db.SaveChanges();

  db.CheckTextOfLastExecutedCommand
   (new TestSqlTemplate()
     .T("INSERT INTO ").N(c_NameOf__TABLE).T(" (").N(c_NameOf__COL_SOURCE).T(")").EOL()
     .T("VALUES (").P("p0").T(")").EOL()
     .T("RETURNING ").N("TEST_ID").EOL()
     .T("INTO ").P("p1").T(";"));

  Assert.IsTrue
   (newRecord.TEST_ID.HasValue);

  Console.WriteLine("TEST_ID: {0}",newRecord.TEST_ID.Value);

  return newRecord.TEST_ID.Value;
 }//Helper__InsertRow
};//class TestSet__SQL___CastOfRound

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Query.CastAs.SET_001.Double.Int64
