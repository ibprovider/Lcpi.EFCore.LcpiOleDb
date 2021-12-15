﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 05.06.2021.
using System;
using System.Reflection;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE
 =System.Nullable<System.Byte>;

using T_TARGET
 =System.Nullable<System.SByte>;

////////////////////////////////////////////////////////////////////////////////
//class Convert_Code__NullableByte__NullableSByte

static class Convert_Code__NullableByte__NullableSByte
{
 public static readonly System.Reflection.MethodInfo
  MethodInfo
   =typeof(Convert_Code__NullableByte__NullableSByte)
     .GetTypeInfo()
     .GetDeclaredMethod(nameof(Exec));

 //-----------------------------------------------------------------------
 private static T_TARGET Exec(T_SOURCE v)
 {
  if(!v.HasValue)
   return null;

  return MasterCode.Convert_MasterCode__Byte__SByte.Exec
          (v.Value);
 }//Exec
};//class Convert_Code__NullableByte__NullableSByte

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.Code
