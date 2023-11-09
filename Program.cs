using System;

class HypergeometricDistributionCalculator
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Hypergeometric Distribution Calculator");
            int totalOutcomes = GetValidIntegerInput("Enter the total number of possible outcomes: ");

            int totalAttempts = GetValidIntegerInput("\nEnter the number of attempts: ");

            int numCategories = GetValidIntegerInput("\nEnter the number of different success categories: ");

            int[] successesInCategories = new int[numCategories];
            int[] desiredSuccessesInCategories = new int[numCategories];

            for (int i = 0; i < numCategories; i++)
            {
                successesInCategories[i] = GetValidIntegerInput($"\nEnter the number of successes in category {i + 1}: ");

                desiredSuccessesInCategories[i] = GetValidIntegerInput($"\nEnter the number of desired successes in category {i + 1}: ");
            }

            double[] allOddsExact = new double[numCategories];
            double[] allOddsOrBetter = new double[numCategories];
            double exactlyDesiredSuccesses = 1.0;
            double atLeastDesiredSuccesses = 1.0;

            for (int i = 0; i < numCategories; i++)
            {
                allOddsExact[i] = CalculateExactlyDesiredSuccesses(totalOutcomes - i, totalAttempts - i, successesInCategories[i], desiredSuccessesInCategories[i]);
                allOddsOrBetter[i] = CalculateAtLeastDesiredSuccesses(totalOutcomes - i, totalAttempts - i, successesInCategories[i], desiredSuccessesInCategories[i]);
            }

            foreach (double odds in allOddsExact)
            {
                exactlyDesiredSuccesses *= odds;
            }

            foreach (double odds in allOddsOrBetter)
            {
                atLeastDesiredSuccesses *= odds;
            }

            double notDesiredSuccesses = 1 - atLeastDesiredSuccesses;

            Console.WriteLine($"\nOdds of getting at least the desired outcome or better: {atLeastDesiredSuccesses * 100:F2}%");
            Console.WriteLine($"Odds of getting exactly the desired outcome: {exactlyDesiredSuccesses * 100:F2}%");
            Console.WriteLine($"Odds of not getting the desired outcome: {notDesiredSuccesses * 100:F2}%");
        } 
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

    }

    static int GetValidIntegerInput(string prompt)
    {
        int result;
        bool validInput = false;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out result))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (!validInput);

        return result;
    }

    static double CalculateAtLeastDesiredSuccesses(int totalOutcomes, int totalAttempts, int successes, int desiredSuccesses)
    {
        double probability = 0.0;
        for (int i = desiredSuccesses; i <= Math.Min(successes, totalAttempts); i++)
        {
            probability += (CalculateCombination(successes, i) * CalculateCombination(totalOutcomes - successes, totalAttempts - i)) / CalculateCombination(totalOutcomes, totalAttempts);
        }
        return probability;
    }

    static double CalculateExactlyDesiredSuccesses(int totalOutcomes, int totalAttempts, int successes, int desiredSuccesses)
    {
        return (CalculateCombination(successes, desiredSuccesses) * CalculateCombination(totalOutcomes - successes, totalAttempts - desiredSuccesses)) / CalculateCombination(totalOutcomes, totalAttempts);
    }

    static double CalculateCombination(int n, int k)
    {
        return Factorial(n) / (Factorial(k) * Factorial(n - k));
    }

    static double Factorial(int n)
    {
        double result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
