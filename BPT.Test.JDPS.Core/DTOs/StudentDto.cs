using BPT.Test.JDPS.Core.Entities;
using System;

namespace BPT.Test.JDPS.Core.DTOs
{
    public class StudentDto : BaseEntity
    {
        public string Name { get; set; }

        public DateTime Birth { get; set; }
    }
}
