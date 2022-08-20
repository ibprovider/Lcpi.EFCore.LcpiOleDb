﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 24.02.2021.
//
// (short)string_column==int_column
//
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Query.CastAs.SET_001.String.Int16{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE_VALUE=System.String;
using T_TARGET_VALUE=System.Int16;

////////////////////////////////////////////////////////////////////////////////
//class TestSet__004__param

public static class TestSet__004__param
{
 private const string c_NameOf__TABLE="TEST_MODIFY_ROW2";

 private const string c_NameOf__COL_SOURCE="COL_VARCHAR_32";
 private const string c_NameOf__COL_TARGET="COL2_SMALLINT";

 private sealed class MyContext:TestBaseDbContext
 {
  [Table(c_NameOf__TABLE)]
  public sealed class TEST_RECORD
  {
   [Key]
   [Column("TEST_ID")]
   public System.Int64? TEST_ID { get; set; }

   [Column(c_NameOf__COL_SOURCE,TypeName="VARCHAR(32)")]
   public T_SOURCE_VALUE COL_SOURCE { get; set; }

   [Column(c_NameOf__COL_TARGET)]
   public T_TARGET_VALUE COL_TARGET { get; set; }
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
 public static void Test_001__m1_6()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource="-1.6";
     const T_TARGET_VALUE c_valueTarget=-1;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource,c_valueTarget);

     T_SOURCE_VALUE vv=c_valueSource;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv==r.COL_TARGET && r.TEST_ID==testID);

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

      Assert.AreEqual
       (c_valueTarget,
        r.COL_TARGET);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).T(", ").N("t",c_NameOf__COL_TARGET).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").P_I2("__p_0").T(" = ").N("t",c_NameOf__COL_TARGET).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_001__m1_6

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_002__m1_5()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource="-1.5";
     const T_TARGET_VALUE c_valueTarget=-1;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource,c_valueTarget);

     T_SOURCE_VALUE vv=c_valueSource;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv==r.COL_TARGET && r.TEST_ID==testID);

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

      Assert.AreEqual
       (c_valueTarget,
        r.COL_TARGET);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).T(", ").N("t",c_NameOf__COL_TARGET).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").P_I2("__p_0").T(" = ").N("t",c_NameOf__COL_TARGET).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_002__m1_5

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_003__m1_4()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource="-1.4";
     const T_TARGET_VALUE c_valueTarget=-1;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource,c_valueTarget);

     T_SOURCE_VALUE vv=c_valueSource;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv==r.COL_TARGET && r.TEST_ID==testID);

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

      Assert.AreEqual
       (c_valueTarget,
        r.COL_TARGET);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).T(", ").N("t",c_NameOf__COL_TARGET).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").P_I2("__p_0").T(" = ").N("t",c_NameOf__COL_TARGET).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_003__m1_4

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_004__m1()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource="-1";
     const T_TARGET_VALUE c_valueTarget=-1;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource,c_valueTarget);

     T_SOURCE_VALUE vv=c_valueSource;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv==r.COL_TARGET && r.TEST_ID==testID);

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

      Assert.AreEqual
       (c_valueTarget,
        r.COL_TARGET);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).T(", ").N("t",c_NameOf__COL_TARGET).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").P_I2("__p_0").T(" = ").N("t",c_NameOf__COL_TARGET).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_004__m1

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_005__0()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource="0";
     const T_TARGET_VALUE c_valueTarget=0;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource,c_valueTarget);

     T_SOURCE_VALUE vv=c_valueSource;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv==r.COL_TARGET && r.TEST_ID==testID);

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

      Assert.AreEqual
       (c_valueTarget,
        r.COL_TARGET);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).T(", ").N("t",c_NameOf__COL_TARGET).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").P_I2("__p_0").T(" = ").N("t",c_NameOf__COL_TARGET).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_005__0

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_006__p1()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource="+1";
     const T_TARGET_VALUE c_valueTarget=1;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource,c_valueTarget);

     T_SOURCE_VALUE vv=c_valueSource;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv==r.COL_TARGET && r.TEST_ID==testID);

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

      Assert.AreEqual
       (c_valueTarget,
        r.COL_TARGET);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).T(", ").N("t",c_NameOf__COL_TARGET).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").P_I2("__p_0").T(" = ").N("t",c_NameOf__COL_TARGET).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_006__p1

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_007__p1_4()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource="+1.4";
     const T_TARGET_VALUE c_valueTarget=1;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource,c_valueTarget);

     T_SOURCE_VALUE vv=c_valueSource;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv==r.COL_TARGET && r.TEST_ID==testID);

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

      Assert.AreEqual
       (c_valueTarget,
        r.COL_TARGET);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).T(", ").N("t",c_NameOf__COL_TARGET).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").P_I2("__p_0").T(" = ").N("t",c_NameOf__COL_TARGET).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_007__p1_4

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_008__p1_5()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource="+1.5";
     const T_TARGET_VALUE c_valueTarget=1;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource,c_valueTarget);

     T_SOURCE_VALUE vv=c_valueSource;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv==r.COL_TARGET && r.TEST_ID==testID);

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

      Assert.AreEqual
       (c_valueTarget,
        r.COL_TARGET);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).T(", ").N("t",c_NameOf__COL_TARGET).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").P_I2("__p_0").T(" = ").N("t",c_NameOf__COL_TARGET).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_008__p1_5

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_009__p1_6()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource="+1.6";
     const T_TARGET_VALUE c_valueTarget=1;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource,c_valueTarget);

     T_SOURCE_VALUE vv=c_valueSource;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv==r.COL_TARGET && r.TEST_ID==testID);

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

      Assert.AreEqual
       (c_valueTarget,
        r.COL_TARGET);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).T(", ").N("t",c_NameOf__COL_TARGET).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").P_I2("__p_0").T(" = ").N("t",c_NameOf__COL_TARGET).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_009__p1_6

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_M01__minValue()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource="-32768";
     const T_TARGET_VALUE c_valueTarget=T_TARGET_VALUE.MinValue;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource,c_valueTarget);

     T_SOURCE_VALUE vv=c_valueSource;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv==r.COL_TARGET && r.TEST_ID==testID);

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

      Assert.AreEqual
       (c_valueTarget,
        r.COL_TARGET);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).T(", ").N("t",c_NameOf__COL_TARGET).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").P_I2("__p_0").T(" = ").N("t",c_NameOf__COL_TARGET).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_M01__minValue

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_M02__maxValue()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource="+32767";
     const T_TARGET_VALUE c_valueTarget=T_TARGET_VALUE.MaxValue;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource,c_valueTarget);

     T_SOURCE_VALUE vv=c_valueSource;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv==r.COL_TARGET && r.TEST_ID==testID);

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

      Assert.AreEqual
       (c_valueTarget,
        r.COL_TARGET);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).T(", ").N("t",c_NameOf__COL_TARGET).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").P_I2("__p_0").T(" = ").N("t",c_NameOf__COL_TARGET).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_M02__maxValue

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_M03()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE c_valueSource="000012345";
     const T_TARGET_VALUE c_valueTarget=12345;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource,c_valueTarget);

     T_SOURCE_VALUE vv=c_valueSource;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv==r.COL_TARGET && r.TEST_ID==testID);

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

      Assert.AreEqual
       (c_valueTarget,
        r.COL_TARGET);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).T(", ").N("t",c_NameOf__COL_TARGET).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").P_I2("__p_0").T(" = ").N("t",c_NameOf__COL_TARGET).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_M03

 //Helper methods --------------------------------------------------------
 private static System.Int64 Helper__InsertRow(MyContext      db,
                                               T_SOURCE_VALUE valueForColSource,
                                               T_TARGET_VALUE valueForColTarget)
 {
  var newRecord=new MyContext.TEST_RECORD();

  newRecord.COL_SOURCE =valueForColSource;
  newRecord.COL_TARGET =valueForColTarget;

  db.testTable.Add(newRecord);

  db.SaveChanges();

  db.CheckTextOfLastExecutedCommand
   (new TestSqlTemplate()
     .T("INSERT INTO ").N(c_NameOf__TABLE).T(" (").N(c_NameOf__COL_SOURCE).T(", ").N(c_NameOf__COL_TARGET).T(")").EOL()
     .T("VALUES (").P("p0").T(", ").P("p1").T(")").EOL()
     .T("RETURNING ").N("TEST_ID").EOL()
     .T("INTO ").P("p2").T(";"));

  Assert.IsTrue
   (newRecord.TEST_ID.HasValue);

  Console.WriteLine("TEST_ID: {0}",newRecord.TEST_ID.Value);

  return newRecord.TEST_ID.Value;
 }//Helper__InsertRow
};//class TestSet__004__param

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Query.CastAs.SET_001.String.Int16
