using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransfer.DataModel
{
    public class ModelFactory
    {
        public IBaseModel<TDTO> Create<TDTO>(TDTO dto)
        {
            return new BaseModel<TDTO>();
        } 
    }
}
