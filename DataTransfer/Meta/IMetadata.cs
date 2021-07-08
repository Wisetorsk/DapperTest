using System;

namespace DataTransfer.Meta
{
    public interface IMetadata
    {
        DateTime Created { get; }
        DateTime LastAccessed { get; set; }
        int TotalRowsInTable { get; set; }
        int RowsInQuery { get; set; }
        double Size { get; set; }
    }
}