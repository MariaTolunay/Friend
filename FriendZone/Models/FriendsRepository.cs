using FriendZone.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendZone.Models
{
    public class FriendsRepository
    {
        static List<FriendsInfo> friends = new List<FriendsInfo>
        {
            new FriendsInfo { Id = 1, FirstName = "Håkan", Age = 55, LookAlike = "Bruce Willis", FavoriteColor = "Green", Horoscope = "Geminin", ShoeSize = 45},
            new FriendsInfo { Id = 2, FirstName = "Tolunay", Age = 25, LookAlike = "Selma Hayek", FavoriteColor = "Red", Horoscope = "Leo", ShoeSize = 37},
            new FriendsInfo { Id = 3, FirstName = "Maria", Age = 25, LookAlike = "Robert", FavoriteColor = "Green", Horoscope = "Scorpio", ShoeSize = 38}
        };

        public static FriendsInfoVM GetFriendsInfoById(int id)
        {
            FriendsInfo f = friends
                .SingleOrDefault(p => p.Id == id);

            if(f != null)
            {
                FriendsInfoVM vm = new FriendsInfoVM
                {
                    FirstName = f.FirstName,
                    Age = f.Age,
                    FavoriteColor = f.FavoriteColor,
                    Horoscope = f.Horoscope,
                    LookAlike = f.LookAlike,
                    ShoeSize = f.ShoeSize,

                };

                return vm;
            }
            else
            {
                return new FriendsInfoVM();
            }
        }
    }
}
