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
            //reviewManagment.ProductReviews();
            //reviewManagment.Count();
            //reviewManagment.PrintProductIDandReviews();
            //reviewManagment.PrintRecordsExcpetTop5();
            reviewManagment.PrintReviewsOfLikesAreTrue();
        }
    }
}
