﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.17929
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowTtrial.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Login to FINS")]
    public partial class LoginToFINSFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Login.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Login to FINS", "In order to get to my FINS profile\r\nAs a user\r\nI want to be able to log in at FIN" +
                    "S from all possible places", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login in the header at home page")]
        public virtual void LoginInTheHeaderAtHomePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login in the header at home page", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.And("The board is \'none\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("in the header I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
  testRunner.And("in the popup login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
  testRunner.And("in the popup login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
  testRunner.And("in the popup login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login in Get Started Now section at home page")]
        public virtual void LoginInGetStartedNowSectionAtHomePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login in Get Started Now section at home page", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
  testRunner.And("The board is \'none\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.When("I click button \'Get Started Now\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
  testRunner.And("in the login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
  testRunner.And("in the login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
  testRunner.And("in the login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login in the header at Finance board")]
        public virtual void LoginInTheHeaderAtFinanceBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login in the header at Finance board", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
  testRunner.And("The board is \'Finance\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.When("in the header I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
  testRunner.And("in the popup login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
  testRunner.And("in the popup login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
  testRunner.And("in the popup login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login by My Dashboard menu at Finance board")]
        public virtual void LoginByMyDashboardMenuAtFinanceBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login by My Dashboard menu at Finance board", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
  testRunner.And("The board is \'Finance\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.When("in the menu I click item \'My Dashboard\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
  testRunner.And("in the login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
  testRunner.And("in the login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
  testRunner.And("in the login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login in the header at Technology board")]
        public virtual void LoginInTheHeaderAtTechnologyBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login in the header at Technology board", ((string[])(null)));
#line 45
this.ScenarioSetup(scenarioInfo);
#line 46
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
  testRunner.And("The board is \'Technology\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.When("in the header I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
  testRunner.And("in the popup login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
  testRunner.And("in the popup login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
  testRunner.And("in the popup login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login by My Dashboard menu at Technology board")]
        public virtual void LoginByMyDashboardMenuAtTechnologyBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login by My Dashboard menu at Technology board", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line 55
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 56
  testRunner.And("The board is \'Technology\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.When("in the menu I click item \'My Dashboard\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
  testRunner.And("in the login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
  testRunner.And("in the login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
  testRunner.And("in the login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login in the header at Sales board")]
        public virtual void LoginInTheHeaderAtSalesBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login in the header at Sales board", ((string[])(null)));
#line 64
this.ScenarioSetup(scenarioInfo);
#line 65
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 66
  testRunner.And("The board is \'Sales\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.When("in the header I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
  testRunner.And("in the popup login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
  testRunner.And("in the popup login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
  testRunner.And("in the popup login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login by My Dashboard menu at Sales board")]
        public virtual void LoginByMyDashboardMenuAtSalesBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login by My Dashboard menu at Sales board", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line 74
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
  testRunner.And("The board is \'Sales\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.When("in the menu I click item \'My Dashboard\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
  testRunner.And("in the login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
  testRunner.And("in the login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
  testRunner.And("in the login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login in the header at Student board")]
        public virtual void LoginInTheHeaderAtStudentBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login in the header at Student board", ((string[])(null)));
#line 83
this.ScenarioSetup(scenarioInfo);
#line 84
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 85
  testRunner.And("The board is \'Student\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.When("in the header I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
  testRunner.And("in the popup login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
  testRunner.And("in the popup login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
  testRunner.And("in the popup login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login by My Dashboard menu at Student board")]
        public virtual void LoginByMyDashboardMenuAtStudentBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login by My Dashboard menu at Student board", ((string[])(null)));
#line 92
this.ScenarioSetup(scenarioInfo);
#line 93
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 94
  testRunner.And("The board is \'Student\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.When("in the menu I click item \'My Dashboard\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
  testRunner.And("in the login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
  testRunner.And("in the login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
  testRunner.And("in the login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login in the header at Europe board")]
        public virtual void LoginInTheHeaderAtEuropeBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login in the header at Europe board", ((string[])(null)));
#line 102
this.ScenarioSetup(scenarioInfo);
#line 103
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
  testRunner.And("The board is Europe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.When("in the header I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
  testRunner.And("in the popup login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
  testRunner.And("in the popup login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
  testRunner.And("in the popup login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login by My Dashboard menu at Europe board")]
        public virtual void LoginByMyDashboardMenuAtEuropeBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login by My Dashboard menu at Europe board", ((string[])(null)));
#line 111
this.ScenarioSetup(scenarioInfo);
#line 112
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 113
  testRunner.And("The board is \'Europe\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.When("in the menu I click item \'My Dashboard\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 115
  testRunner.And("in the login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
  testRunner.And("in the login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
  testRunner.And("in the login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login in the header at Asia board")]
        public virtual void LoginInTheHeaderAtAsiaBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login in the header at Asia board", ((string[])(null)));
#line 121
this.ScenarioSetup(scenarioInfo);
#line 122
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 123
  testRunner.And("The board is Asia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.When("in the header I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 125
  testRunner.And("in the popup login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
  testRunner.And("in the popup login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
  testRunner.And("in the popup login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("login by My Dashboard menu at Asia board")]
        public virtual void LoginByMyDashboardMenuAtAsiaBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("login by My Dashboard menu at Asia board", ((string[])(null)));
#line 130
this.ScenarioSetup(scenarioInfo);
#line 131
 testRunner.Given("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 132
  testRunner.And("The board is \'Asia\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.When("in the menu I click item \'My Dashboard\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
  testRunner.And("in the login form I enter login \'paa@intetics.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
  testRunner.And("in the login form I enter password \'Newbuild14\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
  testRunner.And("in the login form I click button \'Login\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.Then("Login Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
