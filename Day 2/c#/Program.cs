using System;
using System.IO;
using System.Reflection.Metadata;

public static class Util {
    public static void log<T>(T text) {
        Console.WriteLine(text);
    }

    public static List<String> loadFile(string filename) {
        var lines = File.ReadAllLines(filename);
        // foreach (string line in lines) {
        //     print(line);
        // }
        // print(logList);

        return new List<string>(lines);
    }
}


namespace QuickStart {
    class Program {
        static void Main() {

            List<String> input = Util.loadFile(@"..\input1.txt");

            Util.log(input);
            Part1(input);
        }

        static bool PossibleCubes(Dictionary<string, int> CubeValues) {
            // only 12 red cubes, 13 green cubes, and 14 blue cubes
            foreach(KeyValuePair<string, int> entry in CubeValues) {
                if (entry.Key == "red" && entry.Value > 12) {
                    return false;
                } else if (entry.Key == "green" && entry.Value > 13) {
                    return false;
                } else if (entry.Key == "blue" && entry.Value > 14) {
                    return false;
                }
            }
            return true;
        }

        static void Part1(List<String> inputs) {

            int counter = 0;

            foreach (string input in inputs) {
               
                // only 12 red cubes, 13 green cubes, and 14 blue cubes

                // input = Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
                
                string[] game_dice_throw = input.Split(": ");

                int gameID;
                int.TryParse(game_dice_throw[0].Split(" ")[1], out gameID);
                //  [Game 1:] [3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green]
                Util.log(string.Join(Environment.NewLine, game_dice_throw[1]));

                bool Outside = false;

                // string items = string.Join(Environment.NewLine, game_dice_throw);
                // Console.WriteLine(items);

                foreach (string dicePull in game_dice_throw[1].Split("; ")) {

                    if (Outside) break;
                    Util.log(string.Join(Environment.NewLine, dicePull));
                    foreach (string singleRoll in dicePull.Split(", ")) {
                        Dictionary<string, int> CubeStorage = new Dictionary<string, int>() {
                            { "green", 0 },
                            { "blue", 0 },
                            { "red", 0 }
                        };
                        var singleDice = singleRoll.Split(" ");

                        int amount;
                        string color = singleDice[1];

                        int.TryParse(singleDice[0], out amount);

                        CubeStorage[color] += amount;

                        CubeStorage.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
                        // Util.log($"{amount} - {color}");
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
    }
}
