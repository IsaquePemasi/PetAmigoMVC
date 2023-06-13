using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PetAmigoMVC.Models;

namespace PetAmigoMVC.Data;

public class PetAmigoContext : DbContext
{


    public PetAmigoContext(DbContextOptions<PetAmigoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Doacao> Doacaos { get; set; }


}
