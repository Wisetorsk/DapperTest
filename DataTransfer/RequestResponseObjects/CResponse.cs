using System;
using System.Collections.Generic;
using System.Text;
using DataTransfer.DataModel;
using DataTransfer.Meta;

namespace DataTransfer.RequestResponseObjects
{
    /// <summary>
    /// Collection of Metadata, error information and Payload (IBaseModel with DTO list)
    /// </summary>
    /// <typeparam name="DTO"></typeparam>
    public class CResponse <DTO>
    {
        public IMetadata Metadata { get; set; } 
        public IBaseModel<DTO> Payload { get; set; }
        public int RowCount { get; set; }
        public bool Error { get; set; }
        public String ErrorMessage { get; set; }
        public String Status { get; set; }
    }
}
