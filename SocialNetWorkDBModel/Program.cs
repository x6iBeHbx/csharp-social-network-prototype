using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetWorkDBModel.Context;
using SocialNetWorkDBModel.userData;
using SocialNetWorkDBModel.userData.professions;

namespace SocialNetWorkDBModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SocialPrototypeContext())
            {
                var profession = new Professions()
                {
                    ProfessionName = "QA"
                };

                //context.Professions.Add(profession);
                //context.SaveChanges();

                var user = new User()
                {
                    FirstName = "Vova",
                    SecondName = "Vovan",
                    BirthDate = DateTime.Now,
                };

                var userData = new UserData()
                {
                    Login = "jora",
                    Password = "qqq111",
                    UserAvatarUrl = "https://www.google.com.ua/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=0ahUKEwj6yqD9vIjSAhWkNJoKHYl1DTUQjRwIBw&url=http%3A%2F%2Fkotaku.com%2Fno-jackie-chan-is-not-dead-1762840753&psig=AFQjCNEjHaz0bwiG4GL1lJt568o5rJn56Q&ust=1486917364727333",
                    Sex = SexEnum.Male,
                    User = user,
                    Profession = profession,
                    StateId = StatesEnum.Whants_a_meet
                };

                //context.Users.Add(user);
                //context.SaveChanges();

                try
                {
                    context.UsersData.Add(userData);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                //Console.WriteLine("Введите логин юзера");
                //var userLigin = Console.ReadLine();

                //UserData userdata = context.UsersData.FirstOrDefault(c => c.Login == userLigin.ToString());

                //User us = context.Users.FirstOrDefault(x => x.UserId == userdata.UserDataId);
                //Console.WriteLine($"User login: {0}, User Sex: {1}, USer Profssion {3} User Status {4}", userdata.Login, userdata.Sex, userdata.Profession, userdata.StateId);
            }

            Console.ReadLine();
        }
    }
}
