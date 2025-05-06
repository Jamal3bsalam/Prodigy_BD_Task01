using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODIGY_Task01.Models.Dtos
{
    public class UpdateUserDto
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Enter A Valid Email")]
        public string? Email { get; set; }
        public int? Age { get; set; }
    }
}
