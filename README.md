# SpectreXR Development Test

The purpose of this test is to evaluate your development team for hire for outsourced development work by testing the following areas:
- Unity Development (please use Unity version 2020.3.26f1)
- Git Proficiency
- Oculus Quest / Android Development
- VR Menu - Simple scroll menu with one item selectable
- Completion Criteria - Ding Ding, you win, now exit to main menu

# Design and Instructions

## Simulation Guidelines
* Load Application
* Menu Scene
  * Simple controller-selectable menu with more than one field - though only one field needs to actually work
  * Select the proper menu field to load the simulation
* Simulation Scene
  * User is in a small workshop in front of a desk / work table with a pneumatic drill on the table and a pneumatic hose next to it, but not connected
  * There is a board with a screw in it, but not screwed all the way in 
  * Instructions pop up and prompt the user to pick up the drill in one hand and then grab the pneumatic hose and connect it to the drill
  * Instructions then pop up and instruct the user to use the drill to screw the screw into the board
  * When the screw is successfully screwed in, the simulation ends with a notification that you were successful and then an ‘exit’ button to return to the main menu

# Coding Guidelines
* Please follow industry standard coding structures, code quality is a point of emphasis in this test.
* Please comment your code where applicable when intent may not be clear.
* Please briefly explain your architectural choices in a separate document so we can better understand your design's intent with regards to extensibility, reusability, and maintainability.
* Keep it simple but design the project's architecture so it can be scaled easily in the future. 
* If you use any third party assets, please let us know which ones and why.

# Art Guidelines
* Use the asset provided at Assets/Scenes/PlantSafety_Workshop.unity as your main scene
* The scene may consist of any props you would like to add, but they are not necessary, some models are already provided in Assets/Models
* You should create some simple VFX for the interactions

# Audio Guidelines
* Assets
  * The main simulation asset and any interactions should have the necessary audio to accompany the interactions
   * Pull the trigger, the drill makes noise
   * Plug in the hose, it clicks
   * Etc …
* Pop Ups / End 
  * Pop ups can have a notification sound
  * End pop ups and any interactions with buttons, etc, should have audio

# Package Guidelines
* Package as an application for Android to be deployed to an Oculus Quest - .apk
* Send us the package with any documentation on the approach, intent, code standard and work and art work, as well as a link to a git repo with history showing your work.

Thanks and good luck!
