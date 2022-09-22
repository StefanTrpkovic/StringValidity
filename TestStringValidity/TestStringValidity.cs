using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringValidityNamespace;
using System;
using System.IO;

namespace TestStringValidity
{
	[TestClass]
	public class TestStringCorectness
	{
		[TestMethod]
		public void ShouldReturnCorrectStringWhenAllCharsAreEqual()
		{
			//Arrange
			ConsoleReaderWriter consoleReaderWriter = new ConsoleReaderWriter("xyz");

			//Act
			StringValidity.Main();

			//Assert
			Assert.AreEqual("Correct String", consoleReaderWriter.StringWriter.ToString());
		}

		[TestMethod]
		public void ShouldReturnCorrectStringWhenAllCharsAreEqualTwo()
		{
			//Arrange
			ConsoleReaderWriter consoleReaderWriter = new ConsoleReaderWriter("xyyzxz");

			//Act
			StringValidity.Main();

			//Assert
			Assert.AreEqual("Correct String", consoleReaderWriter.StringWriter.ToString());
		}

		[TestMethod]
		public void ShouldReturnCorrectStringWhenRemovedOneElement()
		{
			//Arrange
			ConsoleReaderWriter consoleReaderWriter = new ConsoleReaderWriter("zxzyyxz");

			//Act
			StringValidity.Main();

			//Assert
			Assert.AreEqual("Correct String", consoleReaderWriter.StringWriter.ToString());
		}

		[TestMethod]
		public void ShouldReturnNotCorrectStringWhenHavingMoreThanOneIncorrectChar()
		{
			//Arrange
			ConsoleReaderWriter consoleReaderWriter = new ConsoleReaderWriter("yzyzxjox");

			//Act
			StringValidity.Main();

			//Assert
			Assert.AreEqual("Not Correct String", consoleReaderWriter.StringWriter.ToString());
		}
	}

	public class ConsoleReaderWriter
	{
		public StringReader StringReader { get; set; }
		public StringWriter StringWriter { get; set; }

		public ConsoleReaderWriter(string consoleInput)
		{
			StringReader = new StringReader(consoleInput);
			StringWriter = new StringWriter();
			Console.SetIn(StringReader);
			Console.SetOut(StringWriter);
		}
	}
}
