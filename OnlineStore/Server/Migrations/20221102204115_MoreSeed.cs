using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineStore.Server.Migrations
{
    public partial class MoreSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgURL", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 3, "Echo Dot (3rd Gen, 2018 release) - Smart speaker with Alexa - Charcoal", "https://m.media-amazon.com/images/I/6182S7MYC2L._AC_SL1000_.jpg", 19.989999999999998, "Smart speaker" },
                    { 5, 3, "Echo Show 8 (2nd Gen, 2021 release) | HD smart display with Alexa and 13 MP camera | Charcoal", "https://m.media-amazon.com/images/I/51yQll2L7xL._AC_SL1000_.jpg", 160.0, "smart display" },
                    { 6, 2, "Sixteen-year-old Frankie Budge—aspiring writer, indifferent student, offbeat loner—is determined to make it through yet another sad summer in Coalfield, Tennessee, when she meets Zeke, a talented artist who has just moved into his grandmother’s unhappy house and who is as lonely and awkward as Frankie is. Romantic and creative sparks begin to fly, and when the two jointly make an unsigned poster, shot through with an enigmatic phrase, it becomes unforgettable to anyone who sees it. The edge is a shantytown filled with gold seekers. We are fugitives, and the law is skinny with hunger for us.\r\n\r\nThe posters begin appearing everywhere, and people wonder who is behind them. Satanists, kidnappers—the rumors won’t stop, and soon the mystery has dangerous repercussions that spread far beyond the town. The art that brought Frankie and Zeke together now threatens to tear them apart.\r\n\r\nTwenty years later, Frances Eleanor Budge—famous author, mom to a wonderful daughter, wife to a loving husband—gets a call that threatens to upend everything: a journalist named Mazzy Brower is writing a story about the Coalfield Panic of 1996. Might Frances know something about that? And will what she knows destroy the life she’s so carefully built?\r\n\r\nA bold coming-of-age story, written with Kevin Wilson’s trademark wit and blazing prose, Now Is Not The Time to Panic is a nuanced exploration of young love, identity, and the power of art. It’s also about the secrets that haunt us—and, ultimately, what the truth will set free.", "https://m.media-amazon.com/images/I/517JPB71DyL.jpg", 9.0, "Now Is Not the Time to Panic" },
                    { 7, 2, "Whether we love them or hate them, think they’re sexy, think they’re strange, consider them too big, too small, or anywhere in between, humans have a complicated relationship with butts. It is a body part unique to humans, critical to our evolution and survival, and yet it has come to signify so much more: sex, desire, comedy, shame. A woman’s butt, in particular, is forever being assessed, criticized, and objectified, from anxious self-examinations trying on jeans in department store dressing rooms to enduring crass remarks while walking down a street or high school hallways. But why? In Butts: A Backstory, reporter, essayist, and RadioLab contributing editor Heather Radke is determined to find out.\r\n\r\nSpanning nearly two centuries, this “whip-smart” (Publishers Weekly, starred review) cultural history takes us from the performance halls of 19th-century London to the aerobics studios of the 1980s, the music video set of Sir Mix-a-Lot’s “Baby Got Back” and the mountains of Arizona, where every year humans and horses race in a feat of gluteal endurance. Along the way, she meets evolutionary biologists who study how butts first developed; models whose measurements have defined jean sizing for millions of women; and the fitness gurus who created fads like “Buns of Steel.” She also examines the central importance of race through figures like Sarah Bartmann, once known as the “Venus Hottentot,” Josephine Baker, Jennifer Lopez, and other women of color whose butts have been idolized, envied, and despised.\r\n\r\nPart deep dive reportage, part personal journey, part cabinet of curiosities, Butts is an entertaining, illuminating, and thoughtful examination of why certain silhouettes come in and out of fashion—and how larger ideas about race, control, liberation, and power affect our most private feelings about ourselves and others.", "https://m.media-amazon.com/images/I/31ntk3LZQyL.jpg", 20.0, "Butts: A Backstory" },
                    { 8, 1, "REDMOND 4 Slice Toaster Retro Stainless Steel Toasters with Bagel Defrost Cancel Function, 6 Browning Settings, Cream, ST033", "https://m.media-amazon.com/images/I/71cZBKs+kGL._AC_SL1500_.jpg", 59.0, "REDMOND" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
