using System;
using System.Diagnostics;
using System.IO;
using ClosedXML.Excel;

public class WorkbookPrinter
{
    private XLWorkbook _workbook;

    public WorkbookPrinter(XLWorkbook workbook)
    {
        _workbook = workbook;
    }

    public void Print()
    {
        string tempPath = Path.Combine(Path.GetTempPath(), "tempWorkbookPrint.xlsx");
        _workbook.SaveAs(tempPath);

        Process printProcess = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = tempPath,
                Verb = "Print",
                CreateNoWindow = true,
                UseShellExecute = true
            }
        };
        printProcess.Start();
    }
}
