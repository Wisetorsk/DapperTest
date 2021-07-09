using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransfer.Meta;

namespace DataTransfer.DataModel
{
    public class BaseModel<TDto> : IBaseModel<TDto>
    {
        public SortedList<int, TDto> Data { get; set; }
        public bool HasData => Data.Any();
    }
}
