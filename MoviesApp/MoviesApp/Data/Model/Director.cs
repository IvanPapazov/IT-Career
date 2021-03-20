using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MoviesApp.Data.Model
{
    /// <summary>
    /// Клас, който отговаря за обект "режисьор" в приложението.
    /// Върху този клас, с помощта на EntityFramework.Core се създава таблица "Directors", която съдържа всички 
    /// режисьори на приложението.
    /// </summary>
    [Table("Directors")]
    public class Director
    {
        /// <summary>
        /// Номер на режисьора
        /// Уникален номер на режисьора в приложението
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Име на режисьора
        /// Задължително поле
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия на режисьора
        /// </summary>
        [Required]
        public string LastName { get; set; }
        /// <summary>
        /// Колекция от филми, съдъжаща филмите на режисьора
        /// </summary>
        public ICollection<Movie> Movies { get; set; }
        /// <summary>
        /// Конструктор на класа
        /// </summary>
        /// <param name="firstName">Име на режисьора</param>
        /// <param name="lastName">Фамилия на режисьора</param>
        public Director(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
