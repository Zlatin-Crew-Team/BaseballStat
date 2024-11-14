namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;
    using BaseballStat.Web.ViewModels.PlayerStatistic;
    using Microsoft.EntityFrameworkCore;

    public class PlayerStatisticSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.PlayerStatistics.Any())
            {
                return;
            }

            var playerStatistics = new PlayerStatistic[]
            {
                new PlayerStatistic
                {
                    PlayerId = 1,
                    Games = 980,
                    AtBats = 4215,
                    Runs = 616,
                    Hits = 1062,
                    Doubles = 255,
                    Triples = 12,
                    HomeRuns = 200,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731343690/Players/tampa-fl-rafael-devers-of-the-boston-red-sox-fields-the-ball-for-an-out-in-the-fifth-inning_mjzydp.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 2,
                    Games = 1245,
                    AtBats = 410,
                    Runs = 3,
                    Hits = 12,
                    Doubles = 1,
                    Triples = 1,
                    HomeRuns = 1,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731343857/Players/baltimore-md-kenley-jansen-of-the-boston-red-sox-pitches-during-the-game-between-the-boston_rzgqxw.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 3,
                    Games = 993,
                    AtBats = 4323,
                    Runs = 736,
                    Hits = 1026,
                    Doubles = 173,
                    Triples = 5,
                    HomeRuns = 315,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731344591/Players/new-york-new-york-aaron-judge-of-the-new-york-yankees-in-action-against-the-boston-red-sox-at_fj1fjx.jpg",
                },
                new PlayerStatistic
                {
                     PlayerId = 4,
                     Games = 1024,
                     AtBats = 212,
                     Runs = 10,
                     Hits = 14,
                     Doubles = 1,
                     Triples = 1,
                     HomeRuns = 1,
                     ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731344721/Players/kansas-city-missouri-gerrit-cole-of-the-new-york-yankees-reacts-during-the-seventh-inning_axzhyr.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 5,
                    Games = 641,
                    AtBats = 2550,
                    Runs = 357,
                    Hits = 583,
                    Doubles = 128,
                    Triples = 9,
                    HomeRuns = 9,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731344915/Players/toronto-canada-randy-arozarena-of-the-tampa-bay-rays-at-bat-during-of-their-mlb-game-against_dt2h7a.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 6,
                    Games = 265,
                    AtBats = 1143,
                    Runs = 164,
                    Hits = 292,
                    Doubles = 61,
                    Triples = 14,
                    HomeRuns = 30,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731345672/Players/st-petersburg-florida-wander-franco-of-the-tampa-bay-rays-looks-on-during-the-fifth-inning_yft1wm.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 7,
                    Games = 1245,
                    AtBats = 410,
                    Runs = 3,
                    Hits = 12,
                    Doubles = 1,
                    Triples = 1,
                    HomeRuns = 1,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731345620/Players/toronto-on-vladimir-guerrero-jr-27-of-toronto-blue-jays-celebrates-a-double-against-the_of4rld.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 8,
                    Games = 609,
                    AtBats = 2664,
                    Runs = 360,
                    Hits = 723,
                    Doubles = 146,
                    Triples = 7,
                    HomeRuns = 93,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731345882/Players/toronto-on-bo-bichette-of-the-toronto-blue-jays-runs-onto-the-field-prior-to-a-game-against_bj3bwn.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 9,
                    Games = 693,
                    AtBats = 2719,
                    Runs = 346,
                    Hits = 614,
                    Doubles = 121,
                    Triples = 20,
                    HomeRuns = 86,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731346137/Players/baltimore-maryland-cedric-mullins-of-the-baltimore-orioles-bats-against-the-san-francisco_zecgmx.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 10,
                    Games = 343,
                    AtBats = 1473,
                    Runs = 230,
                    Hits = 350,
                    Doubles = 67,
                    Triples = 17,
                    HomeRuns = 69,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731346180/Players/new-york-new-york-gunnar-henderson-of-the-baltimore-orioles-in-action-against-the-new-york_vgx1tx.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 11,
                    Games = 534,
                    AtBats = 1966,
                    Runs = 233,
                    Hits = 528,
                    Doubles = 91,
                    Triples = 2,
                    HomeRuns = 95,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731346469/Players/new-york-new-york-eloy-jim_C3_A9nez-of-the-chicago-white-sox-in-action-against-the-new-york_px3ylg.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 12,
                    Games = 467,
                    AtBats = 1796,
                    Runs = 266,
                    Hits = 480,
                    Doubles = 103,
                    Triples = 2,
                    HomeRuns = 88,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731346510/Players/chicago-illinois-luis-robert-jr-88-of-the-chicago-white-sox-runs-the-bases-against-the-los_jdrh25.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 13,
                    Games = 1451,
                    AtBats = 5377,
                    Runs = 898,
                    Hits = 1500,
                    Doubles = 364,
                    Triples = 40,
                    HomeRuns = 255,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731346675/Players/cleveland-ohio-jose-ramirez-of-the-cleveland-guardians-hits-a-rbi-double-in-the-seventh_fffqxi.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 14,
                    Games = 1102,
                    AtBats = 125,
                    Runs = 3,
                    Hits = 12,
                    Doubles = 1,
                    Triples = 1,
                    HomeRuns = 1,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731346710/Players/oakland-ca-shane-bieber-of-the-cleveland-guardians-pitches-during-the-game-between-the_pdsjoc.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 15,
                    Games = 38,
                    AtBats = 13,
                    Runs = 1,
                    Hits = 1,
                    Doubles = 1,
                    Triples = 1,
                    HomeRuns = 1,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731429565/Players/houston-texas-tarik-skubal-of-the-detroit-tigers-reacts-recording-a-strikeout-against-the_thuvil.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 16,
                    Games = 329,
                    AtBats = 1266,
                    Runs = 179,
                    Hits = 338,
                    Doubles = 64,
                    Triples = 14,
                    HomeRuns = 40,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731429659/Players/houston-texas-riley-greene-of-the-detroit-tigers-attempts-to-catch-a-double-hit-by-yordan_ygeazx.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 17,
                    Games = 152,
                    AtBats = 5880,
                    Runs = 656,
                    Hits = 1571,
                    Doubles = 285,
                    Triples = 11,
                    HomeRuns = 273,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731429779/Players/new-york-new-york-salvador-perez-of-the-kansas-city-royals-celebrates-after-hitting-a-solo_j9xltc.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 18,
                    Games = 469,
                    AtBats = 1868,
                    Runs = 304,
                    Hits = 538,
                    Doubles = 104,
                    Triples = 28,
                    HomeRuns = 82,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731429824/Players/baltimore-maryland-bobby-witt-jr-7-of-the-kansas-city-royals-celebrates-after-the-final-out_pvuc3e.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 19,
                    Games = 1109,
                    AtBats = 4179,
                    Runs = 623,
                    Hits = 1150,
                    Doubles = 235,
                    Triples = 13,
                    HomeRuns = 187,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731430395/Players/minneapolis-mn-carlos-correa-of-the-minnesota-twins-looks-on-against-the-miami-marlins-on_livof1.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 20,
                    Games = 125,
                    AtBats = 11,
                    Runs = 1,
                    Hits = 1,
                    Doubles = 1,
                    Triples = 1,
                    HomeRuns = 1,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731430637/Players/houston-texas-lance-mccullers-jr-43-of-the-houston-astros-watches-from-the-dugout-in-the_aa1zse.jpg",
                },
                new PlayerStatistic
                {
                    PlayerId = 21,
                    Games = 1821,
                    AtBats = 7293,
                    Runs = 1156,
                    Hits = 2232,
                    Doubles = 431,
                    Triples = 31,
                    HomeRuns = 229,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731430606/Players/houston-tx-jose-altuve-of-the-houston-astros-runs-to-first-base-during-game-2-of-the-wild_zdxqca.jpg",
                },
                new PlayerStatistic
                    {
                        PlayerId = 22,
                        Games = 629,
                        AtBats = 2290,
                        Runs = 412,
                        Hits = 683,
                        Doubles = 140,
                        Triples = 6,
                        HomeRuns = 164,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731430694/Players/houston-texas-yordan-alvarez-of-the-houston-astros-bats-in-the-first-inning-against-the-los_rk4yyn.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 23,
                        Games = 1518,
                        AtBats = 5511,
                        Runs = 1123,
                        Hits = 1648,
                        Doubles = 311,
                        Triples = 54,
                        HomeRuns = 378,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731430924/Players/boston-massachusetts-mike-trout-of-the-los-angeles-angels-runs-up-the-first-base-line-after_gqye03.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 24,
                        Games = 1173,
                        AtBats = 4350,
                        Runs = 683,
                        Hits = 1218,
                        Doubles = 295,
                        Triples = 16,
                        HomeRuns = 158,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731431092/Players/anaheim-california-anthony-rendon-of-the-los-angeles-angels-at-bat-during-the-seventh-inning_oy2pjn.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 25,
                        Games = 373,
                        AtBats = 1361,
                        Runs = 161,
                        Hits = 372,
                        Doubles = 79,
                        Triples = 5,
                        HomeRuns = 43,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731431258/Players/oakland-california-miguel-andujar-of-the-oakland-athletics-looks-on-running-off-the-field_hvm2zr.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 26,
                        Games = 363,
                        AtBats = 1249,
                        Runs = 173,
                        Hits = 322,
                        Doubles = 59,
                        Triples = 3,
                        HomeRuns = 79,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731431310/Players/oakland-california-brent-rooker-of-the-oakland-athletics-bats-against-the-new-york-yankees-in_xymocm.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 27,
                        Games = 567,
                        AtBats = 1789,
                        Runs = 255,
                        Hits = 422,
                        Doubles = 87,
                        Triples = 6,
                        HomeRuns = 97,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731431944/Players/houston-texas-mitch-garver-of-the-seattle-mariners-bats-in-the-third-inning-against-the_ef7z6z.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 28,
                        Games = 950,
                        AtBats = 3573,
                        Runs = 486,
                        Hits = 938,
                        Doubles = 192,
                        Triples = 20,
                        HomeRuns = 128,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731431991/Players/arlington-tx-jorge-polanco-of-the-seattle-mariners-singles-against-the-texas-rangers-during_qkplox.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 29,
                        Games = 1029,
                        AtBats = 3964,
                        Runs = 641,
                        Hits = 1151,
                        Doubles = 251,
                        Triples = 13,
                        HomeRuns = 200,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731432138/Players/chicago-illinois-corey-seager-of-the-texas-rangers-hits-an-rbi-single-in-the-ninth-inning_yaohp4.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 30,
                        Games = 631,
                        AtBats = 2344,
                        Runs = 344,
                        Hits = 560,
                        Doubles = 117,
                        Triples = 7,
                        HomeRuns = 122,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731432175/Players/anaheim-california-adolis-garc_C3_ADa-of-the-texas-rangers-at-bat-during-the-sixth-inning-against_i4xzrb.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 31,
                        Games = 722,
                        AtBats = 2818,
                        Runs = 581,
                        Hits = 815,
                        Doubles = 145,
                        Triples = 12,
                        HomeRuns = 165,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731432709/Players/anaheim-california-ronald-acu_C3_B1a-jr-13-of-the-atlanta-braves-looks-on-during-the-fourth_nlr2ya.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 32,
                        Games = 871,
                        AtBats = 3485,
                        Runs = 549,
                        Hits = 941,
                        Doubles = 212,
                        Triples = 31,
                        HomeRuns = 141,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731432743/Players/atlanta-ga-ozzie-albies-of-the-atlanta-braves-reaches-second-on-a-fielding-error-in-the_rg8dsp.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 33,
                        Games = 1147,
                        AtBats = 4035,
                        Runs = 550,
                        Hits = 1042,
                        Doubles = 209,
                        Triples = 19,
                        HomeRuns = 171,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731433096/Players/detroit-mi-josh-bell-of-the-cleveland-guardians-walks-through-the-dugout-in-the-ninth-inning_kxunkb.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 34,
                        Games = 124,
                        AtBats = 45,
                        Runs = 1,
                        Hits = 1,
                        Doubles = 1,
                        Triples = 1,
                        HomeRuns = 1,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731433135/Players/miami-florida-jesus-luzardo-of-the-miami-marlins-pitches-against-the-philadelphia-phillies_kduhbv.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 35,
                        Games = 846,
                        AtBats = 3139,
                        Runs = 493,
                        Hits = 781,
                        Doubles = 142,
                        Triples = 7,
                        HomeRuns = 226,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731433266/Players/new-york-new-york-pete-alonso-of-the-new-york-mets-watches-after-hitting-a-three-run-home-run_a3vd4s.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 36,
                        Games = 156,
                        AtBats = 1,
                        Runs = 1,
                        Hits = 1,
                        Doubles = 1,
                        Triples = 1,
                        HomeRuns = 3,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731433312/Players/anaheim-california-jacob-degrom-of-the-texas-rangers-pitches-in-the-first-inning-against-the_vmqknm.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 37,
                        Games = 1125,
                        AtBats = 4568,
                        Runs = 776,
                        Hits = 1352,
                        Doubles = 251,
                        Triples = 41,
                        HomeRuns = 171,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731508344/Players/philadelphia-pennsylvania-trea-turner-of-the-philadelphia-phillies-reacts-with-teammates_oxrwje.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 38,
                        Games = 1653,
                        AtBats = 5934,
                        Runs = 1082,
                        Hits = 1670,
                        Doubles = 369,
                        Triples = 24,
                        HomeRuns = 336,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731508394/Players/washington-dc-bryce-harper-of-the-philadelphia-phillies-at-bat-against-the-washington_isyjce.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 39,
                        Games = 939,
                        AtBats = 2869,
                        Runs = 463,
                        Hits = 557,
                        Doubles = 107,
                        Triples = 10,
                        HomeRuns = 208,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731508600/Players/washington-dc-joey-gallo-of-the-washington-nationals-bats-against-the-kansas-city-royals_nxuilq.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 40,
                        Games = 755,
                        AtBats = 2364,
                        Runs = 344,
                        Hits = 620,
                        Doubles = 122,
                        Triples = 3,
                        HomeRuns = 95,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731508640/Players/los-angeles-ca-jesse-winker-of-the-new-york-mets-is-walked-in-the-first-inning-during-game-6_h25h4w.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 41,
                        Games = 1005,
                        AtBats = 3542,
                        Runs = 601,
                        Hits = 942,
                        Doubles = 186,
                        Triples = 23,
                        HomeRuns = 196,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731508927/Players/chicago-illinois-cody-bellinger-of-the-chicago-cubs-at-bat-against-the-cincinnati-reds-at_rhtj1v.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 42,
                        Games = 989,
                        AtBats = 3276,
                        Runs = 480,
                        Hits = 812,
                        Doubles = 185,
                        Triples = 16,
                        HomeRuns = 150,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731509050/Players/chicago-illinois-ian-happ-of-the-chicago-cubs-in-action-against-the-cincinnati-reds-at_amc9dr.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 43,
                        Games = 258,
                        AtBats = 1006,
                        Runs = 172,
                        Hits = 251,
                        Doubles = 51,
                        Triples = 17,
                        HomeRuns = 38,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731509237/Players/chicago-illinois-elly-de-la-cruz-of-the-cincinnati-reds-in-action-against-the-chicago-cubs-at_xnywqu.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 44,
                        Games = 523,
                        AtBats = 1905,
                        Runs = 308,
                        Hits = 482,
                        Doubles = 101,
                        Triples = 6,
                        HomeRuns = 63,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731432175/Players/anaheim-california-adolis-garc_C3_ADa-of-the-texas-rangers-at-bat-during-the-sixth-inning-against_i4xzrb.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 45,
                        Games = 1466,
                        AtBats = 5535,
                        Runs = 945,
                        Hits = 1590,
                        Doubles = 306,
                        Triples = 35,
                        HomeRuns = 204,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731512227/Players/milwaukee-wisconsin-christian-yelich-of-the-milwaukee-brewers-up-to-bat-against-the_os8bp3.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 46,
                        Games = 152,
                        AtBats = 145,
                        Runs = 2,
                        Hits = 2,
                        Doubles = 1,
                        Triples = 1,
                        HomeRuns = 1,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731512265/Players/milwaukee-wisconsin-brandon-woodruff-of-the-milwaukee-brewers-pitches-in-the-first-inning_lpk3mr.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 47,
                        Games = 28,
                        AtBats = 15,
                        Runs = 1,
                        Hits = 1,
                        Doubles = 1,
                        Triples = 1,
                        HomeRuns = 1,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731512418/Players/cincinnati-ohio-paul-skenes-of-the-pittsburgh-pirates-pitches-in-the-second-inning-against_rq9bdz.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 48,
                        Games = 476,
                        AtBats = 1972,
                        Runs = 224,
                        Hits = 467,
                        Doubles = 91,
                        Triples = 4,
                        HomeRuns = 37,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731512456/Players/pittsburgh-pa-kebryan-hayes-of-the-pittsburgh-pirates-hits-an-rbi-single-in-the-first-inning_uerhuz.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 49,
                        Games = 1680,
                        AtBats = 6406,
                        Runs = 944,
                        Hits = 1826,
                        Doubles = 387,
                        Triples = 33,
                        HomeRuns = 341,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731512634/Players/san-francisco-california-nolan-arenado-of-the-st-louis-cardinals-throws-for-an-out-at-oracle_oisgje.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 50,
                        Games = 1928,
                        AtBats = 7119,
                        Runs = 1204,
                        Hits = 2056,
                        Doubles = 446,
                        Triples = 23,
                        HomeRuns = 362,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731512671/Players/toronto-canada-paul-goldschmidt-of-the-st-louis-cardinals-takes-an-at-bat-against-the-toronto_ghlgrl.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 51,
                        Games = 126,
                        AtBats = 1,
                        Runs = 1,
                        Hits = 1,
                        Doubles = 1,
                        Triples = 1,
                        HomeRuns = 1,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731514249/Players/san-francisco-california-zac-gallen-of-the-arizona-diamondbacks-pitches-against-the-san_j7aaqz.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 52,
                        Games = 1104,
                        AtBats = 4054,
                        Runs = 601,
                        Hits = 1137,
                        Doubles = 1242,
                        Triples = 43,
                        HomeRuns = 143,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731514288/Players/milwaukee-wisconsin-ketel-marte-of-the-arizona-diamondbacks-hits-a-two-run-homer-in-the-ninth_q5wlj5.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 53,
                        Games = 910,
                        AtBats = 3032,
                        Runs = 407,
                        Hits = 736,
                        Doubles = 152,
                        Triples = 10,
                        HomeRuns = 124,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731514379/Players/denver-colorado-ryan-mcmahon-of-the-colorado-rockies-hits-a-rbi-double-against-the-st-louis_optnon.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 54,
                        Games = 1624,
                        AtBats = 6825,
                        Runs = 996,
                        Hits = 1805,
                        Doubles = 334,
                        Triples = 68,
                        HomeRuns = 227,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731514434/Players/denver-colorado-charlie-blackmon-of-the-colorado-rockies-hits-a-single-against-the-st-louis_o3wsli.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 55,
                        Games = 1381,
                        AtBats = 5394,
                        Runs = 1071,
                        Hits = 1615,
                        Doubles = 371,
                        Triples = 39,
                        HomeRuns = 271,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731515049/Players/new-york-new-york-mookie-betts-of-the-los-angeles-dodgers-celebrates-a-two-run-home-run_x7uwcs.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 56,
                        Games = 431,
                        AtBats = 23,
                        Runs = 34,
                        Hits = 56,
                        Doubles = 11,
                        Triples = 7,
                        HomeRuns = 1,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731515093/Players/st-louis-missouri-clayton-kershaw-of-the-los-angeles-dodgers-delivers-a-pitch-against-the-st_vxnxth.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 57,
                        Games = 860,
                        AtBats = 3119,
                        Runs = 562,
                        Hits = 878,
                        Doubles = 167,
                        Triples = 36,
                        HomeRuns = 225,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731515214/Players/los-angeles-california-shohei-ohtani-of-the-los-angeles-dodgers-reacts-after-hitting-a-double_ezxzkr.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 58,
                        Games = 516,
                        AtBats = 2009,
                        Runs = 365,
                        Hits = 561,
                        Doubles = 109,
                        Triples = 10,
                        HomeRuns = 127,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731515309/Players/san-diego-california-fernando-tatis-jr-23-of-the-san-diego-padres-tosses-his-bat-after_jp8ct2.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 59,
                        Games = 1735,
                        AtBats = 7517,
                        Runs = 991,
                        Hits = 1900,
                        Doubles = 363,
                        Triples = 18,
                        HomeRuns = 342,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731515355/Players/los-angeles-california-manny-machado-of-the-san-diego-padres-flies-out-against-the-los_cj12q9.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 60,
                        Games = 1022,
                        AtBats = 3713,
                        Runs = 585,
                        Hits = 896,
                        Doubles = 230,
                        Triples = 21,
                        HomeRuns = 182,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731515397/Players/phoenix-arizona-matt-chapman-of-the-san-francisco-giants-gets-ready-to-make-a-play-against_wrinkb.jpg",
                    },
                new PlayerStatistic
                    {
                        PlayerId = 61,
                        Games = 1012,
                        AtBats = 3395,
                        Runs = 514,
                        Hits = 851,
                        Doubles = 182,
                        Triples = 7,
                        HomeRuns = 167,
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731515433/Players/san-francisco-california-michael-conforto-of-the-san-francisco-giants-celebrates-his-single_ifxe2e.jpg",
                    },
            };
            foreach (var playerStatistic in playerStatistics)
            {
                await dbContext.PlayerStatistics.AddAsync(playerStatistic);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
