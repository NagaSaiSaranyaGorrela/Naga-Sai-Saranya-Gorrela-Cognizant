using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCruiser.Model;

namespace Com.Cognizant.MovieCruiser.Dao
{
    abstract public class User
    {
        public List<Movie> movieList = new List<Movie>()
                {
                   new Movie(1,"Avatar","$2,787,965,087",true,"15/03/2017","Science Fiction",true),
                    new Movie(2,"The Avengers","$1,518,812,988",true,"23/12/2017","Superhero",false),
                    new Movie(3,"Titanic","$2,187,463,944",true,"21/08/2017","Romance",false),
                    new Movie(4,"Jurassic World","$1,617,713,208",false,"02/07/2017","Science Fiction",true),
                    new Movie(5,"Avengers","$2,750,760,348",true,"02/11/2022","Superhero",true)
            };
        abstract public List<Movie> GetMovieList();
    }
    public class Admin : User
    {
        public int adminId;
        public int AdminId
        {
            get
            {
                return adminId;
            }
            set
            {
                adminId = value;
            }
        }
        public string adminName;
        public string AdminName
        {
            get
            {
                return adminName;
            }
            set
            {
                adminName = value;
            }
        }
        public override List<Movie> GetMovieList()
        {
            return movieList;
        }

        public void ViewMovieListAdmin(List<Movie> movieList)
        {
            int i = 1;
            Console.WriteLine("Id Title                BoxOffice          Active      DateOfLaunch       Genre        HasTeaser");
            foreach (Movie temp in movieList)
            {

                Console.WriteLine("{0} {1,-20} {2,-20} {3,-10} {4,-14} {5,-17} {6}", i, temp.Title, temp.BoxOffice, temp.Active, temp.DateOfLaunch, temp.Genre, temp.HasTeaser);
                i++;
            }

        }
        //EditMovie by Admin
        public void EditMovie(int k, List<Movie> movieList)
        {
            foreach (Movie temp in movieList)
            {
                if (temp.Id == k)
                {
                    Console.WriteLine("Enter title,boxoffice,active,dateoflaunch,genre,hasteaser in order");
                    temp.Title = Console.ReadLine();
                    temp.BoxOffice = Console.ReadLine();
                    temp.Active = Convert.ToBoolean(Console.ReadLine());
                    temp.DateOfLaunch = Console.ReadLine();
                    temp.Genre = Console.ReadLine();
                    temp.HasTeaser = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Selected Record Updated Sucessfully");

                }
            }
            ViewMovieListAdmin(movieList);
        }
        public void EditMovie(string Id, List<Movie> movieList)
        {
            throw new NotImplementedException();
        }
    }
    public class Customer : User
    {
        public int customerId;
        public int CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
            }
        }
        public string customerName;
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
        public Customer() { }
        public Customer(int CustomerId, string CustomerName)
        {
            this.CustomerId = CustomerId;
            this.CustomerName = CustomerName;
        }
        //public List<Movie> movielist;
        public override List<Movie> GetMovieList()
        {
            return movieList;
        }

        public void ViewMovieListCustomer(List<Movie> movieList)
        {
            int i = 1;
            Console.WriteLine("Id     Title                   BoxOffice             Genre            HasTeaser");
            foreach (Movie temp in movieList)
            {
                Console.WriteLine("{0}  {1,-25} {2,-18}  {3,-20} {4}", i, temp.Title, temp.BoxOffice, temp.Genre, temp.HasTeaser);
                i++;
            }
        }

        //Add to favorites

        public void AddToFavorites(int id, List<Movie> movieList, List<Movie> favourites)
        {
            int favId, s = 0, count = 0;
            string favTitle;
            string favBoxOffice;
            Boolean favActive;
            string favDateOfLaunch;
            string favGenre;
            Boolean favHasTeaser;
            foreach (Movie temp in movieList)
            {
                count++;
                if (temp.Id == id)
                {
                    foreach (Movie emp in favourites)
                    {
                        if (temp.Id == emp.Id)
                        {
                            s = 1;
                        }
                    }
                    if (s == 0)
                    {
                        favId = temp.Id;
                        favTitle = temp.Title;
                        favBoxOffice = temp.BoxOffice;
                        favActive = temp.Active;
                        favDateOfLaunch = temp.DateOfLaunch;
                        favGenre = temp.Genre;
                        favHasTeaser = temp.HasTeaser;
                        favourites.Add(new Movie(favId, favTitle, favBoxOffice, favActive, favDateOfLaunch, favGenre, favHasTeaser));
                        Console.WriteLine("Added to Favorites Successfully");
                        Console.WriteLine("The Movie list in favorites is:");
                        ViewFavourites(favourites);
                    }
                    else
                    {
                        Console.WriteLine("The selected movie is in favourites already");
                    }
                }
            }
            if (count < id)
            {
                Console.WriteLine("Movie index out of bounds");
            }

        }

        //View Favourites
        public void ViewFavourites(List<Movie> favourites)
        {
            int i = 1;
            Console.WriteLine("Id     Title               BoxOffice           Genre");
            foreach (Movie temp in favourites)
            {
                Console.WriteLine("{0} {1,-25} {2,-18}  {3}", i, temp.Title, temp.BoxOffice, temp.Genre);
                i++;
            }
        }

        //Remove favourites

        public void RemoveFavorites(int id, List<Movie> favourites)
        {
            if (favourites.ElementAtOrDefault((id - 1)) != null)
            {
                favourites.RemoveAt(id - 1);
                Console.WriteLine("Record removed successfully");
                ViewFavourites(favourites);
            }
            else
            {
                Console.WriteLine("No movie found for selected id");
            }
        }


    }


}
