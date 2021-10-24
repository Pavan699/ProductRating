using System;
using System.Collections.Generic;
using System.Text;

namespace ProductRatingProblem
{
    class ReviewManagment
    {
        List<Reviews> reviewsList = new List<Reviews>()
            {
                new Reviews(){ProductId=1,UserId=1,Rating=5,Review="Good",isLike=true },
                new Reviews(){ProductId=2,UserId=1,Rating=4,Review="Avg",isLike=true },
                new Reviews(){ProductId=3,UserId=2,Rating=5,Review="Best",isLike=true },
                new Reviews(){ProductId=4,UserId=4,Rating=4,Review="Good",isLike=true },
                new Reviews(){ProductId=5,UserId=3,Rating=2,Review="Nice",isLike=false},
                new Reviews(){ProductId=6,UserId=4,Rating=1,Review="Bad",isLike=false },
                new Reviews(){ProductId=7,UserId=3,Rating=1,Review="Nice",isLike=false },
                new Reviews(){ProductId=8,UserId=10,Rating=9,Review="Avg",isLike=true },
                new Reviews(){ProductId=9,UserId=7,Rating=10,Review="Best",isLike=true },
                new Reviews(){ProductId=10,UserId=5,Rating=8,Review="Nice",isLike=true },
                new Reviews(){ProductId=11,UserId=9,Rating=3,Review="Avg",isLike=true },
                new Reviews(){ProductId=12,UserId=10,Rating=7,Review="Nice",isLike=true },
                new Reviews(){ProductId=13,UserId=2,Rating=2,Review="Best",isLike=true },
                new Reviews(){ProductId=14,UserId=7,Rating=4,Review="Good",isLike=true },
                new Reviews(){ProductId=15,UserId=1,Rating=4,Review="Avg",isLike=true },
                new Reviews(){ProductId=16,UserId=8,Rating=4,Review="Nice",isLike=true },
                new Reviews(){ProductId=17,UserId=3,Rating=1,Review="Nice",isLike=false },
                new Reviews(){ProductId=18,UserId=10,Rating=9,Review="Avg",isLike=true },
                new Reviews(){ProductId=19,UserId=7,Rating=10,Review="Best",isLike=true },
                new Reviews(){ProductId=20,UserId=5,Rating=8,Review="Nice",isLike=true },
                new Reviews(){ProductId=21,UserId=9,Rating=3,Review="Avg",isLike=true },
                new Reviews(){ProductId=22,UserId=10,Rating=7,Review="Nice",isLike=true },
                new Reviews(){ProductId=23,UserId=2,Rating=2,Review="Best",isLike=true },
                new Reviews(){ProductId=24,UserId=7,Rating=4,Review="Good",isLike=true },
                new Reviews(){ProductId=25,UserId=1,Rating=4,Review="Avg",isLike=true },
            };
        public void PrintReviews()
        {
            foreach (var list in reviewsList)//to print list 
            {
                Console.WriteLine("ProductId : " + list.ProductId + " UserId : " + list.UserId + " Rating : " + list.Rating +" Review : " + list.Review + " isLike : " + list.isLike);
            }
        }
    }
}
