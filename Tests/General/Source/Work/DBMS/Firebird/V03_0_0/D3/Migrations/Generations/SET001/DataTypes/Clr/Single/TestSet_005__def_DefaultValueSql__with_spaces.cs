﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 24.09.2021.
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using NUnit.Framework;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Migrations.Generations.SET001.DataTypes.Clr.Single{
////////////////////////////////////////////////////////////////////////////////
//class TestSet_005__def_DefaultValueSql__with_spaces

public static class TestSet_005__def_DefaultValueSql__with_spaces
{
 private const string c_testTableName
  ="EFCORE_TTABLE_DUMMY";

 private const string c_testColumnName
  ="MY_COLUMN";

 //-----------------------------------------------------------------------
 private const string c_testColumnTypeName
  ="FLOAT";

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0001__NOT_NULL()
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
         ClrType         = null,
         ColumnType      = c_testColumnTypeName,
         IsNullable      = false,
         DefaultValueSql = "   12345   "
        },
       },
    };//operation

  //------------------------------------------------------------
  var expectedSQL
   =new TestSqlTemplate()
     .T("CREATE TABLE ").N(c_testTableName).T(" (").CRLF()
     .T("    ").N(c_testColumnName).T(" FLOAT DEFAULT 12345 NOT NULL").CRLF()
     .T(");").CRLF();

  TestHelper.Exec
   (new[]{operation},
    new[]{expectedSQL});
 }//Test_0001__NOT_NULL

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_0002__NULLABLE()
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
         ClrType         = null,
         ColumnType      = c_testColumnTypeName,
         IsNullable      = true,
         DefaultValueSql = " 12345 "
        },
       },
    };//operation

  //------------------------------------------------------------
  var expectedSQL
   =new TestSqlTemplate()
     .T("CREATE TABLE ").N(c_testTableName).T(" (").CRLF()
     .T("    ").N(c_testColumnName).T(" FLOAT DEFAULT 12345").CRLF()
     .T(");").CRLF();

  TestHelper.Exec
   (new[]{operation},
    new[]{expectedSQL});
 }//Test_0002__NULLABLE
};//class TestSet_005__def_DefaultValueSql__with_spaces

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Migrations.Generations.SET001.DataTypes.Clr.Single
