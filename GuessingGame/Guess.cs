using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class Guess
    {
        public int UserGuess { get; } //readonly property
        public DateTime GuessTime { get; } //readonly property

        //Constructor
        public Guess(int userGuess)
        {
            UserGuess = userGuess;  
            GuessTime = DateTime.Now; 
        }

    }
}
