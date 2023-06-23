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

/*namespace Starpholio.Models
{
    public class Categories
    {
        public Categories()
        {
            categoriesColour = new HashSet<Category>(); // For the choice between Regular colours, Monochromatic and Negative
            categoriesStyle = new HashSet<Category>(); // For the choice of picture type(portrait, fashion, sports, nature, urban etc...)
        }

        public int ID { get; set; }
        
        // categoriesColour categories
        [Required(ErrorMessage = "Category 1 is required.")]
        public HashSet<Category> categoriesColour { get; set; }

        // categoriesStyle categories
        [Required(ErrorMessage = "Category 2 is required.")]
        public HashSet<Category>  categoriesStyle { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

*/