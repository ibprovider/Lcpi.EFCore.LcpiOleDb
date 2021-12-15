﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 28.12.2020.
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Funcs.Object.SET_001.STD.Equals__obj2.Complete.Boolean.Boolean{
////////////////////////////////////////////////////////////////////////////////

using T_DATA1=System.Boolean;
using T_DATA2=System.Boolean;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_001__fields

public static class TestSet_001__fields
{
 private const string c_NameOf__TABLE            ="TEST_MODIFY_ROW2";
 private const string c_NameOf__COL_DATA1        ="COL_BOOLEAN";
 private const string c_NameOf__COL_DATA2        ="COL2_BOOLEAN";

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
 public static void Test_001__field__field()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1 c_value1=true;
     const T_DATA2 c_value2=true;

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     var recs=db.testTable.Where(r => object.Equals(r.COL_DATA1,r.COL_DATA2) && r.TEST_ID==testID);

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
        .T("WHERE (").N("t",c_NameOf__COL_DATA1).T(" = ").N("t",c_NameOf__COL_DATA2).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_001__field__field

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_002__null__field()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1 c_value1=true;
     const T_DATA2 c_value2=true;

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     var recs=db.testTable.Where(r => !object.Equals(null,r.COL_DATA2) && r.TEST_ID==testID);

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
        .T("WHERE ").N("t","TEST_ID").T(" = ").P_ID("__testID_0"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_002__null__field

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_003__field__null()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     const T_DATA1 c_value1=true;
     const T_DATA2 c_value2=true;

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     var recs=db.testTable.Where(r => !object.Equals(r.COL_DATA1,null) && r.TEST_ID==testID);

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
        .T("WHERE ").N("t","TEST_ID").T(" = ").P_ID("__testID_0"));

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_003__field__null

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_100()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     var Errors=new List<int>();

     for(int iData=0;iData!=MasterValues.sm_Data100.Length;++iData)
     {
      Console.WriteLine("------------------------------ [{0}]",iData);

      var testData=MasterValues.sm_Data100[iData];

      if(!testData.arg1.HasValue)
       continue;

      if(!testData.arg2.HasValue)
       continue;

      T_DATA1 vv1=testData.arg1.Value;
      T_DATA2 vv2=testData.arg2.Value;

      System.Int64? testID=Helper__InsertRow(db,vv1,vv2);

      var recs=db.testTable.Where(r => object.Equals(r.COL_DATA1,r.COL_DATA2) && r.TEST_ID==testID);

      try
      {
       if(testData.result)
       {
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
          (vv1,
           r.COL_DATA1);

         Assert.AreEqual
          (vv2,
           r.COL_DATA2);
        }//foreach r

        Assert.AreEqual
         (1,
          nRecs);
       }
       else
       {
        Debug.Assert(!testData.result);

        foreach(var r in recs)
        {
         TestServices.ThrowSelectedRow();
        }//foreach r
       }//else

       db.CheckTextOfLastExecutedCommand
        (new TestSqlTemplate()
          .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
          .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
          .T("WHERE (").N("t",c_NameOf__COL_DATA1).T(" = ").N("t",c_NameOf__COL_DATA2).T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")"));
      }
      catch(Exception e)
      {
       Errors.Add(iData);

       Console.WriteLine("FAILED!");

       CheckErrors.PrintException(e);
      }//catch
     }//for iData

     if(Errors.Count!=0)
     {
      var ids
       =string.Join(", ", Errors.Select(p => p.ToString()));

      var msg
       =string.Format
         ("Some subtests [{0}] was finished with errors!",
          ids);

      throw new ApplicationException(msg);
     }//if Errors.Count!=0
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_100

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
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Funcs.Object.SET_001.STD.Equals__obj2.Complete.Boolean.Boolean
