using Data.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace WebUI.Models
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<Context>();

                if (context == null) return;

                // context.Database.Migrate(); // Ensure database is created/migrated

                if (!context.Sliders.Any())
                {
                    context.Sliders.AddRange(
                        new Slider
                        {
                            SliderTitle = "Doğanın Kalbine Yolculuk",
                            SliderSubTitle = "Dünyanın en güzel manzaralarını keşfedin.",
                            SliderImage = "/Template/images/banner1.jpg"
                        },
                        new Slider
                        {
                            SliderTitle = "Unutulmaz Anlar",
                            SliderSubTitle = "Sevdiklerinizle birlikte eşsiz deneyimler yaşayın.",
                            SliderImage = "/Template/images/banner2.jpg"
                        },
                        new Slider
                        {
                            SliderTitle = "Macera Seni Bekliyor",
                            SliderSubTitle = "Yeni yerler, yeni kültürler ve yeni sen.",
                            SliderImage = "/Template/images/banner3.jpg"
                        }
                    );
                    context.SaveChanges();
                }

                if (!context.Destinations.Any())
                {
                    context.Destinations.AddRange(
                        new Destination
                        {
                            DestinationCity = "Paris",
                            DestinationDayNight = "3 Gün 4 Gece",
                            DestinationPrice = 1200,
                            DestinationImage = "/Template/images/g1.jpg",
                            DestinationDescription = "Aşk şehri Paris'te romantik bir kaçamak yapın. Eyfel Kulesi, Louvre Müzesi ve daha fazlası.",
                            DestinationSubTitle = "Fransa'nın İncisi",
                            DestinationStatus = true,
                            DestinationCapacity = 50
                        },
                         new Destination
                         {
                             DestinationCity = "Londra",
                             DestinationDayNight = "5 Gün 6 Gece",
                             DestinationPrice = 1500,
                             DestinationImage = "/Template/images/g2.jpg",
                             DestinationDescription = "Tarih ve modernizmin iç içe geçtiği Londra sokaklarını keşfedin.",
                             DestinationSubTitle = "İngiltere'nin Başkenti",
                             DestinationStatus = true,
                             DestinationCapacity = 40
                         },
                         new Destination
                         {
                             DestinationCity = "İstanbul",
                             DestinationDayNight = "2 Gün 3 Gece",
                             DestinationPrice = 800,
                             DestinationImage = "/Template/images/g3.jpg",
                             DestinationDescription = "Kıtaların buluştuğu eşsiz şehir İstanbul.",
                             DestinationSubTitle = "Medeniyetler Beşiği",
                             DestinationStatus = true,
                             DestinationCapacity = 100
                         },
                         new Destination
                         {
                             DestinationCity = "Roma",
                             DestinationDayNight = "4 Gün 5 Gece",
                             DestinationPrice = 1300,
                             DestinationImage = "/Template/images/g4.jpg",
                             DestinationDescription = "Antik Roma'nın izinde tarihi bir yolculuk.",
                             DestinationSubTitle = "İtalya'nın Ruhu",
                             DestinationStatus = true,
                             DestinationCapacity = 60
                         }
                    );
                    context.SaveChanges();
                }

                if (!context.Destinations.Any(x => x.DestinationCity == "Kapadokya"))
                {
                    context.Destinations.AddRange(
                        new Destination
                        {
                            DestinationCity = "Kapadokya",
                            DestinationDayNight = "3 Gün 4 Gece",
                            DestinationPrice = 900,
                            DestinationImage = "/Template/images/g5.jpg",
                            DestinationDescription = "Peribacalarının büyüleyici atmosferinde balon turu.",
                            DestinationSubTitle = "Masallar Diyarı",
                            DestinationStatus = true,
                            DestinationCapacity = 45
                        },
                        new Destination
                        {
                            DestinationCity = "Tokyo",
                            DestinationDayNight = "6 Gün 7 Gece",
                            DestinationPrice = 2500,
                            DestinationImage = "/Template/images/g6.jpg",
                            DestinationDescription = "Teknoloji ve geleneğin muhteşem uyumu.",
                            DestinationSubTitle = "Uzak Doğu'nun Kalbi",
                            DestinationStatus = true,
                            DestinationCapacity = 30
                        },
                        new Destination
                        {
                            DestinationCity = "New York",
                            DestinationDayNight = "5 Gün 6 Gece",
                            DestinationPrice = 2200,
                            DestinationImage = "/Template/images/g7.jpg",
                            DestinationDescription = "Hiç uyumayan şehirde unutulmaz bir macera.",
                            DestinationSubTitle = "Özgürlük Şehri",
                            DestinationStatus = true,
                            DestinationCapacity = 40
                        },
                         new Destination
                         {
                             DestinationCity = "Dubai",
                             DestinationDayNight = "4 Gün 5 Gece",
                             DestinationPrice = 1800,
                             DestinationImage = "/Template/images/g8.jpg",
                             DestinationDescription = "Lüks ve ihtişamın çölle buluştuğu nokta.",
                             DestinationSubTitle = "Geleceğin Şehri",
                             DestinationStatus = true,
                             DestinationCapacity = 50
                         },
                        new Destination
                        {
                            DestinationCity = "Barselona",
                            DestinationDayNight = "4 Gün 5 Gece",
                            DestinationPrice = 1400,
                            DestinationImage = "/Template/images/g9.jpg",
                            DestinationDescription = "Gaudi'nin eserleriyle dolu renkli bir Akdeniz rüyası.",
                            DestinationSubTitle = "İspanya'nın İncisi",
                            DestinationStatus = true,
                            DestinationCapacity = 60
                        }
                    );
                    context.SaveChanges();
                }

                if (!context.Banners.Any())
                {
                    context.Banners.Add(new Banner
                    {
                        BannerTitle = "İndirimli Kış Turları",
                        BannerDescription = "Kış sezonuna özel %20 indirim fırsatını kaçırmayın. Hemen rezervasyon yapın!",
                        BannerImage = "/Template/images/banner4.jpg"
                    });
                    context.SaveChanges();
                }

                if (!context.Abouts.Any())
                {
                    context.Abouts.Add(new About
                    {
                        AboutTitle = "Biz Kimiz?",
                        AboutDescription = "Traversal olarak 10 yılı aşkın süredir müşterilerimize en kaliteli seyahat deneyimini sunuyoruz.",
                        AboutImage = "/Template/images/img-sprite.png", // Or maybe a generic image
                        AboutTitle2 = "Vizyonumuz",
                        AboutDescription2 = "Dünyanın her yerine güvenle seyahat etmenizi sağlamak."
                    });
                    context.SaveChanges();
                }

                if (!context.Testimonials.Any())
                {
                    context.Testimonials.AddRange(
                        new Testimonial
                        {
                            TestimonialFullname = "Ahmet Yılmaz",
                            TestimonialComment = "Harika bir tatildi, her şey çok organizeydi. Teşekkürler!",
                            TestimonialImage = "/Template/images/team1.jpg"
                        },
                        new Testimonial
                        {
                            TestimonialFullname = "Ayşe Demir",
                            TestimonialComment = "Rehberimiz çok bilgiliydi, çok keyif aldık.",
                            TestimonialImage = "/Template/images/team2.jpg"
                        },
                        new Testimonial
                        {
                            TestimonialFullname = "Mehmet Öz",
                            TestimonialComment = "Fiyat performans olarak mükemmel bir turdu.",
                            TestimonialImage = "/Template/images/team3.jpg"
                        }
                    );
                    context.SaveChanges();
                }


                if (!context.Teams.Any())
                {
                    context.Teams.AddRange(
                        new Team
                        {
                            TeamFullname = "Elif Kaya",
                            TeamDescription = "Kültür turları uzmanı, 5 yıllık deneyim.",
                            TeamImage = "/Template/images/team4.jpg",
                            TeamTwitterUrl = "https://twitter.com/elifkaya",
                            TeamInstagramUrl = "https://instagram.com/elifkaya",
                            TeamStatus = true
                        },
                        new Team
                        {
                            TeamFullname = "Can Yıldız",
                            TeamDescription = "Doğa ve macera turları rehberi.",
                            TeamImage = "/Template/images/team5.jpg",
                            TeamTwitterUrl = "https://twitter.com/canyildiz",
                            TeamInstagramUrl = "https://instagram.com/canyildiz",
                            TeamStatus = true
                        },
                          new Team
                          {
                              TeamFullname = "Zeynep Çelik",
                              TeamDescription = "Tarih ve sanat tarihi uzmanı.",
                              TeamImage = "/Template/images/team1.jpg", // Reusing existing image if needed or placeholder
                              TeamTwitterUrl = "https://twitter.com/zeynepcelik",
                              TeamInstagramUrl = "https://instagram.com/zeynepcelik",
                              TeamStatus = true
                          }
                    );
                    context.SaveChanges();
                }

                if (!context.Rooms.Any())
                {
                    context.Rooms.AddRange(
                        new Room
                        {
                            RoomTitle = "Standart Oda",
                            RoomSubTitle = "Konforlu ve ekonomik.",
                            RoomImage = "/Template/images/c1.jpg"
                        },
                        new Room
                        {
                            RoomTitle = "Deluxe Oda",
                            RoomSubTitle = "Geniş ve manzaralı.",
                            RoomImage = "/Template/images/c2.jpg"
                        },
                        new Room
                        {
                            RoomTitle = "Kral Dairesi",
                            RoomSubTitle = "Lüksün zirvesi.",
                            RoomImage = "/Template/images/c3.jpg"
                        },
                        new Room
                        {
                            RoomTitle = "Aile Odası",
                            RoomSubTitle = "Geniş aileler için ideal.",
                            RoomImage = "/Template/images/c4.jpg"
                        }
                    );
                    context.SaveChanges();
                }

                if (!context.Newsletters.Any())
                {
                    context.Newsletters.AddRange(
                        new Newsletter { NewsletterMail = "kadir@gmail.com", NewsletterDate = DateTime.Now.AddDays(-10) },
                        new Newsletter { NewsletterMail = "mehmet@gmail.com", NewsletterDate = DateTime.Now.AddDays(-5) },
                        new Newsletter { NewsletterMail = "ayse@hotmail.com", NewsletterDate = DateTime.Now.AddDays(-2) },
                        new Newsletter { NewsletterMail = "fatma@outlook.com", NewsletterDate = DateTime.Now.AddDays(-1) },
                        new Newsletter { NewsletterMail = "ali@yahoo.com", NewsletterDate = DateTime.Now.AddDays(-20) },
                        new Newsletter { NewsletterMail = "test@test.com", NewsletterDate = DateTime.Now }
                    );
                    context.SaveChanges();
                }
                // ROLE SEEDING
                var roleManager = scope.ServiceProvider.GetService<RoleManager<AppRole>>();
                var userManager = scope.ServiceProvider.GetService<UserManager<AppUser>>();

                string[] roleNames = { "Admin", "Member", "Visitor" };

                foreach (var roleName in roleNames)
                {
                    var roleExist = roleManager.RoleExistsAsync(roleName).Result;
                    if (!roleExist)
                    {
                        roleManager.CreateAsync(new AppRole { Name = roleName }).Wait();
                    }
                }

                // DEFAULT ADMIN USER SEEDING
                if (userManager.Users.All(u => u.UserName != "admin"))
                {
                    var adminUser = new AppUser
                    {
                        UserName = "admin",
                        Email = "admin@traversal.com",
                        Name = "Admin",
                        Surname = "User",
                        City = "Istanbul"
                    };

                    var result = userManager.CreateAsync(adminUser, "Admin123!").Result;
                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(adminUser, "Admin").Wait();
                    }
                }
            }
        }
    }
}
