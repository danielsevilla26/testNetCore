using System;

namespace BPT.Test.JDPS.Core.Entities
{
    public class StudentEntity : BaseEntity
    {
        /// <summary>
        /// Obtiene y establece el nombre
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtiene y establece la fecha de nacimiento
        /// </summary>
        public DateTime Birth { get; set; }
    }
}
