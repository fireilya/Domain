using System;

namespace Domain.Enumerations
{
    /// <summary>
    /// Атрибут нужен для автоматического создания типов Enum в хранилище
    /// </summary>
    /// <param name="nameInStorage">Имя перечисления в хранилище</param>
    [AttributeUsage(AttributeTargets.Enum)]
    public class StorageEnumerationAttribute : Attribute
    {
        public StorageEnumerationAttribute(string nameInStorage)
        {
            NameInStorage = nameInStorage;
        }

        public string NameInStorage { get; set; }
    }
}