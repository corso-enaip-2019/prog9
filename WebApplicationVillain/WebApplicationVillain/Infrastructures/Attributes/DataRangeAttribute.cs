using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVillain.Infrastructures.Attributes
{
    public class DataRangeAttribute : ValidationAttribute
    {
        private DateTime _start;

        public DataRangeAttribute(int startYear,int startMonth,int startDay)
        {
            _start = new DateTime(startYear, startMonth, startDay);
        }

        public override bool IsValid(object value)
        {
            return (value is DateTime date) && (_start < date && date < DateTime.Today);

            //if (value is DateTime date)
            //{
            //    return _start < date && date < DateTime.Today;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
