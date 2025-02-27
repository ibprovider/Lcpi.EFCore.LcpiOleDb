﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 11.06.2021.
using System;
using System.Linq;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Code{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Collections.Generic.IEnumerable<System.Nullable<System.Int32>>;

using T_ARG2
 =System.Nullable<System.Int32>;

using T_RESULT
 =System.Nullable<System.Boolean>;

////////////////////////////////////////////////////////////////////////////////
//class Method_Code__IEnumerableNullableInt32__Contains__NullableInt32

static class Method_Code__IEnumerableNullableInt32__Contains__NullableInt32
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Method_Code__IEnumerableNullableInt32__Contains__NullableInt32)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec(Core.Core_OperationCtx opCtx,
                              T_ARG1                 collection,
                              T_ARG2                 testValue)
 {
  return MasterCode.Method_MasterCode__IEnumerable_generic__Contains.Exec
          (opCtx,
           collection,
           testValue);
 }//Exec
};//class Method_Code__IEnumerableNullableInt32__Contains__NullableInt32

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Code
