using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductRatingProblem
{
    /// <summary>
    /// Class to manage the review process
    /// </summary>
    class ReviewManagment
    {
        /// <summary>
        /// List of 25 users with there reviews
        /// </summary>
        List<Reviews> reviewsList = new List<Reviews>()
            {
                new Reviews(){ProductId=1,UserId=1,Rating=5,Review="Good",isLike=true },
                new Reviews(){ProductId=2,UserId=1,Rating=4,Review="Avg",isLike=true },
                new Reviews(){ProductId=3,UserId=2,Rating=5,Review="Best",isLike=true },
                new Reviews(){ProductId=4,UserId=4,Rating=4,Review="Good",isLike=true },
                new Reviews(){ProductId=5,UserId=3,Rating=2,Review="Nice",isLike=false},
                new Reviews(){ProductId=6,UserId=4,Rating=1,Review="Bad",isLike=false },
                new Reviews(){ProductId=7,UserId=3,Rating=1,Review="Nice",isLike=false },
                new Reviews(){ProductId=1,UserId=10,Rating=9,Review="Avg",isLike=true },
                new Reviews(){ProductId=9,UserId=7,Rating=10,Review="Best",isLike=true },
                new Reviews(){ProductId=10,UserId=5,Rating=8,Review="Nice",isLike=true },
                new Reviews(){ProductId=1,UserId=9,Rating=3,Review="Avg",isLike=true },
                new Reviews(){ProductId=12,UserId=10,Rating=7,Review="Nice",isLike=true },
                new Reviews(){ProductId=13,UserId=2,Rating=2,Review="Best",isLike=true },
                new Reviews(){ProductId=14,UserId=7,Rating=4,Review="Good",isLike=true },
                new Reviews(){ProductId=15,UserId=1,Rating=4,Review="Avg",isLike=true },
                new Reviews(){ProductId=16,UserId=8,Rating=4,Review="Nice",isLike=true },
                new Reviews(){ProductId=1,UserId=3,Rating=1,Review="Nice",isLike=false },
                new Reviews(){ProductId=18,UserId=10,Rating=9,Review="Avg",isLike=true },
                new Reviews(){ProductId=9,UserId=7,Rating=10,Review="Best",isLike=true },
                new Reviews(){ProductId=20,UserId=5,Rating=8,Review="Nice",isLike=true },
                new Reviews(){ProductId=1,UserId=9,Rating=3,Review="Avg",isLike=true },
                new Reviews(){ProductId=22,UserId=10,Rating=7,Review="Nice",isLike=true },
                new Reviews(){ProductId=23,UserId=2,Rating=2,Review="Best",isLike=true },
                new Reviews(){ProductId=4,UserId=7,Rating=4,Review="Good",isLike=true },
                new Reviews(){ProductId=25,UserId=1,Rating=4,Review="Avg",isLike=true },
            };
        /// <summary>
        /// Print metghod to print all the reviews
        /// </summary>
        public void PrintReviews()
        {
            foreach (var list in reviewsList)//to print list 
            {
                Console.WriteLine("ProductId : " + list.ProductId + " UserId : " + list.UserId + " Rating : " + list.Rating +" Review : " + list.Review + " isLike : " + list.isLike);
            }
        }
        /// <summary>
        /// Method to get the top 3 reviews
        /// </summary>
        public void ProductReviews()
        {
            Console.WriteLine("Top 3 high rated Reviws");
            var top3reviews = (from userReview in reviewsList
                                orderby userReview.Rating descending//using orderby - decending to get the higher to lower ratings
                                select userReview).Take(3);//take(3) will take top 3 user with high ratings
            foreach (var list in top3reviews)//to print list 
            {
                Console.WriteLine("ProductId : " + list.ProductId + " UserId : " + list.UserId + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.isLike);
            }

            Console.WriteLine("Reviews of ProductID 1,4,9 which id greater than 3");
            var ProductIDReviews = from userReview in reviewsList
                                   where (userReview.ProductId == 1 || userReview.ProductId == 4 || userReview.ProductId == 9) && (userReview.Rating > 3)
                               select userReview;//ids are 1,4,9 and rating is grater than 3
            foreach (var list in ProductIDReviews)//to print list 
            {
                Console.WriteLine("ProductId : " + list.ProductId + " UserId : " + list.UserId + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }
    }
}
