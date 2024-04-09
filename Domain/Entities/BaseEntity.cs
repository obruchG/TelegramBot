using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Класс для всех сущностей
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор сущности
        /// Использую Guid для уникальности
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Проверяет равны ли два объекта BaseEntity
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj) //override указывает на то, что мы можем переопределить метод. Изначально Equals является virtual 
        {
            if(obj == null)
            {
                return false;
            }             
            if(obj is not BaseEntity entity)
            {
                return false;
            }
            if(Id != entity.Id) 
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Вычисление хеш-кода объекта
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 21 + Id.GetHashCode();
            return hash;
        }


        /// <summary>
        /// Проверяет, равны ли два объекта BaseEntity.
        /// </summary>
        /// <param name="obj1">Объект для сравнения 1.</param>
        /// <param name="obj2">Объект для сравнения 2.</param>
        /// <returns>True, если объекты равны, иначе False.</returns>
        public static bool operator ==(BaseEntity obj1, object? obj2)
        {
            return obj1.Equals(obj2);
        }
        /// <summary>
        /// Проверяет, равны ли два объекта BaseEntity.
        /// </summary>
        /// <param name="obj1">Объект для сравнения 1.</param>
        /// <param name="obj2">Объект для сравнения 2.</param>
        /// <returns>True, если объекты неравны, иначе False.</returns>
        public static bool operator !=(BaseEntity obj1, object? obj2)
        {
            return !obj1.Equals(obj2);
        }
    } 
}
