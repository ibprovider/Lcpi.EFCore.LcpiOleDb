﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 30.06.2021.
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.TypeMapping.Group001{
////////////////////////////////////////////////////////////////////////////////
//class TestSet_019__TYPE_DATE__as_DateOnly

public static class TestSet_019__TYPE_DATE__as_DateOnly
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
   public DateOnly COL_TYPE_DATE { get; set; }
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

    using(var db=new MyContext(tr))
    {
     int nRecs=0;

     foreach(var rec in db.testTable.Where(r=>r.TEST_ID==(Int64)recID))
     {
      Assert.AreEqual(0,nRecs);

      ++nRecs;

      Assert.AreEqual(recID,rec.TEST_ID);
      Assert.AreEqual(new DateOnly(2018,5,28),rec.COL_TYPE_DATE);
     }//foreach

     Assert.AreEqual(1,nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_01
};//class TestSet_019__TYPE_DATE__as_DateOnly

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.TypeMapping.Group001
