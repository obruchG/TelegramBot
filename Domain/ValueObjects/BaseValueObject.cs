using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public abstract class BaseValueObject
    {
        public override bool Equals(object? obj)
        {

            if (ReferenceEquals(this, obj)) //Эта проверка осуществляет сравнение ссылок объектов. Если this и obj указывают на один и тот же объект в памяти, то метод возвращает true, что означает, что объекты равны.
            {
                return true;
            }

            if (obj is null) //Проверка, что объект не пустой
            {
                return false;
            }

            if(this.GetType() != obj.GetType()) //Проверка сравнивает типы объектов. Если типы объектов не совпадают, то они не могут быть равными, и метод возвращает false
            {
                return false;
            }

            string jsonThis = JsonSerializer.Serialize(this);
            string jsonOther = JsonSerializer.Serialize(obj);

            return jsonThis.Equals(jsonOther);

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
