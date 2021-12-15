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

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.TypeMapping.Group002.TYPE_TIME{
////////////////////////////////////////////////////////////////////////////////

using TEST_COL_TYPE  =System.Nullable<System.TimeOnly>;
using TEST_COL_TYPE_U=System.TimeOnly;

////////////////////////////////////////////////////////////////////////////////
//class TestSet__TimeOnly

public static class TestSet__TimeOnly
{
 private sealed class MyContext:TestBaseDbContext
 {
  [Table("TEST_MODIFY_ROW_WD")]
  public sealed class TEST_RECORD
  {
   [Key]
   [Column("TEST_ID")]
   public System.Int64? TEST_ID { get; set; }

   [Column("COL_TYPE_TIME")]
   public TEST_COL_TYPE TEST_COL { get; set; }
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
  const string
   c_ex_cn_params
    ="dbtime_rules=1";

  using(var cn=LocalCnHelper.CreateCn(c_ex_cn_params))
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    Int64 recID;

    const long c_k=10000000/10000;

    TEST_COL_TYPE recData=new TEST_COL_TYPE_U(21,35,43).Add(new System.TimeSpan(4321*c_k));

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
    cmd.CommandText="select COL_TYPE_TIME from TEST_MODIFY_ROW_WD where TEST_ID="+recID.ToString();

    var rd=cmd.ExecuteReader();

    Assert.IsTrue(rd.Read());

    Assert.AreEqual(recData,rd.GetTimeOnly(0));

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
    }//using
   }//using tr
  }//using cn
 }//Test_01
};//class TestSet__TimeOnly

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.TypeMapping.Group002.TYPE_TIME
