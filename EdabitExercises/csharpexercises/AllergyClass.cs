using System;
using System.Linq;
using System.Collections.Generic;

public class Allergies
{
    // Define an enum representing possible allergies, each associated with a power of 2
    [Flags]
    public enum Allergen
    {
        Eggs = 1,
        Peanuts = 2,
        Shellfish = 4,
        Strawberries = 8,
        Tomatoes = 16,
        Chocolate = 32,
        Pollen = 64,
        Cats = 128
    }

    // Personal properties
    public string PersonName { get; private set; }
    public int Score { get; private set; }

    // List of allergies, determined by the Score
    private List<string> allergies = new List<string>();

    // Constructor for when only name is provided
    public Allergies(string personName)
    {
        PersonName = personName;
    }

    // Constructor for when name and Score are provided
    public Allergies(string personName, int allergyInitNumber)
    {
        PersonName = personName;
        Score = allergyInitNumber;
        MapScoreToAllergies();
    }

    // Constructor for when name and string of allergies are provided
    public Allergies(string personName, string stringOfAllergies)
    {
        PersonName = personName;
        Score = ConvertStringOfAllergiesToScore(stringOfAllergies);
        MapScoreToAllergies();
    }

    // Returns a string representation of the Person's allergies
    public override string ToString()
    {
        int allergyCount = allergies.Count;

        if (allergyCount == 0)
            return $"{PersonName} has no allergies!";

        if (allergyCount == 1)
            return $"{PersonName} is allergic to {allergies[0]}.";

        string output = $"{PersonName} is allergic to ";
        for (int i = 0; i < allergyCount; i++)
        {
            if (i == allergyCount - 1)
            {
                output += allergies[i] + ".";
                return output;
            }
            else if (i == allergyCount - 2)
            {
                output += allergies[i] + " and ";
            }
            else
            {
                output += allergies[i] + ", ";
            }
        }
        return output;
    }

    // Checks if Person is allergic to a given allergy
    public bool IsAllergicTo(string allergen)
    {
        return allergies.Contains(allergen);
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        var allergy = Enum.GetName(typeof(Allergen), (int)allergen);

        if (allergy != null)
        {
            return allergies.Contains(allergy);
        }

        return false;
    }

    // Add an allergy to the Person
    public void AddAllergy(string allergy)
    {
        if (Enum.TryParse(allergy, out Allergen allergen))
        {
            Score += (int)allergen;
        }
        MapScoreToAllergies();
    }

    public void AddAllergy(Allergen allergy)
    {
        Score += (int)allergy;
        MapScoreToAllergies();
    }

    // Remove an allergy from the Person
    public void DeleteAllergy(string allergy)
    {
        if (Enum.TryParse(allergy, out Allergen allergen))
        {
            Score -= (int)allergen;
        }
        MapScoreToAllergies();
    }

    public void DeleteAllergy(Allergen allergy)
    {
        Score -= (int)allergy;
        MapScoreToAllergies();
    }

    // Convert a string of allergies to a Score
    private int ConvertStringOfAllergiesToScore(string stringOfAllergies)
    {
        string[] allergyStrings = stringOfAllergies.Split(" ");
        int score = 0;

        foreach (var allergy in allergyStrings)
        {
            if (Enum.TryParse(allergy, out Allergen allergen))
            {
                score += (int)allergen;
            }
        }

        return score;
    }

    // Map a Score to the corresponding allergies
    private void MapScoreToAllergies()
    {
        allergies.Clear();

        int remainingScore = Score;
        List<int> powersOfTwo = new List<int>();

        // Decompose the Score into powers of 2
        for (int i = 0; remainingScore > 0; i++)
        {
            if ((remainingScore & 1) == 1)
                powersOfTwo.Add(1 << i);
            remainingScore >>= 1;
        }

        // Add corresponding allergies for each power of 2 in the Score
        foreach (var powerOfTwo in powersOfTwo)
        {
            var allergy = Enum.GetName(typeof(Allergen), powerOfTwo);
            if (allergy != null)
            {
                allergies.Add(allergy);
            }
        }
    }
}
