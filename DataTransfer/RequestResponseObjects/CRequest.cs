using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.RequestResponseObjects
{
    public class CRequest
    {
        public String RequestType { get; set; }
        public Guid CorrelationID { get; set; }
        public SortedList<string, Object> QueryParameters { get; set; }
        public SortedList<string, object> ResponseParameters { get; set; }
        public SortedList<string, object> ACLParameters { get; set; }

        public CRequest(string requestType, Guid correlationID)
        {
            QueryParameters = new SortedList<string, object>();
            ResponseParameters = new SortedList<string, object>();
            ACLParameters = new SortedList<string, object>();
            CorrelationID = correlationID;
            RequestType = requestType;
        }
    }
}
