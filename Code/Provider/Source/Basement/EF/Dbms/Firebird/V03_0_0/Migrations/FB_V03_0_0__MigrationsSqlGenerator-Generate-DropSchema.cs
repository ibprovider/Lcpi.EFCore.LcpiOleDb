﻿////////////////////////////////////////////////////////////////////////////////
//EF Core Provider for LCPI OLE DB.
//                                      IBProvider and Contributors. 11.11.2021.
using System;
using System.Diagnostics;

using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Migrations{
////////////////////////////////////////////////////////////////////////////////
//class FB_V03_0_0__MigrationsSqlGenerator

partial class FB_V03_0_0__MigrationsSqlGenerator
{
 //MigrationsSqlGenerator interface --------------------------------------

 protected override void Generate(DropSchemaOperation         operation,
                                  IModel                      model,
                                  MigrationCommandListBuilder builder)
 {
  const string c_methodSign
   =nameof(Generate)+"("+nameof(DropSchemaOperation)+"...)";

  Check.Arg_NotNull
   (c_ErrSrcID,
    c_methodSign,
    nameof(operation),
    operation);

  Check.Arg_NotNullAndNotEmpty
   (c_ErrSrcID,
    c_methodSign,
    "operation.Name",
    operation.Name);

  Check.Arg_NotNull
   (c_ErrSrcID,
    c_methodSign,
    nameof(builder),
    builder);

  //----------------------------------------------------------------------
  ThrowError.DbmsErr__FB__FirebirdDoesNotSupportSchemas
   (c_ErrSrcID);
 }//Generate - DropSchemaOperation
};//class FB_V03_0_0__MigrationsSqlGenerator

////////////////////////////////////////////////////////////////////////////////
}//namespace Lcpi.EntityFrameworkCore.DataProvider.LcpiOleDb.Basement.EF.Dbms.Firebird.V03_0_0.Migrations
