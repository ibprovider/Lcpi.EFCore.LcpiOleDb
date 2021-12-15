﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 05.06.2021.
using System;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.MasterCode{
////////////////////////////////////////////////////////////////////////////////

using T_SOURCE
 =System.Int64;

using T_TARGET
 =System.Int16;

////////////////////////////////////////////////////////////////////////////////
//class Convert_MasterCode__Int64__Int16

static class Convert_MasterCode__Int64__Int16
{
 private const ErrSourceID
  c_ErrSrcID
   =ErrSourceID.Root_Query_Local_Expressions__Cvt_MasterCode__Int64__Int16;

 //-----------------------------------------------------------------------
 public static T_TARGET Exec(T_SOURCE v)
 {
  if(v<T_TARGET.MinValue || T_TARGET.MaxValue<v)
  {
   ThrowError.FailedToConvertValueBetweenTypes__overflow
    (c_ErrSrcID,
     /*source*/typeof(T_SOURCE),
     /*target*/typeof(T_TARGET),
     /*innerException*/null);
  }//if

  return (T_TARGET)v;
 }//Exec
};//class Convert_MasterCode__Int64__Int16

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Root.Query.Local.Expressions.Converts.MasterCode
