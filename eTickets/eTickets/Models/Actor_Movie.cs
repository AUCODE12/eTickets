﻿namespace eTickets.Models;

public class Actor_Movie
{
    public long MovieId { get; set; }
    public Movie Movie { get; set; }
    public long ActorId { get; set; }
    public Actor Actor { get; set; }
}
