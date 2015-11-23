using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageControl
{
    public static class DynSettings 
    {
        public static int LanguageID=0;
    }

    public class ltext
    {
        string[] sText = { "", "" };

        public string s
        {
            get
            {
                return sText[DynSettings.LanguageID];
            }
        }
        public ltext(string Lang1, string Lang2)
        {
            sText[0] = Lang1;
            sText[1] = Lang2;
        }
    }

    public static class lngRPM
    {
        public static ltext s_ExportToFile = new ltext(" Export to file", "Izvoz v datoke");
        public static ltext s_Rows = new ltext("Rows", "Število vrstic");
        public static ltext s_Columns = new ltext("Columns", "Število stolpcev");
        public static ltext s_ExportDoneInXprocent = new ltext(" Export", "Izvoženo");
        public static ltext s_ErrorStartExecuteExcel = new ltext("Error opening file:", "Napaka pri odpiranju datoteke:");
        public static ltext s_ErrorInExportToExcel = new ltext("Error in export", "Napaka pri izvozu");
        public static ltext s_ThereAreNoSelectedRowsToExport = new ltext("You didn't select rows to export into  \"Excel\"(.xls) file.", "Niste izbrali vrstic za izvoz v \"Excel\" datoteko?");
        public static ltext s_Error = new ltext ("Error",
                                                 "Napaka");

        public static ltext s_ShowRowNumbers = new ltext("Show Row Numbers", "Prikaži številke vrstic");

        public static ltext s_SaveSelectedRowsToExcelFile = new ltext("Export selected rows to Excel file?", "Izvozim izbrane vrstice v \"Excel\" datoteko?");

    }
}
