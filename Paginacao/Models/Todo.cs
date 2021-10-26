                                                                                                                                                                                                                                                                                                                                                                       using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paginacao.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
