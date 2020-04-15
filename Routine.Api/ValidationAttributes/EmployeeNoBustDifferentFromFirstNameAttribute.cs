using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Routine.Api.Models;

namespace Routine.Api.ValidationAttributes
{
    public class EmployeeNoBustDifferentFromFirstNameAttribute : ValidationAttribute
    {
        //object 指要验证的对象,EmployeeAddDto
        //用于访问要验证的对象，如果作用于属性，value就是指属性了，但是validationContext还是可以访问到哪个类
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
           //1.转化为具体的类，使用validationContext，因为objectInstance总可以得到类的对象，value是变化的
           var addDto = (EmployeeAddOrUpdateDto) validationContext.ObjectInstance;
           if (addDto.EmployeeNo == addDto.FirstName)
           {
               return new ValidationResult(ErrorMessage,new []{nameof(EmployeeAddOrUpdateDto)});
           }
           return ValidationResult.Success;
        }
    }
}
