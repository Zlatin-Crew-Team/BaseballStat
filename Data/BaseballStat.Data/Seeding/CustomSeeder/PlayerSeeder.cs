namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class PlayerSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Players.Any())
            {
                return;
            }

            var players = new Player[]
            {
                new Player
                {
                    FirstName = "Rafael",
                    LastName = "Devers",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730975716/Players/910d1ca4_mlbam_k6mwts.jpg",
                    Position = "3B",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1996,
                    TeamId = 1,
                },
                new Player
                {
                    FirstName = "Kenley",
                    LastName = "Jansen",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730654075/Players/c8f863dc_mlbam_sjdntg.jpg",
                    Position = "RP",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1987,
                    TeamId = 1,
                },
                new Player()
                {
                    FirstName = "Aaron",
                    LastName = "Judge",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730654123/Players/06c9f502_mlbam_pbvmdx.jpg",
                    Position = "RF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 2,
                },
                new Player()
                {
                    FirstName = "Gerrit",
                    LastName = "Cole",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730739497/Players/d1c6d6d7_mlbam_smyitt.jpg",
                    Position = "SP",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1990,
                    TeamId = 2,
                },
                new Player
                {
                    FirstName = "Randy",
                    LastName = "Arozarena",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730739545/Players/d3eebd0c_mlbam_whn3hd.jpg",
                    Position = "LF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1995,
                    TeamId = 3,
                },
                new Player
                {
                    FirstName = "Wander",
                    LastName = "Franco",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730739613/Players/fdd8af79_mlbam_lmtm83.jpg",
                    Position = "SS",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 2001,
                    TeamId = 3,
                },
                new Player
                {
                     FirstName = "Vladimir",
                     LastName = "Guerrero Jr.",
                     ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730739731/Players/a557a5ef_mlbam_ybbsfm.jpg",
                     Position = "1B",
                     Bats = "R",
                     Throws = "R",
                     YearOfBirth = 1999,
                     TeamId = 4,
                },
                new Player
                {
                    FirstName = "Bo",
                    LastName = "Bichette",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730739783/Players/e9e70aad_mlbam_xawlvi.jpg",
                    Position = "SS",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1998,
                    TeamId = 4,
                },
                new Player
                {
                    FirstName = "Cedric",
                    LastName = "Mullins",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730739942/Players/24bf4355_mlbam_vmasoi.jpg",
                    Position = "CF",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 5,
                },
                new Player
                {
                    FirstName = "Gunnar",
                    LastName = "Henderson",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740025/Players/298c5bf9_mlbam_cw8b5f.jpg",
                    Position = "SS",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 2001,
                    TeamId = 5,
                },
                new Player
                {
                    FirstName = "Eloy",
                    LastName = "Jimenez",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740076/Players/3847ab75_mlbam_jwce3g.jpg",
                    Position = "LF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1996,
                    TeamId = 6,
                },
                new Player
                {
                    FirstName = "Luis",
                    LastName = "Robert",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740136/Players/c115568b_mlbam_npyajw.jpg",
                    Position = "CF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1997,
                    TeamId = 6,
                },
                new Player
                {
                    FirstName = "Jose",
                    LastName = "Ramirez",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740207/Players/e3e66986_mlbam_srjcou.jpg",
                    Position = "3B",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 7,
                },
                new Player
                {
                    FirstName = "Shane",
                    LastName = "Bieber",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740281/Players/aad73d64_mlbam_yhwqls.jpg",
                    Position = "SP",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1995,
                    TeamId = 7,
                },
                new Player
                {
                    FirstName = "Tarick",
                    LastName = "Scuball",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740338/Players/1e4029ec_mlbam_bjvpsz.jpg",
                    Position = "SP",
                    Bats = "L",
                    Throws = "L",
                    YearOfBirth = 1997,
                    TeamId = 8,
                },
                new Player
                {
                    FirstName = "Riley",
                    LastName = "Greene",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740414/Players/8605b494_mlbam_pgj4dy.jpg",
                    Position = "RF",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 2000,
                    TeamId = 8,
                },
                new Player
                {
                    FirstName = "Salvador",
                    LastName = "Perez",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740450/Players/b6654965_mlbam_zl3uao.jpg",
                    Position = "C",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1990,
                    TeamId = 9,
                },
                new Player
                {
                    FirstName = "Bobby",
                    LastName = "Witt Jr.",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740698/Players/042fbc15_mlbam_qosgzx.jpg",
                    Position = "SS",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 2000,
                    TeamId = 9,
                },
                new Player
                {
                    FirstName = "Carlos",
                    LastName = "Correa",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740749/Players/33687c9b_mlbam_pxqrnb.jpg",
                    Position = "SS",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 10,
                },
                new Player
                {
                    FirstName = "Lance",
                    LastName = "McCullers Jr.",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740808/Players/4d714500_mlbam_kl1czj.jpg",
                    Position = "SP",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 10,
                },
                new Player
                {
                    FirstName = "Jose",
                    LastName = "Altuve",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740877/Players/f0e8fd62_mlbam_dwdxsf.jpg",
                    Position = "2B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1990,
                    TeamId = 11,
                },
                new Player
                {
                    FirstName = "Yordan",
                    LastName = "Alvarez",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730740912/Players/6abe077d_mlbam_vb8ela.jpg",
                    Position = "DH",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1997,
                    TeamId = 11,
                },
                new Player
                {
                    FirstName = "Mike",
                    LastName = "Trout",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741065/Players/f322d40f_mlbam_upiou4.jpg",
                    Position = "CF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1991,
                    TeamId = 12,
                },
                new Player
                {
                    FirstName = "Anthony",
                    LastName = "Rendon",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741096/Players/7f641c08_mlbam_etckwx.jpg",
                    Position = "3B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1990,
                    TeamId = 12,
                },
                new Player
                {
                    FirstName = "Miguel",
                    LastName = "Andujar",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741143/Players/199bb60b_mlbam_mf9sfa.jpg",
                    Position = "3B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1995,
                    TeamId = 13,
                },
                new Player
                {
                    FirstName = "Brent",
                    LastName = "Rooker",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741261/Players/665cc19a_mlbam_bfjqzq.jpg",
                    Position = "LF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 13,
                },
                new Player
                {
                    FirstName = "Mitch",
                    LastName = "Garver",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741473/Players/a5037e60_mlbam_zaqhip.jpg",
                    Position = "C",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1990,
                    TeamId = 14,
                },
                new Player
                {
                    FirstName = "Jorge",
                    LastName = "Polanco",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741564/Players/088d3244_mlbam_w0zcae.jpg",
                    Position = "SS",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 14,
                },
                new Player
                {
                    FirstName = "Corey",
                    LastName = "Seager",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741622/Players/73dd747b_mlbam_dlyzfp.jpg",
                    Position = "SS",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 15,
                },
                new Player
                {
                    FirstName = "Adolis",
                    LastName = "Garcia",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741679/Players/1306eb2a_mlbam_hwkweg.jpg",
                    Position = "CF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 15,
                },
                new Player
                {
                    FirstName = "Ronald",
                    LastName = "Acuna Jr.",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741720/Players/cc15ccfa_mlbam_b5wrll.jpg",
                    Position = "CF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1997,
                    TeamId = 16,
                },
                new Player
                {
                    FirstName = "Ozzie",
                    LastName = "Albies",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741755/Players/1f8df31a_mlbam_sxyuyl.jpg",
                    Position = "2B",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1997,
                    TeamId = 16,
                },
                new Player
                {
                    FirstName = "Josh",
                    LastName = "Bell",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741816/Players/e36fd0ee_mlbam_ukbuxh.jpg",
                    Position = "1B",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 17,
                },
                new Player
                {
                    FirstName = "Jesus",
                    LastName = "Luzardo",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741876/Players/9bc273c8_mlbam_eqvcli.jpg",
                    Position = "SP",
                    Bats = "L",
                    Throws = "L",
                    YearOfBirth = 1997,
                    TeamId = 17,
                },
                new Player
                {
                    FirstName = "Pete",
                    LastName = "Alonso",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730741937/Players/e4bd060e_mlbam_zqi34k.jpg",
                    Position = "1B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 18,
                },
                new Player
                {
                    FirstName = "Jacob",
                    LastName = "deGrom",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730742026/Players/a4f0935e_mlbam_qcvg4a.jpg",
                    Position = "SP",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1988,
                    TeamId = 18,
                },
                new Player
                {
                    FirstName = "Trea",
                    LastName = "Turner",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730742064/Players/7ba8f9ac_mlbam_ize19i.jpg",
                    Position = "SS",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 19,
                },
                new Player
                {
                    FirstName = "Bryce",
                    LastName = "Harper",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730742098/Players/c61e922e_mlbam_i6hyfv.jpg",
                    Position = "RF",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 19,
                },
                new Player
                {
                    FirstName = "Joey",
                    LastName = "Gallo",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730742330/Players/cd298525_mlbam_harype.jpg",
                    Position = "RF",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 20,
                },
                new Player
                {
                    FirstName = "Jesse",
                    LastName = "Winker",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730742381/Players/048070cd_mlbam_jhqd4c.jpg",
                    Position = "LF",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 20,
                },
                new Player
                {
                    FirstName = "Cody",
                    LastName = "Bellinger",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730742451/Players/32775691_mlbam_kgum8j.jpg",
                    Position = "CF",
                    Bats = "L",
                    Throws = "L",
                    YearOfBirth = 1995,
                    TeamId = 21,
                },
                new Player
                {
                    FirstName = "Ian",
                    LastName = "Happ",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730742508/Players/cbe72712_mlbam_jngq1c.jpg",
                    Position = "CF",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 21,
                },
                new Player
                {
                    FirstName = "Elly",
                    LastName = "De La Cruz",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730742602/Players/f0540df0_mlbam_qlnu1x.jpg",
                    Position = "RF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1996,
                    TeamId = 22,
                },
                new Player
                {
                    FirstName = "Jonathan",
                    LastName = "India",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730742648/Players/d19b960b_mlbam_nwgouq.jpg",
                    Position = "2B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1996,
                    TeamId = 22,
                },
                new Player
                {
                    FirstName = "Cristian",
                    LastName = "Yelich",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730742803/Players/76d9fda9_mlbam_zwx3kp.jpg",
                    Position = "LF",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1991,
                    TeamId = 23,
                },
                new Player
                {
                    FirstName = "Brandon",
                    LastName = "Woodruff",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730742848/Players/5091436e_mlbam_oryvbv.jpg",
                    Position = "SP",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 23,
                },
                new Player
                {
                    FirstName = "Paul",
                    LastName = "Skenes",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730825969/Players/2e7ed9f9_mlbam_z7c1wl.jpg",
                    Position = "SP",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 2002,
                    TeamId = 24,
                },
                new Player
                {
                    FirstName = "Ke'Bryan",
                    LastName = "Hayes",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730826051/Players/3a2bfaab_mlbam_slfa2h.jpg",
                    Position = "3B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1997,
                    TeamId = 24,
                },
                new Player
                {
                    FirstName = "Nolan",
                    LastName = "Arenado",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730826094/Players/4009314f_mlbam_vg4naz.jpg",
                    Position = "3B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1991,
                    TeamId = 25,
                },
                new Player
                {
                    FirstName = "Paul",
                    LastName = "Goldschmidt",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730826135/Players/6b37a7f2_mlbam_znxu1d.jpg",
                    Position = "1B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1987,
                    TeamId = 25,
                },
                new Player
                {
                    FirstName = "Zack",
                    LastName = "Galen",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730826195/Players/f76307d1_mlbam_jcsl2w.jpg",
                    Position = "SP",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1995,
                    TeamId = 26,
                },
                new Player
                {
                    FirstName = "Ketel",
                    LastName = "Marte",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730826232/Players/d70d4384_mlbam_awzaqo.jpg",
                    Position = "2B",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 26,
                },
                new Player
                {
                    FirstName = "Ryan",
                    LastName = "McMahon",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730826296/Players/6731e251_mlbam_url5pu.jpg",
                    Position = "2B",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 27,
                },
                new Player
                {
                    FirstName = "Charlie",
                    LastName = "Blackmon",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730826344/Players/12154e57_mlbam_vhwjvg.jpg",
                    Position = "RF",
                    Bats = "L",
                    Throws = "L",
                    YearOfBirth = 1986,
                    TeamId = 27,
                },
                new Player
                {
                    FirstName = "Mookie",
                    LastName = "Betts",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730826389/Players/f3a0cc68_mlbam_hko53b.jpg",
                    Position = "RF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 28,
                },
                new Player
                {
                    FirstName = "Clayton",
                    LastName = "Kershaw",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730826468/Players/0caa3053_mlbam_tfop8p.jpg",
                    Position = "SP",
                    Bats = "L",
                    Throws = "L",
                    YearOfBirth = 1988,
                    TeamId = 28,
                },
                new Player
                {
                    FirstName = "Shohei",
                    LastName = "Ohtani",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730826508/Players/270bfa31_mlbam_ylnajr.jpg",
                    Position = "DH",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 28,
                },
                new Player
                {
                    FirstName = "Fernando",
                    LastName = "Tatis Jr.",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730826552/Players/38faa7ea_mlbam_spmbeb.jpg",
                    Position = "SS",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1999,
                    TeamId = 29,
                },
                new Player
                {
                    FirstName = "Manny",
                    LastName = "Machado",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730826595/Players/45d62ce6_mlbam_elxlfh.jpg",
                    Position = "3B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 29,
                },
                new Player
                {
                    FirstName = "Matt",
                    LastName = "Chapman",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731514986/Players/f4e771ca_mlbam_x8xllq.jpg",
                    Position = "3B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 30,
                },
                new Player
                {
                     FirstName = "Michael",
                     LastName = "Conforto",
                     ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731514952/Players/8b2cf761_mlbam_qpusjk.jpg",
                     Position = "RF",
                     Bats = "L",
                     Throws = "R",
                     YearOfBirth = 1993,
                     TeamId = 30,
                },
            };
            foreach (var player in players)
            {
                await dbContext.AddAsync(player);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
