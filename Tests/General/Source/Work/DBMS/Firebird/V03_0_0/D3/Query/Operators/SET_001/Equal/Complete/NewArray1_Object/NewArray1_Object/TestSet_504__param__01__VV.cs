﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 02.12.2021.
using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

using structure_lib=lcpi.lib.structure;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Operators.SET_001.Equal.Complete.NewArray1_Object.NewArray1_Object{
////////////////////////////////////////////////////////////////////////////////

using T_ARR1_E =System.Object;
using T_ARR2_E =System.Object;

using T_DATA1  =System.Int16;
using T_DATA2  =System.Int32;

using T_DATA1_U=System.Int16;
using T_DATA2_U=System.Int32;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_504__param__01__VV

public static class TestSet_504__param__01__VV
{
 private const string c_NameOf__TABLE            ="DUAL";

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
 public static void Test_001__less()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     T_DATA1 vv1=3;
     T_DATA2 vv2=4;

     var recs=db.testTable.Where(r => new T_ARR1_E[] {vv1, vv2} /*OP{*/ == /*}OP*/ new T_ARR2_E[] {vv2, vv1});

     foreach(var r in recs)
     {
      TestServices.ThrowSelectedRow();
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE ").P_BOOL("__Exec_V_V_0"));
    }//using db

    tr.Commit();
   }//using tr
  }//using cn
 }//Test_001__less

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_002__equal()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     T_DATA1 vv1=4;
     T_DATA2 vv2=4;

     var recs=db.testTable.Where(r => new T_ARR1_E[] {vv1, vv2} /*OP{*/ == /*}OP*/ new T_ARR2_E[] {vv2, vv1});

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

    tr.Commit();
   }//using tr
  }//using cn
 }//Test_002__equal

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_003__greater()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     T_DATA1 vv1=4;
     T_DATA2 vv2=3;

     var recs=db.testTable.Where(r => new T_ARR1_E[] {vv1, vv2} /*OP{*/ == /*}OP*/ new T_ARR2_E[] {vv2, vv1});

     foreach(var r in recs)
     {
      TestServices.ThrowSelectedRow();
     }//foreach r

     db.CheckTextOfLastExecutedCommand
      (new TestSqlTemplate()
        .T("SELECT ").N("d","ID").EOL()
        .T("FROM ").N(c_NameOf__TABLE).T(" AS ").N("d").EOL()
        .T("WHERE ").P_BOOL("__Exec_V_V_0"));
    }//using db

    tr.Commit();
   }//using tr
  }//using cn
 }//Test_003__greater

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_ERR001__different_length()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     T_DATA1 vv1=4;
     T_DATA2 vv2=3;

     var recs=db.testTable.Where(r => new T_ARR1_E[] {vv1, vv2, vv1} /*OP{*/ == /*}OP*/ new T_ARR2_E[] {vv2, vv1});

     try
     {
      foreach(var r in recs)
      {
       TestServices.ThrowWeWaitError();
      }//foreach r

      TestServices.ThrowWeWaitError();
     }
     catch(InvalidOperationException exc)
     {
      CheckErrors.PrintException_OK
       (exc);

      Assert.NotNull
       (exc.InnerException);

      Assert.IsInstanceOf<structure_lib.exceptions.t_invalid_operation_exception>
       (exc.InnerException);

      var e2
       =(structure_lib.exceptions.t_invalid_operation_exception)exc.InnerException;

      Assert.NotNull
       (e2);

      Assert.AreEqual
       (1,
        TestUtils.GetRecordCount(e2));

      CheckErrors.CheckErrorRecord__local_eval_err__comparison_of_arrays_with_different_length_not_supported_2
       (TestUtils.GetRecord(e2,0),
        CheckErrors.c_src__EFCoreDataProvider__Root_Query_Local_Expressions__Op2_MasterCode__Equal___Array1_generic__Array1_generic,
        3,
        2);
     }//catch
    }//using db

    tr.Commit();
   }//using tr
  }//using cn
 }//Test_ERR001__different_length

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_ERR002__unsupported_comparison()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     T_DATA1 vv1=4;
     T_DATA2 vv2=4;

     var recs=db.testTable.Where(r => new T_ARR1_E[] {vv1, vv2} /*OP{*/ == /*}OP*/ new T_ARR2_E[] {vv2, new System.DateTime(2021,12,02)});

     try
     {
      foreach(var r in recs)
      {
       TestServices.ThrowWeWaitError();
      }//foreach r

      TestServices.ThrowWeWaitError();
     }
     catch(InvalidOperationException exc)
     {
      CheckErrors.PrintException_OK
       (exc);

      Assert.NotNull
       (exc.InnerException);

      Assert.IsInstanceOf<structure_lib.exceptions.t_invalid_operation_exception>
       (exc.InnerException);

      var e2
       =(structure_lib.exceptions.t_invalid_operation_exception)exc.InnerException;

      Assert.NotNull
       (e2);

      Assert.AreEqual
       (1,
        TestUtils.GetRecordCount(e2));

      CheckErrors.CheckErrorRecord__local_eval_err__failed_to_compare_element_of_arrays_1
       (TestUtils.GetRecord(e2,0),
        CheckErrors.c_src__EFCoreDataProvider__Root_Query_Local_Expressions__Op2_MasterCode__Equal___Array1_generic__Array1_generic,
        new[]{1});

      Assert.NotNull
       (e2.InnerException);

      Assert.IsInstanceOf<structure_lib.exceptions.t_invalid_operation_exception>
       (e2.InnerException);

      var e3
       =(structure_lib.exceptions.t_invalid_operation_exception)e2.InnerException;

      Assert.NotNull
       (e3);

      Assert.AreEqual
       (1,
        TestUtils.GetRecordCount(e3));

      CheckErrors.CheckErrorRecord__local_eval_err__binary_operator_not_supported_3
       (TestUtils.GetRecord(e3,0),
        CheckErrors.c_src__EFCoreDataProvider__Root_Query_Local_Expressions__Op2_Code__Equal___Object__Object,
        System.Linq.Expressions.ExpressionType.Equal,
        "System.Int32",
        "System.DateTime");
     }//catch
    }//using db

    tr.Commit();
   }//using tr
  }//using cn
 }//Test_ERR002__unsupported_comparison
};//class TestSet_504__param__01__VV

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Operators.SET_001.Equal.Complete.NewArray1_Object.NewArray1_Object
