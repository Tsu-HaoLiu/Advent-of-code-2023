#include <iostream>
#include <string>
#include <sstream>
#include <queue>
#include <fstream>
#include <stdio.h>
#include <unordered_map>

using namespace std;


int part1(string input) {
    const int colon = input.find(':');
    const int bar = input.find('|');
    // cout << card.substr(0, colon) << endl;

    // https://cplusplus.com/reference/string/string/substr/
    stringstream winning_strings(input.substr(colon + 1, bar - colon - 1));
    stringstream my_nums(input.substr(bar + 1));

    // https://en.cppreference.com/w/cpp/container/priority_queue
    // https://www.geeksforgeeks.org/priority-queue-of-vectors-in-c-stl-with-examples/
    priority_queue<int> winning_numbers;
    priority_queue<int> numbers;
    int wins = 0;

    // convert string to int
    int n;
    while (winning_strings >> n) {
        winning_numbers.push(n);
    }
    while (my_nums >> n) {
        numbers.push(n);
    }
    
    // Match our numbers with winning numbers
    while (!winning_numbers.empty() && !numbers.empty()) {
        if (winning_numbers.top() == numbers.top()) {
            wins++;
        }

        // pop the largest num from queue
        if (winning_numbers.top() > numbers.top()) {
            winning_numbers.pop();
        } else {
            numbers.pop();
        }

    }

    // printf("%u\n", points);
    return 1 * pow(2, (wins-1));
};



int main() {
    // https://cplusplus.com/doc/tutorial/files/
    ifstream input("../input1.txt");
    string card;

    unsigned int part1_points = 0;
    unsigned int part2_scratchcards;

    if (!input.is_open()) {
        return 0;
    }

    while ( getline(input, card) ) {
        part1_points += part1(card);
        // part2_scratchcards += part2(card);  
    }
    printf("Part 1: %u\n", part1_points);
    // printf("Part 2: %u", part2_scratchcards);

}


