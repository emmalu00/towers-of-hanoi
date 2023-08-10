# towers-of-hanoi
## Towers of Hanoi Background 

The Towers of Hanoi is a puzzle invented in the late 1800's around a temple legend. The puzzle involves 3 posts (pegs) and a number of discs. These discs start stacked on the first pole in descending order with the largest disc on the bottom and the smallest on the top. To solve this puzzle, one must move all the discs from the first pole to the third pole. The only limitations of this puzzle are that you may only move one disc at a time, and you cannot stack a disc onto a disc that is larger than itself. 
This project uses an user interface, utilizing stacks, that allows a user to create and solve the Tower of Hanoi puzzle.


## User Interface
The user interface was developed in Visual Studio using Windows Forms. 

![image](https://github.com/emmalu00/towers-of-hanoi/assets/106994328/816cf7da-d9da-4663-be95-0c6c2efaa076)


The GUI is structured with:
* A **Button** and a **NumericUpDown** control in the top left hand corner that allows the user to change the number of discs and start a new game. The default number of discs is 3, but the user may choose to play a game with up to 11 discs. 
* A **Label** in the top center that help keep track of the number of moves made. 
* A Button and a **NumericUpDown** control with a corresponding Label in the top right hand corner. The button triggers the program algorithm to solve the puzzle automatically. The **NumericUpDown** control changes the delay between steps in milliseconds. 
* In the middle, there are three **FlowLayoutPanels**. These columns represent the poles/pegs for the discs to slide onto. The discs **Labels** that are created dynamically.
* The **Buttons** below the **FlowLayoutPanels** allow the user to move discs between each of the panels. Note that Move Left in the first panel allows discs to be moved from panel one to panel three and Move Right on the third panel allows discs to be moved from panel three to panel one.

### Performance
The user should be able to win the game with a message indicating whether or not they won in an optimal number of moves. If the user chooses to "Solve" the puzzle, all actions on the UI will be blocked until the computer is done solving the problem.

![image](https://github.com/emmalu00/towers-of-hanoi/assets/106994328/0b427ab2-0a0f-46fd-b6bf-7d11aa18869d)

## The UserInterface Class
This is the main and only class. `UserInterface` houses all the properties, methods, and event handlers needed for this project.
