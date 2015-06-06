using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapmleReports
{
    class ExcelUtil
    {
        public DataTable ExcelToDataTable(String fileName)
        {
            //open file and returns as stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //CreateOpenXmlReader via ExcelReaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);//.xlsx files
            //Set the first row as a column name
            excelReader.IsFirstRowAsColumnNames = true;
            //Return as Dataset
            DataSet result = excelReader.AsDataSet();
            //Get all the tables
            DataTableCollection table = result.Tables;
            //Store it in datatable
            DataTable resultTable = table["sheet1"];
            //return
            return resultTable;
        }
        List<DataCollection> dataCol = new List<DataCollection>();
        public void PopulateInCollection(String fileName)
        {
            DataTable table = ExcelToDataTable(fileName);
            //Iterate through row and columns of the table  
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dtable = new DataCollection()
                    //dtable.rowNumber=row;
                    //dtable.colName=table.Columns[col].ColumnName;
                    //dtable.colValue=table.Rows[row-1][col].ToString();
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString(),

                    };
                    //Add all the details for each row
                    dataCol.Add(dtable);
                }
            }
        }
        public String ReadData(int rowNumber, String columnName)
        {
            try
            {
                //Retrieving data using LINQ to reduce much of iterations
                //string data = (from colData in dataCol
                //               where colData.colName == columnName && colData.rowNumber == rowNumber
                //               select colData.colValue).SingleOrDefault();
                var data = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
    public class DataCollection{
        
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }
}
