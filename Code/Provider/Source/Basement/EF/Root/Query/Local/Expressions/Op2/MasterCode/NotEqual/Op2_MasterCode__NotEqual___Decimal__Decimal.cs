﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 15.05.2021.

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.MasterCode{
////////////////////////////////////////////////////////////////////////////////
//using

using T_ARG1
 =System.Decimal;

using T_ARG2
 =System.Decimal;

using T_RESULT
 =System.Boolean;

////////////////////////////////////////////////////////////////////////////////
//class Op2_MasterCode__NotEqual___Decimal__Decimal

static class Op2_MasterCode__NotEqual___Decimal__Decimal
{
 public static T_RESULT Exec(T_ARG1 a,T_ARG2 b)
 {
  if(a!=b)
   return true;

  return false;
 }//Exec
};//class Op2_MasterCode__NotEqual___Decimal__Decimal

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Op2.MasterCode