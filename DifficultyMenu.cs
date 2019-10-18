using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyMenu : GameStartingMenu
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        unityEvents.Add(EventName.GameStartedEvent, new GameStartedEvent());
        EventManager.AddInvoker(EventName.GameStartedEvent, this);
    }
    */

    public void HandleEasyButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.MenuButtonClick);
        unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.Easy, GameType.OnePlayer);
    }

    public void HandleMediumButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.MenuButtonClick);
        unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.Medium, GameType.OnePlayer);
    }

    public void HandleHardButtonOnClickEvent()
    {
        AudioManager.Play(AudioClipName.MenuButtonClick);
        unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.Hard, GameType.OnePlayer);
    }


    public void GoBack()
    {
        AudioManager.Play(AudioClipName.MenuButtonClick);
        MenuManager.GoToMenu(MenuName.Main);
    }
    
}
