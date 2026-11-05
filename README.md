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
DevMemo is built using C#, .NET 10 and Blazor WebAssembly. C# handles the game logic using object-oriented programming (OOP) principles, while HTML and CSS are used to build and style the user interface.

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
The current version of DevMemo has a fixed board size of 16 cards and the final performance evaluation is based on the number of attempts needed to complete the game.

During the planning phase I considered allowing players to choose between different board sizes, representing different difficulty levels. I also considered adding a timer but decided not to include it as a requirement in the initial plan, while still keeping it in mind as a possible feature.

A possible future improvement I might implement is to let players choose the size of the game board, for example 8, 16 or 24 cards.

Another idea I've been considering is to make DevMemo more than just a memory game by displaying a short description of each technology or framework when a matching pair is found. The thought behind this is that it could add a small educational dimension to the game while keeping the basic gameplay unchanged.

## Development process and reflection
Instead of rushing into coding I decided to set aside time to get familiar with Blazor, mainly through a tutorial. This helped me better understand the framework, its component structure and how C# can be used to handle the game logic and user interactions.

During the planning phase I created a flowchart and pseudocode to describe the game logic. I found the flowchart especially useful for identifying potential edge cases at an early stage. Considering these situations during implementation made the process easier and helped me avoid unnecessary complications later in development.

Another important part of the project was finding a reasonable balance between the time available and the complexity of the application. I wanted to create something challenging enough to further develop my C# and OOP skills, but also realistic enough to complete within the assignment deadline. I therefore prioritized the main functionality rather than committing to additional features that I might not have time to finish.

Working with Blazor has been an interesting and valuable experience as it allowed me to combine my previous knowledge of HTML and CSS with the C# skills I'm continuing to develop. It has introduced me to another approach to building interactive web applications, where C# can be used instead of JavaScript for the application logic.

This project has given me more experience in planning and managing the development process. It has also been a reminder of the importance of allowing enough time for the different stages of a project. Besides implementation, time is needed for testing, fixing unexpected issues, deployment and documentation, rather than leaving these tasks until the final days before a deadline.

## Live demo
https://devmemo.mx10.se/
