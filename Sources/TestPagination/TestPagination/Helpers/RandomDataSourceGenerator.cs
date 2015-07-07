using System;
using System.Data;

namespace TestPagination.Helpers
{
    public class RandomDataSourceGenerator
    {
        private readonly Random _random;

        public RandomDataSourceGenerator()
        {
            _random = new Random(Guid.NewGuid().GetHashCode());
        }
        public DataTable Generate(int rowCount)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            for (int i = 0; i < rowCount; i++)
            {
                var row = dt.NewRow();
                row[0] = i;
                row[1] = GenerateRandomString(6);
                dt.Rows.Add(row);
            }
            return dt;
        }

        private string GenerateRandomString(int length)
        {
            string result = string.Empty;
            for (int i = 0; i < length; i++)
            {
                int randomNumber = _random.Next(97, 122);
                char randomChar = (char)randomNumber;
                result += randomChar;
            }
            return result;
        }
    }
}