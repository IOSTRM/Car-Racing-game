# Car-Racing-game
My semester project. I have used Windows Forms to create this game, because it is a really convenient environment for such job. It automatically created objects for me, so I did not spend the time writing each component. The rest is written using c# language.
The game is not fully finished yet, but the main mechanics is done. Only design remains. Also, you will notice that car models are like squares, so each model have their own black background. I could not find how to fix this, maybe you know, so I would like to hear the idea. For now I guess these are all the problems in this game, if I did not miss something.

FINAL UPDATES!!!
So, I have fixed the problem with ipening a Help window. Also, was added a background picture to the menu and some exit functions which return to the menu. After playing for a while, you can notice that if you hold move button, it starts working not immediately. I thought that it is directly a problem of a code, but then I found an information that it is because of keyboard's hold delay, so if you want to play comfortably you have to change your keyboard settings. 
I have added several code files. For example, StartMenu.cs and Help.cs are responsible for buttons functioning inside those slides. .Designer. files contain inside visual information(i.e. size of a box, colors, etc.). Form1.cs is a file, where whole game process is written, i.e. counting your record and terminating the process and moving a car. What is about game idea: you start with initial speed 10. After achieving some distance(you will receive the corresponding message in the top right corner, your speed increases, so it becomes harder to survive. The opponents car appear in some random range for each of them, but they cannot coincide(I hope, that I did not forget to add this condition). To run this game you can just download .exe file and execute it. That's all about it. Enjoy! 
