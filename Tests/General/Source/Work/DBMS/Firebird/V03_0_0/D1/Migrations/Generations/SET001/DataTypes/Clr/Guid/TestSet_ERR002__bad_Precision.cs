﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 19.10.2021.
using Microsoft.EntityFrameworkCore.Migrations.Operations;

using NUnit.Framework;

using xEFCore=Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Migrations.Generations.SET001.DataTypes.Clr.Guid{
////////////////////////////////////////////////////////////////////////////////

using T_DATA=System.Guid;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_ERR002__bad_Precision

public static class TestSet_ERR002__bad_Precision
{
 private const string c_testTableName
  ="EFCORE_TTABLE_DUMMY";

 private const string c_testColumnName
  ="MY_COLUMN";

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0000__ValidForData()
 {
  var operation
   =new CreateTableOperation
    {
     Name
      =c_testTableName,
   
     Columns
      ={
        new AddColumnOperation
        {
         Name            = c_testColumnName,
         Table           = c_testTableName,
         ClrType         = typeof(T_DATA),
         IsNullable      = false,
         Precision       = 0
        },
       },
    };//operation

  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(xEFCore.LcpiOleDb__DataToolException e)
  {
   CheckErrors.PrintException_OK(e);

   Assert.AreEqual
    (3,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__type_mapping_err__unexpected_Precision_1
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__FB_Common__TypeMapping__GUAD__as_bytes,
     0);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_column_definition__2
    (TestUtils.GetRecord(e,1),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_testTableName,
     c_testColumnName);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_table_creation_script__1
    (TestUtils.GetRecord(e,2),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_testTableName);

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0000__ValidForData

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0001__p123()
 {
  var operation
   =new CreateTableOperation
    {
     Name
      =c_testTableName,
   
     Columns
      ={
        new AddColumnOperation
        {
         Name            = c_testColumnName,
         Table           = c_testTableName,
         ClrType         = typeof(T_DATA),
         IsNullable      = false,
         Precision       = 123
        },
       },
    };//operation

  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(xEFCore.LcpiOleDb__DataToolException e)
  {
   CheckErrors.PrintException_OK(e);

   Assert.AreEqual
    (3,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__type_mapping_err__unexpected_Precision_1
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__FB_Common__TypeMapping__GUAD__as_bytes,
     123);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_column_definition__2
    (TestUtils.GetRecord(e,1),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_testTableName,
     c_testColumnName);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_table_creation_script__1
    (TestUtils.GetRecord(e,2),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_testTableName);

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0001__p123

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0002__m123()
 {
  var operation
   =new CreateTableOperation
    {
     Name
      =c_testTableName,
   
     Columns
      ={
        new AddColumnOperation
        {
         Name            = c_testColumnName,
         Table           = c_testTableName,
         ClrType         = typeof(T_DATA),
         IsNullable      = false,
         Precision       = -123
        },
       },
    };//operation

  try
  {
   TestHelper.Exec
    (new[]{operation});
  }
  catch(xEFCore.LcpiOleDb__DataToolException e)
  {
   CheckErrors.PrintException_OK(e);

   Assert.AreEqual
    (3,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__type_mapping_err__unexpected_Precision_1
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__FB_Common__TypeMapping__GUAD__as_bytes,
     -123);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_column_definition__2
    (TestUtils.GetRecord(e,1),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_testTableName,
     c_testColumnName);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_table_creation_script__1
    (TestUtils.GetRecord(e,2),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_testTableName);

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_0002__m123
};//class TestSet_ERR002__bad_Precision

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Migrations.Generations.SET001.DataTypes.Clr.Guid
