using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace PutLuckTestMVC.Models
{
    public class DAL
    {
        public static string CurrentUser = null;
        public static MySqlConnection DB;

        public static List<Dish> GetAllDishes()
        {
            return DB.GetAll<Dish>().ToList();
        }
      
        public static List<TeamMember> GetAllTeamMembers()
        {
            return DB.GetAll<TeamMember>().ToList();
        }
        public static void AddDish(Dish newDish)
        {
            newDish.Id = 2;
            DB.Insert(newDish);
        }
        public static void AddRSVP(TeamMember newRSVP)
        {
            var tmlist = DB.GetAll<TeamMember>().ToList();
            var length = tmlist.Count();
            newRSVP.Id = length + 2;
            DB.Insert(newRSVP);
        }
        public static void EditDish(Dish dish)
        {
            DB.Update(dish);
        }

        public static void DeleteDish(int dishUserID)
        {
            Dish dishes = new Dish() { Id = dishUserID };
            DB.Delete(dishes);
        }
    }
}