using HETS1Design;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Forms;

namespace CshConsoleAPI
{
	public class AppCommands
	{
		public const string CMD_PROMPED = ">";
		public const string CMD_ECHO = "echo";
		public const string CMD_ADD = "Add";
		public const string CMD_SUB = "Sub";
		public const string CMD_MULT = "Mult";
		public static string CMD_DIV = "Div";
		public const string CMD_EXIT = "exit";

		public const string GUI_SHOW = "gui";
		public const string CMD_ZIPFILE = "zip";
		public const string CMD_OpenFolder = "folder";
		public const string CMD_INPUT = "input";
		public const string CMD_OUTPUT = "output";
		public const string CMD_COMPILE = "compile";
		public const string CMD_RUN = "run";
		public const string CMD_RES = "results";
		public const string CMD_ResultsFile = "fileResults";
		public const string CMD_32BIT = "bit32";
		public const string CMD_radioCode = "onlyCode";//if we checkes only code files.
		public const string CMD_radioExec = "onlyExec";//if we checked only exec files.
		public const string CMD_radioExecAndCode = "ExecAndCode";
		public const string GUI_CLOSE = "close";
		

		private static HETS1Design.MainScreen gui = new HETS1Design.MainScreen();
		//public static MainScreen mainScreen = new MainScreen();


		public static bool CommandGuiShow(string[] parameters)
		{
			Task.Run(() => { gui.ShowDialog(); });
			Console.WriteLine("succeeded");
			return true;
		}

		/*open/extract ZipFile
		 D:\שנה ג\סמסטר ב\אימות ובדיקת תוכנה\project2_1\Project Code\HETS - Azo\Assets\New Test_ilonaAbdala/ZipForTest.zip
		 */
		public static bool CommandZipFile(String[] zipPath)
        {
		
			gui.CmdOpenArch();
			Console.WriteLine("succeeded");
			return true;

		}

		public static bool CommandInput(String[] inputpath)
        {
			OpenFileDialog ofdInput = new OpenFileDialog();
			ofdInput.FileName = @"D:\שנה ג\סמסטר ב\אימות ובדיקת תוכנה\project2_1\Project Code\HETS - Azo\Assets\New Test_ilonaAbdala\TestFile_Correct_ilona\InputTestCasesGoodExample.txt";
			
			gui.CmdOpenInput(ofdInput);
			Console.WriteLine("succeeded");


			return true;
        }

		public static bool CommandOutput(String[] outPutpath)
        {
			OpenFileDialog ofdOutput = new OpenFileDialog();
			ofdOutput.FileName = @"D:\שנה ג\סמסטר ב\אימות ובדיקת תוכנה\project2_1\Project Code\HETS - Azo\Assets\New Test_ilonaAbdala\TestFile_Correct_ilona\OutputTestCasesGoodExample.txt";

			gui.CmdOpenOutput(ofdOutput);
			Console.WriteLine("succeeded");
			return true;
        }

		public static bool CommandCompail(String[] comp)
        {
			gui.CmdCompile();
			Console.WriteLine("succeeded");
			return true;
        }

		public static bool CommandRun(String[] run)
        {
			gui.CmdRun();
			Console.WriteLine("succeeded");
			return true;
        }

		public static bool CommandResults(String[] res)
        {

			gui.CmdResults();
			Console.WriteLine("succeeded");
			return true;
        }

		public static bool CommandResultsFile(String[] resFile)
        {
			gui.CmdResultsFile();
			Console.WriteLine("succeeded");
			return true;
        }

		public static bool CommandOpenFolder(String[] openFolder)
        {
			gui.CmdOpenFolder();
			Console.WriteLine("succeeded");
			return true;
			
		}

		public static bool Command32Bits(String[] param)
        {
			gui.Cmd32Bits();
			Console.WriteLine("succeeded");

			return true;
        }

		public static bool CommandExecAndCode(String[] param)
        {
			gui.CmdRadioBoth();
			Console.WriteLine("succeeded");
			return true;
        }

		public static bool CommandRadioCode(String[] param)
        {
			gui.CmdRadioCode();
			Console.WriteLine("checked only c code files");
			return true;
        }

		public static bool CommandRadioExec(String[] param)
        {
			gui.CmdRadioExec();
			Console.WriteLine("checked only Exec files.You can only run()");
			return true;
        }

		public static bool CommandClose(String[] param)
        {
			gui.CmdClose();
			Console.WriteLine("gui closed");
			return true;
        }

		/***
		* Echo demonstrates a command execution function.
		* the command prints the parameters it receives.
		*/
		public static bool CommandEcho(string[] parameters)
		{
			foreach (string param in parameters)
			{
				Console.WriteLine(param);
			}
			return (true);
		}

		/*ADD demonstrates a command execution functuon.
		 *the command prints rhe sum ofdInput numbers.
		 */
		public static bool CommandAdd(string[] parameters)
        {
			int sum = 0;

			for(int i =0; i <parameters.Length; i++)
            {
				sum += int.Parse(parameters[i]);
			}
			Console.WriteLine(sum);

			return (true);

		}

		/*ADD demonstrates a command execution functuon.
		 *the command prints the sub ofdInput numbers in list.
		 */
		public static bool commandSub(string[] parameters)
        {
			int sub = int.Parse(parameters[0]);

			for(int i=1; i<parameters.Length;i++)
            {
				sub -= int.Parse(parameters[i]);
            }
			Console.WriteLine(sub);
			return (true);
        }

		//
		public static bool CommandMult(string[] parameters)
        {
			int mult = int.Parse(parameters[0]);

			for(int i=1; i<parameters.Length; i++)
            {
				mult *= int.Parse(parameters[i]);
            }
			Console.WriteLine(mult);

			return (true);
        }

		//
		public static bool CommandDiv(string[] parameters)
        {
			int div = int.Parse(parameters[0]);

			for(int i=1; i<parameters.Length; i++)
            {
				div /= int.Parse(parameters[i]);
			}
			Console.WriteLine(div);
			return (true);
        }

		/***
		* Exit terminates the application.
		* the command prints the exit messsage.
		*/
		public static bool CommandExit(string[] parameters)
		{
			Console.WriteLine(CMD_EXIT);
			return (false);
		}
	}
}
