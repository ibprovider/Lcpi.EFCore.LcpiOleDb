﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 07.11.2021.
using NUnit.Framework;

using EF_MnOP
 =Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Migrations.Generations.SET001.Operations.DropSequence{
////////////////////////////////////////////////////////////////////////////////
//class TestSet_001

public static class TestSet_001
{
 private const string c_NameOf_Sequence
  ="TEST_SEQ";

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0001()
 {
  var operation
   =new EF_MnOP.DropSequenceOperation
    {
     Name             = c_NameOf_Sequence
    };//operation

  //----------------------------------------
  var expectedSQL
   =new TestSqlTemplate()
     .T("DROP SEQUENCE ").N(c_NameOf_Sequence).T(";").CRLF();

  TestHelper.Exec
   (new[]{operation},
    new[]{expectedSQL});
 }//Test_0001
};//class TestSet_001

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Migrations.Generations.SET001.Operations.DropSequence
