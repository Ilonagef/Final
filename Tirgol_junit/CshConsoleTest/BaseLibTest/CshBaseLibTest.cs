using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using CshConsoleAPI;





namespace CshConsoleTest
{
	[TestClass]
	public class CshBaseLibTest
	{
		const string HELLO_WORLD_TRIMED = "Hello World";

		[TestMethod]
		//	Right left string trimming test.
		public void TestTrim()
		{
			string trimmed = CStrTrim.trim(" \t\n  Hello World  ");
			Assert.IsTrue(trimmed == HELLO_WORLD_TRIMED);
		}
	}
}
