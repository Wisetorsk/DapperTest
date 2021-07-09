using DataTransfer.Meta;
using System.Collections.Generic;

namespace DataTransfer.DataModel
{
    public interface IBaseModel<TDto>
    {
        SortedList<int, TDto> Data { get; set; }
        bool HasData { get; }
    }
}