# DevMemo

## About the project
DevMemo is a memory card game developed as my final individual project for the course *Objektorienterad programmering, grund* (Introduction to Object-Oriented Programming).
The project has been an opportunity for me to practice and further develop my fundamental skills in C# and object-oriented programming (OOP).

The game consists of 16 cards forming eight matching pairs, each represented by an icon or logo associated with a technology or framework used in software development. The objective is to find all matching pairs in as few attempts as possible.

Beyond creating a functional game, my goal was to apply concepts such as classes, objects, methods and separation of responsibilities, while focusing on clean, well-structured and maintainable code that could be understood and further developed in the future.

I chose to build DevMemo using Blazor WebAssembly, as it allowed me to take advantage of my previous experience with HTML, CSS and component-based frontend development. This meant I could focus more on developing the game logic in C# rather than spending too much time learning an unfamiliar approach to building user interfaces.

Another advantage of choosing Blazor WebAssembly was the possibility of deploying the application as a website, making it easy to access, demonstrate and share directly through a web browser.

## Features
When the player selects a card, it flips to reveal its icon. The player can then select a second card. If the two cards match, they remain face up. Otherwise, they flip back after a short delay.

To prevent invalid selections, the game board is temporarily locked while unmatched cards are displayed. The game also ignores clicks on cards that are already flipped or matched. Throughout the game, the number of attempts and matched pairs are tracked and displayed separately.

Once all eight pairs have been found, a results modal appears, showing the total number of attempts along with performance feedback based on the player's result. The player can then choose to start a new game or return to the start screen. The interface is designed to be responsive and playable on different screen sizes.

## Technologies and Project Structure
DevMemo is built using C#, .NET 10 and Blazor WebAssembly. C# handles the game logic built using object-oriented programming (OOP), while HTML and CSS are used to build and style the user interface.

The project is structured using C# classes and Razor components, separating the game logic from the user interface. Razor components combine HTML markup with C# code to handle rendering and user interactions.

### C# classes
- Card.cs: Represents an individual card and its properties, including its icon or logo and current state.
- CardSet.cs: Creates the matching pairs and shuffles the cards at the start of each game.
- GameManager.cs: Handles card selection, matching logic, game rules and tracking of attempts and matched pairs.

### Razor components
- Home.razor: Manages the different game views, including the welcome screen, gameplay and final results.
- GameBoard.razor: Coordinates the game by connecting the card components with the game logic.
- GameCard.razor: Displays individual cards and handles click events.
- GameStats.razor: Displays the number of attempts and matched pairs.

This structure allows the game logic to be kept separate from most of the interface code, making the application easier to understand, maintain and further develop.

## Limitations and future improvements

## Development process and reflection

## Live demo
https://devmemo.mx10.se/
