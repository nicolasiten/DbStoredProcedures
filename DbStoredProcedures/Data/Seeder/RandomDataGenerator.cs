using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleNLG;

namespace DbStoredProcedures.Data.Seeder
{
    public static class RandomDataGenerator
    {
        private static readonly Random _random = new Random();

        public static string GetRandomProblem(string productName)
        {
            var lexicon = Lexicon.getDefaultLexicon();
            var nlgFactory = new NLGFactory(lexicon); 
            var realiser = new Realiser(lexicon);

            var clause = nlgFactory.createClause();
            clause.setSubject(GetRandomSubject());
            clause.setVerb(GetRandomVerb());
            clause.setObject(productName);
            clause.addComplement(GetRandomProblemComplement());

            return realiser.realiseSentence(clause);
        }

        public static string GetRandomResolution()
        {
            var lexicon = Lexicon.getDefaultLexicon();
            var nlgFactory = new NLGFactory(lexicon);
            var realiser = new Realiser(lexicon);

            var clause = nlgFactory.createClause();
            clause.setSubject(GetRandomSubject());
            clause.setVerb("is");
            clause.addComplement(GetRandomResolutionComplement());
            clause.setFeature(Feature.TENSE.ToString(), Tense.PAST);

            return realiser.realiseSentence(clause);
        }

        public static DateTime GetRandomDate(DateTime startDate, DateTime endDate)
        {
            TimeSpan timeSpan = endDate - startDate;
            TimeSpan newTimeSpan = new TimeSpan(0, _random.Next(0, (int)timeSpan.TotalMinutes), 0);
            return startDate + newTimeSpan;
        }

        public static int GetRandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public static bool GetRandomBool()
        {
            return _random.NextDouble() >= 0.5;
        }

        public static void SetRandomProductVersionOs(List<ProductVersionOs> productVersionOsEntities, Issue issue)
        {
            var productVersionOsEntity = productVersionOsEntities[GetRandomNumber(0, productVersionOsEntities.Count())];
            issue.OperatingSystemFk = productVersionOsEntity.OperatingSystemFk;
            issue.VersionFk = productVersionOsEntity.VersionFk;
            issue.ProductFk = productVersionOsEntity.ProductFk;
        }

        private static string GetRandomSubject()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 6);

            switch (randomNumber)
            {
                case 0:
                    return "The user";

                case 1:
                    return "Free Plan subscriber";

                case 2:
                    return "Basic Plan subscriber";

                case 3:
                    return "Premium Plan subscriber";

                case 4:
                    return "A developer";

                case 5:
                    return "A tester";
            }

            return "The user";
        }

        private static string GetRandomVerb()
        {
            int randomNumber = _random.Next(0, 6);

            switch (randomNumber)
            {
                case 0:
                    return "says";

                case 1:
                    return "reported";

                case 2:
                    return "described";

                case 3:
                    return "made known";

                case 4:
                    return "shouted";

                case 5:
                    return "made clear";
            }

            return "says";
        }

        private static string GetRandomProblemComplement()
        {
            int randomNumber = _random.Next(0, 10);

            switch (randomNumber)
            {
                case 0:
                    return "application is crashing after connection loss";

                case 1:
                    return "application startup time is extremely slow";

                case 2:
                    return "application shows exception on startup";

                case 3:
                    return "application freezes sporadically";

                case 4:
                    return "buttons are not clickable";

                case 5:
                    return "application layout looks weird on small mobile screen";

                case 6:
                    return "application is not responsive on long operation, not clear if it crashed";

                case 7:
                    return "application is loading endlessly";

                case 8:
                    return "application showing OutOfMemory Exception";

                case 9:
                    return "application button linking to wrong actions";
            }

            return "application is crashing after connection loss";
        }

        private static string GetRandomResolutionComplement()
        {
            int randomNumber = _random.Next(0, 15);

            switch (randomNumber)
            {
                case 0:
                    return "using a slow 3G Network. The application will be optimize to work with a slow network.";

                case 1:
                    return "using a slow 3G Network. The application will show message that the network is too slow.";

                case 2:
                    return "using a slow Phone with very less free Disk space. Problem is not related to the application.";

                case 3:
                    return "using a device with an unsopported OS. The application will show an error message if a user tries to install the application on an unsopported OS";

                case 4:
                    return "on a 3G network and expected the operation to complete faster then it was. In Progress animation will be implemented";

                case 5:
                    return "using an old device with a very limited amount of RAM. Application is expected to be slower on such a device";

                case 6:
                    return "using an old device with a very limited amount of RAM. Dev team will store less objects in the RAM";

                case 7:
                    return "using an old device with a very limited amount of RAM. Developers will optimize the RAM usage.";

                case 8:
                    return "having no network connection. Exception will be catched and user will get informed with a dialog";

                case 9:
                    return "having no network connection. Exception will be catched and cached offline data will be shown instead";

                case 10:
                    return "using a phone with a cracked screen that is randomly sending click events. User will have to buy a new phone";

                case 11:
                    return "using a desktop device with a very small screen. Application will be optimized to work with smaller screens.";

                case 12:
                    return "sending requests over and over again by clicking around. Show in progress screen on long operations";

                case 13:
                    return "sending several buy requests because application seemed unresponsive. Show in progress screen on checkout";

                case 14:
                    return "using an old version of the OS which doesn't support all the features. In future releases a minimum version of supported OS will be set.";
            }

            return "using a slow 3G Network. The application needs to be optimize to work with a slow network.";
        }
    }
}
