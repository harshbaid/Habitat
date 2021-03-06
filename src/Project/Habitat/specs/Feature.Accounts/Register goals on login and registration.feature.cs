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
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "UI")]
    public partial class RegisterGoalsOnLoginAndRegistrationFeature : Xunit.IClassFixture<RegisterGoalsOnLoginAndRegistrationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Register goals on login and registration.feature"
#line hidden
        
        public RegisterGoalsOnLoginAndRegistrationFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Register goals on login and registration", null, ProgrammingLanguage.CSharp, new string[] {
                        "UI"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(RegisterGoalsOnLoginAndRegistrationFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Register goals on login and registration_UC1_Register new user")]
        [Xunit.TraitAttribute("FeatureTitle", "Register goals on login and registration")]
        [Xunit.TraitAttribute("Description", "Account_Register goals on login and registration_UC1_Register new user")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_RegisterGoalsOnLoginAndRegistration_UC1_RegisterNewUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Register goals on login and registration_UC1_Register new user", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table1.AddRow(new string[] {
                        "kov1@sitecore.net",
                        "k",
                        "k"});
#line 8
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table1, "When ");
#line 11
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Goal"});
            table2.AddRow(new string[] {
                        "Register"});
            table2.AddRow(new string[] {
                        "Login"});
#line 13
 testRunner.Then("Profile Activity Goals section for kov@sitecore.net contains", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Register goals on login and registration_UC2_Login with new user")]
        [Xunit.TraitAttribute("FeatureTitle", "Register goals on login and registration")]
        [Xunit.TraitAttribute("Description", "Account_Register goals on login and registration_UC2_Login with new user")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_RegisterGoalsOnLoginAndRegistration_UC2_LoginWithNewUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Register goals on login and registration_UC2_Login with new user", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table3.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 20
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table3, "Given ");
#line 23
 testRunner.And("Actor selects User icon on Navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table4.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k"});
#line 24
 testRunner.When("Actor enteres following data into Login form fields", ((string)(null)), table4, "When ");
#line 27
 testRunner.And("Actor clicks Login button on User form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Goal"});
            table5.AddRow(new string[] {
                        "Register"});
            table5.AddRow(new string[] {
                        "Login"});
            table5.AddRow(new string[] {
                        "Login"});
#line 29
 testRunner.Then("Profile Activity Goals section for kov10@sitecore.net contains", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Register goals on login and registration_UC3_Login twice with new user")]
        [Xunit.TraitAttribute("FeatureTitle", "Register goals on login and registration")]
        [Xunit.TraitAttribute("Description", "Account_Register goals on login and registration_UC3_Login twice with new user")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_RegisterGoalsOnLoginAndRegistration_UC3_LoginTwiceWithNewUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Register goals on login and registration_UC3_Login twice with new user", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table6.AddRow(new string[] {
                        "kov11@sitecore.net",
                        "k",
                        "k"});
#line 38
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table6, "Given ");
#line 41
 testRunner.When("Actor selects User icon on Navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table7.AddRow(new string[] {
                        "kov11@sitecore.net",
                        "k"});
#line 42
 testRunner.And("Actor enteres following data into Login form fields", ((string)(null)), table7, "And ");
#line 45
 testRunner.And("Actor clicks Login button on User form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("Actor selects User icon on Navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("Actor clicks Logout button on User form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("Actor selects User icon on Navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table8.AddRow(new string[] {
                        "kov11@sitecore.net",
                        "k"});
#line 49
 testRunner.And("Actor enteres following data into Login form fields", ((string)(null)), table8, "And ");
#line 52
 testRunner.And("Actor clicks Login button on User form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Goal"});
            table9.AddRow(new string[] {
                        "Register"});
            table9.AddRow(new string[] {
                        "Login"});
            table9.AddRow(new string[] {
                        "Login"});
            table9.AddRow(new string[] {
                        "Login"});
#line 54
 testRunner.Then("Profile Activity Goals section for kov10@sitecore.net contains", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RegisterGoalsOnLoginAndRegistrationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RegisterGoalsOnLoginAndRegistrationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
