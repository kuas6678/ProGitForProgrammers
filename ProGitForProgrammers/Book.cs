using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProGitForProgrammers
{
    public class Book
    {
        public string Title { get; set; }

        public List<string> Authors { get; set; }

        public DateTime PublicationDate { get; set; }

        public record Book1(string Branch);
        public record Book2(string Branch);
    }
}
