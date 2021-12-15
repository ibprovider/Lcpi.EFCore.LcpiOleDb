﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 04.11.2020.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE
 =System.Nullable<System.Int16>;

using T_TARGET
 =System.Nullable<System.Int64>;

////////////////////////////////////////////////////////////////////////////////
//class Convert_Code__NullableInt16__NullableInt64

static class Convert_Code__NullableInt16__NullableInt64
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Convert_Code__NullableInt16__NullableInt64)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static T_TARGET Exec(T_SOURCE v)
 {
  if(!v.HasValue)
   return null;

  return MasterCode.Convert_MasterCode__Int16__Int64.Exec
          (v.Value);
 }//Exec
};//class Convert_Code__NullableInt16__NullableInt64

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code
