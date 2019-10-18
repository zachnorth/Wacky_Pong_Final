using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// The main menu
/// </summary>
public class MainMenu : GameStartingMenu
{
    GameStartedEvent gameStartedEvent = new GameStartedEvent();
    /// <summary>
    /// Goes to the difficulty menu
    /// </summary>
    public void GoToDifficultyMenu()
    {
        AudioManager.Play(AudioClipName.MenuButtonClick);
        MenuManager.GoToMenu(MenuName.Difficulty);
    }

    /// <summary>
    /// Starts a two player game
    /// </summary>
    public void StartTwoPlayerGame()
    {
        AudioManager.Play(AudioClipName.MenuButtonClick);
        gameStartedEvent.Invoke((int)Difficulty.Medium, GameType.TwoPlayer);
        SceneManager.LoadScene("gameplay");
    }

    /// <summary>
    /// Shows the help menu
    /// </summary>
    public void ShowHelp()
    {
        AudioManager.Play(AudioClipName.MenuButtonClick);
        MenuManager.GoToMenu(MenuName.Help);
    }

    /// <summary>
    /// Exits the game
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
}
