﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 10.12.2021.
using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D3.Expressions{
////////////////////////////////////////////////////////////////////////////////
//using

using Common_ETRS
 =Root.Query.Local.Expressions.Op2.Translators.Instances;

using Common_ETR_STD
 =Root.Query.Local.Expressions.Op2.Translators.Std;

using FB3_D0_ETRS
 =Firebird.V03_0_0.Query.Local.D0.Expressions.Op2.Translators.Instances;

using FB3_D3_ETRS
 =Firebird.V03_0_0.Query.Local.D3.Expressions.Op2.Translators.Instances;

using LcpiOleDb__LocalEval_Op2__Map
 =Root.Query.Local.LcpiOleDb__LocalEval_Op2__Map;

using Structure_TypeCache
 =Structure.Structure_TypeCache;

////////////////////////////////////////////////////////////////////////////////
//class FB_Data__Expressions_Local__Op2__V_V

static partial class FB_Data__Expressions_Local__Op2__V_V
{
 private static LcpiOleDb__LocalEval_Op2__Map Helper__Reg__Add(LcpiOleDb__LocalEval_Op2__Map Map)
 {
  Debug.Assert(!Object.ReferenceEquals(Map,null));

  Map
   .Reg(LcpiOleDb__ExpressionType.Add)

   .Add(FB3_D0_ETRS.ETranslators__Add__DateTime.sm_Instance__TimeSpan)
   .Add(FB3_D0_ETRS.ETranslators__Add__DateTime.sm_Instance__NullableTimeSpan)

   .Add(FB3_D0_ETRS.ETranslators__Add__TimeSpan.sm_Instance__TimeSpan)
   .Add(FB3_D0_ETRS.ETranslators__Add__TimeSpan.sm_Instance__NullableTimeSpan)

   .Add(Common_ETRS.ETranslators__Add__Decimal.sm_Instance__Decimal)                             //Decimal
   .Add(FB3_D0_ETRS.ETranslators__Add__Decimal.sm_Instance__Double)                              //Double
   .Add(Common_ETRS.ETranslators__Add__Decimal.sm_Instance__NullableDecimal)                     //Decimal?
   .Add(FB3_D0_ETRS.ETranslators__Add__Decimal.sm_Instance__NullableDouble)                      //Double?

   .Add(FB3_D0_ETRS.ETranslators__Add__Double.sm_Instance__Decimal)                              //Double
   .Add(FB3_D0_ETRS.ETranslators__Add__Double.sm_Instance__Double)                               //Double
   .Add(FB3_D0_ETRS.ETranslators__Add__Double.sm_Instance__Single)                               //Double
   .Add(FB3_D0_ETRS.ETranslators__Add__Double.sm_Instance__NullableDecimal)                      //Double?
   .Add(FB3_D0_ETRS.ETranslators__Add__Double.sm_Instance__NullableDouble)                       //Double?
   .Add(FB3_D0_ETRS.ETranslators__Add__Double.sm_Instance__NullableSingle)                       //Double?

   .Add(FB3_D3_ETRS.ETranslators__Add__Int16.sm_Instance__Int16)                                 //Int64
   .Add(FB3_D3_ETRS.ETranslators__Add__Int16.sm_Instance__Int32)                                 //Int64
   .Add(FB3_D3_ETRS.ETranslators__Add__Int16.sm_Instance__Int64)                                 //Int64
   .Add(FB3_D3_ETRS.ETranslators__Add__Int16.sm_Instance__NullableInt16)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__Int16.sm_Instance__NullableInt32)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__Int16.sm_Instance__NullableInt64)                         //Int64?

   .Add(FB3_D3_ETRS.ETranslators__Add__Int32.sm_Instance__Int16)                                 //Int64
   .Add(FB3_D3_ETRS.ETranslators__Add__Int32.sm_Instance__Int32)                                 //Int64
   .Add(FB3_D3_ETRS.ETranslators__Add__Int32.sm_Instance__Int64)                                 //Int64
   .Add(FB3_D3_ETRS.ETranslators__Add__Int32.sm_Instance__NullableInt16)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__Int32.sm_Instance__NullableInt32)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__Int32.sm_Instance__NullableInt64)                         //Int64?

   .Add(FB3_D3_ETRS.ETranslators__Add__Int64.sm_Instance__Int16)                                 //Int64
   .Add(FB3_D3_ETRS.ETranslators__Add__Int64.sm_Instance__Int32)                                 //Int64
   .Add(FB3_D3_ETRS.ETranslators__Add__Int64.sm_Instance__Int64)                                 //Int64
   .Add(FB3_D3_ETRS.ETranslators__Add__Int64.sm_Instance__NullableInt16)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__Int64.sm_Instance__NullableInt32)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__Int64.sm_Instance__NullableInt64)                         //Int64?

   .Add(FB3_D0_ETRS.ETranslators__Add__NullableDateTime.sm_Instance__TimeSpan)
   .Add(FB3_D0_ETRS.ETranslators__Add__NullableDateTime.sm_Instance__NullableTimeSpan)

   .Add(FB3_D0_ETRS.ETranslators__Add__NullableTimeSpan.sm_Instance__TimeSpan)
   .Add(FB3_D0_ETRS.ETranslators__Add__NullableTimeSpan.sm_Instance__NullableTimeSpan)

   .Add(Common_ETRS.ETranslators__Add__NullableDecimal.sm_Instance__Decimal)                     //Decimal?
   .Add(FB3_D0_ETRS.ETranslators__Add__NullableDecimal.sm_Instance__Double)                      //Double?
   .Add(Common_ETRS.ETranslators__Add__NullableDecimal.sm_Instance__NullableDecimal)             //Decimal?
   .Add(FB3_D0_ETRS.ETranslators__Add__NullableDecimal.sm_Instance__NullableDouble)              //Double?

   .Add(FB3_D0_ETRS.ETranslators__Add__NullableDouble.sm_Instance__Decimal)                      //Double?
   .Add(FB3_D0_ETRS.ETranslators__Add__NullableDouble.sm_Instance__Double)                       //Double?
   .Add(FB3_D0_ETRS.ETranslators__Add__NullableDouble.sm_Instance__Single)                       //Double?
   .Add(FB3_D0_ETRS.ETranslators__Add__NullableDouble.sm_Instance__NullableDecimal)              //Double?
   .Add(FB3_D0_ETRS.ETranslators__Add__NullableDouble.sm_Instance__NullableDouble)               //Double?
   .Add(FB3_D0_ETRS.ETranslators__Add__NullableDouble.sm_Instance__NullableSingle)               //Double?

   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt16.sm_Instance__Int16)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt16.sm_Instance__Int32)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt16.sm_Instance__Int64)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt16.sm_Instance__NullableInt16)                 //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt16.sm_Instance__NullableInt32)                 //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt16.sm_Instance__NullableInt64)                 //Int64?

   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt32.sm_Instance__Int16)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt32.sm_Instance__Int32)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt32.sm_Instance__Int64)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt32.sm_Instance__NullableInt16)                 //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt32.sm_Instance__NullableInt32)                 //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt32.sm_Instance__NullableInt64)                 //Int64?

   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt64.sm_Instance__Int16)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt64.sm_Instance__Int32)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt64.sm_Instance__Int64)                         //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt64.sm_Instance__NullableInt16)                 //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt64.sm_Instance__NullableInt32)                 //Int64?
   .Add(FB3_D3_ETRS.ETranslators__Add__NullableInt64.sm_Instance__NullableInt64)                 //Int64?

   .Add(FB3_D0_ETRS.ETranslators__Add__NullableSingle.sm_Instance__Double)                       //Double?
   .Add(FB3_D0_ETRS.ETranslators__Add__NullableSingle.sm_Instance__Single)                       //Double?
   .Add(FB3_D0_ETRS.ETranslators__Add__NullableSingle.sm_Instance__NullableDouble)               //Double?
   .Add(FB3_D0_ETRS.ETranslators__Add__NullableSingle.sm_Instance__NullableSingle)               //Double?

   .Add(FB3_D0_ETRS.ETranslators__Add__Single.sm_Instance__Double)                               //Double
   .Add(FB3_D0_ETRS.ETranslators__Add__Single.sm_Instance__Single)                               //Double
   .Add(FB3_D0_ETRS.ETranslators__Add__Single.sm_Instance__NullableDouble)                       //Double?
   .Add(FB3_D0_ETRS.ETranslators__Add__Single.sm_Instance__NullableSingle)                       //Double?

   /*string*/
   .Add(Common_ETRS.ETranslators__Concat__String.sm_Instance__String)

   .Add_Concat(Structure_TypeCache.TypeOf__System_String,Structure_TypeCache.TypeOf__System_Object)

   /*object*/
   .Add_Concat(Structure_TypeCache.TypeOf__System_Object,Structure_TypeCache.TypeOf__System_String)

   /*END*/
   ;

  return Map;
 }//Helper__Reg__Add
};//class FB_Data__Expressions_Local__Op2__V_V

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D3.Expressions
