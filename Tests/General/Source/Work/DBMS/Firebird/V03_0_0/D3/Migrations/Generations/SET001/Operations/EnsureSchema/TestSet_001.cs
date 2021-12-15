﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 11.11.2021.
using NUnit.Framework;

using EF_MnOP
 =Microsoft.EntityFrameworkCore.Migrations.Operations;

using structure_lib
 =lcpi.lib.structure;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Migrations.Generations.SET001.Operations.EnsureSchema{
////////////////////////////////////////////////////////////////////////////////
//class TestSet_001

public static class TestSet_001
{
 [Test]
 public static void Test_0001()
 {
  var operation
   =new EF_MnOP.EnsureSchemaOperation
    {
     Name             = "MY_SCHEMA",
    };//operation

  //----------------------------------------
  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(structure_lib.exceptions.t_not_supported_exception e)
  {
   CheckErrors.PrintException_OK
    (e);

   Assert.AreEqual
    (1,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__dbms_err__fb__firebird_does_not_support_schemas__0
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator);

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0001
};//class TestSet_001

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Migrations.Generations.SET001.Operations.EnsureSchema
