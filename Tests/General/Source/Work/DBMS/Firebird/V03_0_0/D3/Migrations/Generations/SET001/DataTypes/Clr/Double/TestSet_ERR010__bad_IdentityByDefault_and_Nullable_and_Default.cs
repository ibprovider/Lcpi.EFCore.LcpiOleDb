﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 23.09.2021.
using Microsoft.EntityFrameworkCore.Migrations.Operations;

using NUnit.Framework;

using xEFCore=Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Migrations.Generations.SET001.DataTypes.Clr.Double{
////////////////////////////////////////////////////////////////////////////////
//class TestSet_ERR010__bad_IdentityByDefault_and_Nullable_and_Default

public static class TestSet_ERR010__bad_IdentityByDefault_and_Nullable_and_Default
{
 private const string c_testTableName
  ="EFCORE_TTABLE_DUMMY";

 private const string c_testColumnName
  ="MY_COLUMN";

 //-----------------------------------------------------------------------
 private const string c_testColumnTypeName
  ="DOUBLE PRECISION";

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_001()
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
         ColumnType      = c_testColumnTypeName,
         IsNullable      = true,
         DefaultValue    = 321,

         [xEFCore.MetaData.Internal.LcpiOleDb__AnnotationNames.ValueGenerationStrategy]
          =xEFCore.MetaData.LcpiOleDb__ValueGenerationStrategy.IdentityByDefaultColumn,
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
    (5,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__msql_gen_err__identity_column_cant_be_created_with_required_data_type__2
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     "System.Double",
     "DOUBLE PRECISION");

   CheckErrors.CheckErrorRecord__msql_gen_err__identity_column_cant_be_has_default_value__0
    (TestUtils.GetRecord(e,1),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator);

   CheckErrors.CheckErrorRecord__msql_gen_err__identity_column_cant_be_nullable__0
    (TestUtils.GetRecord(e,2),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_column_definition__2
    (TestUtils.GetRecord(e,3),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_testTableName,
     c_testColumnName);

   CheckErrors.CheckErrorRecord__msql_gen_err__failed_to_generate_table_creation_script__1
    (TestUtils.GetRecord(e,4),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0__MigrationSqlGenerator,
     c_testTableName);

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_001
};//class TestSet_ERR010__bad_IdentityByDefault_and_Nullable_and_Default

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Migrations.Generations.SET001.DataTypes.Clr.Double
