using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";
    Dictionary<ConfigurationDataValueName, float> values = 
        new Dictionary<ConfigurationDataValueName, float>();


    #endregion

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public float PaddleMoveUnitsPerSecond
    {
        get { return values[ConfigurationDataValueName.PaddleMoveUnitsPerSecond]; }
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public float BallImpulseForceEasy
    {
        get { return values[ConfigurationDataValueName.BallImpulseForceEasy]; }
    }

    public float BallImpulseForceMedium
    {
        get { return values[ConfigurationDataValueName.BallImpulseForceMedium]; }
    }

    public float BallImpulseForceHard
    {
        get { return values[ConfigurationDataValueName.BallImpulseForceHard]; }
    }

    /// <summary>
    /// Gets how many seconds a ball stays alive
    /// </summary>
    public float BallLifeSeconds
    {
        get { return values[ConfigurationDataValueName.BallLifeSeconds]; }
    }

    /// <summary>
    /// Gets the min spawn delay for ball spawning
    /// </summary>
    public float MinSpawnDelayEasy
    {
        get { return values[ConfigurationDataValueName.MinSpawnDelayEasy]; }
    }

    /// <summary>
    /// Gets the max spawn delay for ball spawning
    /// </summary>
    public float MaxSpawnDelayEasy
    {
        get { return values[ConfigurationDataValueName.MaxSpawnDelayEasy]; }
    }

    public float MinSpawnDelayMedium
    {
        get { return values[ConfigurationDataValueName.MinSpawnDelayMedium]; }
    }

    /// <summary>
    /// Gets the max spawn delay for ball spawning
    /// </summary>
    public float MaxSpawnDelayMedium
    {
        get { return values[ConfigurationDataValueName.MaxSpawnDelayMedium]; }
    }

    public float MinSpawnDelayHard
    {
        get { return values[ConfigurationDataValueName.MinSpawnDelayHard]; }
    }

    /// <summary>
    /// Gets the max spawn delay for ball spawning
    /// </summary>
    public float MaxSpawnDelayHard
    {
        get { return values[ConfigurationDataValueName.MaxSpawnDelayHard]; }
    }

    /// <summary>
    /// Gets the number of points a standard ball is worth
    /// </summary>
    public float StandardPoints
    {
        get { return values[ConfigurationDataValueName.StandardPoints]; }
    }

    /// <summary>
    /// Gets the number of hits a standard ball is worth
    /// </summary>
    public float StandardHits
    {
        get { return values[ConfigurationDataValueName.StandardHits]; }
    }

    /// <summary>
    /// Gets the number of points a bonus ball is worth
    /// </summary>
    public float BonusPoints
    {
        get { return values[ConfigurationDataValueName.BonusPoints]; }
    }

    /// <summary>
    /// Gets the number of hits a bonus ball is worth
    /// </summary>
    public float BonusHits
    {
        get { return values[ConfigurationDataValueName.BonusHits]; }
    }

    /// <summary>
    /// Gets the number of seconds the freezer effect lasts
    /// </summary>
    public float FreezerSeconds
    {
        get { return values[ConfigurationDataValueName.FreezerSeconds]; }
    }

    /// <summary>
    /// Gets the number of seconds the speedup effect lasts
    /// </summary>
    public float SpeedupSeconds
    {
        get { return values[ConfigurationDataValueName.SpeedUpSeconds]; }
    }

    /// <summary>
    /// Gets the speedup multiplier
    /// </summary>
    public float SpeedupFactor
    {
        get { return values[ConfigurationDataValueName.SpeedUpFactor]; }
    }

    /// <summary>
    /// Gets the probability of spawning a standard ball
    /// </summary>
    public float StandardBallSpawnProbability
    {
        get { return values[ConfigurationDataValueName.StandardBallProbability]; }
    }

    /// <summary>
    /// Gets the probability of spawning a bonus ball
    /// </summary>
    public float BonusBallSpawnProbability
    {
        get { return values[ConfigurationDataValueName.BonusBallProbability]; }
    }

    /// <summary>
    /// Gets the probability of spawning a freezer pickup
    /// </summary>
    public float FreezerPickupSpawnProbability
    {
        get { return values[ConfigurationDataValueName.FreezerPickupProbability]; }
    }

    /// <summary>
    /// Gets the probability of spawning a speedup pickup
    /// </summary>
    public float SpeedupPickupSpawnProbability
    {
        get { return values[ConfigurationDataValueName.SpeedupPickupProbability]; }
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        // read and save configuration data from file
        StreamReader input = null;
        try
        {
            // create stream reader object
            input = File.OpenText(Path.Combine(
                Application.streamingAssetsPath, ConfigurationDataFileName));
            

            string currentLine = input.ReadLine();
            while(currentLine != null)
            {
                string[] tokens = currentLine.Split(',');
                ConfigurationDataValueName valueName =
                    (ConfigurationDataValueName)Enum.Parse(typeof(ConfigurationDataValueName), tokens[0]);
                values.Add(valueName, float.Parse(tokens[1]));
                currentLine = input.ReadLine();
            }

            // set configuration data fields
            //SetConfigurationDataFields(values);
        }
        catch (Exception e)
        {
            setDefaultValues();
        }
        finally
        {
            // always close input file
            if (input != null)
            {
                input.Close();
            }
        }
    }

    #endregion


    void setDefaultValues()
    {
        values.Clear();
        values.Add(ConfigurationDataValueName.PaddleMoveUnitsPerSecond, 5);
        values.Add(ConfigurationDataValueName.BallImpulseForceEasy, 5);
        values.Add(ConfigurationDataValueName.BallImpulseForceMedium, 7);
        values.Add(ConfigurationDataValueName.BallImpulseForceHard, 9);
        values.Add(ConfigurationDataValueName.BallLifeSeconds, 10);
        values.Add(ConfigurationDataValueName.MinSpawnDelayEasy, 5);
        values.Add(ConfigurationDataValueName.MaxSpawnDelayEasy, 10);
        values.Add(ConfigurationDataValueName.MinSpawnDelayMedium, 3);
        values.Add(ConfigurationDataValueName.MaxSpawnDelayMedium, 7);
        values.Add(ConfigurationDataValueName.MinSpawnDelayHard, 1);
        values.Add(ConfigurationDataValueName.MaxSpawnDelayHard, 4);
        values.Add(ConfigurationDataValueName.StandardPoints, 1);
        values.Add(ConfigurationDataValueName.StandardHits, 1);
        values.Add(ConfigurationDataValueName.BonusPoints, 2);
        values.Add(ConfigurationDataValueName.BonusHits, 2);
        values.Add(ConfigurationDataValueName.FreezerSeconds, 2);
        values.Add(ConfigurationDataValueName.SpeedUpSeconds, 2);
        values.Add(ConfigurationDataValueName.SpeedUpFactor, 2);
        values.Add(ConfigurationDataValueName.StandardBallProbability, 0.6f);
        values.Add(ConfigurationDataValueName.BonusBallProbability, 0.2f);
        values.Add(ConfigurationDataValueName.FreezerPickupProbability, 0.1f);
        values.Add(ConfigurationDataValueName.SpeedupPickupProbability, 0.1f);
    }
}
