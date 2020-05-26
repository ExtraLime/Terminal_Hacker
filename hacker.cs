using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacker : MonoBehaviour
{
    //GamseState
    int level;
    enum Screen { MainMenu, Password, Win };
    // Start is called before the first frame update
    Screen currentScreen;
    void Start()
    {
        ShowMainMenu();
    }
    void ShowMainMenu () {

        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();     
        Terminal.WriteLine("What would you like to Hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for your mom's email");
        Terminal.WriteLine("Press 2 for kim kardash's spank bank");
        Terminal.WriteLine("Press 3 for a random account");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection");
    }
    
    void OnUserInput (string input)
    {
        if (input ==  "menu") 
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "sexytime")
        {
            Terminal.WriteLine("Make a selection, Sexy");
        }
        else
        {
            Terminal.WriteLine("Please choose a Valid Option");
        }
    }




    void StartGame(){
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chose level: " + level);
        Terminal.WriteLine("Please Enter your Password");
    }

}
