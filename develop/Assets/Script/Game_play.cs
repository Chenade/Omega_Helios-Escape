using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_play : MonoBehaviour
{
    public Text Content;

    //public int test;

    // Start is called before the first frame update
    void Start()
    {
        //Main_System.now_playing = 23;
        switch (Main_System.now_playing)
        //switch (test)
        {
            case 25: //warp
                Content.text = "Through the game to explain the concept of the speed engine, use the arrow keys to adjust the direction of the space distortion, so that the spacecraft can reach the end point";
                break;

            case 16: //MDP
                Content.text = "Controlled by the mouse, emit ions in different directions to dodge obstacles floating in the universe and head to the target";
                break;

            case 18: //Bussard
                Content.text = "Use the arrow keys to control the character to run and jump to collect hydrogen atoms and hydrogen ions\nThe collected will be converted into bullets in the next level.\nIn the second level, use bullets to shoot lithium-6 or boron-11 targets \nAchieve the target score to complete the level";
                break;

            case 21: //NEMP
                Content.text = "Use the arrow keys to control the character to run forward,\nCollect 'Uranium - 235 / Plutonium - 239' (synthetic atomic bomb) along the way\n or 'Deuterium / Tritium / Lithium deuteride 6' (synthetic hydrogen bomb) to accelerate \n(The former has less acceleration and the latter has more)\nComplete the level when you reach the end within time";
                break;

            case 23: //MassDriver
                Content.text = "Using the mass projector to reach the target! The spacecraft launched by the mass launcher cannot turn. When traveling in space, the 'gravity slingshot' will be used to accelerate the turn of the spacecraft. In the game, you will get one The rotatable fixed turret can determine the launch angle and launch energy by itself, and pass through the gravitational field between the planets to reach the designated destination!";
                break;

            case 15: //solar
                Content.text = "This game is designed to use the principle of solar sail movement to control the spacecraft to avoid collisions with asteroids.\n\nThe operation method is: move the bottom light source to make the solar sail move in the opposite direction. If the number of collisions within time Pass the level not more than 3 times.";
                break;

            case 14: //operate solar
                Content.text = "Use the mouse to move the part to the position.\nThrough the outline prompt, let the player understand the general structure of the thruster\nAfter the assembly is completed, you will pass the level.";
                break;

            case 17: //operate MDP
                Content.text = "Use the mouse to move the part to the position.\nThrough the outline prompt, let the player understand the general structure of the thruster\nAfter the assembly is completed, you will pass the level.";
                break;

            case 20: //operate warp
                Content.text = "Use the mouse to move the part to the position.\nThrough the outline prompt, let the player understand the general structure of the thruster\nAfter the assembly is completed, you will pass the level.";
                break;

            case 22: //operate warp
                Content.text = "Use the mouse to move the part to the position.\nThrough the outline prompt, let the player understand the general structure of the thruster\nAfter the assembly is completed, you will pass the level.";
                break;

            case 24: //operate warp
                Content.text = "Use the mouse to move the part to the position.\nThrough the outline prompt, let the player understand the general structure of the thruster\nAfter the assembly is completed, you will pass the level.";
                break;

        }
    }

}
