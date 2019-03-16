using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;


namespace ChodbaSvetlaInteraction
{
	class SpreadsheetWriter
	{
		public ExcelPackage excelFile;
		public ExcelWorkbook excelWorkbook;
		public ExcelWorksheet dataWorksheet;

		int currentCollumn;
		int currentRow;


		public void Initialise()
		{
			string filePath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "Data.xlsx";
			if (File.Exists(filePath))
			{
				excelFile = new ExcelPackage(new FileInfo(filePath));
				excelWorkbook = excelFile.Workbook;

			}
			else
			{
				//Initial setup
				throw new Exception("Didn't find Data.xlsx, closing");
			}
			


		}

		public void RecordEvent(DateTime dateTime, int eventType)
		{
			try
			{
				dataWorksheet = excelWorkbook.Worksheets["Events"];
			}
			catch
			{
				throw new Exception("Can't find a worksheet named Events or it's already open");
			}




		}

		int getCollumnBasedOn
	}
}
