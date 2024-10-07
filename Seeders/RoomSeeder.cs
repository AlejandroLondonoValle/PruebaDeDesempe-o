using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApiRestFull.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelApiRestFull.Seeders;

public class RoomSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Room>().HasData(

            new Room
            {
                Id = 1,
                Number = "101",
                Price = 50.000,
                Availability = true,
                Occupancy = 1,
                RoomTypeId = 1
            },
            new Room
            {
                Id = 2,
                Number = "102",
                Price = 50.000,
                Availability = true,
                Occupancy = 1,
                RoomTypeId = 1
            },
            new Room
            {
                Id = 3,
                Number = "103",
                Price = 50.000,
                Availability = true,
                Occupancy = 1,
                RoomTypeId = 1
            },
            new Room
            {
                Id = 4,
                Number = "104",
                Price = 50.000,
                Availability = true,
                Occupancy = 1,
                RoomTypeId = 1
            },
            new Room
            {
                Id = 5,
                Number = "105",
                Price = 50.000,
                Availability = true,
                Occupancy = 1,
                RoomTypeId = 1
            },
            new Room
            {
                Id = 6,
                Number = "106",
                Price = 50.000,
                Availability = true,
                Occupancy = 1,
                RoomTypeId = 1
            },
            new Room
            {
                Id = 7,
                Number = "107",
                Price = 50.000,
                Availability = true,
                Occupancy = 1,
                RoomTypeId = 1
            },
            new Room
            {
                Id = 8,
                Number = "108",
                Price = 50.000,
                Availability = true,
                Occupancy = 1,
                RoomTypeId = 1
            },
            new Room
            {
                Id = 9,
                Number = "109",
                Price = 50.000,
                Availability = true,
                Occupancy = 1,
                RoomTypeId = 1
            },
            new Room
            {
                Id = 10,
                Number = "110",
                Price = 50.000,
                Availability = true,
                Occupancy = 1,
                RoomTypeId = 1
            },
            new Room
            {
                Id = 11,
                Number = "201",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 12,
                Number = "202",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 13,
                Number = "203",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 14,
                Number = "204",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 15,
                Number = "205",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 16,
                Number = "206",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 17,
                Number = "207",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 18,
                Number = "208",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 19,
                Number = "209",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 20,
                Number = "210",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 21,
                Number = "301",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 22,
                Number = "302",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 23,
                Number = "303",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 24,
                Number = "304",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 25,
                Number = "305",
                Price = 80.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 26,
                Number = "306",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 27,
                Number = "307",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 28,
                Number = "308",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 29,
                Number = "309",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 30,
                Number = "310",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 31,
                Number = "401",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 32,
                Number = "402",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 33,
                Number = "403",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 34,
                Number = "404",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 35,
                Number = "405",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 36,
                Number = "406",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 37,
                Number = "407",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 38,
                Number = "408",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 39,
                Number = "409",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 40,
                Number = "410",
                Price = 150.000,
                Availability = true,
                Occupancy = 2,
                RoomTypeId = 3
            },
            new Room
            {
                Id = 41,
                Number = "501",
                Price = 200.000,
                Availability = true,
                Occupancy = 4,
                RoomTypeId = 4
            },
            new Room
            {
                Id = 42,
                Number = "502",
                Price = 200.000,
                Availability = true,
                Occupancy = 4,
                RoomTypeId = 4
            },
            new Room
            {
                Id = 43,
                Number = "503",
                Price = 200.000,
                Availability = true,
                Occupancy = 4,
                RoomTypeId = 4
            },
            new Room
            {
                Id = 44,
                Number = "504",
                Price = 200.000,
                Availability = true,
                Occupancy = 4,
                RoomTypeId = 4
            },
            new Room
            {
                Id = 45,
                Number = "505",
                Price = 200.000,
                Availability = true,
                Occupancy = 4,
                RoomTypeId = 4
            },
            new Room
            {
                Id = 46,
                Number = "506",
                Price = 200.000,
                Availability = true,
                Occupancy = 4,
                RoomTypeId = 4
            },
            new Room
            {
                Id = 47,
                Number = "507",
                Price = 200.000,
                Availability = true,
                Occupancy = 4,
                RoomTypeId = 4
            },
            new Room
            {
                Id = 48,
                Number = "508",
                Price = 200.000,
                Availability = true,
                Occupancy = 4,
                RoomTypeId = 4
            },
            new Room
            {
                Id = 49,
                Number = "509",
                Price = 200.000,
                Availability = true,
                Occupancy = 4,
                RoomTypeId = 4
            },
            new Room
            {
                Id = 50,
                Number = "510",
                Price = 200.000,
                Availability = true,
                Occupancy = 4,
                RoomTypeId = 4
            });
    }
}
