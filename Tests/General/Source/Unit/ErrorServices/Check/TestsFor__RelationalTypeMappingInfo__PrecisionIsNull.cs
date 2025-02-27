﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 29.05.2018.
using NUnit.Framework;

using xEFCore=Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb;

namespace EFCore_LcpiOleDb_Tests.General.Unit.ErrorServices.Check{
////////////////////////////////////////////////////////////////////////////////
//class TestsFor__RelationalTypeMappingInfo__PrecisionIsNull

class TestsFor__RelationalTypeMappingInfo__PrecisionIsNull
{
 [Test]
 public static void Test_02()
 {
  // public RelationalTypeMappingInfo(
  //     [NotNull] string storeTypeName,
  //     [NotNull] string storeTypeNameBase,
  //     bool? unicode,
  //     int? size,
  //     int? precision,
  //     int? scale)

  var mappingInfo
   =new Microsoft.EntityFrameworkCore.Storage.RelationalTypeMappingInfo
        ("CHAR",
         "CHAR",
         null,
         null,
         null,
         null);

  Assert.IsFalse
   (mappingInfo.Precision.HasValue);

  xEFCore.Check.RelationalTypeMappingInfo__PrecisionIsNull
   (xEFCore.ErrSourceID.FB_Common__TypeMapping__NUMERIC,
    mappingInfo);
 }//Test_02

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_03__err()
 {
  // public RelationalTypeMappingInfo(
  //     [NotNull] string storeTypeName,
  //     [NotNull] string storeTypeNameBase,
  //     bool? unicode,
  //     int? size,
  //     int? precision,
  //     int? scale)

  var mappingInfo
   =new Microsoft.EntityFrameworkCore.Storage.RelationalTypeMappingInfo
         ("NUMERIC(10,4)",
          "NUMERIC",
          null,
          null,
          10,
          4);

  Assert.IsTrue
   (mappingInfo.Precision.HasValue);

  Assert.AreEqual
   (10,
    mappingInfo.Precision.Value);

  try
  {
   xEFCore.Check.RelationalTypeMappingInfo__PrecisionIsNull
    (xEFCore.ErrSourceID.FB_Common__TypeMapping__CHAR,
     mappingInfo);
  }
  catch(xEFCore.LcpiOleDb__DataToolException e)
  {
   CheckErrors.PrintException_OK(e);

   Assert.AreEqual
    (1,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__type_mapping_err__unexpected_Precision_1
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__FB_Common__TypeMapping__CHAR,
     10);

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_03__err
};//class TestsFor__RelationalTypeMappingInfo__PrecisionIsNull

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Unit.ErrorServices.Check
