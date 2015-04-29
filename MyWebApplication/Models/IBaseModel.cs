using System;
namespace MyWebApplication.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    public interface IBaseModel
    {
        long GetHashCode();
    }
}