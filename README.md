# 20-Project-SecondSemester
## File Breakdown:
### Movement.cs
#### Movement is the script that is move the player up/down/left/right is w/a/s/d and will flip the character model whenever an opposing movement direction is triggered left/right.
### Shoot.cs
#### Shoot is the code that will shoot a bullet whenever the player left clicks. It will launch a sprite toward wherever the mouse position is.
### Health.cs
#### Health is a peice of code that I am trying to get to be a collision all in one to work with both my character's bullet collision with the enemy and the enemy's collision with the player. Optimally it will be able to damage whomever based on who the script is attached to. It is based off unity's givin hp collision code and has been modified to try and fit with my project.
## How to run the code:
### Place all files into a unity project and apply the movement and shoot files to your character sprite. Attach Health to the player and the enemy sprite. Inside of the players movement code attach the players rigidbody2D to the code and inside the players shoot script attach the bullet and the location you want the bullet to come from.
