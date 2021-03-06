﻿using CinemaTickets.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTickets.Services.Contracts
{
    public interface IMovieService
    {
        IQueryable<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        void AddMovie(Movie movie);
        void DeleteMovie(int movieID);
    }
}
