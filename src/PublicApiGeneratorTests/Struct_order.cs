﻿using PublicApiGeneratorTests.Examples;
using Xunit;

namespace PublicApiGeneratorTests
{
    public class Struct_order : ApiGeneratorTestsBase
    {
        [Fact]
        public void Should_output_structs_in_alphabetical_order()
        {
            AssertPublicApi(new[] { typeof(ZZ_Struct), typeof(AA_Struct), typeof(MM_Struct) },
@"namespace PublicApiGeneratorTests.Examples
{
    public struct AA_Struct { }
    public struct MM_Struct { }
    public struct ZZ_Struct { }
}");
        }
    }

    // ReSharper disable InconsistentNaming
    namespace Examples
    {
        public struct ZZ_Struct
        {
        }

        public struct AA_Struct
        {
        }

        public struct MM_Struct
        {
        }
    }
    // ReSharper restore InconsistentNaming
}