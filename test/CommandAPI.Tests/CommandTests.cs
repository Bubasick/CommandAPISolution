using CommandAPI.Models;
using System;
using Xunit;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        private Command testCommand;

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some Platform",
                CommandLine = "Some Command Line"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Act
            testCommand.HowTo = "Execute unit tests";

            //Assert
            Assert.Equal("Execute unit tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            //Act
            testCommand.Platform = "XUnit";

            //Assert
            Assert.Equal("XUnit", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //Act
            testCommand.CommandLine = "dotnet test";

            //Assert
            Assert.Equal("dotnet test", testCommand.CommandLine);
        }
    }
}