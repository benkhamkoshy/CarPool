using CarPool.Business;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CarPool.Specs
{
    [Binding]
    public class RegisterOwnerSteps
    {
        private Registration registration = new Registration();
        private string response { get; set; }

        [Given(@"I am on the registration page")]
        public void GivenIAmOnTheRegistrationPage()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I entered name ""(.*)"" employee id ""(.*)"" email ""(.*)"" and phone ""(.*)""")]
        public void GivenIEnteredNameEmployeeIdEmailAndPhone(string name, string employeeId, string email, string phone)
        {
            registration.Name = name;
            registration.EmployeeId = employeeId;
            registration.Email = email;
            registration.Phone = phone;
        }
        
        [When(@"click on Register")]
        public void WhenClickOnRegister()
        {
            response = registration.Register();
        }
        
        [Then(@"send confirmation email ""(.*)""")]
        public void ThenSendConfirmationEmail(string expectedResult)
        {
            Assert.AreEqual(expectedResult, response);
        }
        
        [Then(@"display message ""(.*)"" for invalid input")]
        public void ThenDisplayMessageForInvalidInput(string message)
        {
            Assert.AreEqual(message, response);
        }
    }
}
