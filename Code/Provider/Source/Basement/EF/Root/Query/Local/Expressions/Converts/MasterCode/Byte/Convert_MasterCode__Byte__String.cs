﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 05.06.2021.
using System;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.MasterCode{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE
 =System.Byte;

using T_TARGET
 =System.String;

////////////////////////////////////////////////////////////////////////////////
//class Convert_MasterCode__Byte__String

static class Convert_MasterCode__Byte__String
{
 public static T_TARGET Exec(T_SOURCE v)
 {
  return v.ToString(EConvertConfig.CvtCulture);
 }//Exec
};//class Convert_MasterCode__Byte__String

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.MasterCode
