using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Starpholio.Models
{
    public class Categories
    {
        public Categories()
        {
            Post = new HashSet<Posts>();
        }
        public int ID { get; set; }
        [Required(ErrorMessage = "o nome é de preenchimento obrigatório.")]
        public string Nome { get; set; }

        
        public virtual ICollection<Posts> Post { get; set; }

    }
}