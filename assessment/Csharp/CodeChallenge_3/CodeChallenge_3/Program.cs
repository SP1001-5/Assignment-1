using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_3
{
    public class CricketTeam
    {
        public int Pointscalculation(int no_matches)
        {
            int score;
            int sum = 0;
            for (int i = 0; i < no_matches; i++) {
                Console.WriteLine($"Enter the {i+1} match score : ");
                score = Convert.ToInt32(Console.ReadLine());
                sum += score;
            }
            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int no_of_matches;
            Console.WriteLine("Enter the matches count : ");
            no_of_matches = Convert.ToInt32(Console.ReadLine());
            CricketTeam cricket = new CricketTeam();
            int sum = cricket.Pointscalculation(no_of_matches);
            Console.WriteLine($"The count of the matches are : {no_of_matches}");
            Console.WriteLine($"The total sum of the score is {sum} and the average of the score id {sum / no_of_matches}");
        }
    }
}
