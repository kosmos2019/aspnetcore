#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6fa3992fa56644768995c97941d682d90f6d8ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_NoLinePragmas_Runtime), @"default", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml")]
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6fa3992fa56644768995c97941d682d90f6d8ec", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml")]
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_NoLinePragmas_Runtime
    {
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
  
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
 while(i <= 10) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Hello from C#, #");
#nullable restore
#line 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
    i += 1;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
 if(i == 11) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>We wrote 10 lines!</p>\r\n");
#nullable restore
#line 12 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
 switch(i) {
    case 11:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No really, we wrote 10 lines!</p>\r\n");
#nullable restore
#line 17 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
        break;
    default:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Actually, we didn\'t...</p>\r\n");
#nullable restore
#line 20 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
        break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 23 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
 for(int j = 1; j <= 10; j += 2) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Hello again from C#, #");
#nullable restore
#line 24 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
                         Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 25 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
 try {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>That time, we wrote 5 lines!</p>\r\n");
#nullable restore
#line 29 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
} catch(Exception ex) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Oh no! An error occurred: ");
#nullable restore
#line 30 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
                             Write(ex.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 31 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
}


#line default
#line hidden
#nullable disable
            WriteLiteral("<p>i is now ");
#nullable restore
#line 34 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 36 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
 lock(new object()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>This block is locked, for your security!</p>\r\n");
#nullable restore
#line 38 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/NoLinePragmas.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
