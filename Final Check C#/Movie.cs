using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.MovieCruiser.Model
{
    public class Movie
    {
        int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id=value;
            }
        }
        string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
               title= value;
            }
        }
        string boxOffice;
        public string BoxOffice
        {
            get
            {
                return boxOffice;
            }
            set
            {
                boxOffice=value;
            }
        }
        Boolean active;
        public Boolean Active
        {
            get
            {
                return active;
            }
            set
            {
                active=value;
            }
        }
        string dateOfLaunch;
        public string DateOfLaunch
        {
            get
            {
                return dateOfLaunch;
            }
            set
            {
                dateOfLaunch= value ;
            }
        }
        string genre;
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre= value ;
            }
        }
        Boolean hasTeaser;
        public Boolean HasTeaser
        {
            get
            {
                return hasTeaser;
            }
            set
            {
                hasTeaser=value;
            }
        }
        public Movie() { }
        public Movie(int id, string title, string boxOffice, Boolean active, string dateOfLaunch, string genre, Boolean hasTeaser)
        {
            this.Id = id;
            this.Title = title;
            this.BoxOffice = boxOffice;
            this.Active = active;
            this.DateOfLaunch = dateOfLaunch;
            this.Genre = genre;
            this.HasTeaser = hasTeaser;

        }

    }
}
