using System.ComponentModel;
using System.Security.Cryptography;
using UnityEngine;

public class hacker : MonoBehaviour
{
    //Game Configuration Data
    string[] level1Passwords = {"password1","pass","word","easy"};
    string[] level2Passwords = {"password2","kink ","thong", "medium"};
    string[] level3Passwords = {"password3","passchart","word", "hard"};

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
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
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

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        switch(level)
        {   
            
            case 1:
                password = level1Passwords[Random.Range(0,level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0,level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0,level3Passwords.Length)];
                break;
            default:
                Debug.LogError("Invalid Level Value");
                break;
        }
        Terminal.WriteLine("Enter your Password");
        Terminal.WriteLine("Hint: " + password.Anagram());
        
    }

    void RunCheckAttempt(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            StartGame();
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }
    void ShowLevelReward()
    {
        switch(level)
        {
            case 1:
                Terminal.WriteLine("You Found a Picture");
                Terminal.WriteLine(@"
 _-''_^_''-_
  -_nn_nn_-"
                   );
                break;
            case 2:
                Terminal.WriteLine("Ewww");
                 Terminal.WriteLine(@"
     (   )
  (   ) (
   ) _   )
    ( \_
  _(_\ \)__
 (____\___))"
                   );
                break;
            case 3:
                Terminal.WriteLine("You Scored Big");
                 Terminal.WriteLine(@"
   $             
 $$$$$            
 $ $              
 $$$$$          
   $ $
 $$$$$
   $"
            );
            break;
        }
        Terminal.WriteLine("");
        Terminal.WriteLine("Now, welcome to the Matrix!");
    }

}
