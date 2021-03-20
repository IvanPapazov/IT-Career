using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MoviesApp.Data.Model
{
    /// <summary>
    /// Клас, който отговаря за обект "актьор" в приложението.
    /// Върху този клас, с помощта на EntityFramework.Core се създава таблица "Actors", която съдържа всички 
    /// актьори на приложението.
    /// </summary>
    [Table("Actors")]
    public class Actor
    {
        /// <summary>
        /// Номер на актьора
        /// Уникален номер в базата данни
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Първо име на актьора 
        /// Задължително поле
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия на актьора
        /// Задължително поле
        /// </summary>
        [Required]
        public string LastName { get; set; }
        /// <summary>
        /// Пол на актьора
        /// </summary>
        [Required]
        public string Gender { get; set; }
        /// <summary>
        /// Колекция, съдържаща връзките на актьора с филмите, в които той участва
        /// </summary>
        public IList<MovieActor> MoviesActors { get; set; }
        /// <summary>
        /// Конструктор на класа
        /// </summary>
        /// <param name="firstName">Име на актьора</param>
        /// <param name="lastName">Фамилия на актьора</param>
        /// <param name="gender">Пол на актьора</param>
        public Actor(string firstName, string lastName, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
    }
}