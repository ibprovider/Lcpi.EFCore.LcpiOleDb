﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 04.06.2021.

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.MasterCode{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE
 =System.SByte;

using T_TARGET
 =System.Decimal;

////////////////////////////////////////////////////////////////////////////////
//class Convert_MasterCode__SByte__Decimal

static class Convert_MasterCode__SByte__Decimal
{
 public static T_TARGET Exec(T_SOURCE v)
 {
  return v;
 }//Exec
};//class Convert_MasterCode__SByte__Decimal

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.MasterCode
