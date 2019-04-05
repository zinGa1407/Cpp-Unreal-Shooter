# Cpp Unreal Shooter
## Folder Conventions

Content/ is where our game assets will be

__Programmers__

- Content/Actors/**Asset name**  this is where the actors will be
- Content/Interfaces/**Asset name**
- Content/Pawns/**Asset name**
- Content/Widgets/**Asset name**
- Content/GameModes/**Asset name**
- Content/Blueprints/**Asset name**

####  The structure for the .h and .cpp files should be similar

__Artists__

- Content/Asset/**Asset name** this is where the meshes will be with the corresponding materials
- Content/Particles/**Asset name** etc etc!
- Content/Materials/**Asset name** etc etc!


## Programming naming conventions

- Template classes are prefixed by T.
- Classes that inherit from UObject are prefixed by U.
- Classes that inherit from AActor are prefixed by A.
- Classes that are abstract interfaces are prefixed by I.
- Enums are prefixed by E.


#### - Boolean variables must be prefixed by b (e.g. "bPendingDestruction", or "bHasFadedIn").
#### - variables = PrivateVariable;
#### - functions = ATestFunction();
#### - Parameters = pPendingDestruction
