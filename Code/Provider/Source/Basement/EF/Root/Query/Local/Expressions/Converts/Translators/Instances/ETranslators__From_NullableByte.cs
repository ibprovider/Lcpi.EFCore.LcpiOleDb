﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 14.05.2021.

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Translators.Instances{
////////////////////////////////////////////////////////////////////////////////

using LOCAL_EVAL__Convert__Descr
 =Root.Query.Local.LcpiOleDb__LocalEval_Convert__Descr;

using LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE
 =Root.Query.Local.Expressions.Converts.Translators.Std.ETranslator__Std__Simple;

using LOCAL_EVAL__Convert__ETranslator__STD__WITH_CVT_CTX
 =Translators.Std.ETranslator__Std__WithCvtCtx;

////////////////////////////////////////////////////////////////////////////////
//class ETranslators__From_NullableByte

static class ETranslators__From_NullableByte
{
 public static readonly LOCAL_EVAL__Convert__Descr
  sm_TO__Object
   =new LOCAL_EVAL__Convert__Descr
     (new LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE(Code.Convert_Code__NullableByte__Object.MethodInfo),
      null);

 public static readonly LOCAL_EVAL__Convert__Descr
  sm_TO__String
   =new LOCAL_EVAL__Convert__Descr
     (new LOCAL_EVAL__Convert__ETranslator__STD__WITH_CVT_CTX(Code.Convert_Code__NullableByte__String.MethodInfo),
      null);

 //-------------------------------------------------------- NULLABLE
 public static readonly LOCAL_EVAL__Convert__Descr
  sm_TO__NullableByte
   =new LOCAL_EVAL__Convert__Descr
     (new LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE(Code.Convert_Code__NullableByte__NullableByte.MethodInfo),
      null);

 public static readonly LOCAL_EVAL__Convert__Descr
  sm_TO__NullableDecimal
   =new LOCAL_EVAL__Convert__Descr
     (new LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE(Code.Convert_Code__NullableByte__NullableDecimal.MethodInfo),
      null);

 public static readonly LOCAL_EVAL__Convert__Descr
  sm_TO__NullableDouble
   =new LOCAL_EVAL__Convert__Descr
     (new LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE(Code.Convert_Code__NullableByte__NullableDouble.MethodInfo),
      null);

 public static readonly LOCAL_EVAL__Convert__Descr
  sm_TO__NullableInt16
   =new LOCAL_EVAL__Convert__Descr
     (new LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE(Code.Convert_Code__NullableByte__NullableInt16.MethodInfo),
      null);

 public static readonly LOCAL_EVAL__Convert__Descr
  sm_TO__NullableInt32
   =new LOCAL_EVAL__Convert__Descr
     (new LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE(Code.Convert_Code__NullableByte__NullableInt32.MethodInfo),
      null);

 public static readonly LOCAL_EVAL__Convert__Descr
  sm_TO__NullableInt64
   =new LOCAL_EVAL__Convert__Descr
     (new LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE(Code.Convert_Code__NullableByte__NullableInt64.MethodInfo),
      null);

 public static readonly LOCAL_EVAL__Convert__Descr
  sm_TO__NullableSByte
   =new LOCAL_EVAL__Convert__Descr
     (new LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE(Code.Convert_Code__NullableByte__NullableSByte.MethodInfo),
      null);

 public static readonly LOCAL_EVAL__Convert__Descr
  sm_TO__NullableSingle
   =new LOCAL_EVAL__Convert__Descr
     (new LOCAL_EVAL__Convert__ETranslator__STD__SIMPLE(Code.Convert_Code__NullableByte__NullableSingle.MethodInfo),
      null);
};//class ETranslators__From_NullableByte

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Translators.Instances
