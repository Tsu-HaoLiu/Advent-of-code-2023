## Main challenge of Day 2

Part 1 we are given a maximum for 3 different types of cubes. Each "game" consist of pulls which cannot be higher than the set maximum for each type. (12 red cubes, 13 green cubes, and 14 blue cubes)
Steps to solve:
- Iterate through each game
- Store dice pull in a Key-Value Pair
- Parse the string to retrieve relevant data
- If any values go over the maximum for any type, discard
- Sum all possible games for answer

What I learned:

What I can improve:

Extra:
The question was word a little differently. "game 1, three sets of cubes are revealed from the bag (and then put back again)". When storing the types it was surmised that we were taking the total of each game, not the single draws.

```
Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
Total: Red 5, Green 4, Blue 9 < maximum
--- VS ---
Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
[3 blue, 4 red;] < maximum
[1 red, 2 green, 6 blue;] < maximum
[2 green] < maximum
```


### Part 2

In part 2 we are still looking to at the same problem with a small twist. For each game (row) we are looking for the fewest number of cubes of each color that could make the game possible.

```
Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
Maximum: 4 red, 2 green, 6 blue
```

Steps to solve:
- Every iteration of pulls, we want to take the maximum amount for each color available. 
- Multiple them together and add them to the total


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