using Help;
using NUnit.Framework;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace SpecFlowProject_unittest.StepDefinitions
{
    [Binding]
    public class InputValidationStepDefinitions
    {
        private string input;
        private InputValidator validator;
        private bool validationResult;



        [Given(@"I have an input string ""([^""]*)""")]
        public void GivenIHaveAnInputString(string p0)
        {
            input = p0;
            validator = new InputValidator();
        }


     
        [When(@"I validate the (.*) and (.*)")]
        public void WhenIValidateTheAsA(string p0, string p1)
        {
            switch (stringonly(p1.ToLower()))
            {
                case "number":
                    validationResult = validator.IsNumber(input.ToLower());
                    break;
                case "email":
                    validationResult = validator.IsEmail(input.ToLower());
                    break;
                // Add more cases for other string types
                default:
                    Assert.Fail($"Unknown validation type: {p1}");
                    break;
            }
        }


        [Then(@"the ""([^""]*)"" and ""([^""]*)"" should be ""([^""]*)""")]
        public void ThenTheAndTypeShouldBe(string p0, string p1, string p2)
        {
            if (p2.ToLower() == "valid")
            {
                Assert.True(validationResult);
            }
            else
            {
                Assert.False(validationResult);
            }
            Console.WriteLine(validationResult);
        }
   

        public string stringonly(string text)
        {
            return Regex.Replace(text, "[^0-9A-Za-z _-]", "");
        }
    }
}
