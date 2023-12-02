## Main challenge of Day 1
https://adventofcode.com/2023/day/1

In part 1 of the problem we are trying to take the first and last digit in a string to form a single two digit number (10-99)
Steps to solve:
- Remove all non-digits from string/Find all digits from string
- Take the digits that appear first and last (e.g 12345 = 15)
- "Combine" (not add) those two digits together
- Return sum of all lines

What I learned:
- \[Rust\] learned about &str (borrowed_string) vs String (owned_string)
    - https://users.rust-lang.org/t/whats-the-difference-between-string-and-str/10177/2
    - https://stackoverflow.com/questions/30154541/how-do-i-concatenate-strings
- \[Rust\] Signed vs Unsigned interger types
    - https://doc.rust-lang.org/book/ch03-02-data-types.html
- \[Rust\] .iter() and reversing strings
- \[Rust\] Mutable variables and Vectors

What I can improve:

Extra:

## Part 2
In part 2, we are still trying to take the first and last digit in the string. The twist is the first or last digit could be spelled out with letters `one`, `two`, `three`, `four`, `five`, `six`, `seven`, `eight`, and `nine`.
Steps to solve:
- Use regex to separate letters & digits
- Take the first and last item of the regex vector
- Combine them together and take the sum of the vector

Extra:
Ran into some issues with regex that increased my answer by 26 points with a total of 21 incorrect lines.
When running regex it doesn't take into account 2 digit letters over lapping each other:
```
Text: 8ghsxbzoneightg
Regex: ["8", "one"]
Generated -> Correct: 81 -> 88
---
Text: lnmqnine855four17twoeightwolx
Regex: ["nine", "8", "5", "5", "four", "1", "7", "two", "eight"]
Generated -> Correct: 98 -> 92
```
https://stackoverflow.com/questions/11430863/how-to-find-overlapping-matches-with-a-regexp
Python has a lookahead assertion to allow overlapping, however, rust regex does not
```
error: look-around, including look-ahead and look-behind, is not supported
```


## setting up c#
```
dotnet new 
```

### .net commands
```
# building and runnning application 
dotnet run
```

## setting up c++
```
### NEW ###
run start_vscode.bat
mkdir project.cpp
run C/C++ file # to build/run program

# OLD #
launch "Developer Command Prompt for VS 2019"
navigate to project folder
code .
```

## Setting up rust

```
cargo new <project-name> day-01
```

### cargo commands
```
# building and runnning application 
cargo run

# running multiple binaries
cargo run --bin <binary-name>
```



