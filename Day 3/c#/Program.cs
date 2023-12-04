using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


public static class Util {
    public static void log<T>(T text) {
        Console.WriteLine(text);
    }

    public static List<String> loadFile(string filename) {
        var lines = File.ReadAllLines(filename);
        return new List<string>(lines);
    }
}


class Program {
    static int total = 0;
    static List<string> matrix = Util.loadFile("../input1.txt");
    static Dictionary<(int, int), List<int>> gear_nums = new Dictionary<(int, int), List<int>>();

    static bool symbolSearch(int start_y, int start_x, int end_y, int end_x, int num) {

        for (int y = start_y; y <= end_y; y++) {
            for (int x = start_x; x <= end_x; x++) {
                if (y >= 0 && y < matrix.Count && x >= 0 && x < matrix[y].Length) {
                    if (!"0123456789.".Contains(matrix[y][x])) {
                        if (matrix[y][x] == '*') {
                            if (!gear_nums.ContainsKey((y, x))) {
                                gear_nums[(y, x)] = new List<int>();
                            }
                            gear_nums[(y, x)].Add(num);
                        }
                        return true;
                    }
                }
            }
        }
        return false;
    }

    static void Main() {
        Regex numberRegex = new Regex("\\d+");

        for (int row=0; row < matrix.Count; row++) {
            foreach (Match match in numberRegex.Matches(matrix[row])) {
                if (symbolSearch(row-1, match.Index-1, row+1, match.Index + match.Length, int.Parse(match.Value))) {
                    total += int.Parse(match.Value);
                }
            }
        }

        Util.log(total);

        int ratTotal = 0;
        foreach (var kvp in gear_nums) {
            if (kvp.Value.Count == 2) {
                ratTotal += kvp.Value[0] * kvp.Value[1];
            }
        }
        Util.log(ratTotal);
    }
}
