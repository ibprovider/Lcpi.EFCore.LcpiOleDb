﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 08.06.2021.
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Funcs.MS_EFCore.DbFunctions.SET_001.EXT.Like__str2{
////////////////////////////////////////////////////////////////////////////////
//using

using T_DATA=System.String;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_002

public static class TestSet_002
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
 public static void Test_0001()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64? testID=Helper__InsertRow(db,"1");

     var recs=db.testTable.Where(r => EF.Functions.Like(""+EF.Functions.Like(r.DATA,"1"),"TRUE") && r.TEST_ID==testID);

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
       ("1",
        r.DATA);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE ((_utf8 ''||COALESCE(").N("t",c_NameOf__COL_DATA).T(" LIKE _utf8 '1', _utf8 '')) LIKE _utf8 'TRUE') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_0001

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0002()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64? testID=Helper__InsertRow(db,"1");

     var recs=db.testTable.Where(r => EF.Functions.Like(""+EF.Functions.Like("1","1"),"TRUE") && r.TEST_ID==testID);

     // int nRecs=0;
     //
     // foreach(var r in recs)
     // {
     //  Assert.AreEqual
     //   (0,
     //    nRecs);
     //
     //  ++nRecs;
     //
     //  Assert.IsTrue
     //   (r.TEST_ID.HasValue);
     //
     //  Assert.AreEqual
     //   (testID,
     //    r.TEST_ID.Value);
     //
     //  Assert.AreEqual
     //   ("1",
     //    r.DATA);
     // }//foreach r
     //
     // db.CheckTextOfLastExecutedCommand
     //  (new TestSqlTemplate()
     //    .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
     //    .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
     //    .T("WHERE (_utf8 ''||(_utf8 '1' LIKE _utf8 '1') LIKE _utf8 'TRUE') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));
     //
     // Assert.AreEqual
     //  (1,
     //   nRecs);

     // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
     //
     //  [2021-11-27]. Uncomment this, when FB will able to work without problem.
     //

     try
     {
      foreach(var r in recs)
      {
       TestServices.ThrowWeWaitError();
      }

      TestServices.ThrowWeWaitError();
     }
     catch(xdb.OleDbException exc)
     {
      CheckErrors.PrintException_OK
       (exc);

      Assert.AreEqual
       (3,
        TestUtils.GetRecordCount(exc));

      Assert.AreEqual
       (2,
        exc.Errors.Count);

      StringAssert.Contains
       ("Dynamic SQL Error\n"
        +"SQL error code = -104\n"
        +"Token unknown - line 3, column 30\n"
        +"LIKE",
        exc.Errors[0].Message);
     }//catch
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_0002

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0003()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64? testID=Helper__InsertRow(db,"1");

     var recs=db.testTable.Where(r => EF.Functions.Like((string)(object)EF.Functions.Like("1","1"),"TRUE") && r.TEST_ID==testID);

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
       ("1",
        r.DATA);
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
        .T("WHERE (CAST((_utf8 '1' LIKE _utf8 '1') AS VARCHAR(5)) LIKE _utf8 'TRUE') AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_0003

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0004()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     System.Int64? testID=Helper__InsertRow(db,"1");

     var recs=db.testTable.Where(r => EF.Functions.Like(""+EF.Functions.Like(""+r.DATA,""+r.DATA),""+((""+r.DATA)==r.DATA)) && r.TEST_ID==testID);

     // int nRecs=0;
     //
     // foreach(var r in recs)
     // {
     //  Assert.AreEqual
     //   (0,
     //    nRecs);
     //
     //  ++nRecs;
     //
     //  Assert.IsTrue
     //   (r.TEST_ID.HasValue);
     //
     //  Assert.AreEqual
     //   (testID,
     //    r.TEST_ID.Value);
     //
     //  Assert.AreEqual
     //   ("1",
     //    r.DATA);
     // }//foreach r
     //
     // db.CheckTextOfLastExecutedCommand
     //  (new TestSqlTemplate()
     //    .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA).EOL()
     //    .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
     //    .T("WHERE ((_utf8 ''||((_utf8 ''||").N_TXT_NP("t",c_NameOf__COL_DATA).T(") LIKE (_utf8 ''||").N_TXT_NP("t",c_NameOf__COL_DATA).T("))) LIKE (_utf8 ''||(((_utf8 ''||").N_TXT_NP("t",c_NameOf__COL_DATA).T(") = ").N("t",c_NameOf__COL_DATA).T(") AND (").N("t",c_NameOf__COL_DATA).T(" IS NOT NULL)))) AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_1").T(")"));
     //
     // Assert.AreEqual
     //  (1,
     //   nRecs);

     // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
     //
     //  [2021-11-27]. Uncomment this, when FB will able to work without problem.
     //

     try
     {
      foreach(var r in recs)
      {
       TestServices.ThrowWeWaitError();
      }

      TestServices.ThrowWeWaitError();
     }
     catch(xdb.OleDbException exc)
     {
      CheckErrors.PrintException_OK
       (exc);

      Assert.AreEqual
       (3,
        TestUtils.GetRecordCount(exc));

      Assert.AreEqual
       (2,
        exc.Errors.Count);

      StringAssert.Contains
       ("Dynamic SQL Error\n"
        +"SQL error code = -104\n"
        +"Token unknown - line 3, column 73\n"
        +"LIKE",
        exc.Errors[0].Message);
     }//catch
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_0004

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
};//class TestSet_002

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Funcs.MS_EFCore.DbFunctions.SET_001.EXT.Like__str2
