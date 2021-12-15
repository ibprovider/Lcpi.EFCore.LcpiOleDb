﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 15.09.2021.
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Operators.SET_001.ArrayLength.Complete.Array_Byte{
////////////////////////////////////////////////////////////////////////////////
//class TestSet_000__verify_result_type

public static class TestSet_000__verify_result_type
{
 private struct tagData
 {
  public string TestTableName;
  public string TestColumnName;

  public xdb.OleDbType ResultOleDbType;

  public tagData(string        testTableName,
                 string        testColumnName,
                 xdb.OleDbType result)
  {
   this.TestTableName   =testTableName;
   this.TestColumnName  =testColumnName;

   this.ResultOleDbType =result;
  }//tagData
 };//struct tagData

 //-----------------------------------------------------------------------
 private static readonly tagData[] sm_Data_000=
 {
  new tagData
   ("BIN_BLOB_TABLE",
    "BIN_DATA",
    xdb.OleDbType.BigInt),

  new tagData
   ("TBL_CS__OCTETS",
    "COL_BLOB",
    xdb.OleDbType.BigInt),

  new tagData
   ("TBL_CS__OCTETS",
    "CHAR__8",
    xdb.OleDbType.Integer),

  new tagData
   ("TBL_CS__OCTETS",
    "VARCHAR__8",
    xdb.OleDbType.Integer),

  new tagData
   ("TBL_CS__WIN1251",
    "VARCHAR__8",
    xdb.OleDbType.Integer),

  new tagData
   ("TBL_CS__WIN1251",
    "COL_BLOB",
    xdb.OleDbType.BigInt),
 };//sm_Data_000

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_000()
 {
  var errList=new List<string>();

  using(var cn=LocalCnHelper.CreateCn())
  {
   cn.Open();

   using(var tr=cn.BeginTransaction())
   {
    using(var cmd=cn.CreateCommand())
    {
     cmd.Transaction=tr;

     foreach(var testData in sm_Data_000)
     {
      string sql
       ="select OCTET_LENGTH("+testData.TestColumnName+") from "+testData.TestTableName;

      cmd.CommandText
       =sql;

      cmd.Prepare();

      using(var reader=cmd.ExecuteReader(System.Data.CommandBehavior.SchemaOnly))
      {
       Assert.IsNotNull
        (reader);

       var schema=reader.GetSchemaTable();

       Assert.IsNotNull
        (schema);

       Assert.AreEqual
        (1,
         schema.Rows.Count);

       var actualOleDbType
        =(xdb.OleDbType)schema.Rows[0][xdb.OleDbDataReaderSchemaColumnNames.ProviderType];

       var currentErrCount=errList.Count;

       if(testData.ResultOleDbType != actualOleDbType)
       {
        string err
         =string.Format
          ("{0}.{1} -> {2}. Expected {3}",
           testData.TestTableName,
           testData.TestColumnName,
           actualOleDbType,
           testData.ResultOleDbType);

        errList.Add(err);
       }//if

       if(currentErrCount==errList.Count)
       {
        Console.WriteLine
         ("OK: {0}.{1} -> {2}.",
          testData.TestTableName,
          testData.TestColumnName,
          actualOleDbType);
       }//if
      }//using reader
     }//foreach testData
    }//using cmd
   }//using tr
  }//using cn

  if(errList.Count>0)
  {
   var sb=new StringBuilder();

   sb.Append("FAILED OPERATIONS:");

   errList
    .Aggregate
      (sb,(current,next)=>current.Append(Environment.NewLine).Append(next))
    .ToString();

   throw new ApplicationException(sb.ToString());
  }//if
 }//Test_000
};//class TestSet_000__verify_result_type

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Operators.SET_001.ArrayLength.Complete.Array_Byte
