using System;

namespace ProductRatingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Rating");
            ReviewManagment reviewManagment = new ReviewManagment();
            //reviewManagment.PrintReviews();
            reviewManagment.TopReviews();
        }
    }
}
