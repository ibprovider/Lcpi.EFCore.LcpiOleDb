﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 03.10.2018.
//
// <field+text>.StartsWith(...)
//
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Funcs.String.SET_001.STD.EndsWith__str{
////////////////////////////////////////////////////////////////////////////////
//using

using T_DATA=System.String;

////////////////////////////////////////////////////////////////////////////////
//class TestSet___Expr_with_param

public static class TestSet___Expr_with_param
{
 private const string c_NameOf__TABLE="TEST_MODIFY_ROW";

 private const string c_NameOf__COL_DATA="COL_VARCHAR_10";

 //-----------------------------------------------------------------------
 private sealed class MyContext:TestBaseDbContext
 {
  [Table(c_NameOf__TABLE)]
  public sealed class TEST_RECORD
  {
   [Key]
   [Column("TEST_ID")]
   public System.Int64? TEST_ID { get; set; }

   [Column(c_NameOf__COL_DATA, TypeName="VARCHAR(10)")]
   public T_DATA DATA { get; set; }
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
 public static void Test___field___ByDBMS()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64 testID=Helper__InsertRow(db,"ABC\0123");

     T_DATA vvs="";

     var recs=db.testTable.Where(r => (r.DATA+vvs).EndsWith(r.DATA) && r.TEST_ID==testID);

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
       ("ABC\0123",
        r.DATA);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (RIGHT(").N_TXT_NP("t",c_NameOf__COL_DATA).T("||").P_TXT("__vvs_0").T(", CHARACTER_LENGTH(").N("t",c_NameOf__COL_DATA).T(")) = ").N("t",c_NameOf__COL_DATA).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___field___ByDBMS

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___text___ByDBMS()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64 testID=Helper__InsertRow(db,"ABC\0123");

     T_DATA vvs="45";

     var recs=db.testTable.Where(r => (r.DATA+vvs).EndsWith("12345") && r.TEST_ID==testID);

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
       ("ABC\0123",
        r.DATA);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (RIGHT(").N_TXT_NP("t",c_NameOf__COL_DATA).T("||").P_TXT("__vvs_0").T(", 5) = _utf8 '12345') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___text___ByDBMS

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___textZ___ByDBMS()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64 testID=Helper__InsertRow(db,"ABC\0123");

     T_DATA vvs="45";

     var recs=db.testTable.Where(r => (r.DATA+vvs).EndsWith("\012345") && r.TEST_ID==testID);

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
       ("ABC\0123",
        r.DATA);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (RIGHT(").N_TXT_NP("t",c_NameOf__COL_DATA).T("||").P_TXT("__vvs_0").T(", 6) = _utf8 x'00'||_utf8 '12345') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___textZ___ByDBMS

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___textZ___ByDBMS_____no()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64 testID=Helper__InsertRow(db,"\0ABC123");

     T_DATA vvs="-";

     var recs=db.testTable.Where(r => (r.DATA+vvs).EndsWith("\0ABC1234") && r.TEST_ID==testID);

     foreach(var r in recs)
     {
      TestServices.ThrowSelectedRow();
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (RIGHT(").N_TXT_NP("t",c_NameOf__COL_DATA).T("||").P_TXT("__vvs_0").T(", 8) = _utf8 x'00'||_utf8 'ABC1234') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___textZ___ByDBMS_____no

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___textLower___ByDBMS()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64 testID=Helper__InsertRow(db,"123\0ABC");

     T_DATA vvs="";

     var recs=db.testTable.Where(r => (r.DATA+vvs).EndsWith("abc") && r.TEST_ID==testID);

     foreach(var r in recs)
     {
      TestServices.ThrowSelectedRow();
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (RIGHT(").N_TXT_NP("t",c_NameOf__COL_DATA).T("||").P_TXT("__vvs_0").T(", 3) = _utf8 'abc') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___textLower___ByDBMS

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___param___ByEF()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64 testID=Helper__InsertRow(db,"ABC\0123");

     T_DATA vv="\01234";

     T_DATA vvs="4";

     var recs=db.testTable.Where(r => (r.DATA+vvs).EndsWith(vv) && r.TEST_ID==testID);

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
       ("ABC\0123",
        r.DATA);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (RIGHT(").N_TXT_NP("t",c_NameOf__COL_DATA).T("||").P_TXT("__vvs_0").T(", CHARACTER_LENGTH(").P_TXT("__vv_1").T(")) = ").P_TXT("__vv_1").T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_2").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___param___ByEF

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___param___ByEF_____no()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64 testID=Helper__InsertRow(db,"ABC123\0");

     T_DATA vvs="-";

     T_DATA vv="123\0";

     var recs=db.testTable.Where(r => (r.DATA+vvs).EndsWith(vv) && r.TEST_ID==testID);

     foreach(var r in recs)
     {
      TestServices.ThrowSelectedRow();
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (RIGHT(").N_TXT_NP("t",c_NameOf__COL_DATA).T("||").P_TXT("__vvs_0").T(", CHARACTER_LENGTH(").P_TXT("__vv_1").T(")) = ").P_TXT("__vv_1").T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_2").T(")"));
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___param___ByEF_____no

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___paramL___ByEF()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64 testID=Helper__InsertRow(db,"\0ABC123");

     T_DATA vv="01234567890123456789012345678901234567890123456789012345678901234567890123456789";

     T_DATA vvs="";

     var recs=db.testTable.Where(r => (r.DATA+vvs).EndsWith(vv) && r.TEST_ID==testID);

     foreach(var r in recs)
     {
      TestServices.ThrowSelectedRow();
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (RIGHT(").N_TXT_NP("t",c_NameOf__COL_DATA).T("||").P_TXT("__vvs_0").T(", CHARACTER_LENGTH(").P_TXT("__vv_1").T(")) = ").P_TXT("__vv_1").T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_2").T(")"));
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___paramL___ByEF

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___paramL___ByEF____yes()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64 testID=Helper__InsertRow(db,"\0ABC123");

     T_DATA vv="01234567890123456789012345678901234567890123456789012345678901234567890123456789";

     T_DATA vvs=vv;

     var recs=db.testTable.Where(r => (r.DATA+vvs).EndsWith(vv) && r.TEST_ID==testID);

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
       ("\0ABC123",
        r.DATA);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (RIGHT(").N_TXT_NP("t",c_NameOf__COL_DATA).T("||").P_TXT("__vvs_0").T(", CHARACTER_LENGTH(").P_TXT("__vv_1").T(")) = ").P_TXT("__vv_1").T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_2").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___paramL___ByEF____yes

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___paramN___ByEF()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64 testID=Helper__InsertRow(db,"\0ABC123");

     T_DATA vv=null;

     T_DATA vvs="-";

     var recs=db.testTable.Where(r => (r.DATA+vvs).EndsWith(vv) && r.TEST_ID==testID);

     foreach(var r in recs)
     {
      TestServices.ThrowSelectedRow();
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (RIGHT(").N_TXT_NP("t",c_NameOf__COL_DATA).T("||").P_TXT("__vvs_0").T(", CHARACTER_LENGTH(NULL)) = NULL) AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_2").T(")"));
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___paramN___ByEF

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___paramN___ByEF_____no()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64 testID=Helper__InsertRow(db,"\0ABC123");

     T_DATA vv=null;

     T_DATA vvs="-";

#pragma warning disable CS0472
     var recs=db.testTable.Where(r => (r.DATA+vvs).EndsWith(vv)==null && r.TEST_ID==testID);
#pragma warning restore CS0472

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
       ("\0ABC123",
        r.DATA);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE ").N("t","TEST_ID").T(" = ").P_ID("__testID_2"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___paramN___ByEF_____no

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___exprToLowerToUpper___ByDBMS()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64 testID=Helper__InsertRow(db,"ABC\0123");

     T_DATA vvs="";

     var recs=db.testTable.Where(r => (r.DATA+vvs).EndsWith(r.DATA.ToLower().ToUpper()) && r.TEST_ID==testID);

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
       ("ABC\0123",
        r.DATA);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (RIGHT(").N_TXT_NP("t",c_NameOf__COL_DATA).T("||").P_TXT("__vvs_0").T(", CHARACTER_LENGTH(UPPER(LOWER(").N("t",c_NameOf__COL_DATA).T(")))) = UPPER(LOWER(").N("t",c_NameOf__COL_DATA).T("))) AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___exprToLowerToUpper___ByDBMS

 //-----------------------------------------------------------------------
 private static System.Int64 Helper__InsertRow(MyContext db,
                                               T_DATA    valueOfData)
 {
  var newRecord=new MyContext.TEST_RECORD();

  newRecord.DATA=valueOfData;

  db.testTable.Add(newRecord);

  db.SaveChanges();

  db.CheckTextOfLastExecutedCommand
   (new TestSqlTemplate()
     .T("INSERT INTO ").N(c_NameOf__TABLE).T(" (").N(c_NameOf__COL_DATA).T(")").EOL()
     .T("VALUES (").P("p0").T(")").EOL()
     .T("RETURNING ").N("TEST_ID").EOL()
     .T("INTO ").P("p1").T(";"));

  Assert.IsTrue
   (newRecord.TEST_ID.HasValue);

  Console.WriteLine("TEST_ID: {0}",newRecord.TEST_ID.Value);

  return newRecord.TEST_ID.Value;
 }//Helper__InsertRow
};//class TestSet___Expr_with_param

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Funcs.String.SET_001.STD.EndsWith__str
