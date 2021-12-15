﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 16.11.2021.
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

using xEFCore=Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Model.Annotations.VGS.SET_001.ExplicitDefinition.CHAR_8{
////////////////////////////////////////////////////////////////////////////////

using T_ID  =System.String;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_000__null

public static class TestSet_000__null
{
 private const string c_NameOf__Table                 = "DUMMY_TEST_TABLE";

 private const string c_NameOf__COL__ID               = "TEST_ID";

 private sealed class MyContext:TestBaseDbContext
 {
  [Table(c_NameOf__Table)]
  public sealed class TEST_RECORD
  {
   [Key]
   [Column(c_NameOf__COL__ID, TypeName="CHAR(8) CHARACTER SET NONE")]
   public T_ID TEST_ID { get; set; }
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
   var propMetaData
    =modelBuilder
     .Entity<TEST_RECORD>()
     .Property(b => b.TEST_ID)
     .Metadata;

   Assert.NotNull
    (propMetaData);

   Assert.IsNull
    (propMetaData.Internal__SelectValueGenerationStrategy());

   propMetaData
    .SetValueGenerationStrategy(null);

   Assert.IsNull
    (propMetaData.Internal__SelectValueGenerationStrategy());
  }//OnModelCreating
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
     //check model

     var entity
      =db.Model.FindEntityType(typeof(MyContext.TEST_RECORD));

     Assert.NotNull
      (entity);

     var property
      =entity.GetProperty(c_NameOf__COL__ID);

     var vgs
      =property.GetValueGenerationStrategy();

     Assert.NotNull
      (vgs);

     Assert.IsInstanceOf<xEFCore.MetaData.LcpiOleDb__AnnotationData__ValueGenerationStrategy_None>
      (vgs);

    //---------------------------------------------------------------
    var expectedSQL1
     =new TestSqlTemplate()
       .T("CREATE TABLE ").N(c_NameOf__Table).T(" (").CRLF()
       .T("    ").N(c_NameOf__COL__ID).T(" CHAR(8) CHARACTER SET NONE NOT NULL,").CRLF()
       .T("    CONSTRAINT ").N("PK_"+c_NameOf__Table).T(" PRIMARY KEY (").N(c_NameOf__COL__ID).T(")").CRLF()
       .T(");").CRLF();

     //----------------------
     TestServices.CheckMigrationSQLs
      (db,
       new [] {expectedSQL1});
    }//using db

    tr.Rollback();
   }//using tr
  }//using cn
 }//Test_001
};//class TestSet_000__null

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Model.Annotations.VGS.SET_001.ExplicitDefinition.CHAR_8
