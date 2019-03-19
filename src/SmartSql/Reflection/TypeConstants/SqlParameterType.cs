﻿using SmartSql.Data;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SmartSql.Reflection.TypeConstants
{
    public static class SqlParameterType
    {
        public readonly static Type SqlParameter = typeof(SqlParameter);
        public readonly static Type SqlParameterCollection = typeof(SqlParameterCollection);

        public static class Ctor
        {
            public readonly static ConstructorInfo SqlParameter = SqlParameterType.SqlParameter.GetConstructor(new Type[] { CommonType.String, CommonType.Object, TypeType.Type });
            public readonly static ConstructorInfo SqlParameterCollection = SqlParameterType.SqlParameterCollection.GetConstructor(new Type[] { CommonType.Boolean });
        }
        public static class Method
        {
            /// <summary>
            /// Add By SqlParameter
            /// </summary>
            public readonly static MethodInfo Add = SqlParameterCollection.GetMethod("Add", new Type[] { SqlParameterType.SqlParameter });
            public readonly static MethodInfo SetTypeHandler = SqlParameter.GetMethod("set_TypeHandler");
        }
    }
}
