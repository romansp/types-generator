using Reinforced.Typings.Ast.TypeNames;
using Reinforced.Typings.Fluent;
using System;
using System.Collections.Generic;

namespace generator {
    public static class TypescriptGenerationConfiguration {

        private static readonly RtSimpleTypeName TsString = new RtSimpleTypeName(typeof(string).Name.ToLower());
        private static readonly Dictionary<Type, RtTypeName> _TypeSubstituteMap = new Dictionary<Type, RtTypeName> {
            { typeof(DateTime), TsString },
            { typeof(DateTime?), TsString },
            { typeof(DateTimeOffset), TsString },
            { typeof(Guid), TsString },
        };

        private static readonly Action<InterfaceExportBuilder> interfacesDefaults = config => config.WithPublicFields().WithPublicProperties().AutoI(false).DontIncludeToNamespace();
        private static readonly Action<EnumExportBuilder> enumsDefaults = config => config.DontIncludeToNamespace().Const();

        public static void Configure(ConfigurationBuilder builder) {
            builder.Global(global => global.TabSymbol("  ").UseModules().AutoOptionalProperties());
            builder.ExportAsInterface<Class1>();
        }
    }
}
