using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacker : MonoBehaviour
{
    //Game Configuration Data
    string[] level1Passwords = {"password1","pass","word"};
    string[] level2Passwords = {"password2","kink ","thong"};
    string[] level3Passwords = {"password3","passchart","word"};

    //GamseState
    int level;
    enum Screen { MainMenu, Password, Win };
    // Start is called before the first frame update
    Screen currentScreen;
    string password;

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
        else if (currentScreen == Screen.Password)
        {
            RunCheckAttempt(input);
        }
    }



    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = level1Passwords[0];
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = level2Passwords[2];
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            password = level2Passwords[1];
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

    void RunCheckAttempt(string input)
    {
        if (input == password)
        {
            currentScreen = Screen.Win;
            Terminal.WriteLine("Welcome to the Matrix!");
        }
        else
        {
            Terminal.WriteLine("Denied, Try Again");
        }
    }

}
