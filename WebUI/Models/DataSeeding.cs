using Data.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

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
            }
        }
    }
}
