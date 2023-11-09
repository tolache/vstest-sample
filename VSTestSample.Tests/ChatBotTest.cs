using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VSTestSample.Tests
{
    [TestClass]
    public class ChatBotTest
    {
        public TestContext? TestContext { get; set; }

        [TestMethod]
        public void GreetShouldContainName()
        {
            // Arrange
            string name = "World";
            string expected = "Hello, World!";
        
            // Act
            string actual = ChatBot.Greet(name);
        
            // Assert
            Assert.AreEqual(expected, actual, "Greeting doesn't contain name");
            
            // Add attachment
            const string attachmentFilename = "MyTestResult.txt";
            File.WriteAllText(attachmentFilename, $"The result of the operation is '{actual}'");
            TestContext?.AddResultFile(attachmentFilename);
        }
        
        [TestCategory("Questions")]
        [TestMethod]
        public void AskQuestionShouldEndWithQuestionMArk()
        {
            // Arrange
            string name = "World";
        
            // Act
            string question = ChatBot.AskQuestion(name);
            bool actual = question.EndsWith("?");
        
            // Assert
            Assert.IsTrue(actual, "Question doesn't with a question mark");
            
            // Add attachment
            const string attachmentFilename = "MyTestResult.txt";
            File.WriteAllText(attachmentFilename, $"The actual question is '{question}'");
            TestContext?.AddResultFile(attachmentFilename);
        }
    }
}