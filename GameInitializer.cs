using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Initializes the game
/// </summary>
public class GameInitializer : MonoBehaviour 
{
    /// <summary>
    /// Awake is called before Start
    /// </summary>
	void Start()
    {
        // initialize screen and configuration utils
        EventManager.Initialize();
        ScreenUtils.Initialize();
        GameUtils.Initialize();
        ConfigurationUtils.Initialize();
    }
}
