﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UserStories.AcceptanceTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("EditCustomer", SourceFile="Features\\EditCustomer.feature", SourceLine=0)]
    public partial class EditCustomerFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "EditCustomer.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "EditCustomer", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("The user edits an existing customer", SourceLine=2)]
        public virtual void TheUserEditsAnExistingCustomer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user edits an existing customer", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("The user enters to the home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("The user logs with a valid user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
 testRunner.When("The user goes to the select edit customer page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.And("The user inserts a valid customer id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.And("The user clicks the select edit customer submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
    testRunner.And("The user edit a customer with parameters \'Plaza Catalunya\', \'Barcelona\', \'Barcelo" +
                    "na\', \'123456\', \'666123444\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
    testRunner.And("The user clicks the submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("The customer with parameters \'Juan\', \'15121990\', \'Male\', \'Plaza Catalunya\', \'Barc" +
                    "elona\', \'Barcelona\', \'123456\', \'666123444\' has been edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void TheUserTriesToEditACustomerWithEmptyParameters(string address, string city, string state, string pin, string mobile, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user tries to edit a customer with empty parameters", exampleTags);
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("The user enters to the home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.And("The user logs with a valid user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.When("The user goes to the select edit customer page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.And("The user inserts a valid customer id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("The user clicks the select edit customer submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
    testRunner.And(string.Format("The user edit a customer with parameters \'{0}\', \'{1}\', \'{2}\', \'{3}\', \'{4}\'", address, city, state, pin, mobile), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
    testRunner.And("The user clicks the submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
    testRunner.Then("The customer cannot be edited", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("The user tries to edit a customer with empty parameters, Variant 0", SourceLine=24)]
        public virtual void TheUserTriesToEditACustomerWithEmptyParameters_Variant0()
        {
            this.TheUserTriesToEditACustomerWithEmptyParameters("empty", "Barcelona", "Barcelona", "123456", "666123444", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("The user tries to edit a customer with empty parameters, Variant 1", SourceLine=24)]
        public virtual void TheUserTriesToEditACustomerWithEmptyParameters_Variant1()
        {
            this.TheUserTriesToEditACustomerWithEmptyParameters("Plaza Catalunya", "empty", "Barcelona", "123456", "666123444", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("The user tries to edit a customer with empty parameters, Variant 2", SourceLine=24)]
        public virtual void TheUserTriesToEditACustomerWithEmptyParameters_Variant2()
        {
            this.TheUserTriesToEditACustomerWithEmptyParameters("Plaza Catalunya", "Barcelona", "empty", "123456", "666123444", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("The user tries to edit a customer with empty parameters, Variant 3", SourceLine=24)]
        public virtual void TheUserTriesToEditACustomerWithEmptyParameters_Variant3()
        {
            this.TheUserTriesToEditACustomerWithEmptyParameters("Plaza Catalunya", "Barcelona", "Barcelona", "empty", "666123444", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("The user tries to edit a customer with empty parameters, Variant 4", SourceLine=24)]
        public virtual void TheUserTriesToEditACustomerWithEmptyParameters_Variant4()
        {
            this.TheUserTriesToEditACustomerWithEmptyParameters("Plaza Catalunya", "Barcelona", "Barcelona", "123456", "empty", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
