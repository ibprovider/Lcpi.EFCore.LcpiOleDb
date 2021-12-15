﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 05.01.2021.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE
 =System.Nullable<System.Single>;

using T_TARGET
 =System.Nullable<System.Double>;

////////////////////////////////////////////////////////////////////////////////
//class Convert_Code__NullableSingle__NullableDouble

static class Convert_Code__NullableSingle__NullableDouble
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Convert_Code__NullableSingle__NullableDouble)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static T_TARGET Exec(T_SOURCE v)
 {
  if(!v.HasValue)
   return null;

  return MasterCode.Convert_MasterCode__Single__Double.Exec
          (v.Value);
 }//Exec
};//class Convert_Code__NullableSingle__NullableDouble

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code
