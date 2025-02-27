﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 05.11.2021.
using System;
using NUnit.Framework;

using EF_MnOP
 =Microsoft.EntityFrameworkCore.Migrations.Operations;

using xEFCore
 =Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Migrations.Generations.SET001.Operations.CreateSequence{
////////////////////////////////////////////////////////////////////////////////
//class TestSet_ERR001

public static class TestSet_ERR001
{
 private const string c_NameOf_Sequence
  ="TEST_SEQ";

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0001__overflow()
 {
  var operation
   =new EF_MnOP.CreateSequenceOperation
    {
     Name             = c_NameOf_Sequence,
     IsCyclic         = true,
     ClrType          = typeof(long),
     StartValue       = long.MaxValue,
     IncrementBy      = -1,
    };//operation

  //----------------------------------------
  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(xEFCore.LcpiOleDb__DataToolException e)
  {
   CheckErrors.PrintException_OK
    (e);

   Assert.AreEqual
    (2,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__msql_gen_err__overflow_in_calculation_of_adjusted_sequence_start_value__3
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__Basement_EF_Dbms_Firebird_V03_0_0_Migrations_D3_Internal_SvcImpls___FB_V03_0_0__MigrationsSvcImpl__GenerateCreateSequence,
     c_NameOf_Sequence,
     long.MaxValue,
     -1);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_create_sequence_statement__1
    (TestUtils.GetRecord(e,1),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_NameOf_Sequence);

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0001__overflow

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0002__overflow()
 {
  var operation
   =new EF_MnOP.CreateSequenceOperation
    {
     Name             = c_NameOf_Sequence,
     IsCyclic         = true,
     ClrType          = typeof(long),
     StartValue       = long.MinValue,
     IncrementBy      = 1,
    };//operation

  //----------------------------------------
  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(xEFCore.LcpiOleDb__DataToolException e)
  {
   CheckErrors.PrintException_OK
    (e);

   Assert.AreEqual
    (2,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__msql_gen_err__overflow_in_calculation_of_adjusted_sequence_start_value__3
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__Basement_EF_Dbms_Firebird_V03_0_0_Migrations_D3_Internal_SvcImpls___FB_V03_0_0__MigrationsSvcImpl__GenerateCreateSequence,
     c_NameOf_Sequence,
     long.MinValue,
     1);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_create_sequence_statement__1
    (TestUtils.GetRecord(e,1),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_NameOf_Sequence);

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0002__overflow

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0003__NonCyclic()
 {
  var operation
   =new EF_MnOP.CreateSequenceOperation
    {
     Name             = c_NameOf_Sequence,
    IsCyclic         = false,
     ClrType          = typeof(long),
    };//operation

  //----------------------------------------
  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(xEFCore.LcpiOleDb__DataToolException e)
  {
   CheckErrors.PrintException_OK
    (e);

   Assert.AreEqual
    (2,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__msql_gen_err__firebird_does_not_support_non_cyclic_sequence__1
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__Basement_EF_Dbms_Firebird_V03_0_0_Migrations_D3_Internal_SvcImpls___FB_V03_0_0__MigrationsSvcImpl__GenerateCreateSequence,
     c_NameOf_Sequence);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_create_sequence_statement__1
    (TestUtils.GetRecord(e,1),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_NameOf_Sequence);

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0003__NonCyclic

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0004__Int32()
 {
  var operation
   =new EF_MnOP.CreateSequenceOperation
    {
     Name             = c_NameOf_Sequence,
     IsCyclic         = true,
     ClrType          = typeof(int),
    };//operation

  //----------------------------------------
  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(xEFCore.LcpiOleDb__DataToolException e)
  {
   CheckErrors.PrintException_OK
    (e);

   Assert.AreEqual
    (2,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__msql_gen_err__unexpected_sequence_ClrType__3
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__Basement_EF_Dbms_Firebird_V03_0_0_Migrations_D3_Internal_SvcImpls___FB_V03_0_0__MigrationsSvcImpl__GenerateCreateSequence,
     c_NameOf_Sequence,
     "System.Int32",
     "System.Int64");

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_create_sequence_statement__1
    (TestUtils.GetRecord(e,1),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_NameOf_Sequence);

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0004__Int32

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0005__SchemaNotNull()
 {
  var operation
   =new EF_MnOP.CreateSequenceOperation
    {
     Name             = c_NameOf_Sequence,
     IsCyclic         = true,
     ClrType          = typeof(long),
     Schema           = "",
    };//operation

  //----------------------------------------
  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(ArgumentException e)
  {
   CheckErrors.PrintException_OK
    (e);

   CheckErrors.CheckException__ArgumentIsNotNull
    (e,
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     "Generate(CreateSequenceOperation...)",
     "operation.Schema");

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0005__SchemaNotNull

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0006__ClrTypeIsNull()
 {
  var operation
   =new EF_MnOP.CreateSequenceOperation
    {
     Name             = c_NameOf_Sequence,
     IsCyclic         = true,
     ClrType          = null,
    };//operation

  //----------------------------------------
  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(ArgumentNullException e)
  {
   CheckErrors.PrintException_OK
    (e);

   CheckErrors.CheckException__ArgumentNullException
    (e,
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     "Generate(CreateSequenceOperation...)",
     "operation.ClrType");

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0006__ClrTypeIsNull

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0007__NameIsNull()
 {
  var operation
   =new EF_MnOP.CreateSequenceOperation
    {
     Name             = null,
     IsCyclic         = true,
     ClrType          = typeof(long),
    };//operation

  //----------------------------------------
  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(ArgumentNullException e)
  {
   CheckErrors.PrintException_OK
    (e);

   CheckErrors.CheckException__ArgumentNullException
    (e,
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     "Generate(CreateSequenceOperation...)",
     "operation.Name");

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0007__NameIsNull

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0008__SetupMinValue()
 {
  var operation
   =new EF_MnOP.CreateSequenceOperation
    {
     Name             = c_NameOf_Sequence,
     IsCyclic         = true,
     ClrType          = typeof(long),
     MinValue         = 0,
    };//operation

  //----------------------------------------
  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(xEFCore.LcpiOleDb__DataToolException e)
  {
   CheckErrors.PrintException_OK
    (e);

   Assert.AreEqual
    (2,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__msql_gen_err__firebird_does_not_support_configuration_of_sequence_bound_value__3
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__Basement_EF_Dbms_Firebird_V03_0_0_Migrations_D3_Internal_SvcImpls___FB_V03_0_0__MigrationsSvcImpl__GenerateCreateSequence,
     "MinValue",
     c_NameOf_Sequence,
     long.MinValue);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_create_sequence_statement__1
    (TestUtils.GetRecord(e,1),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_NameOf_Sequence);

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0008__SetupMinValue

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0009__SetupMaxValue()
 {
  var operation
   =new EF_MnOP.CreateSequenceOperation
    {
     Name             = c_NameOf_Sequence,
     IsCyclic         = true,
     ClrType          = typeof(long),
     MaxValue         = 0,
    };//operation

  //----------------------------------------
  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(xEFCore.LcpiOleDb__DataToolException e)
  {
   CheckErrors.PrintException_OK
    (e);

   Assert.AreEqual
    (2,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__msql_gen_err__firebird_does_not_support_configuration_of_sequence_bound_value__3
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__Basement_EF_Dbms_Firebird_V03_0_0_Migrations_D3_Internal_SvcImpls___FB_V03_0_0__MigrationsSvcImpl__GenerateCreateSequence,
     "MaxValue",
     c_NameOf_Sequence,
     long.MaxValue);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_create_sequence_statement__1
    (TestUtils.GetRecord(e,1),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_NameOf_Sequence);

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0009__SetupMaxValue
};//class TestSet_ERR001

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Migrations.Generations.SET001.Operations.CreateSequence
