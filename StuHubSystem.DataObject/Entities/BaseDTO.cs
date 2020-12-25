using System;
using System.Collections.Generic;
using System.Text;

namespace StuHubSystem.DataObject.Entities
{
    public abstract class BaseDTO<T>
    {
        public T Id { get; set; } = default!;
    }

    public abstract class BaseDTO : BaseDTO<int>
    {
    }
}
