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
 private static LcpiOleDb__LocalEval_Op2__Map Helper__Reg__LessThanOrEqual(LcpiOleDb__LocalEval_Op2__Map Map)
 {
  Debug.Assert(!Object.ReferenceEquals(Map,null));

  Map
   .Reg(LcpiOleDb__ExpressionType.LessThanOrEqual)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__DateOnly.sm_Instance__DateOnly)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__DateOnly.sm_Instance__NullableDateOnly)

   .Add(FB3_D0_ETRS.ETranslators__LessThanOrEqual__DateTime.sm_Instance__DateTime)
   .Add(FB3_D0_ETRS.ETranslators__LessThanOrEqual__DateTime.sm_Instance__NullableDateTime)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Decimal.sm_Instance__NullableSingle)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Double.sm_Instance__NullableSingle)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__SByte.sm_Instance__NullableSingle)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int16.sm_Instance__NullableSingle)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int32.sm_Instance__NullableSingle)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Int64.sm_Instance__NullableSingle)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDateOnly.sm_Instance__DateOnly)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDateOnly.sm_Instance__NullableDateOnly)

   .Add(FB3_D0_ETRS.ETranslators__LessThanOrEqual__NullableDateTime.sm_Instance__DateTime)
   .Add(FB3_D0_ETRS.ETranslators__LessThanOrEqual__NullableDateTime.sm_Instance__NullableDateTime)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDecimal.sm_Instance__NullableSingle)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableDouble.sm_Instance__NullableSingle)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSByte.sm_Instance__NullableSingle)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt16.sm_Instance__NullableSingle)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt32.sm_Instance__NullableSingle)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableInt64.sm_Instance__NullableSingle)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__NullableSingle.sm_Instance__NullableSingle)

   .Add(FB3_D0_ETRS.ETranslators__LessThanOrEqual__NullableTimeOnly.sm_Instance__TimeOnly)
   .Add(FB3_D0_ETRS.ETranslators__LessThanOrEqual__NullableTimeOnly.sm_Instance__NullableTimeOnly)

   .Add(FB3_D0_ETRS.ETranslators__LessThanOrEqual__NullableTimeSpan.sm_Instance__TimeSpan)
   .Add(FB3_D0_ETRS.ETranslators__LessThanOrEqual__NullableTimeSpan.sm_Instance__NullableTimeSpan)

   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__Decimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__Double)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__Int16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__Int32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__Int64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__SByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__Single)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__NullableDecimal)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__NullableDouble)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__NullableInt16)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__NullableInt32)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__NullableInt64)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__NullableSByte)
   .Add(Common_ETRS.ETranslators__LessThanOrEqual__Single.sm_Instance__NullableSingle)

   .Add(FB3_D0_ETRS.ETranslators__LessThanOrEqual__TimeOnly.sm_Instance__TimeOnly)
   .Add(FB3_D0_ETRS.ETranslators__LessThanOrEqual__TimeOnly.sm_Instance__NullableTimeOnly)

   .Add(FB3_D0_ETRS.ETranslators__LessThanOrEqual__TimeSpan.sm_Instance__TimeSpan)
   .Add(FB3_D0_ETRS.ETranslators__LessThanOrEqual__TimeSpan.sm_Instance__NullableTimeSpan)

   /*END*/
   ;

  return Map;
 }//Helper__Reg__LessThanOrEqual
};//class FB_Data__Expressions_Local__Op2__V_V

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Query.Local.D3.Expressions
