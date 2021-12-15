﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 23.11.2020.
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

using structure_lib=lcpi.lib.structure;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Query.Operators.SET_001.RightShift.Complete.NullableInt16.Int32{
////////////////////////////////////////////////////////////////////////////////

using T_DATA1=System.Nullable<System.Int16>;
using T_DATA2=System.Int32;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_001__fields

public static class TestSet_001__fields
{
 private const string c_NameOf__TABLE            ="TEST_MODIFY_ROW2";
 private const string c_NameOf__COL_DATA1        ="COL_SMALLINT";
 private const string c_NameOf__COL_DATA2        ="COL2_INTEGER";

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
           T_DATA1 c_value1=8+2+1;
     const T_DATA2 c_value2=1;

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     Assert.AreEqual
      (4+1,
       c_value1>>c_value2);

     var recs=db.testTable.Where(r => (r.COL_DATA1>>r.COL_DATA2)==5 && r.TEST_ID==testID);

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
       .T("WHERE (BIN_SHR(").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).T(") = 5) AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")");

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
 public static void Test_002__null__value___eq___value()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     //const T_DATA1 c_value1=8+2+1;
     const T_DATA2 c_value2=1;

     System.Int64? testID=Helper__InsertRow(db,null,c_value2);

     var recs=db.testTable.Where(r => (r.COL_DATA1>>r.COL_DATA2)==5 && r.TEST_ID==testID);

     foreach(var r in recs)
     {
      TestServices.ThrowSelectedRow();
     }//foreach r

     var sqlt
      =new TestSqlTemplate()
       .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
       .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
       .T("WHERE (BIN_SHR(").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).T(") = 5) AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")");

     db.CheckTextOfLastExecutedCommand
      (sqlt);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_002__null__value___eq___value

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_003__null__value___eq___null()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     //const T_DATA1 c_value1=8+2+1;
     const T_DATA2 c_value2=1;

     System.Int64? testID=Helper__InsertRow(db,null,c_value2);

     var recs=db.testTable.Where(r => (r.COL_DATA1>>r.COL_DATA2)==null && r.TEST_ID==testID);

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

      Assert.IsNull
       (r.COL_DATA1);

      Assert.AreEqual
       (c_value2,
        r.COL_DATA2);
     }//foreach r

     var sqlt
      =new TestSqlTemplate()
       .T("SELECT ").N("t","TEST_ID").T(", ").N("t",c_NameOf__COL_DATA1).T(", ").N("t",c_NameOf__COL_DATA2).EOL()
       .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("t").EOL()
       .T("WHERE (").N("t",c_NameOf__COL_DATA1).IS_NULL().T(") AND (").N("t","TEST_ID").T(" = ").P_ID("__testID_0").T(")");

     db.CheckTextOfLastExecutedCommand
      (sqlt);

     Assert.AreEqual
      (1,
       nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_003__null__value___eq___null

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_x01()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
           T_DATA1 c_value1=16+8+2+1;
     const T_DATA2 c_value2=1;

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     Assert.AreEqual
      (4+2,
       c_value1>>(c_value2+c_value2));

     //
     // note: [FB3 D3] r.COL_DATA2+r.COL_DATA2 has result type BIGINT
     //
     var recs=db.testTable.Where(r => (r.COL_DATA1>>(r.COL_DATA2+r.COL_DATA2))==6 && r.TEST_ID==testID);

     try
     {
      foreach(var r in recs)
      {
       TestServices.ThrowSelectedRow();
      }

      TestServices.ThrowWeWaitError();
     }
     catch(lcpi.lib.structure.exceptions.t_invalid_operation_exception e)
     {
      CheckErrors.PrintException_OK(e);

      Assert.AreEqual
       (1,
        TestUtils.GetRecordCount(e));

      CheckErrors.CheckErrorRecord__sql_translator_err__unsupported_binary_operator_type_3
       (TestUtils.GetRecord(e,0),
        CheckErrors.c_src__EFCoreDataProvider__FB_Common__BinaryOperatorTranslatorProvider,
        Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.LcpiOleDb__ExpressionType.RightShift,
        typeof(System.Int16),
        typeof(System.Double));
     }//catch
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_x01

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_x02()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
           T_DATA1 c_value1=16+8+2+1;
     const T_DATA2 c_value2=4;

     System.Int64? testID=Helper__InsertRow(db,c_value1,c_value2);

     Assert.AreEqual
      (4+2,
       c_value1>>(c_value2/2));

     //
     // note: [FB3 D3] r.COL_DATA2/2 has result type BIGINT
     //
     var recs=db.testTable.Where(r => (r.COL_DATA1>>(r.COL_DATA2/2))==6 && r.TEST_ID==testID);

     try
     {
      foreach(var r in recs)
      {
       TestServices.ThrowSelectedRow();
      }//foreach r

      TestServices.ThrowWeWaitError();
     }
     catch(structure_lib.exceptions.t_invalid_operation_exception e)
     {
      CheckErrors.PrintException_OK(e);

      Assert.AreEqual
       (1,
        TestUtils.GetRecordCount(e));

      CheckErrors.CheckErrorRecord__sql_translator_err__unsupported_binary_operator_type_3
       (TestUtils.GetRecord(e,0),
        CheckErrors.c_src__EFCoreDataProvider__FB_Common__BinaryOperatorTranslatorProvider,
        Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.LcpiOleDb__ExpressionType.RightShift,
        typeof(System.Int16),
        typeof(System.Double));
     }//catch
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_x02

 //Helper methods --------------------------------------------------------
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
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Query.Operators.SET_001.RightShift.Complete.NullableInt16.Int32
