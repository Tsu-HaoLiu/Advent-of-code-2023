## Main challenge of Day 3

In part 1 we are looking at a 2D matrix problem where we want to find answer around a target. In this case there are multiple targets. Using regex we can find the digits and their positions in the matrix. 
Steps to solve:
- Iterate through each row and find any digits with regex.
- Using the positions from regex iterate through the col and row around the digits
- If a symbol is found, add the found digits to the total

What I learned:

What I can improve:
- Matrix and how to effectively move through them
- Understanding rows and cols in code form

Extra:

### Part 2

For the part 2 twist, we looking for 2 numbers touching the `*` symbol. The similar leetcode question to this would be checking to see if we've seen the coords of the `*` symbol, since we will be looping through all numbers. So we will save the seen `*` symbol, if we see it again we will multiply the numbers together.

"A gear is any `*` symbol that is adjacent to exactly two part numbers. Its gear ratio is the result of multiplying those two numbers together."

Steps to solve:
- Iterate though each row and find any digits
- If `*` symbol is found when iterating save the position in a dictionary
- If another digit locates the same `*` symbol position multiply numbers together

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
OR
cargo init
```

### cargo commands
```
# building and runnning application 
cargo run

# running multiple binaries
cargo run --bin <binary-name>
```