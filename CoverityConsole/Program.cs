﻿using CoverityLibrary;
using NodaTime;
using Serilog;
using System;
using System.Collections.Generic;

namespace CoverityConsole
{
    static class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console(restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Debug) // restricted... is Option
                .CreateLogger();
            Log.Debug("hello, world!");
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    Log.Debug($"argument is {arg}");
                }
            }

            var abrahamLincoln = new Person()
            {
                Id = Guid.NewGuid(),
                LegalName = "Abraham Lincoln",
                PreferredName = "Abe",
                DateOfBirth = new NodaTime.LocalDate(1809, 2, 12, CalendarSystem.Iso),
                FavoriteQuotes = new List<Quote>()
            };
            var quote1 = new Quote()
            {
                Text = "Four score and seven years ago our fathers brought forth upon this continent, a new nation, conceived in Liberty, and dedicated to the proposition that all men are created equal.  Now we are engaged in a great civil war, testing whether that nation, or any nation so conceived and so dedicated, can long endure. We are met on a great battle-field of that war. We have come to dedicate a portion of that field, as a final resting place for those who here gave their lives that that nation might live. It is altogether fitting and proper that we should do this. But, in a larger sense, we can not dedicate—we can not consecrate—we can not hallow—this ground. The brave men, living and dead, who struggled here, have consecrated it, far above our poor power to add or detract. The world will little note, nor long remember what we say here, but it can never forget what they did here. It is for us the living, rather, to be dedicated here to the unfinished work which they who fought here have thus far so nobly advanced. It is rather for us to be here dedicated to the great task remaining before us—that from these honored dead we take increased devotion to that cause for which they gave the last full measure of devotion—that we here highly resolve that these dead shall not have died in vain—that this nation, under God, shall have a new birth of freedom—and that government of the people, by the people, for the people, shall not perish from the earth.",
                Author = abrahamLincoln,
                UtteredDate = new LocalDate(1863, 11, 19, CalendarSystem.Iso)
            };
            abrahamLincoln.FavoriteQuotes.Add(quote1);
        }
    }
}
