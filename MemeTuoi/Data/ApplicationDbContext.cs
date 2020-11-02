using System;
using System.Collections.Generic;
using System.Text;
using MemeTuoi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MemeTuoi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Meme> TMeme { get; set; }
        public DbSet<AppUser> TUser { get; set; }
        public DbSet<AppUserMeme> TAppUserMeme { get; set; }
        public DbSet<TheLoai> TTheLoai { get; set; }
        public DbSet<MemeCanDuyet> TMemeCanDuyet { get; set; }
    }
}
