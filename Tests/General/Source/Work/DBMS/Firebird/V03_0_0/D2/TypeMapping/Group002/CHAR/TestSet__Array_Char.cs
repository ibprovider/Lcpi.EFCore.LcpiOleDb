﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 22.09.2021.
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D2.TypeMapping.Group002.CHAR{
////////////////////////////////////////////////////////////////////////////////

using TEST_COL_TYPE_E=System.Char;

////////////////////////////////////////////////////////////////////////////////
//class TestSet__Array_Char

public static class TestSet__Array_Char
{
 private sealed class MyContext:TestBaseDbContext
 {
  [Table("TEST_MODIFY_ROW_WD")]
  public sealed class TEST_RECORD
  {
   [Key]
   [Column("TEST_ID")]
   public Int64? TEST_ID { get; set; }

   [Column("COL_CHAR_10", TypeName="CHAR(10)")]
   public TEST_COL_TYPE_E[] TEST_COL { get; set; }
  };//class TEST_RECORD

  //----------------------------------------------------------------------
  public DbSet<TEST_RECORD> testTable { get; set; }

  //----------------------------------------------------------------------
  public MyContext(xdb.OleDbTransaction tr)
   :base(tr)
  {
  }//MyContext

  //----------------------------------------------------------------------
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
   modelBuilder
    .Entity<TEST_RECORD>()
    .Property(b => b.TEST_COL)
    .HasDefaultValue();
  }//OnModelCreating
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
    Int64             recID;
    TEST_COL_TYPE_E[] recData=" ABCD54321".ToCharArray();

    var cmd=new xdb.OleDbCommand("",cn,tr);

    using(var db=new MyContext(tr))
    {
     var newRec=new MyContext.TEST_RECORD();

     db.testTable.Add(newRec);

     var nChanges=db.SaveChanges();

     Assert.AreEqual(1,nChanges);

     Assert.NotNull(newRec.TEST_ID);

     Assert.NotNull(newRec.TEST_COL);

     Assert.AreEqual(recData,newRec.TEST_COL);

     recID=newRec.TEST_ID.Value;
    }//using db

    //------------------
    cmd.CommandText="select COL_CHAR_10 from TEST_MODIFY_ROW_WD where TEST_ID="+recID.ToString();

    var rd=cmd.ExecuteReader();

    Assert.IsTrue(rd.Read());

    Assert.AreEqual(recData,rd.GetString(0));

    Assert.IsFalse(rd.Read());

    using(var db=new MyContext(tr))
    {
     var recs=db.testTable.Where(r => r.TEST_ID==recID && r.TEST_COL==recData);

     int nRecs=0;

     foreach(var rec in recs)
     {
      Assert.AreEqual(0,nRecs);

      ++nRecs;

      Assert.AreEqual(recID,rec.TEST_ID);

      Assert.AreEqual(recData,rec.TEST_COL);
     }//foreach

     Assert.AreEqual(1,nRecs);
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_01
};//class TestSet__Array_Char

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D2.TypeMapping.Group002.CHAR
