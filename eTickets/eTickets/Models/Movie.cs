﻿using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models;

public class Movie
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageURL { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public MovieCategory MovieCategory { get; set; }

    public List<Actor_Movie> Actors_Movies { get; set; }

    public long CinemaId { get; set; }
    [ForeignKey("CinemaId")]
    public Cinema Cinema { get; set; }

    public long ProducerId { get; set; }
    [ForeignKey("ProducerId")]
    public Producer Producer { get; set; }

}
