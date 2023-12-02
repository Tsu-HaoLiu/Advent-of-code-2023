use std::{
    fs::File,
    io::{prelude::*, BufReader},
    path::Path,
};

// https://stackoverflow.com/questions/30801031/read-a-file-and-get-an-array-of-strings
fn lines_from_file(filename: impl AsRef<Path>) -> Vec<String> {
    let file = File::open(filename).expect("no such file");
    let buf = BufReader::new(file);
    buf.lines()
        .map(|l| l.expect("Could not parse line"))
        .collect()
}


fn main() {
    let _input_data: [&str; 4] = [
        "1abc2",
        "pqr3stu8vwx",
        "a1b2c3d4e5f",
        "treb7uchet"
    ];
    // fn type_of<T>(_: T) -> &'static str {
    //     std::any::type_name::<T>()
    // }
    // println!("{}", type_of(&input_data));
    
    // Read a file as a Vec<u8>
    let data = lines_from_file("../../../input1.txt");
    // println!("{:?}", data);

    // println!("{:?}", input_data);
    part1(data);
}

fn part1(input: Vec<String>) {
    // Vector to store final results of each row
    let mut result: Vec<u32> = Vec::new();

    // Iterate through each line
    for cryp_text in input.iter() {
        // println!("{:?}", cryp_text);

        // Mutable string to store two digit number
        let mut digit_string: String = String::new();

        // Finds the first instance of a digit and push to String.
        for text in cryp_text.chars() {
            if text.is_digit(10) { // Checks if a char is a digit in the given radix.
                digit_string.push_str(text.to_string().as_str());
                break;
            }
        }

        // Reverse, then finds the "first" instance of a digit and push to String.
        for text in cryp_text.chars().rev().collect::<String>().chars() {
            if text.is_digit(10) {// Checks if a char is a digit in the given radix.
                digit_string.push_str(text.to_string().as_str());
                break;
            }
        }
        // combined first and last digit into an u32 int, push to vector
        result.push(digit_string.parse::<u32>().unwrap());
    }

    // println!("{:?}", result);
    println!("{}", result.iter().sum::<u32>());
}