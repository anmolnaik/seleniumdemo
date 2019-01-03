﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SeleniumDemoApplication.Src.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DemoPageNegative")]
    [NUnit.Framework.CategoryAttribute("chrome_setup_before_feature")]
    [NUnit.Framework.CategoryAttribute("close_current_browser")]
    public partial class DemoPageNegativeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DemoPageNegative.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DemoPageNegative", null, ProgrammingLanguage.CSharp, new string[] {
                        "chrome_setup_before_feature",
                        "close_current_browser"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01_Amazon Login")]
        public virtual void _01_AmazonLogin()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01_Amazon Login", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given("Go To Login Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Then("Set incorrect username anmol.naik15@gmail.com and password  Anmol@000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 7
 testRunner.When("I press login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.Then("Validate incorrect password error message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02_Amazon Login")]
        public virtual void _02_AmazonLogin()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02_Amazon Login", null, ((string[])(null)));
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
 testRunner.Given("Go To Login Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
 testRunner.Then("Enter incorrect emailid anmol.naik90@gmail.com", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.Then("Validate incorrect email error message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03_Amazon Login")]
        public virtual void _03_AmazonLogin()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03_Amazon Login", null, ((string[])(null)));
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 16
 testRunner.Given("Go To Login Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When("Enter blank Email id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Table Structure")]
        public virtual void TableStructure()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Table Structure", null, ((string[])(null)));
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table1.AddRow(new string[] {
                        "Anmol",
                        "26"});
#line 20
 testRunner.When("Sameple data of table", ((string)(null)), table1, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Json Data Read and write")]
        public virtual void JsonDataReadAndWrite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Json Data Read and write", null, ((string[])(null)));
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 25
 testRunner.Given("Read data from jsonfile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.Then("write data to json file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.Then("A customer updates color of product from Black to Red", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
