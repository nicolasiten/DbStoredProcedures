using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleNLG;

namespace DbStoredProcedures.Data.Seeder
{
    public static class RandomProblemSolutionGenerator
    {
        private static readonly Random _random = new Random();

        public static string GetRandomProblem()
        {
            var lexicon = Lexicon.getDefaultLexicon();
            var nlgFactory = new NLGFactory(lexicon); 
            var realiser = new Realiser(lexicon);

            var p = nlgFactory.createClause();
            p.setSubject(GetRandomSubject());
            p.setVerb(GetRandomVerb());
            p.setObject(GetRandomObject());
            p.addComplement(GetRandomComplement());

            return realiser.realiseSentence(p);
        }

        public static string GetRandomSubject()
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

        private static string GetRandomObject()
        {
            int randomNumber = _random.Next(0, 4);

            switch (randomNumber)
            {
                case 0:
                    return "Day Trader Wannabe";

                case 1:
                    return "Investment Overlord";

                case 2:
                    return "Workout Planner";

                case 3:
                    return "Social Anxiety Planner";
            }

            return "Day Trader Wannabe";
        }

        private static string GetRandomComplement()
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
    }
}
