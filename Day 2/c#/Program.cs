using System;
using System.IO;
using System.Reflection.Metadata;

public static class Util {
    public static void log<T>(T text) {
        Console.WriteLine(text);
    }

    public static List<String> loadFile(string filename) {
        var lines = File.ReadAllLines(filename);
        return new List<string>(lines);
    }
}


namespace QuickStart {
    class Program {
        static void Main() {

            List<String> input = Util.loadFile(@"..\input1.txt");

            Part1(input);
            Part2(input);
        }

        static bool PossibleCubes(Dictionary<string, int> CubeValues) {
            // only 12 red cubes, 13 green cubes, and 14 blue cubes
            foreach(KeyValuePair<string, int> entry in CubeValues) {
                switch (entry.Key) {
                    case "red" when entry.Value > 12:
                    case "green" when entry.Value > 13:
                    case "blue" when entry.Value > 14:
                        return false;
                    default:
                        break;
                }
            }
            return true;
        }

        static void Part1(List<String> inputs) {

            int counter = 0;

            // Iterate through each game
            foreach (string input in inputs) {
               
                // Split the Game and dice pulls strings
                // [Game 1:] [3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green]
                string[] game_dice_throw = input.Split(": ");

                int gameID; // Save gameID for answer
                int.TryParse(game_dice_throw[0].Split(" ")[1], out gameID); // string to int converter

                bool Outside = false;

                // Iterate through each pull
                foreach (string dicePull in game_dice_throw[1].Split("; ")) {
                    if (Outside) break;

                    // Iterate through each color
                    foreach (string singleRoll in dicePull.Split(", ")) {
                        Dictionary<string, int> CubeStorage = new Dictionary<string, int>() {
                            { "green", 0 },
                            { "blue", 0 },
                            { "red", 0 }
                        };

                        // Split the amount and color
                        var singleDice = singleRoll.Split(" ");

                        int amount;
                        int.TryParse(singleDice[0], out amount); // string to int converter
                        string color = singleDice[1];

                        CubeStorage[color] += amount;
                        // CubeStorage.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);

                        // Validates the maximum for each color
                        if (!PossibleCubes(CubeStorage)) {
                            Outside = true;
                            break;
                        }
                    }
                }
                
                if (!Outside) {
                    counter += gameID; 
                }
            }
            Util.log(counter);
        } 

        static void Part2(List<String> inputs) {

            int counter = 0;

            foreach (string input in inputs) {
        
                string[] game_dice_throw = input.Split(": ");
                Dictionary<string, int> CubeStorage = new Dictionary<string, int>() {
                    { "green", 0 },
                    { "blue", 0 },
                    { "red", 0 }
                };

                foreach (string dicePull in game_dice_throw[1].Split("; ")) {

                    // Util.log(string.Join(Environment.NewLine, dicePull));
                    foreach (string singleRoll in dicePull.Split(", ")) {
                        var singleDice = singleRoll.Split(" ");

                        int amount;
                        string color = singleDice[1];

                        int.TryParse(singleDice[0], out amount);

                        CubeStorage[color] = Math.Max(amount, CubeStorage[color]);

                        // Util.log($"{amount} - {color}");
                    }
                }
                

                counter += CubeStorage["green"] * CubeStorage["red"] * CubeStorage["blue"]; 
                
            }
            Util.log(counter);
        } 
    }
}
