﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 23.09.2021.
using Microsoft.EntityFrameworkCore.Migrations.Operations;

using NUnit.Framework;

using xEFCore=Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Migrations.Generations.SET001.DataTypes.Clr.Int64{
////////////////////////////////////////////////////////////////////////////////
//class TestSet_ERR009__bad_IdentityByDefault_and_Nullable

public static class TestSet_ERR009__bad_IdentityByDefault_and_Nullable
{
 private const string c_testTableName
  ="EFCORE_TTABLE_DUMMY";

 private const string c_testColumnName
  ="MY_COLUMN";

 //-----------------------------------------------------------------------
 private const string c_testColumnTypeName
  ="BIGINT";

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
    (3,
     TestUtils.GetRecordCount(e));
 
   CheckErrors.CheckErrorRecord__type_mapping_err__cn_dialect_does_not_support_usage_of_type_in_DDL_query_2
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__FB_V03_0_0_D1__TypeMappingSourceForDDL,
     1,
     "BIGINT");
 
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
 }//Test_001
};//class TestSet_ERR009__bad_IdentityByDefault_and_Nullable

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D1.Migrations.Generations.SET001.DataTypes.Clr.Int64
