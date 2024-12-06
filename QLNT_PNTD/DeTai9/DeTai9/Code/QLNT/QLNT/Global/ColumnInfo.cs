using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Global
{
    public class ColumnInfo
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public int OrdinalPosition { get; set; }
        public bool Nullable { get; set; }
        public string MaxLength { get; set; }

        protected string MaxLengthFormatted
        {
            // note that columns with a max length return –1.
            get { return MaxLength.Equals("-1") ? "max" : MaxLength; }
        }

        public ColumnInfo ReadFromReader(IDataReader reader)
        {
            // get the necessary information from the datareader.
            // run the SQL on your database to see all the other information available.
            this.Name = reader["COLUMN_NAME"].ToString();
            this.DataType = reader["DATA_TYPE"].ToString();
            this.OrdinalPosition = (int)reader["ORDINAL_POSITION"];
            this.Nullable = ((string)reader["IS_NULLABLE"]) == "YES";
            this.MaxLength = reader["CHARACTER_MAXIMUM_LENGTH"].ToString();
            return this;
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1}{2} {3}NULL", Name, DataType,
                MaxLength == string.Empty ? "" : "(" + MaxLengthFormatted + ")",
                Nullable ? "" : "NOT ");
        }
    }
}
