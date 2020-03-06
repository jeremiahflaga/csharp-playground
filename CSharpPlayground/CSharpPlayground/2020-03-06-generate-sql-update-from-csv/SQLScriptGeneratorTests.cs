using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace CSharpPlayground._2020_03_06_generate_sql_update_from_csv
{
    public class SQLScriptGeneratorTests
    {
        [Fact]
        public void generate_sql_script()
        {
            // https://stackoverflow.com/a/5283044
            string sqlScript = "";
            using (var reader = new StreamReader("2020-03-06-generate-sql-update-from-csv/data.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var indexOfFirstComma = line.IndexOf(',');
                    var code = line.Substring(0, indexOfFirstComma).Replace("'", "''");
                    var theRest = line.Substring(indexOfFirstComma + 2).Replace("'", "''");

                    sqlScript += CreateSQLScript(code, theRest);
                }
            }

            Assert.NotEmpty(sqlScript);
        }

        private string CreateSQLScript(string code, string theRest)
        {
            return $@"
                UPDATE Table
                SET Column1 = '{theRest}'
                WHERE Column2 = '{code}';
                GO
            ";
        }
    }
}
