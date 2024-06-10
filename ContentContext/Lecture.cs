using Projeto.ContentContext;
using Projeto.ContentContext.Enums;
using Projeto.SharedContext;

namespace Projeto.ContentContext;
    public class Lecture : Base
    {
        public int Ordem { get; set; }

        public string Tile { get; set; }

        public int DurationInMinutes { get; set; }
        
        public EContentLevel level { get; set; }

    }
