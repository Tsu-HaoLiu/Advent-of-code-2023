## Main challenge of Day 1
https://adventofcode.com/2023/day/1

In part 1 of the problem we are trying to take the first and last digit in a string to form a single two digit number (10-99)
Steps to take:
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

What I can improve:

Extra:


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



