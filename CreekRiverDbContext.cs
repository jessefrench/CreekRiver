using Microsoft.EntityFrameworkCore;
using CreekRiver.Models;

public class CreekRiverDbContext : DbContext
{
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Campsite> Campsites { get; set; }
    public DbSet<CampsiteType> CampsiteTypes { get; set; }

    public CreekRiverDbContext(DbContextOptions<CreekRiverDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CampsiteType>().HasData(new CampsiteType[]
        {
            new CampsiteType
            {
                Id = 1,
                CampsiteTypeName = "Tent",
                FeePerNight = 15.99M,
                MaxReservationDays = 7
            },
            new CampsiteType
            {
                Id = 2,
                CampsiteTypeName = "RV",
                FeePerNight = 26.50M,
                MaxReservationDays = 14
            },
            new CampsiteType
            {
                Id = 3,
                CampsiteTypeName = "Primitive",
                FeePerNight = 10.00M,
                MaxReservationDays = 3
            },
            new CampsiteType
            {
                Id = 4,
                CampsiteTypeName = "Hammock",
                FeePerNight = 12M,
                MaxReservationDays = 7
            }
        });

        modelBuilder.Entity<Campsite>().HasData(new Campsite[]
        {
            new Campsite
            {
                Id = 1,
                CampsiteTypeId = 1,
                Nickname = "Barred Owl",
                ImageUrl = "https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"
            },
            new Campsite
            {
                Id = 2,
                CampsiteTypeId = 2,
                Nickname = "Eagle's Nest",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWufCbQIEvK65qi5XJngs46TwhTXkxD9WixA&s"
            },
            new Campsite
            {
                Id = 3,
                CampsiteTypeId = 1,
                Nickname = "Whispering Pines",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTjrQw2OqVFvfUNsxFtV8WxJp_2jDSAyCWUcQ&s"
            },
            new Campsite
            {
                Id = 4,
                CampsiteTypeId = 3,
                Nickname = "Mountain View",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjPWuwPtSasA14j9YFXBExdChO6H71O86UXA&s"
            },
            new Campsite
            {
                Id = 5,
                CampsiteTypeId = 2,
                Nickname = "Riverbend Retreat",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRI7zg34cxtzzFBqisoCFwj-xqDepr09UBfVw&s"
            },
            new Campsite
            {
                Id = 6,
                CampsiteTypeId = 3,
                Nickname = "Sunny Meadow",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTFZD-Tg-t4UUkVgW0nIjNND8XtwZQAbPz9Aw&s"
            }
        });

        modelBuilder.Entity<UserProfile>().HasData(new UserProfile[]
        {
            new UserProfile
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            }
        });

        modelBuilder.Entity<Reservation>().HasData(new Reservation[]
        {
            new Reservation
            {
                Id = 1,
                CampsiteId = 1,
                UserProfileId = 1,
                CheckinDate = new DateTime(2024, 9, 15),
                CheckoutDate = new DateTime(2024, 9, 20)
            }
        });
    }
}