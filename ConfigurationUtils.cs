using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    #region Fields

    static ConfigurationData configurationData;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    public static float PaddleMoveUnitsPerSecond
    {
        get { return configurationData.PaddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the impulse force to apply to a ball
    /// to get it moving
    /// </summary>
    public static float BallImpulseForce
    {
        get { return GameUtils.MinImpulseForce; }
    }
    

    /// <summary>
    /// Gets how many seconds a ball stays alive
    /// </summary>
    public static float BallLifeSeconds
    {
        get { return configurationData.BallLifeSeconds; }
    }

    /// <summary>
    /// Gets the min spawn delay for ball spawning
    /// </summary>
    public static float MinSpawnDelay
    {
        get { return GameUtils.MinSpawnDelay; }
    }

    /// <summary>
    /// Gets the max spawn delay for ball spawning
    /// </summary>
    public static float MaxSpawnDelay
    {
        get { return GameUtils.MaxSpawnDelay; }
    }

    /// <summary>
    /// Gets the number of points a standard ball is worth
    /// </summary>
    public static float StandardPoints
    {
        get { return configurationData.StandardPoints; }
    }

    /// <summary>
    /// Gets the number of hits a standard ball is worth
    /// </summary>
    public static float StandardHits
    {
        get { return configurationData.StandardHits; }
    }

    /// <summary>
    /// Gets the number of points a bonus ball is worth
    /// </summary>
    public static float BonusPoints
    {
        get { return configurationData.BonusPoints; }
    }

    /// <summary>
    /// Gets the number of hits a bonus ball is worth
    /// </summary>
    public static float BonusHits
    {
        get { return configurationData.BonusHits; }
    }

    /// <summary>
    /// Gets the number of seconds the freezer effect lasts
    /// </summary>
    public static float FreezerSeconds
    {
        get { return configurationData.FreezerSeconds; }
    }

    /// <summary>
    /// Gets the number of seconds the speedup effect lasts
    /// </summary>
    public static float SpeedupSeconds
    {
        get { return configurationData.SpeedupSeconds; }
    }

    /// <summary>
    /// Gets the speedup multiplier
    /// </summary>
    public static float SpeedupFactor
    {
        get { return configurationData.SpeedupFactor; }
    }

    /// <summary>
    /// Gets the probability of spawning a standard ball
    /// </summary>
    public static float StandardBallSpawnProbability
    {
        get { return configurationData.StandardBallSpawnProbability; }
    }

    /// <summary>
    /// Gets the probability of spawning a bonus ball
    /// </summary>
    public static float BonusBallSpawnProbability
    {
        get { return configurationData.BonusBallSpawnProbability; }
    }

    /// <summary>
    /// Gets the probability of spawning a freezer pickup
    /// </summary>
    public static float FreezerPickupSpawnProbability
    {
        get { return configurationData.FreezerPickupSpawnProbability; }
    }

    /// <summary>
    /// Gets the probability of spawning a speedup pickup
    /// </summary>
    public static float SpeedupPickupSpawnProbability
    {
        get { return configurationData.SpeedupPickupSpawnProbability; }
    }

    #endregion

    #region Difficulty Stuff

    public static float MinSpawnDelayEasy
    {
        get { return configurationData.MinSpawnDelayEasy; }
    }

    public static float MinSpawnDelayMedium
    {
        get { return configurationData.MinSpawnDelayMedium; }
    }

    public static float MinSpawnDelayHard
    {
        get { return configurationData.MinSpawnDelayHard; }
    }

    public static float MaxSpawnDelayEasy
    {
        get { return configurationData.MaxSpawnDelayEasy; }
    }

    public static float MaxSpawnDelayMedium
    {
        get { return configurationData.MaxSpawnDelayMedium; }
    }

    public static float MaxSpawnDelayHard
    {
        get { return configurationData.MaxSpawnDelayHard; }
    }


    public static float MinImpulseForceEasy
    {
        get { return configurationData.BallImpulseForceEasy; }
    }

    public static float MinImpulseForceMedium
    {
        get { return configurationData.BallImpulseForceMedium; }
    }

    public static float MinImpulseForceHard
    {
        get { return configurationData.BallImpulseForceHard; }
    }
    #endregion

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }
}
