using Domain.Validators;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Domain.ValueObjects
{
    public class FullName : BaseValueObject
    {
        public FullName()
        {
            var validator = new FullNameValidator();

            validator.Validate(this);
        }

        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public FullName(string firstName, string lastName, string? middleName) : this(firstName, lastName)
        {
            MiddleName = middleName;
        }

        public required string FirstName { get; set; } //обязательное поле

        public required string LastName { get; set; }

        public string? MiddleName { get; set; } //необязательный
    }
}
