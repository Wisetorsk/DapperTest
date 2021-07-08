using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.Meta
{
    public class Metadata : IMetadata
    {
        public DateTime Created { get; }
        public DateTime LastAccessed { get; set; }
        public int TotalRowsInTable { get; set; }
        public int RowsInQuery { get; set; }
        public double Size { get; set; }

        public Metadata(int rowsInTable, int rowsInQuery, double size)
        {
            Created = DateTime.Now;
            LastAccessed = DateTime.Now;
            TotalRowsInTable = rowsInTable;
            RowsInQuery = rowsInQuery;
            Size = size;
        }
    }
}
