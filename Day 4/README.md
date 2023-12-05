## Main challenge of Day 4

For part 1 we have to split the string into 2 categories (winning numbers and our numbers), then compare our numbers with the winning numbers to see if we gain a point. As we continue to win, the points double each time after one. We can use this equation to calculate the correct number of points:  `nx ​= m * r^(n−1)`
- `nx` is the points accumulated
- `m` is the first term
- `r` is the common ratio
- `n` is the total number of wins

Steps to solve:
- Split the card row into winning and our numbers using the delimiter `|` and `:`
- Convert strings to int types
- Compare our numbers with the winning numbers and add total points


What I learned:
- \[C++\] Has a big learning curve in terms of data types, terms and functions.
- \[C++\] Converting between multiple data types, debugging and logging result requires higher proficiency.

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