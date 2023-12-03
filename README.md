# UISystemTask

## TabSystem
### Tab Group Component
![Alt Text](assets/GIFs/TabSystem.gif)

The Tab Group component manages Tab Buttons and Tabs themselves. The logic is straightforward: Each Tab Button activates the corresponding Tab. Additional buttons can be implemented to create more tabs. This component works with Buttons and requires the TabButtonEvents component.

### TabButtonEvents Component
The TabButtonEvents component handles additional logic for buttons, such as OnTabSelected and OnTabDeselected. It provides additional visualization for tab buttons upon selection and deselection.

### TabButton Component
The TabButton component is responsible for tab buttons, managing events for clicks, mouse overs, etc.

## Task1 Folder
![Alt Text](assets/GIFs/Animation.gif)

This folder contains the implementation of the MVVM pattern for controlling the animation speed of the CanvasComponent.

### Animation Speed View Component
This component handles changes in the Slider's value.

### AnimationSpeedViewModel
The AnimationSpeedViewModel manages the logic for updating the Animation speed value. The logic is based on the Animator but for future upgrades and system optimization, this should be migrated to Code animation.

## Task2 Folder
![Alt Text](assets/GIFs/ScrollView.gif)

This folder contains the implementation of the Simple Factory pattern with a basic Object Pooling mechanism for managing ItemBars in a Vertical Scroll View.

### ItemBarFabric Component
The ItemBarFabric component manages the Object Pooling for ItemBars and handles their initialization.

### ContentController Component
The ContentController component detects which ItemBars should be pooled in or out.

## Task3 Folder
![Alt Text](assets/GIFs/Timer.gif)

This folder contains a realization of the MVC pattern that handles only the Model and View. In this particular task, using the Controller wasn't necessary, so the implementation was simplified to include only the model and view.

### CurrentTimeView Component
The CurrentTimeView component manages a Coroutine that updates the current time.

___

The current implementation and optimization were designed for the Vertical view only. However, for future upgrades, consideration will be given to handling both orientations and most popular aspect ratios.
