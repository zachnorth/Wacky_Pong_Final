using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class GameUtils
{
    #region fields

    static Difficulty difficulty;

    static GameType gameType;

    #endregion

    #region properties

    public static float MinSpawnDelay
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.MinSpawnDelayEasy;
                case Difficulty.Medium:
                    return ConfigurationUtils.MinSpawnDelayMedium;
                case Difficulty.Hard:
                    return ConfigurationUtils.MinSpawnDelayHard;
                default:
                    return ConfigurationUtils.MinSpawnDelayEasy;
            }
        }
    }

    public static float MaxSpawnDelay
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.MaxSpawnDelayEasy;
                case Difficulty.Medium:
                    return ConfigurationUtils.MaxSpawnDelayMedium;
                case Difficulty.Hard:
                    return ConfigurationUtils.MaxSpawnDelayHard;
                default:
                    return ConfigurationUtils.MaxSpawnDelayEasy;
            }
        }
    }

    public static float MinImpulseForce
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.MinImpulseForceEasy;
                case Difficulty.Medium:
                    return ConfigurationUtils.MinImpulseForceMedium;
                case Difficulty.Hard:
                    return ConfigurationUtils.MinImpulseForceHard;
                default:
                    return ConfigurationUtils.MinImpulseForceEasy;
            }
        }
    }


    #endregion

    #region Public Methods

    public static void Initialize()
    {
        EventManager.AddListener(EventName.GameStartedEvent, HandleGameStartedEvent);
    }

    public static GameType GetGameType
    {
        get { return gameType; }
    }
    
    #endregion

    #region Private Methods

    static void HandleGameStartedEvent(int intDifficulty, GameType gameTypeTemp)
    {
        difficulty = (Difficulty)intDifficulty;
        gameType = gameTypeTemp;
        SceneManager.LoadScene("gameplay");
    }

    #endregion
}
