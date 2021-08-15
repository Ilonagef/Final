using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using CshConsoleAPI;



namespace CshConsoleTest
{
	[TestClass]
	public class CommandsTest
	{
		public const string CMD_ECHO_PARAM= "hello echo";
		public const string CMD_LINE_ECHO= "echo(hello world)";
		public const string CMD_LINE_ADD = "Add(3,4,5)";
		public const string CMD_LINE_SUB = "Sub(9,2,1)";
		public const string CMD_LINE_MULT= "Mult(2,2,1)";
		public const string CMD_LINE_DIV = "Div(4,2,1)"; 

		private static bool CommandEcho(string[] parameters)
		{
			return (true);
		}

		[TestMethod]
		public void TestMethod1()
		{
		}

		[TestMethod]
		public void TestParser()
		{
			//	Check command name parsing.
			Assert.IsTrue(Commands.CMD_ECHO == CommandsApi.CommandName(CMD_LINE_ECHO));

			// Check command parameters parsing.
			string[] parameters = CommandsApi.CommandParams(CMD_LINE_ECHO);
			Assert.IsTrue(1 == parameters.Length);
			return;
		}

		//	Test the echo command function.
		[TestMethod]
		public void	TestEcho()
		{
			string[] parameters = CommandsApi.CommandParams(CMD_LINE_ECHO);
			Assert.IsTrue(AppCommands.CommandEcho(parameters));
			return;
		}

		//	Test the commands list using the echo command function.
		[TestMethod]
		public void TestCommandEcho()
		{
			//	Check creating a new commands list.
			Commands pCommands = CommandsApi.CommandsInit();
			Assert.IsNotNull(pCommands);

			//	Check adding echo command to commands list.
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_ECHO, CommandEcho));

			//	Execute the echo command in the command list.
			Assert.IsTrue(CommandsApi.CommandExec(ref pCommands, CMD_LINE_ECHO));
			return;
		}

		[TestMethod]
		public void TestCommandAdd()
		{
			/*check Creating a new commands list*/
			Commands pCommands = CommandsApi.CommandsInit();

			//Check adding add command to commands list.
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_ADD, AppCommands.CommandAdd));
			return;

		}

		//Test the commands list using the sub command function.
		[TestMethod]
		public void TestCommandSUB()
		{
			//	Check creating a new commands list.
			Commands pCommands = CommandsApi.CommandsInit();
			Assert.IsNotNull(pCommands);

			//	Check adding add command to commands list.
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_SUB, AppCommands.commandSub));

			//	Execute the add command in the command list.
			Assert.IsTrue(CommandsApi.CommandExec(ref pCommands, CMD_LINE_SUB));
			return;
		}

		//Test the commands list using the mult command function.
		[TestMethod]
		public void TestCommandMULT()
		{
			//	Check creating a new commands list.
			Commands pCommands = CommandsApi.CommandsInit();
			Assert.IsNotNull(pCommands);

			//	Check adding add command to commands list.
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_MULT, AppCommands.CommandMult));

			//	Execute the add command in the command list.
			Assert.IsTrue(CommandsApi.CommandExec(ref pCommands, CMD_LINE_MULT));
			return;
		}

		//Test the commands list using the div command function.
		[TestMethod]
		public void TestCommandDIV()
		{
			//	Check creating a new commands list.
			Commands pCommands = CommandsApi.CommandsInit();
			Assert.IsNotNull(pCommands);

			//	Check adding add command to commands list.
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_DIV, AppCommands.CommandDiv));

			//	Execute the add command in the command list.
			Assert.IsTrue(CommandsApi.CommandExec(ref pCommands, CMD_LINE_DIV));
			return;
		}


	};
}
