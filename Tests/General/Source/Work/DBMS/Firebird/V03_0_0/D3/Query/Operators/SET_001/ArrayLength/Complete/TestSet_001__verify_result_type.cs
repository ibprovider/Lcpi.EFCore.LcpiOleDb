﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 21.05.2021.
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

using xdb=lcpi.data.oledb;

namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Operators.SET_001.ArrayLength.Complete{
////////////////////////////////////////////////////////////////////////////////
//class TestSet_001__verify_result_type

public static class TestSet_001__verify_result_type
{
 private struct tagData
 {
  public string         FunctionName;
  public xdb.OleDbType  ResultOleDbType;
  public int            AsVarCharLen;

  public tagData(string        functionName,
                 xdb.OleDbType resultType,
                 int           asVarCharLen)
  {
   this.FunctionName    =functionName;
   this.ResultOleDbType =resultType;
   this.AsVarCharLen    =asVarCharLen;
  }//tagData
 };//struct tagData

 private static readonly tagData[] sm_Data_000=
 {
  new tagData("OCTET_LENGTH", xdb.OleDbType.BigInt,20),
  new tagData("CHAR_LENGTH" , xdb.OleDbType.BigInt,20),
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
       ="select "+testData.FunctionName+"(x.COL_TEXT_BLOB) from TEST_MODIFY_ROW2 x";

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

       if(testData.ResultOleDbType != actualOleDbType)
       {
        string err
         =string.Format
          ("{0} -> {1}. Expected {2}",
           testData.FunctionName,
           actualOleDbType,
           testData.ResultOleDbType);

        errList.Add(err);
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

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_000__as_vch()
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
       ="select ''||"+testData.FunctionName+"(x.COL_TEXT_BLOB) from TEST_MODIFY_ROW2 x";

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

       var actualColumnSize
        =schema.Rows[0][xdb.OleDbDataReaderSchemaColumnNames.ColumnSize];

       if(!testData.AsVarCharLen.Equals(actualColumnSize))
       {
        string err
         =string.Format
          ("{0} -> {1}. Expected {2}",
           testData.FunctionName,
           actualColumnSize,
           testData.AsVarCharLen);

        errList.Add(err);
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
 }//Test_000__as_vch
};//class TestSet_001__verify_result_type

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Work.DBMS.Firebird.V03_0_0.D3.Query.Operators.SET_001.ArrayLength.Complete
