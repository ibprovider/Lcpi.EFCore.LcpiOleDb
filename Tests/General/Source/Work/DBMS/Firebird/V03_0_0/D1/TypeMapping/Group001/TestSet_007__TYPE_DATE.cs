﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 28.05.2018.
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

using xEFCore=Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.TypeMapping.Group001{
////////////////////////////////////////////////////////////////////////////////
//class TestSet_007__TYPE_DATE

public static class TestSet_007__TYPE_DATE
{
 private sealed class MyContext:TestBaseDbContext
 {
  [Table("TEST_MODIFY_ROW_WD")]
  public class TEST_MODIFY_ROW_WD
  {
   [Key]
   [Column("TEST_ID")]
   public Int64 TEST_ID { get; set; }

   [Column(TypeName = "DATE")]
   public DateTime COL_TYPE_DATE { get; set; }
  };//class TEST_MODIFY_ROW_WD

  //----------------------------------------------------------------------
  public DbSet<TEST_MODIFY_ROW_WD> testTable { get; set; }

  //----------------------------------------------------------------------
  public MyContext(xdb.OleDbTransaction tr)
   :base(tr)
  {
  }//MyContext
 };//class MyContext

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_01()
 {
  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    object recID;

    using(var cmd=new xdb.OleDbCommand())
    {
     cmd.Connection=cn;
     cmd.Transaction=tr;

     cmd.CommandText
      ="insert into TEST_MODIFY_ROW_WD (COL_TYPE_DATE) values ('28.05.2018')\n"
      +"returning TEST_ID\n"
      +"INTO :TEST_ID";

     cmd.Parameters.Refresh();

     cmd.ExecuteNonQuery();

     recID=cmd["TEST_ID"].Value;
    }//using cmd

    try
    {
     using(var db=new MyContext(tr))
     {
      TestServices.ThrowWeWaitError();
     }//using db
    }
    catch(xEFCore.LcpiOleDb__DataToolException e)
    {
     CheckErrors.PrintException_OK(e);

     Assert.AreEqual
      (1,
       TestUtils.GetRecordCount(e));

     CheckErrors.CheckErrorRecord__type_mapping_err__unexpected_ClrType_2
      (TestUtils.GetRecord(e,0),
       CheckErrors.c_src__EFCoreDataProvider__FB_Common__TypeMapping_D1__TYPE_DATE__as_DateOnly,
       typeof(System.DateTime),
       typeof(System.DateOnly));
    }//catch

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_01
};//class TestSet_007__TYPE_DATE

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.TypeMapping.Group001
