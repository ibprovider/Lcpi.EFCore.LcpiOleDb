﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 27.01.2021.
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.CastAs.SET_001.Decimal_15_1.String{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE_VALUE=System.Decimal;
using T_TARGET_VALUE=System.String;

using T_SOURCE_VALUE_U=System.Decimal;

////////////////////////////////////////////////////////////////////////////////
//class TestSet__001__field

public static class TestSet__001__field
{
 private const string c_NameOf__TABLE="TEST_MODIFY_ROW2";

 private const string c_NameOf__COL_SOURCE="COL_NUM_15_1";

 private const int c_TARGET_VCH_LENGTH=32;

 private const T_SOURCE_VALUE_U c_SRC_MIN=T_SOURCE_VALUE_U.MinValue;
 private const T_SOURCE_VALUE_U c_SRC_MAX=T_SOURCE_VALUE_U.MaxValue;

 private sealed class MyContext:TestBaseDbContext
 {
  [Table(c_NameOf__TABLE)]
  public sealed class TEST_RECORD
  {
   [Key]
   [Column("TEST_ID")]
   public System.Int64? TEST_ID { get; set; }

   [Column(c_NameOf__COL_SOURCE,TypeName="NUMERIC(15,1)")]
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
     const T_SOURCE_VALUE_U c_valueSource_=-1.6m;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource_);

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)r.COL_SOURCE=="-1.6" && r.TEST_ID==testID);

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
       (c_valueSource_,
        r.COL_SOURCE);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N_AS_VCH("t",c_NameOf__COL_SOURCE,c_TARGET_VCH_LENGTH).T(" = _utf8 '-1.6') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

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
     const T_SOURCE_VALUE_U c_valueSource_=-1.5m;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource_);

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)r.COL_SOURCE=="-1.5" && r.TEST_ID==testID);

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
       (c_valueSource_,
        r.COL_SOURCE);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N_AS_VCH("t",c_NameOf__COL_SOURCE,c_TARGET_VCH_LENGTH).T(" = _utf8 '-1.5') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

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
     const T_SOURCE_VALUE_U c_valueSource_=-1.4m;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource_);

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)r.COL_SOURCE=="-1.4" && r.TEST_ID==testID);

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
       (c_valueSource_,
        r.COL_SOURCE);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N_AS_VCH("t",c_NameOf__COL_SOURCE,c_TARGET_VCH_LENGTH).T(" = _utf8 '-1.4') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

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
     const T_SOURCE_VALUE_U c_valueSource_=-1m;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource_);

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)r.COL_SOURCE=="-1.0" && r.TEST_ID==testID);

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
       (c_valueSource_,
        r.COL_SOURCE);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N_AS_VCH("t",c_NameOf__COL_SOURCE,c_TARGET_VCH_LENGTH).T(" = _utf8 '-1.0') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

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
 public static void Test_005__zero()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE_U c_valueSource_=0m;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource_);

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)r.COL_SOURCE=="0.0" && r.TEST_ID==testID);

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
       (c_valueSource_,
        r.COL_SOURCE);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N_AS_VCH("t",c_NameOf__COL_SOURCE,c_TARGET_VCH_LENGTH).T(" = _utf8 '0.0') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_005__zero

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
     const T_SOURCE_VALUE_U c_valueSource_=+1m;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource_);

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)r.COL_SOURCE=="1.0" && r.TEST_ID==testID);

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
       (c_valueSource_,
        r.COL_SOURCE);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N_AS_VCH("t",c_NameOf__COL_SOURCE,c_TARGET_VCH_LENGTH).T(" = _utf8 '1.0') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

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
     const T_SOURCE_VALUE_U c_valueSource_=1.4m;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource_);

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)r.COL_SOURCE=="1.4" && r.TEST_ID==testID);

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
       (c_valueSource_,
        r.COL_SOURCE);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N_AS_VCH("t",c_NameOf__COL_SOURCE,c_TARGET_VCH_LENGTH).T(" = _utf8 '1.4') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

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
     const T_SOURCE_VALUE_U c_valueSource_=1.5m;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource_);

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)r.COL_SOURCE=="1.5" && r.TEST_ID==testID);

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
       (c_valueSource_,
        r.COL_SOURCE);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N_AS_VCH("t",c_NameOf__COL_SOURCE,c_TARGET_VCH_LENGTH).T(" = _utf8 '1.5') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

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
     const T_SOURCE_VALUE_U c_valueSource_=1.6m;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource_);

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)r.COL_SOURCE=="1.6" && r.TEST_ID==testID);

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
       (c_valueSource_,
        r.COL_SOURCE);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N_AS_VCH("t",c_NameOf__COL_SOURCE,c_TARGET_VCH_LENGTH).T(" = _utf8 '1.6') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

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
 public static void Test_A001__p123456789_1()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_SOURCE_VALUE_U c_valueSource_=123456789.1m;

     System.Int64? testID=Helper__InsertRow(db,c_valueSource_);

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)r.COL_SOURCE=="123456789.1" && r.TEST_ID==testID);

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
       (c_valueSource_,
        r.COL_SOURCE);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_SOURCE).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (").N_AS_VCH("t",c_NameOf__COL_SOURCE,c_TARGET_VCH_LENGTH).T(" = _utf8 '123456789.1') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_A001__p123456789_1

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
};//class TestSet__001__field

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.CastAs.SET_001.Decimal_15_1.String
