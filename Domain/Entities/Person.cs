using Domain.ValueObjects;
using Domain.Primitives;
using System.Reflection;
using Domain.Validators;

namespace Domain.Entities
{
    public class Person : BaseEntity
    {
        public Person()
        {
            var validator = new PersonValidator();

            validator.Validate(this);
        }

        public FullName FullName { get; set; }

        public DateTime Birthday { get; private set; } // сделал privat для модификации только внутри персоны

        public int Age {
            get // для того чтобы нельзя было изменить возраст, так как он зависит от Birthday
            {
                return DateTime.Now.Year - Birthday.Year;
            }
            set
            {
                Birthday = new DateTime(DateTime.Now.Year - value, Birthday.Month, Birthday.Day);
            }
        }

        public Gender Gender { get; set; }

        public List<CustomField> CustomFields { get; set; }
    }
}
