namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class AllTimeGreatsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
           if (dbContext.AllTimeGreats.Any())
            {
                return;
            }

           var allTimeGreats = new AllTimeGreat[]
            {
                new AllTimeGreat
                {
                    Name = "Babe Ruth",
                    Bio = "George Herman Ruth Jr. was an American professional baseball player whose career in Major League Baseball spanned 22 seasons, from 1914 through 1935.",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732454826/Players/american-baseball-player-george-herman-ruth-known-as-babe-ruth_bg9xyp.jpg",
                    CategoryId = 2,
                },
                new AllTimeGreat
                {
                    Name = "Ted Williams",
                    Bio = "Theodore Samuel Williams was an American professional baseball player and manager. He played his entire 19-year Major League Baseball career as a left fielder for the Boston Red Sox from 1939 to 1960.",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732454901/Players/sarasota-fl-outfielder-ted-williams-of-the-boston-red-sox-poses-for-an-action-portrait-during-a_vnnbuu.jpg",
                    CategoryId = 2,
                },
                new AllTimeGreat
                {
                    Name = "Hank Aaron",
                    Bio = "Henry Louis Aaron, nicknamed 'Hammer' or 'Hammerin' Hank', was an American professional baseball right fielder who played 23 seasons in Major League Baseball, from 1954 through 1976.",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732454973/Players/hank-aaron-is-shown-in-this-close-up-he-is-shown-as-an-atlanta-braves-outfielder-during-spring_plv9q9.jpg",
                    CategoryId = 2,
                },
                new AllTimeGreat
                {
                    Name = "Willie Mays",
                    Bio = "Willie Howard Mays Jr., nicknamed 'The Say Hey Kid', is an American former professional baseball center fielder who spent almost all of his 22-season Major League Baseball career playing for the New York/San Francisco Giants, before finishing with the New York Mets.",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732455086/Players/american-baseball-player-willie-mays-of-the-new-york-giants-holds-his-bat-here-in-this-three_flchpk.jpg",
                    CategoryId = 2,
                },
                new AllTimeGreat
                {
                    Name = "Mickey Mantle",
                    Bio = "Mickey Charles Mantle, nicknamed 'The Commerce Comet' and 'The Mick', was an American professional baseball player. Mantle played his entire Major League Baseball career with the New York Yankees as a center fielder, first baseman, and right fielder.",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732455214/Players/american-baseball-player-mickey-mantle-of-the-new-york-yankees-at-yankee-stadium-new-york_iygdzo.jpg6",
                    CategoryId = 2,
                },
                new AllTimeGreat
                {
                    Name = "Sandy Koufax",
                    Bio = "Sanford Koufax is a former American Major League Baseball left-handed pitcher. He pitched 12 seasons for the Brooklyn/Los Angeles Dodgers, from 1955 to 1966.",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732455285/Players/sandy-koufax-of-the-dodgers-during-spring-training_gd2ga0.jpg",
                    CategoryId = 2,
                },
            };

           foreach (var allTimeGreat in allTimeGreats)
            {
                await dbContext.AllTimeGreats.AddAsync(allTimeGreat);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
