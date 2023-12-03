# UISystemTask

TabSystem
Tab Group component - is a component that manages Tab Buttons and Tabs itself. 
The logic is: Each Tab Button Activates Tab that belongs to button. We can implement more buttons to create more tabs.
This component works with Buttons so it requires TabButtonEvents component.

TabButtonEvenets component handles additional logic for buttons such as OnTabSelected and OnTabDeselected. In that case i was used for adding additional visualization for tab buttons on selection and diselection;

TabButton component - is a component for tab buttons that simply handles evenets for click, mouse over etc.

Task1 folder
Here is relasiation of MVVM pattern for controlling animation speed of CanvasComponent.

Animation Speed View component - handles Slider change value

AnimationSpeedViewModel - handles logic for updating Animation speed value;

The logic based on Animator but in further upgrade and optimization of this system this should be moved to Code animation.

Task2 folder
Here is realisation of Simple Factory pattern with simple ObjectPooling realisation for managing ItemBars in Vertical Scroll View

ItemBarFabric component - handles logic of Object Pooling for ItemBars and Initialisation of bars.

ContentController component - is a component that handles logic of detecting of ItemBars that should be polled in or out


Task3 folder
Here is a realisation of MVC pattern that handles only Model and View, in current task that wasnt nessecary to use Controller so realisation was simplifed only with model and View

CurrentTimeView component - Handles Courutine that updated current time.

____
Current realisation and optimization was made for Vertical view only. But still for further upgrades that would be made for handling both orientation and most of popular aspect ratio.



