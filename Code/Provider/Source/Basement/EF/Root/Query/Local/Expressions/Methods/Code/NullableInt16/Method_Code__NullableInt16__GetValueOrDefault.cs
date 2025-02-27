﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 17.06.2021.
using System;
using System.Diagnostics;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Code{
////////////////////////////////////////////////////////////////////////////////

using T_RESULT
 =System.Int16;

using T_ARG1__OBJ
 =System.Nullable<System.Int16>;

////////////////////////////////////////////////////////////////////////////////
//class Method_Code__NullableInt16__GetValueOrDefault

static class Method_Code__NullableInt16__GetValueOrDefault
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Method_Code__NullableInt16__GetValueOrDefault)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static T_RESULT Exec(T_ARG1__OBJ obj)
 {
  if(!obj.HasValue)
   return 0;

  Debug.Assert(obj.HasValue);

  return obj.Value;
 }//Exec
};//class Method_Code__NullableInt16__GetValueOrDefault

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Methods.Code
