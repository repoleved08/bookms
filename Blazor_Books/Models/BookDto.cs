using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Books.Models
{
public class BookDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public string Description { get; set; }=string.Empty;
        public string Author { get; set; }=string.Empty;
    }

}
