﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 14.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，则所做更改将丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Ranta.Gaea.Template
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class CSharpTestProjectTemplate : CSharpTestProjectTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 6 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"

    if(this.Project != null)
    {

            
            #line default
            #line hidden
            this.Write(@"<?xml version=""1.0"" encoding=""utf-8""?>
<Project ToolsVersion=""14.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <PropertyGroup>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProjectGuid>");
            
            #line 15 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.Guid.ToString("B").ToUpper()));
            
            #line default
            #line hidden
            this.Write("</ProjectGuid>\r\n    <OutputType>Library</OutputType>\r\n    <AppDesignerFolder>Prop" +
                    "erties</AppDesignerFolder>\r\n    <RootNamespace>");
            
            #line 18 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.Name));
            
            #line default
            #line hidden
            this.Write("</RootNamespace>\r\n    <AssemblyName>");
            
            #line 19 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.Name));
            
            #line default
            #line hidden
            this.Write("</AssemblyName>\r\n    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>\r\n    <" +
                    "FileAlignment>512</FileAlignment>\r\n    <ProjectTypeGuids>{3AC096D0-A1C2-E12C-139" +
                    "0-A8335801FDAB};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>\r\n    <" +
                    "VisualStudioVersion Condition=\"\'$(VisualStudioVersion)\' == \'\'\">10.0</VisualStudi" +
                    "oVersion>\r\n    <VSToolsPath Condition=\"\'$(VSToolsPath)\' == \'\'\">$(MSBuildExtensio" +
                    "nsPath32)\\Microsoft\\VisualStudio\\v$(VisualStudioVersion)</VSToolsPath>\r\n    <Ref" +
                    "erencePath>$(ProgramFiles)\\Common Files\\microsoft shared\\VSTT\\$(VisualStudioVers" +
                    "ion)\\UITestExtensionPackages</ReferencePath>\r\n    <IsCodedUITest>False</IsCodedU" +
                    "ITest>\r\n    <TestProjectType>UnitTest</TestProjectType>\r\n  </PropertyGroup>\r\n  <" +
                    "PropertyGroup Condition=\" \'$(Configuration)|$(Platform)\' == \'Debug|AnyCPU\' \">\r\n " +
                    "   <DebugSymbols>true</DebugSymbols>\r\n    <DebugType>full</DebugType>\r\n    <Opti" +
                    "mize>false</Optimize>\r\n    <OutputPath>bin\\Debug\\</OutputPath>\r\n    <DefineConst" +
                    "ants>DEBUG;TRACE</DefineConstants>\r\n    <ErrorReport>prompt</ErrorReport>\r\n    <" +
                    "WarningLevel>4</WarningLevel>\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\" " +
                    "\'$(Configuration)|$(Platform)\' == \'Release|AnyCPU\' \">\r\n    <DebugType>pdbonly</D" +
                    "ebugType>\r\n    <Optimize>true</Optimize>\r\n    <OutputPath>bin\\Release\\</OutputPa" +
                    "th>\r\n    <DefineConstants>TRACE</DefineConstants>\r\n    <ErrorReport>prompt</Erro" +
                    "rReport>\r\n    <WarningLevel>4</WarningLevel>\r\n  </PropertyGroup>\r\n  <ItemGroup>\r" +
                    "\n    <Reference Include=\"System\" />\r\n  </ItemGroup>\r\n  <Choose>\r\n    <When Condi" +
                    "tion=\"(\'$(VisualStudioVersion)\' == \'10.0\' or \'$(VisualStudioVersion)\' == \'\') and" +
                    " \'$(TargetFrameworkVersion)\' == \'v3.5\'\">\r\n      <ItemGroup>\r\n        <Reference " +
                    "Include=\"Microsoft.VisualStudio.QualityTools.UnitTestFramework, Version=10.1.0.0" +
                    ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL\" " +
                    "/>\r\n      </ItemGroup>\r\n    </When>\r\n    <Otherwise>\r\n      <ItemGroup>\r\n       " +
                    " <Reference Include=\"Microsoft.VisualStudio.QualityTools.UnitTestFramework\" />\r\n" +
                    "      </ItemGroup>\r\n    </Otherwise>\r\n  </Choose>\r\n  <ItemGroup>\r\n    <Compile I" +
                    "nclude=\"Properties\\AssemblyInfo.cs\" />\r\n  </ItemGroup>\r\n");
            
            #line 64 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"

    if(this.ProjectToTest != null && this.ProjectToTest.Length > 0)
    {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 69 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"

        foreach(var project in this.ProjectToTest)
        {

            
            #line default
            #line hidden
            this.Write("    <ProjectReference Include=\"..\\");
            
            #line 73 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.FullName));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 73 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.FullName));
            
            #line default
            #line hidden
            this.Write(".csproj\">\r\n      <Project>");
            
            #line 74 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Guid.ToString("B").ToUpper()));
            
            #line default
            #line hidden
            this.Write("</Project>\r\n      <Name>");
            
            #line 75 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.FullName));
            
            #line default
            #line hidden
            this.Write("</Name>\r\n    </ProjectReference>\r\n");
            
            #line 77 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 81 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("  <Choose>\r\n    <When Condition=\"\'$(VisualStudioVersion)\' == \'10.0\' And \'$(IsCode" +
                    "dUITest)\' == \'True\'\">\r\n      <ItemGroup>\r\n        <Reference Include=\"Microsoft." +
                    "VisualStudio.QualityTools.CodedUITestFramework, Version=10.0.0.0, Culture=neutra" +
                    "l, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL\">\r\n          <Pri" +
                    "vate>False</Private>\r\n        </Reference>\r\n        <Reference Include=\"Microsof" +
                    "t.VisualStudio.TestTools.UITest.Common, Version=10.0.0.0, Culture=neutral, Publi" +
                    "cKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL\">\r\n          <Private>Fal" +
                    "se</Private>\r\n        </Reference>\r\n        <Reference Include=\"Microsoft.Visual" +
                    "Studio.TestTools.UITest.Extension, Version=10.0.0.0, Culture=neutral, PublicKeyT" +
                    "oken=b03f5f7f11d50a3a, processorArchitecture=MSIL\">\r\n          <Private>False</P" +
                    "rivate>\r\n        </Reference>\r\n        <Reference Include=\"Microsoft.VisualStudi" +
                    "o.TestTools.UITesting, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                    "f11d50a3a, processorArchitecture=MSIL\">\r\n          <Private>False</Private>\r\n   " +
                    "     </Reference>\r\n      </ItemGroup>\r\n    </When>\r\n  </Choose>\r\n  <Import Proje" +
                    "ct=\"$(VSToolsPath)\\TeamTest\\Microsoft.TestTools.targets\" Condition=\"Exists(\'$(VS" +
                    "ToolsPath)\\TeamTest\\Microsoft.TestTools.targets\')\" />\r\n  <Import Project=\"$(MSBu" +
                    "ildToolsPath)\\Microsoft.CSharp.targets\" />\r\n  <!-- To modify your build process," +
                    " add your task inside one of the targets below and uncomment it. \r\n       Other " +
                    "similar extension points exist, see Microsoft.Common.targets.\r\n  <Target Name=\"B" +
                    "eforeBuild\">\r\n  </Target>\r\n  <Target Name=\"AfterBuild\">\r\n  </Target>\r\n  -->\r\n</P" +
                    "roject>\r\n");
            
            #line 112 "D:\SavoryWorkspace\Migration\MainLine\Gaea\Ranta.Gaea\Template\CSharpTestProjectTemplate.tt"

    }

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class CSharpTestProjectTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
