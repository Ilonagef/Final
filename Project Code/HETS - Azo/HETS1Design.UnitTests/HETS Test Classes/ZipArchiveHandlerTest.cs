﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HETS1Design
{
    [TestClass]
    public class ZipArchiveHandlerTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Submissions.ResetSubmissions();
            TestCases.ResetTestCases();
        }

        [TestMethod]
        public void ZipArchiveHandler_Success()
        {
            string filePath = @"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\ZipForTest.zip";
            ZipArchiveHandler.GetSubmissionData(filePath, true);
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\Codes To Check\איימן שפסו_7085_assignsubmission_file_\Q3 .c"));
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\Codes To Check\אחמד סכראן_7092_assignsubmission_file_\mtla3.c"));
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\Codes To Check\אחמד סכראן_7092_assignsubmission_file_\code files\erl.h"));
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\Codes To Check\אחמד סכראן_7092_assignsubmission_file_\code files\Targil5a.c"));
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\Test Required FIles\ZipArchiveHandlerTest\Codes To Check\אחמד סכראן_7092_assignsubmission_file_\Exe\Source.exe"));
        }

        /*new -> when chooce Folder (not Zip file)*/
        [TestMethod]
        public void ZipArchiveHandler_NotZip()
        {
            string folderPath = @"..\..\..\Assets\New Test_ilonaAbdala\OpenFolderTest";
            ZipArchiveHandler.GetSubmissionData(folderPath, false);
            bool NotZip = folderPath.Contains(".zip");
            int Size_Submissions = 1;
            Assert.AreEqual(Size_Submissions, Submissions.submissions.Count);/*check that only one submissin add*/

            Assert.IsFalse(NotZip);
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\New Test_ilonaAbdala\OpenFolderTest\Code to Check\אחמד סכראן_7092_assignsubmission_file_\mtla3.c"));
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\New Test_ilonaAbdala\OpenFolderTest\Code to Check\אחמד סכראן_7092_assignsubmission_file_\code files\erl.h"));
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\New Test_ilonaAbdala\OpenFolderTest\Code to Check\אחמד סכראן_7092_assignsubmission_file_\code files\Targil5a.c"));
            Assert.IsTrue(File.Exists(@"..\..\..\Assets\New Test_ilonaAbdala\OpenFolderTest\Code to Check\אחמד סכראן_7092_assignsubmission_file_\Exe\Exe\Source.exe"));
            

        }

        [TestCleanup]
        public void TestCleanup()
        {
            Submissions.ResetSubmissions();
            TestCases.ResetTestCases();
           
        }
      
    }
}
