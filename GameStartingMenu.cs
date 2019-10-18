using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameStartingMenu : IntEventInvoker
{
    protected GameStartedEvent gameStartedEvent = new GameStartedEvent();

    void Start()
    {
        unityEvents.Add(EventName.GameStartedEvent, new GameStartedEvent());
        EventManager.AddInvoker(EventName.GameStartedEvent, this);
    }

    public void AddGameStartedListener(UnityAction<int, GameType> listener)
    {
        gameStartedEvent.AddListener(listener);
    }
}
