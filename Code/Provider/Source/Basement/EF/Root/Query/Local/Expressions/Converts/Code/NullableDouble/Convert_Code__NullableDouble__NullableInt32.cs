﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 22.01.2021.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE
 =System.Nullable<System.Double>;

using T_TARGET
 =System.Nullable<System.Int32>;

////////////////////////////////////////////////////////////////////////////////
//class Convert_Code__NullableDouble__NullableInt32

static class Convert_Code__NullableDouble__NullableInt32
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Convert_Code__NullableDouble__NullableInt32)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static T_TARGET Exec(T_SOURCE v)
 {
  if(!v.HasValue)
   return null;

  return MasterCode.Convert_MasterCode__Double__Int32.Exec
          (v.Value);
 }//Exec
};//class Convert_Code__NullableDouble__NullableInt32

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code
