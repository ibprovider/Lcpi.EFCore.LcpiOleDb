﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 21.03.2021.
using System;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

using structure_lib=lcpi.lib.structure;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Operators.SET_002__AS_STR.Add.Complete.Double.Double{
////////////////////////////////////////////////////////////////////////////////

using T_DATA1   =System.Double;
using T_DATA2   =System.Double;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_ERR504__param

public static class TestSet_ERR504__param
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
 public static void Test_001__min()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     T_DATA1 vv1=T_DATA1.MinValue;
     T_DATA2 vv2=T_DATA2.MinValue;

     var recs=db.testTable.Where(r => (string)(object)(vv1+vv2)=="BLA-BLA-BLA");

     try
     {
      foreach(var r in recs)
      {
       TestServices.ThrowSelectedRow();
      }//foreach r

      TestServices.ThrowWeWaitError();
     }
     catch(InvalidOperationException e)
     {
      Assert.NotNull
       (e.InnerException);

      Assert.IsInstanceOf<structure_lib.exceptions.t_overflow_exception>
       (e.InnerException);

      var e2
       =(structure_lib.exceptions.t_overflow_exception)e.InnerException;

      Assert.AreEqual
       (1,
        TestUtils.GetRecordCount(e2));

      CheckErrors.CheckErrorRecord__common_err__overflow_in_arithmetic_op2__5<double,double>
       (TestUtils.GetRecord(e2,0),
        CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__Query_Local_D0_Expressions__Op2_MasterCode__Add___Double__Double,
        System.Linq.Expressions.ExpressionType.Add,
        "-1.7976931348623157E+308",
        "-1.7976931348623157E+308");

      Assert.IsNull
       (e2.InnerException);
     }//catch
    }//using db

    tr.Commit();
   }//using tr
  }//using cn
 }//Test_001__min

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_002__max()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    //insert new record in external transaction
    using(var db=new MyContext(tr))
    {
     T_DATA1 vv1=T_DATA1.MaxValue;
     T_DATA2 vv2=T_DATA2.MaxValue;

     var recs=db.testTable.Where(r => (string)(object)(vv1+vv2)=="BLA-BLA-BLA");

     try
     {
      foreach(var r in recs)
      {
       TestServices.ThrowSelectedRow();
      }//foreach r

      TestServices.ThrowWeWaitError();
     }
     catch(InvalidOperationException e)
     {
      Assert.NotNull
       (e.InnerException);

      Assert.IsInstanceOf<structure_lib.exceptions.t_overflow_exception>
       (e.InnerException);

      var e2
       =(structure_lib.exceptions.t_overflow_exception)e.InnerException;

      Assert.AreEqual
       (1,
        TestUtils.GetRecordCount(e2));

      CheckErrors.CheckErrorRecord__common_err__overflow_in_arithmetic_op2__5<double,double>
       (TestUtils.GetRecord(e2,0),
        CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__Query_Local_D0_Expressions__Op2_MasterCode__Add___Double__Double,
        System.Linq.Expressions.ExpressionType.Add,
        "1.7976931348623157E+308",
        "1.7976931348623157E+308");

      Assert.IsNull
       (e2.InnerException);
     }//catch
    }//using db

    tr.Commit();
   }//using tr
  }//using cn
 }//Test_002__max
};//class TestSet_ERR504__param

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Operators.SET_002__AS_STR.Add.Complete.Double.Double
