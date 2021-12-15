﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 29.03.2019.
//
// Math.Round(<param>)
//
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Funcs.Math.SET_001.STD.Round.Decimal{
////////////////////////////////////////////////////////////////////////////////
//using

using T_DATA=System.Decimal;

////////////////////////////////////////////////////////////////////////////////
//class TestSet___param

public static class TestSet___param
{
 private const string c_NameOf__TABLE="NUM";

 private const string c_NameOf__COL_DATA="N_7_4";

 private sealed class MyContext:TestBaseDbContext
 {
  [Table(c_NameOf__TABLE)]
  public sealed class TEST_RECORD
  {
   [Key]
   [Column("TEST_ID")]
   public System.Int64? TEST_ID { get; set; }

   [Column(c_NameOf__COL_DATA,TypeName ="NUMERIC(7,4)")]
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
 public static void Test___01___ByDBMS()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA c_data=1.9M;

     System.Int64? testID=Helper__InsertRow(db,c_data);

     var vv_src=c_data;

     var recs=db.testTable.Where(r => System.Math.Round(vv_src)==2 && r.TEST_ID==testID);

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
       (c_data,
        r.DATA);
     }//foreach r

     var sqlt
      =new TestSqlTemplate()
        .T("SELECT ").N("n","TEST_ID").T(", ").N("n",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("n").EOL()
        .T("WHERE ").N("n","TEST_ID").T(" = ").P_ID("__testID_0");

     db.CheckTextOfLastExecutedCommand
      (sqlt);

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___01___ByDBMS

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___02___ByDBMS()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA c_data=1.9M;

     System.Int64? testID=Helper__InsertRow(db,c_data);

     var vv_src=c_data;

     var recs=db.testTable.Where(r => System.Math.Round(System.Math.Round(vv_src))==2 && r.TEST_ID==testID);

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
       (c_data,
        r.DATA);
     }//foreach r

     var sqlt
      =new TestSqlTemplate()
        .T("SELECT ").N("n","TEST_ID").T(", ").N("n",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("n").EOL()
        .T("WHERE ").N("n","TEST_ID").T(" = ").P_ID("__testID_0");

     db.CheckTextOfLastExecutedCommand
      (sqlt);

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___02___ByDBMS

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___03___ByDBMS()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA c_data=1.9M;

     System.Int64? testID=Helper__InsertRow(db,c_data);

     var vv_src=c_data;

     var recs=db.testTable.Where(r => System.Math.Round(2*System.Math.Round(vv_src))==4 && r.TEST_ID==testID);

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
       (c_data,
        r.DATA);
     }//foreach r

     var sqlt
      =new TestSqlTemplate()
        .T("SELECT ").N("n","TEST_ID").T(", ").N("n",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("n").EOL()
        .T("WHERE ").N("n","TEST_ID").T(" = ").P_ID("__testID_0");

     db.CheckTextOfLastExecutedCommand
      (sqlt);

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___03___ByDBMS

 //-----------------------------------------------------------------------
 [Test]
 public static void Test___04___ByDBMS()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA c_data=1.9M;

     System.Int64? testID=Helper__InsertRow(db,c_data);

     var vv_src=c_data;

     string vv_str=null;

#pragma warning disable CS0472
     var recs=db.testTable.Where(r => System.Math.Round(2*System.Math.Round(vv_src*vv_str.Length))==null && r.TEST_ID==testID);
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
       (c_data,
        r.DATA);
     }//foreach r

     var sqlt
      =new TestSqlTemplate()
        .T("SELECT ").N("n","TEST_ID").T(", ").N("n",c_NameOf__COL_DATA).EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("n").EOL()
        .T("WHERE ").N("n","TEST_ID").T(" = ").P_ID("__testID_0");

     db.CheckTextOfLastExecutedCommand
      (sqlt);

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test___04___ByDBMS

 //-----------------------------------------------------------------------
 private static System.Int64 Helper__InsertRow(MyContext db,
                                               T_DATA    valueOfData)
 {
  var newRecord=new MyContext.TEST_RECORD();

  newRecord.DATA=valueOfData;

  db.testTable.Add(newRecord);

  db.SaveChanges();

  var sqlt
   =new TestSqlTemplate()
     .T("INSERT INTO ").N(c_NameOf__TABLE).T(" (").N(c_NameOf__COL_DATA).T(")").EOL()
     .T("VALUES (").P("p0").T(")").EOL()
     .T("RETURNING ").N("TEST_ID").EOL()
     .T("INTO ").P("p1").T(";");

  db.CheckTextOfLastExecutedCommand
   (sqlt);

  Assert.IsTrue
   (newRecord.TEST_ID.HasValue);

  Console.WriteLine("TEST_ID: {0}",newRecord.TEST_ID.Value);

  return newRecord.TEST_ID.Value;
 }//Helper__InsertRow
};//class TestSet___param

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Funcs.Math.SET_001.STD.Round.Decimal
