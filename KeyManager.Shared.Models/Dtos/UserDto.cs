using System;
using System.Collections.Generic;
using System.Text;

namespace KeyManager.Shared.Models.Dtos
{
    public class UserDto : BaseDto
    {
        public string Name { get; set; }
        public byte[] BioData { get; set; }
    }
}
