using Microsoft.VisualBasic;
using System;
using System.Linq;

public class PokerHandRankingClass
{   
    public static string PokerHandRanking(string[] hand)
    {
        if (HasRoyalFlushCombination(hand))
        {
            return "Royal Flush";
        }

        if (HasStraightFlushCombination(hand))
        {
            return "Straight Flush";
        }

        if (HasFourOfAKindCombination(hand))
        {
            return "Four of a Kind";
        }

        if (HasFullCombination(hand))
        {
            return "Full House";
        }

        if (HasFlushCombination(hand))
        {
            return "Flush";
        }

        if (HasStraightCombination(hand))
        {
            return "Straight";
        }

        if (HasThreeOfAKindCombination(hand))
        {
            return "Three of a Kind";
        }

        if (HasTwoPairCombination(hand))
        {
            return "Two Pair";
        }

        if (HasPairCombination(hand))
        {
            return "Pair";
        }

        return "High Card";
    }


    private static bool HasTheSameSuit(string[] hand)
    {
        return hand.All(card => card.Last() == hand[0].Last());
    }
    
    private static bool HasSequence(string[] hand)
    {
        List<int> ranks = new List<int>();
        foreach (var card in hand)
        {
            // Get card rank without suit
            string cardRank = card[..^1];

            switch (cardRank)
            {
                case "2":
                    ranks.Add(2);
                    break; 
                case "3":
                    ranks.Add(3);
                    break;
                case "4":
                    ranks.Add(4);
                    break;
                case "5":
                    ranks.Add(5);
                    break;
                case "6":
                    ranks.Add(6);
                    break;
                case "7":
                    ranks.Add(7);
                    break;
                case "8":
                    ranks.Add(8);
                    break;
                case "9":
                    ranks.Add(9);
                    break;
                case "10":
                    ranks.Add(10);
                    break;
                case "J":
                    ranks.Add(11);
                    break;
                case "Q":
                    ranks.Add(12);
                    break;
                case "K":
                    ranks.Add(13);
                    break;
                case "A":
                    ranks.Add(14);
                    break;
                default:
                    break;
            }
        }

        ranks.Sort();

        for (int i = 1; i < ranks.Count; i++)
        {
            // Non-continuous sequence case
            if (ranks[i] != ranks[i - 1] + 1)
            {
                return false; 
            }
        }

        return true;
    }

    private static bool HasRoyalFlushCombination(string[] hand)
    {
        List<string> ranksToCheck = new List<string> { "A", "K", "Q", "J", "10" };
        string handString = string.Join(", ", hand);

        bool hasNecessaryValues = ranksToCheck.All(handString.Contains);

        return hasNecessaryValues && HasTheSameSuit(hand);
    }

    private static bool HasStraightFlushCombination(string[] hand)
    {
        return HasSequence(hand) && HasTheSameSuit(hand);
    }

    private static bool HasFourOfAKindCombination(string[] hand)
    {
        var groupedCards = hand.GroupBy(card => card[..^1]);

        foreach (IGrouping<string, string> group in groupedCards)
        {
            if (group.Count() == 4)
            {
                return true;
            }
        }

        return false; 
    }

    private static bool HasFullCombination(string[] hand)
    {
        var groupedCards = hand.GroupBy(card => card[..^1]);


        bool hasThree = false;
        bool hasPair = false;
        foreach (IGrouping<string, string> group in groupedCards)
        {
            if (group.Count() == 3)
            {
                hasThree = true;
            }

            if (group.Count() == 2)
            {
                hasPair = true;
            }
        }

        return hasThree && hasPair;
    }

    private static bool HasFlushCombination(string[] hand)
    {
        return HasTheSameSuit(hand);
    }

    private static bool HasStraightCombination(string[] hand)
    {
        return HasSequence(hand);
    }

    private static bool HasThreeOfAKindCombination(string[] hand)
    {
        var groupedCards = hand.GroupBy(card => card[..^1]);

        foreach (IGrouping<string, string> group in groupedCards)
        {
            if (group.Count() == 3)
            {
                return true;
            }
        }

        return false;
    }

    private static bool HasTwoPairCombination(string[] hand)
    {
        var groupedCards = hand.GroupBy(card => card[..^1]);
        int pairCount = 0;
        
        foreach (IGrouping<string, string> group in groupedCards)
        {
            if (group.Count() == 2)
            {
                pairCount++;
            }
        }

        return pairCount == 2;
    }

    private static bool HasPairCombination(string[] hand)
    {
        var groupedCards = hand.GroupBy(card => card[..^1]);

        foreach (IGrouping<string, string> group in groupedCards)
        {
            if (group.Count() == 2)
            {
                return true;
            }
        }

        return false;
    }
}