using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CshConsoleAPI
{
	class Program
	{
      private const int ERROR_SUCCESS = 0;


      static int Main(string[] args)
		{
         // Indicates whther to continue reading input.
         bool running = true;

         // Initialize the commands object.
         Commands pCommands = CommandsApi.CommandsInit();

         // Assign the echo command function to the command list.
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_ECHO, AppCommands.CommandEcho);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_EXIT, AppCommands.CommandExit);
         // Assign the Add command function to the command list.
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_ADD, AppCommands.CommandAdd);
         // Assign the Sub command function to the command list.
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_SUB, AppCommands.commandSub);
         // Assign the Mult command function to the command list.
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_MULT, AppCommands.CommandMult);
         // Assign the Div command function to the command list.
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_DIV, AppCommands.CommandDiv);

         CommandsApi.CommandAdd(ref pCommands, AppCommands.GUI_CLOSE, AppCommands.CommandClose);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.GUI_SHOW, AppCommands.CommandGuiShow);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_32BIT, AppCommands.Command32Bits);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_radioExecAndCode, AppCommands.CommandExecAndCode);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_radioCode, AppCommands.CommandRadioCode);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_radioExec, AppCommands.CommandRadioExec);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_ZIPFILE, AppCommands.CommandZipFile);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_INPUT, AppCommands.CommandInput);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_OUTPUT, AppCommands.CommandOutput);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_COMPILE, AppCommands.CommandCompail);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_RUN, AppCommands.CommandRun);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_RES, AppCommands.CommandResults);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_ResultsFile, AppCommands.CommandResultsFile);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_OpenFolder, AppCommands.CommandOpenFolder);
            string command_line;

         // Continues loop.
         while (running)
         {
            // Print command promped '>'
            Console.Write(AppCommands.CMD_PROMPED);

            // Get console command text"
            command_line = Console.ReadLine();

            // Call for command execution.
            running = CommandsApi.CommandExec(ref pCommands, command_line);
         }

         Environment.ExitCode = ERROR_SUCCESS;
         return ERROR_SUCCESS;
      }
	}
}
