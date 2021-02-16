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
                value = id;
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
                value = title;
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
                value = boxOffice;
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
                value = active;
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
                value = dateOfLaunch;
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
                value = genre;
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
                value = hasTeaser;
            }
        }
        public Movie() { }
        public Movie(int id, string title, string boxOffice, Boolean active, string dateOfLaunch, string genre, Boolean hasTeaser)
        {
            this.id = id;
            this.title = title;
            this.boxOffice = boxOffice;
            this.active = active;
            this.dateOfLaunch = dateOfLaunch;
            this.genre = genre;
            this.hasTeaser = hasTeaser;

        }

    }
}
