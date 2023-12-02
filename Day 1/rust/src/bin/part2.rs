use std::{
    fs::File,
    io::{prelude::*, BufReader},
    path::Path,
    collections::HashMap
};
extern crate regex;
use regex::Regex;

// https://stackoverflow.com/questions/30801031/read-a-file-and-get-an-array-of-strings
fn lines_from_file(filename: impl AsRef<Path>) -> Vec<String> {
    let file = File::open(filename).expect("no such file");
    let buf = BufReader::new(file);
    buf.lines()
        .map(|l| l.expect("Could not parse line"))
        .collect()
}


fn main() {
    let _input_data: Vec<String> = [
        "two1nine".to_string(),
        "eightwothree".to_string() ,
        "abcone2threexyz".to_string(),
        "xtwone3four".to_string(),
        "4nineeightseven2".to_string() ,
        "zoneight234".to_string(),
        "7pqrstsixteen".to_string() 
    ].to_vec();

    // Read a file as a Vec<u8>
    let data = lines_from_file("../../../input2.txt");
    // println!("{:?}", data);

    // println!("{:?}", input_data);
    part2(data); 
}



fn part2(input: Vec<String>) {

    // Key-value to store letter -> int conversion
    let mut mapped_digits = HashMap::new();
    mapped_digits.insert("one", "1");
    mapped_digits.insert("two", "2");
    mapped_digits.insert("three", "3");
    mapped_digits.insert("four", "4");
    mapped_digits.insert("five", "5");
    mapped_digits.insert("six", "6");
    mapped_digits.insert("seven", "7");
    mapped_digits.insert("eight", "8");
    mapped_digits.insert("nine", "9");

    // Vector to store final results of each row
    let mut result: Vec<u32> = Vec::new();

    // Regex to find the words
    let re = Regex::new(r"(one|two|three|four|five|six|seven|eight|nine|\d)").unwrap();

    // Iterate through each line
    for texts in input.iter() {
        // println!("{:?}", cryp_text);

        let matches: Vec<_> = re.find_iter(texts).map(|m| m.as_str()).collect();
        // [Match { start: 0, end: 3, string: "two" }, Match { start: 3, end: 4, string: "1" }, 
        // Match { start: 4, end: 8, string: "nine" }]

        let mut first_item = matches[0];
        let mut last_item = matches[matches.len() - 1];

        if first_item.len() > 1 {
            first_item = mapped_digits[first_item];
        }

        if last_item.len() > 1 {
            last_item = mapped_digits[last_item];
        }

        // digit_string.push_str(first_item.to_string().as_str());
        // digit_string.push_str(last_item.to_string().as_str());

        // combined first and last digit into an u32 int, push to vector
        result.push((first_item.to_string() + last_item).parse::<u32>().unwrap());
    }

    // println!("{:?}", result);
    // Print the sum of the vector
    println!("{}", result.iter().sum::<u32>());
}