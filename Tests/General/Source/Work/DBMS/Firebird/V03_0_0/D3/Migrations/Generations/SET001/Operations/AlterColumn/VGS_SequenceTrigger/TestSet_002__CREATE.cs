﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 09.11.2021.
using NUnit.Framework;

using EF_MnOP
 =Microsoft.EntityFrameworkCore.Migrations.Operations;

using xEFCore
 =Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Migrations.Generations.SET001.Operations.AlterColumn.VGS_SequenceTrigger{
////////////////////////////////////////////////////////////////////////////////
//class TestSet_002__CREATE

public static class TestSet_002__CREATE
{
 private const string c_NameOf_Table
  ="TEST_TABLE";

 private const string c_NameOf_Column
  ="COLUMN_NAME";

 private const string c_NameOf__Trigger
  ="TRIGGER_NAME";

 private const string c_NameOf__Sequence
  ="SEQUENCE_NAME";

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0001()
 {
  var operation
   =new EF_MnOP.AlterColumnOperation
    {
     Table            = c_NameOf_Table,
     Name             = c_NameOf_Column,
     ClrType          = typeof(int),
     IsNullable       = false,

     [xEFCore.MetaData.Internal.LcpiOleDb__AnnotationNames.ValueGenerationStrategy]
      =xEFCore.MetaData.LcpiOleDb__ValueGenerationStrategy.SequenceTrigger(c_NameOf__Trigger,c_NameOf__Sequence),

     OldColumn = new EF_MnOP.AddColumnOperation
     {
      Table           = c_NameOf_Table,
      Name            = c_NameOf_Column,
      ClrType         = typeof(int),
      IsNullable      = false,
     }//OldColumn
    };//operation

  //----------------------------------------
  var expectedSQL1
   =new TestSqlTemplate()
     .T("CREATE TRIGGER ").N(c_NameOf__Trigger).T(" ACTIVE BEFORE INSERT ON ").N(c_NameOf_Table).CRLF()
     .T("AS").CRLF()
     .T("BEGIN").CRLF()
     .T("    IF (NEW.").N(c_NameOf_Column).T(" IS NULL) THEN").CRLF()
     .T("    BEGIN").CRLF()
     .T("        NEW.").N(c_NameOf_Column).T(" = NEXT VALUE FOR ").N(c_NameOf__Sequence).T(";").CRLF()
     .T("    END").CRLF()
     .T("END;").CRLF();

  TestHelper.Exec
   (new []{operation},
    new []{expectedSQL1});
 }//Test_0001
};//class TestSet_002__CREATE

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Migrations.Generations.SET001.Operations.AlterColumn.VGS_SequenceTrigger
