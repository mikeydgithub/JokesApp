using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesApp.Models
{
    public class Joke
    {
        // properties
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
            
        // method: constructor, going to be empty so other pieces of the code can use it
        public Joke()
        {

        }
    }
}
