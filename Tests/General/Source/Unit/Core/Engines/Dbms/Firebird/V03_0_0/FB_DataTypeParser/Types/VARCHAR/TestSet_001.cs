﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 20.10.2020.
using NUnit.Framework;

using xEFCore=Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb;

namespace EFCore_LcpiOleDb_Tests.General.Unit.Core.Engines.Dbms.Firebird.V03_0_0.FB_DataTypeParser.Types.VARCHAR{
////////////////////////////////////////////////////////////////////////////////

using T_FB_DATATYPE_ID
 =xEFCore.Core.Engines.Dbms.Firebird.Common.FB_Common__DataTypeID;

using T_FB_DATATYPE_PARSER
 =xEFCore.Core.Engines.Dbms.Firebird.V03_0_0.FB_DataTypeParser;

////////////////////////////////////////////////////////////////////////////////
//class TestSet_001

static class TestSet_001
{
 [Test]
 public static void Test_001__one_typename()
 {
  const string c_sourceStr
   ="VARCHAR";

  var resultCode
   =T_FB_DATATYPE_PARSER.Exec
     (c_sourceStr,
      out var resultData);

  Assert.AreEqual
   (T_FB_DATATYPE_PARSER.ResultCode.Ok,
    resultCode);

  TestHelpers.CheckResultData
   (resultData,
    c_sourceStr,
    T_FB_DATATYPE_ID.VARCHAR,
    "VARCHAR",
    /*length*/   null,
    /*precision*/null,
    /*scale*/    null,
    /*subType*/  null,
    /*csName*/   null,
    /*bounds*/   null);
 }//Test_001__one_typename

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_001__one_typename__with_spaces()
 {
  const string c_sourceStr
   =" VARCHAR ";

  var resultCode
   =T_FB_DATATYPE_PARSER.Exec
     (c_sourceStr,
      out var resultData);

  Assert.AreEqual
   (T_FB_DATATYPE_PARSER.ResultCode.Ok,
    resultCode);

  TestHelpers.CheckResultData
   (resultData,
    c_sourceStr,
    T_FB_DATATYPE_ID.VARCHAR,
    "VARCHAR",
    /*length*/   null,
    /*precision*/null,
    /*scale*/    null,
    /*subType*/  null,
    /*csName*/   null,
    /*bounds*/   null);
 }//Test_001__one_typename__with_spaces

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_002__typename_with_length()
 {
  const string c_sourceStr
   ="VARCHAR(32)";

  var resultCode
   =T_FB_DATATYPE_PARSER.Exec
     (c_sourceStr,
      out var resultData);

  Assert.AreEqual
   (T_FB_DATATYPE_PARSER.ResultCode.Ok,
    resultCode);

  TestHelpers.CheckResultData
   (resultData,
    c_sourceStr,
    T_FB_DATATYPE_ID.VARCHAR,
    "VARCHAR",
    /*length*/   32,
    /*precision*/null,
    /*scale*/    null,
    /*subType*/  null,
    /*csName*/   null,
    /*bounds*/   null);
 }//Test_002__typename_with_length

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_002__typename_with_length__with_spaces()
 {
  const string c_sourceStr
   =" VARCHAR ( 32 ) ";

  var resultCode
   =T_FB_DATATYPE_PARSER.Exec
     (c_sourceStr,
      out var resultData);

  Assert.AreEqual
   (T_FB_DATATYPE_PARSER.ResultCode.Ok,
    resultCode);

  TestHelpers.CheckResultData
   (resultData,
    c_sourceStr,
    T_FB_DATATYPE_ID.VARCHAR,
    "VARCHAR",
    /*length*/   32,
    /*precision*/null,
    /*scale*/    null,
    /*subType*/  null,
    /*csName*/   null,
    /*bounds*/   null);
 }//Test_002__typename_with_length__with_spaces

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_003__typename_with_length_cs()
 {
  const string c_sourceStr
   ="VARCHAR(32) CHARACTER SET ASCII";

  var resultCode
   =T_FB_DATATYPE_PARSER.Exec
     (c_sourceStr,
      out var resultData);

  Assert.AreEqual
   (T_FB_DATATYPE_PARSER.ResultCode.Ok,
    resultCode);

  TestHelpers.CheckResultData
   (resultData,
    c_sourceStr,
    T_FB_DATATYPE_ID.VARCHAR,
    "VARCHAR",
    /*length*/   32,
    /*precision*/null,
    /*scale*/    null,
    /*subType*/  null,
    /*csName*/   "ASCII",
    /*bounds*/   null);
 }//Test_003__typename_with_length_cs

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_003__typename_with_length_cs__with_spaces()
 {
  const string c_sourceStr
   =" VARCHAR ( 32 )  CHARACTER   SET   ASCII   ";

  var resultCode
   =T_FB_DATATYPE_PARSER.Exec
     (c_sourceStr,
      out var resultData);

  Assert.AreEqual
   (T_FB_DATATYPE_PARSER.ResultCode.Ok,
    resultCode);

  TestHelpers.CheckResultData
   (resultData,
    c_sourceStr,
    T_FB_DATATYPE_ID.VARCHAR,
    "VARCHAR",
    /*length*/   32,
    /*precision*/null,
    /*scale*/    null,
    /*subType*/  null,
    /*csName*/   "ASCII",
    /*bounds*/   null);
 }//Test_003__typename_with_length_cs__with_spaces

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_004__typename_with_cs()
 {
  const string c_sourceStr
   ="VARCHAR CHARACTER SET ASCII";

  var resultCode
   =T_FB_DATATYPE_PARSER.Exec
     (c_sourceStr,
      out var resultData);

  Assert.AreEqual
   (T_FB_DATATYPE_PARSER.ResultCode.Ok,
    resultCode);

  TestHelpers.CheckResultData
   (resultData,
    c_sourceStr,
    T_FB_DATATYPE_ID.VARCHAR,
    "VARCHAR",
    /*length*/   null,
    /*precision*/null,
    /*scale*/    null,
    /*subType*/  null,
    /*csName*/   "ASCII",
    /*bounds*/   null);
 }//Test_004__typename_with_cs

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_004__typename_with_cs__with_spaces()
 {
  const string c_sourceStr
   ="  VARCHAR    CHARACTER    SET   ASCII   ";

  var resultCode
   =T_FB_DATATYPE_PARSER.Exec
     (c_sourceStr,
      out var resultData);

  Assert.AreEqual
   (T_FB_DATATYPE_PARSER.ResultCode.Ok,
    resultCode);

  TestHelpers.CheckResultData
   (resultData,
    c_sourceStr,
    T_FB_DATATYPE_ID.VARCHAR,
    "VARCHAR",
    /*length*/   null,
    /*precision*/null,
    /*scale*/    null,
    /*subType*/  null,
    /*csName*/   "ASCII",
    /*bounds*/   null);
 }//Test_004__typename_with_cs__with_spaces
};//class TestSet_001

////////////////////////////////////////////////////////////////////////////////
}//EFCore_LcpiOleDb_Tests.General.Unit.Core.Engines.Dbms.Firebird.V03_0_0.FB_DataTypeParser.Types.VARCHAR
