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

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Query.CastAs.SET_001.Decimal.String{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE_VALUE=System.Decimal;
using T_TARGET_VALUE=System.String;

using T_SOURCE_VALUE_U=System.Decimal;

////////////////////////////////////////////////////////////////////////////////
//class TestSet__004__param

public static class TestSet__004__param
{
 private const string c_NameOf__TABLE="DUAL";

 private const int c_TARGET_VCH_LENGTH=32;

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

     T_SOURCE_VALUE vv=c_valueSource_;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv=="-1.6");

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
       (1,
        r.TEST_ID.Value);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE ").P_BOOL("__Exec_V_V_0"));

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

     T_SOURCE_VALUE vv=c_valueSource_;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv=="-1.5");

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
       (1,
        r.TEST_ID.Value);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE ").P_BOOL("__Exec_V_V_0"));

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

     T_SOURCE_VALUE vv=c_valueSource_;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv=="-1.4");

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
       (1,
        r.TEST_ID.Value);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE ").P_BOOL("__Exec_V_V_0"));

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

     T_SOURCE_VALUE vv=c_valueSource_;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv=="-1");

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
       (1,
        r.TEST_ID.Value);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE ").P_BOOL("__Exec_V_V_0"));

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

     T_SOURCE_VALUE vv=c_valueSource_;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv=="0");

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
       (1,
        r.TEST_ID.Value);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE ").P_BOOL("__Exec_V_V_0"));

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

     T_SOURCE_VALUE vv=c_valueSource_;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv=="1");

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
       (1,
        r.TEST_ID.Value);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE ").P_BOOL("__Exec_V_V_0"));

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

     T_SOURCE_VALUE vv=c_valueSource_;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv=="1.4");

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
       (1,
        r.TEST_ID.Value);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE ").P_BOOL("__Exec_V_V_0"));

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

     T_SOURCE_VALUE vv=c_valueSource_;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv=="1.5");

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
       (1,
        r.TEST_ID.Value);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE ").P_BOOL("__Exec_V_V_0"));

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

     T_SOURCE_VALUE vv=c_valueSource_;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv=="1.6");

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
       (1,
        r.TEST_ID.Value);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE ").P_BOOL("__Exec_V_V_0"));

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

     T_SOURCE_VALUE vv=c_valueSource_;

     var recs=db.testTable.Where(r => (T_TARGET_VALUE)(object)vv=="123456789.1");

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
       (1,
        r.TEST_ID.Value);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE ").P_BOOL("__Exec_V_V_0"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_A001__p123456789_1
};//class TestSet__004__param

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Query.CastAs.SET_001.Decimal.String
