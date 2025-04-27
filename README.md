# Puztle Castle
## 🎮 Beyond Perspective: A 3D/AR Gaming Adventure👓

![Community Project](https://img.shields.io/badge/Community-Project-purple)
![Platform](https://img.shields.io/badge/Platform-Android_|_iOS-blue)
![Made with](https://img.shields.io/badge/Made_with-Unity_|_Vuforia-red)
![Type](https://img.shields.io/badge/Type-3D_|_AR-green)

## 💭 The Story Behind the Game

This project emerged from a programming community I created during high school. We met at least 6 hours weekly to learn, plan, and develop various programming projects - from video games to Arduino robotics, Android development with Java, web development, and intermediate programming concepts.

Among our ambitious projects was this 3D/Augmented Reality game that plays with depth perception and complex camera movements mixed with puzzles and enjoyable platforming elements. The combination creates a game that presents both visual and gameplay challenges. The augmented reality mode adds an extra dimension, allowing players to see beyond what's immediately obvious.

## 📸 A Glimpse into Our World
![image](https://github.com/user-attachments/assets/550592b0-b7f8-482b-85c0-b99762760c4f)
![image](https://github.com/user-attachments/assets/b608f7f4-ae59-481e-b2f9-f473f4fbc04c)
![image](https://github.com/user-attachments/assets/b9f90601-d3bf-4830-ac2d-f91ee95cf0f9)
![image](https://github.com/user-attachments/assets/a8986764-d6f8-47ad-beed-f8206e857479)
![image](https://github.com/user-attachments/assets/5a229478-f50a-42fc-987b-6ed7b56d731a)
![image](https://github.com/user-attachments/assets/b332d477-f61d-4b8b-9618-e72db39d0f77)



## ✨ What Makes This Game Special?

Our game offers a unique blend of traditional platforming with perspective-shifting mechanics:

- 🔄 Dynamic camera perspectives that change how you control the character
- 🧩 Puzzles that require thinking across different spatial dimensions
- 🔍 AR mode that reveals hidden elements and paths
- 📱 Cross-platform compatibility for both Android and iOS devices
- 🎯 Classic platforming elements reimagined with depth perception challenges

## 🛠️ Technical Features

### Multi-Perspective Gameplay
The game constantly shifts between front, behind, left, and right camera views, requiring players to adapt their controls accordingly. What seems like a simple jump from one angle might reveal a complex gap from another!

### Augmented Reality Integration
Using Vuforia technology, the game transforms into an AR experience where physical space becomes part of the gameplay. Point your device at the real world and watch as game elements appear, offering new ways to interact with the environment.

### Dynamic Control System
The character's movement adapts based on camera position, ensuring that "forward" always makes sense relative to the player's current view, creating an intuitive control scheme despite the shifting perspectives.

## 💻 Core Systems

### Knight Controller
This system manages the player character with sophisticated features:

- Multi-directional movement that adjusts to camera perspective
- Custom gravity physics for realistic falling sensations
- Conditional jumping mechanics that respond to ground contact
- Animation integration that synchronizes with player actions
- Automatic rotation that orients the character toward movement direction
- Integrated debugging tools that helped during development

### Camera Position Controller
A critical system that manages the game's unique perspective mechanics:

- Cardinal position detection (front, behind, left, right)
- Angular segmentation that divides the 360° view into specific ranges
- Optional static positioning for certain gameplay segments
- Angle normalization that handles circular transitions (360° to 0°)
- Service-oriented design that other components can query for perspective data

### AR Switch System
Enables seamless transitions between standard and AR gameplay:

- Toggle functionality between normal and AR modes
- Automatic configuration at startup
- Integration with character controllers
- UI compatibility for mode switching
- Modular camera change structure
- Position control inheritance between modes

## 👥 The Programming Community

This project represents the collaborative efforts of a high school programming community I established. We dedicated ourselves to learning and creating together, using this game as a platform to explore:

- 3D game development principles
- Augmented reality implementation
- Complex camera and control systems
- Cross-platform development considerations
- Collaborative programming workflows

## 🌱 Learning Outcomes

Through this project, we gained valuable experience in:

- Building sophisticated control systems that adapt to changing conditions
- Implementing AR technology in gameplay contexts
- Designing puzzles that leverage spatial awareness and perspective
- Working across multiple reference frames in 3D space
- Creating intuitive controls despite complex camera dynamics
- Developing for mobile platforms with different capabilities

## 🔮 Future Possibilities

While the project already showcases innovative mechanics, there's potential for:

- Enhanced AR features using newer technology
- Additional puzzle types that further explore perspective mechanics
- Expanded level design with increasing complexity
- Multiplayer modes where players see different perspectives
- Integration with AR glasses for hands-free gameplay

---

*Created with passion by our high school programming community, demonstrating that young developers can tackle complex technical challenges when motivated by creativity and collaboration.*

```
       /\                                             /\
      /  \                                           /  \
     /    \                                         /    \
    /      \                                       /      \
   /        \___________________________________  /        \
  /                                             \          \
 /                                               \          \
/                                                 \__________\
|                                                            |
|                BEYOND PERSPECTIVE                          |
|                                                            |
|            WHERE REALITY MEETS IMAGINATION                 |
|____________________________________________________________|
```
