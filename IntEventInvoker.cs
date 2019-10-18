﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IntEventInvoker : MonoBehaviour
{
    protected Dictionary<EventName, UnityEvent<int, GameType>> unityEvents =
        new Dictionary<EventName, UnityEvent<int, GameType>>();

    /// <summary>
    /// Adds the given listener for the given event name
    /// </summary>
    /// <param name="eventName">event name</param>
    /// <param name="listener">listener</param>
    public void AddListener(EventName eventName, UnityAction<int, GameType> listener)
    {
        if (unityEvents.ContainsKey(eventName))
        {
            unityEvents[eventName].AddListener(listener);
        }
    }
}
