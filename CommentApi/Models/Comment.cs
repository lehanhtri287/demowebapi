using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommentApi.Models
{
    public class Comment
    {
        public int IdComment { get ; set ; }
        public int IdTopic { get; set; }
        public string context { get; set; }
        public int IdUser { get; set; }
        public DateTime dateCmt { get; set; }
        
    }
}
