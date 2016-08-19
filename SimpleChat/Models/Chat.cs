using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimpleChat.Models
{
    public class Chat
    {
        [Required(ErrorMessage ="Debe incluir un nombre de usuario")]
        public string canal { get; set; }
        [Required(ErrorMessage = "Debe incluir un nombre de Canal")]
        public string user { get; set; }
    }
}