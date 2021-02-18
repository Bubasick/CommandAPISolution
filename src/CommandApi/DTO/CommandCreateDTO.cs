using System.ComponentModel.DataAnnotations;

namespace CommandAPI.DTO
{
    public class CommandCreateDTO
    {
        [Required]
        [MaxLength(250)]
        public string Howto { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        public string CommandLine { get; set; }
    }
}