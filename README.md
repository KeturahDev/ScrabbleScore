# ScrabbleScore

#### C# Week Two Practice Project _March 5th 2020_

#### By _**Keturah Howard**_

## Description

Input the word youve used in your scrabble game, and recieve the score for that word! Make sure you make it a real word first though. Functionality for this will be available in 2021!
#### Point System
- A, E, I, O, U, L, N, R, S, T : 1pt
- D, G  : 2pt
- B, C, M, P : 3pt
- F, H, V, W, Y  : 4pt
- K : 5pt
- J, X : 8pt
- Q, Z : 10pt
This project is being created with the intention of practing object-in-object functionality, and MSTesting with C#.

## Specifications:


| Specification | Example Input | Example Output |
| :------------- |:-------------| :-------------------|
| letter confirms its accessed | "a" | *a from point1 list has been accessed*  |
| letters return correct amount of points | "j" | *8 points*  |
| Word objects broken down into letters | "jam" | *j, a, m*  |
| letters in combination return a sum of their points| "Moo" | *5 points*  |
| letters return correct amount of points(regardless of caps) | "J" | *8 points*  |
| user inputs a word, application returns their score | user: "assemble" | program: *"12 points"*  |



## Setup/Installation Requirements

  ### Installing .NET Core

  #### macOS
  * Download a .NET Core SDK from Microsoft Corp
  * Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.

  #### on Windows
  * Download the 64-bit .NET Core SDK from Microsoft Corp.
  * Open the .exe file and follow the steps provided by the installer for your OS.

  ### Installing This Application

  1. Click on the *clone or download* button of this repository. You can download the project file clicking the **"Download Zip"** button, double clicking the file in downloads, and navigating to the index.html file and double clicking that. *Or*, you can copy the link that pops up when you've clicked the *clone or download* button above this README.md file...
  2. Navigate to your terminal, where you have previously installed git (if you have not done this yet, go ahead and do so now).
  3. In terminal, change your directory to desktop, and then type **git clone https://github.com/KeturahDev/**.
  4. When you've pressed enter, my project will be cloned onto your desktop, and now you can change directory into it and type **"code ."** to open the projects files in Visual Studio Code!
  5. At the root directory for this project in your chosen command promt program, enter the command "dotnet build" followed by "dotnet run". You can now begin to play Banana Bakery!

## Technologies Used

* Git
* VS Code
* C#
* .NET


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email me at keturah.dev@gmail.com.
## Liscenced under MIT
Copyright | Keturah Howard 2020
