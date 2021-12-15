﻿////////////////////////////////////////////////////////////////////////////////
//NUnit tests for "EF Core Provider for LCPI OLE DB"
//                                      IBProvider and Contributors. 19.06.2021.
using System;
using System.Reflection;
using System.Linq;

using NUnit.Framework;

using xEFCore=Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb;

using structure_lib=lcpi.lib.structure;

namespace EFCore_LcpiOleDb_Tests.General.Unit.Structure.Structure_SwitchToUnderlying.Exec__MethodInfo{
////////////////////////////////////////////////////////////////////////////////
//class Test_T002__STATIC

static class Test_T002__STATIC
{
 private class T_OBJECT
 {
  static public T Exec<T>(T x)
  {
   return x;
  }//Exec

  //-------------------------------------------------------
  static public T Exec2<T>(T x,TestTypes.Enums.EnumInt64 e)
  {
   return x;
  }//Exec2

  static public T Exec2<T>(T x,System.Int64 e)
  {
   return x;
  }//Exec2

  //-------------------------------------------------------
  static public T Exec3<T>(T x,TestTypes.Enums.EnumInt64 e)
  {
   return x;
  }//Exec3

  //-------------------------------------------------------
  static public T Exec4<T>(T x,TestTypes.Enums.EnumInt64 e)
  {
   return x;
  }//Exec4

  public T Exec4<T>(T x,System.Int64 e)
  {
   return x;
  }//Exec4
 };//class T_OBJECT

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_001__Exec_16()
 {
  var method_g
   =GetMethod
     ("Exec",
      1,
      types => new[]{ types[0] });

  //----------------------------------------
  var sourceMethod
   =method_g.MakeGenericMethod
     (new[]{typeof(TestTypes.Enums.EnumInt16)});

  Assert.IsNotNull
   (sourceMethod);

  var expectedMethod
   =method_g.MakeGenericMethod
     (new[]{typeof(System.Int16)});

  Assert.IsNotNull
   (expectedMethod);

  //----------------------------------------
  var resultMethod
   =xEFCore.Structure.Structure_SwitchToUnderlying.Exec
     (sourceMethod);

  Assert.AreEqual
   (expectedMethod,
    resultMethod);
 }//Test_001__Exec_16

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_002__Exec2_16()
 {
  var sourceMethod_g
   =GetMethod
     ("Exec2",
      1,
      types => new[]{ types[0], typeof(TestTypes.Enums.EnumInt64) });

  var sourceMethod
   =sourceMethod_g.MakeGenericMethod
     (new[]{typeof(TestTypes.Enums.EnumInt16)});

  Assert.IsNotNull
   (sourceMethod);

  //----------------------------------------
  var expectedMethod_g
   =GetMethod
     ("Exec2",
      1,
      types => new[]{ types[0], typeof(System.Int64) });

  var expectedMethod
   =expectedMethod_g.MakeGenericMethod
     (new[]{typeof(System.Int16)});

  Assert.IsNotNull
   (expectedMethod);

  //----------------------------------------
  var resultMethod
   =xEFCore.Structure.Structure_SwitchToUnderlying.Exec
     (sourceMethod);

  Assert.AreEqual
   (expectedMethod,
    resultMethod);
 }//Test_002__Exec2_16

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_ERR001__Exec3()
 {
  //
  // TRY MAP
  //
  //  Exec3<TestTypes.Enums.EnumInt16>(TestTypes.Enums.EnumInt16, TestTypes.Enums.EnumInt64)
  //
  // TO
  //
  //  Exec3<System.Int16>(System.Int16, System.Int64)
  //

  //----------------------------------------
  var sourceMethod_g
   =GetMethod
     ("Exec3",
      1,
      types => new[]{ types[0], typeof(TestTypes.Enums.EnumInt64) });

  var sourceMethod
   =sourceMethod_g.MakeGenericMethod
     (new[]{typeof(TestTypes.Enums.EnumInt16)});

  Assert.IsNotNull
   (sourceMethod);

  //----------------------------------------
  try
  {
   var resultMethod
    =xEFCore.Structure.Structure_SwitchToUnderlying.Exec
      (sourceMethod);
  }
  catch(structure_lib.exceptions.t_invalid_operation_exception e)
  {
   CheckErrors.PrintException_OK(e);

   Assert.AreEqual
    (1,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__common_err__cant_remap_generic_method_4
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__Structure_SwitchToUnderlying,
     "EFCore_LcpiOleDb_Tests.General.Unit.Structure.Structure_SwitchToUnderlying.Exec__MethodInfo.Test_T002__STATIC+T_OBJECT.Exec3<EFCore_LcpiOleDb_Tests.General.TestTypes.Enums.EnumInt16>(EFCore_LcpiOleDb_Tests.General.TestTypes.Enums.EnumInt16, EFCore_LcpiOleDb_Tests.General.TestTypes.Enums.EnumInt64)",
     "EFCore_LcpiOleDb_Tests.General.Unit.Structure.Structure_SwitchToUnderlying.Exec__MethodInfo.Test_T002__STATIC+T_OBJECT",
     "System.Int16, System.Int64",
     "System.Int16");

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_ERR001__Exec3

 //-----------------------------------------------------------------------
 [Test]
 public static void Test_ERR002__Exec4()
 {
  //
  // TRY MAP
  //
  //  Exec4<TestTypes.Enums.EnumInt16>(TestTypes.Enums.EnumInt16, TestTypes.Enums.EnumInt64)
  //
  // TO
  //
  //  Exec4<System.Int16>(System.Int16, System.Int64)
  //
  //  MUST IGNORE INSTANCE VARIANT
  //

  //----------------------------------------
  var sourceMethod_g
   =GetMethod
     ("Exec4",
      1,
      types => new[]{ types[0], typeof(TestTypes.Enums.EnumInt64) });

  var sourceMethod
   =sourceMethod_g.MakeGenericMethod
     (new[]{typeof(TestTypes.Enums.EnumInt16)});

  Assert.IsNotNull
   (sourceMethod);

  //----------------------------------------
  try
  {
   var resultMethod
    =xEFCore.Structure.Structure_SwitchToUnderlying.Exec
      (sourceMethod);
  }
  catch(structure_lib.exceptions.t_invalid_operation_exception e)
  {
   CheckErrors.PrintException_OK(e);

   Assert.AreEqual
    (1,
     TestUtils.GetRecordCount(e));

   CheckErrors.CheckErrorRecord__common_err__cant_remap_generic_method_4
    (TestUtils.GetRecord(e,0),
     CheckErrors.c_src__EFCoreDataProvider__Structure_SwitchToUnderlying,
     "EFCore_LcpiOleDb_Tests.General.Unit.Structure.Structure_SwitchToUnderlying.Exec__MethodInfo.Test_T002__STATIC+T_OBJECT.Exec4<EFCore_LcpiOleDb_Tests.General.TestTypes.Enums.EnumInt16>(EFCore_LcpiOleDb_Tests.General.TestTypes.Enums.EnumInt16, EFCore_LcpiOleDb_Tests.General.TestTypes.Enums.EnumInt64)",
     "EFCore_LcpiOleDb_Tests.General.Unit.Structure.Structure_SwitchToUnderlying.Exec__MethodInfo.Test_T002__STATIC+T_OBJECT",
     "System.Int16, System.Int64",
     "System.Int16");

   return;
  }//catch

  TestServices.ThrowWeWaitError();
 }//Test_ERR002__Exec4

 //-----------------------------------------------------------------------
 private static MethodInfo GetMethod(string               name,
                                     int                  genericParameterCount,
                                     Func<Type[], Type[]> parameterGenerator)
 {
  var queryableMethodGroups
   =typeof(T_OBJECT)
     .GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
     .GroupBy(mi => mi.Name)
     .ToDictionary(e => e.Key, l => l.ToList());

  var r
   =queryableMethodGroups[name].Single
     (
      mi => ((genericParameterCount == 0 && !mi.IsGenericMethod) || (mi.IsGenericMethod && mi.GetGenericArguments().Length == genericParameterCount))
            && mi.GetParameters().Select(e => e.ParameterType).SequenceEqual(parameterGenerator(mi.IsGenericMethod ? mi.GetGenericArguments() : Array.Empty<Type>()))
     );

  return r;
 }//GetMethod
};//class Test_T002__STATIC

////////////////////////////////////////////////////////////////////////////////
}//namespace EFCore_LcpiOleDb_Tests.General.Unit.Structure.Structure_SwitchToUnderlying.Exec__MethodInfo
