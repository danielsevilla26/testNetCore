using System;

namespace BPT.Test.JDPS.API.Models
{
    public class Student
    {
        /// <summary>
        /// Obtiene y establece el id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtiene y establece el nombre
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtiene y establece la fecha de nacimiento
        /// </summary>
        public DateTime Birthday { get; set; }
    }
}
