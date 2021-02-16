using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCruiser.Model;
using Com.Cognizant.MovieCruiser.Dao;

namespace MovieCruiser
{
    class GetMovieList
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(12, 2);

            List<Movie> movieList = new List<Movie>() {
            new Movie(1, "Avatar", "$2,787,965,087", true, "15/03/2017", "Science Fiction", true),
            new Movie(2, "The Avengers", "$1,518,812,988", true, "23/12/2017", "Superhero", false),
            new Movie(3, "Titanic", "$2,187,463,944", true, "21/08/2017", "Romance", false),
            new Movie(4, "Jurassic World", "$1,671,713,208", false, "02/07/2017", "Science Fiction", true),
            new Movie(5, "Avengers:End Game", "$2,750,760,348", true, "02/11/2017", "Superhero", true)};

            List<Movie> favouriteMovieList = new List<Movie>() {
            new Movie(1, "Avatar", "$2,787,965,087", true, "15/03/2017", "Science Fiction", true),
            new Movie(2, "The Avengers", "$1,518,812,988", true, "23/12/2017", "Superhero", false),
            new Movie(3, "Titanic", "$2,187,463,944", true, "21/08/2017", "Romance", false)};

            Admin admin = new Admin();
            Customer customer = new Customer();

            List<Customer> CustomerList = new List<Customer>() {
            new Customer(1, "Saranya"),
            new Customer(2, "Mahitha"),
            new Customer(3, "Sirisha"),
            new Customer(4, "Sahitya")};

            Console.WriteLine("Welcome to Movie Cruiser!");
            Console.WriteLine("If you are admin enter A or If you are Customer enter C");
            int userType = Convert.ToChar(Console.ReadLine());
            if (userType == 'A')
            {
                Console.WriteLine("Enter your name");
                admin.adminName = Console.ReadLine();
                Console.WriteLine("Enter your Admin Id");
                admin.adminId = Convert.ToInt32(Console.ReadLine());
                if (admin.adminName == "Saranya" && admin.adminId == 895188)
                {
                    int flag = 1;
                    Console.WriteLine("Logged in succesfully as admin");
                    while (flag == 1)
                    {
                        Console.WriteLine("Enter 1 to View movie list \n Enter 2 to edit movie \n Enter 0 to exit");
                        int adminChoice = Convert.ToInt32(Console.ReadLine());
                        if (adminChoice == 1)
                        {
                            admin.ViewMovieListAdmin(movieList);
                        }
                        else if (adminChoice == 2)
                        {
                            admin.ViewMovieListAdmin(movieList);
                            Console.WriteLine("Enter the id of the movie you want to edit");
                            int id = Convert.ToInt32(Console.ReadLine());
                            admin.EditMovie(id, movieList);
                        }
                        else if (adminChoice == 0)
                        {
                            flag = 0;
                        }
                        else
                        {
                            Console.WriteLine("Wrong Credentials");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Wrong Credentials");
                }

            }

            if (userType == 'C')
            {
                Console.WriteLine("Enter your name");
                string customerName = Console.ReadLine();
                Console.WriteLine("Enter your Customer Id");
                int customerId = Convert.ToInt32(Console.ReadLine());
                int customerid = customerId - 1;
                if (customerid < CustomerList.Count())
                {
                    if (customerId == CustomerList[customerid].customerId && customerName == CustomerList[customerid].customerName)
                    {
                        Console.WriteLine("Logged in succesfully as a customer");
                        int flag1 = 1;
                        while (flag1 == 1)
                        {
                            Console.WriteLine("Enter 1 to view movie list \n Enter 2 to add movie to favorites\n Enter 3 to view favorites \n Enter 4 to remove item from favorites \n Enter 0 to exit");
                            int customerChoice = Convert.ToInt32(Console.ReadLine());
                            if (customerChoice == 1)
                            {
                                customer.ViewMovieListCustomer(movieList);
                            }
                            else if (customerChoice == 2)
                            {
                                customer.ViewMovieListCustomer(movieList);
                                Console.WriteLine("Enter the id of the movie you want to add to favorites");
                                int idCustomer = Convert.ToInt32(Console.ReadLine());
                                customer.AddToFavorites(idCustomer, movieList, favouriteMovieList);

                            }
                            else if (customerChoice == 3)
                            {
                                customer.ViewMovieListCustomer(favouriteMovieList);
                            }
                            else if (customerChoice == 4)
                            {
                                customer.ViewMovieListCustomer(movieList);
                                Console.WriteLine("Enter the id of the movie you want to remove from favorites");
                                int idCustomer = Convert.ToInt32(Console.ReadLine());
                                customer.RemoveFavorites(idCustomer, favouriteMovieList);
                            }
                            else if (customerChoice == 0)
                            {
                                flag1 = 0;
                            }
                            else
                            {
                                Console.WriteLine("Wrong Credentials");
                            }

                        }
                    }




                }
            }
        }
    }
}
