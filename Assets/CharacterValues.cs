using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterValues : MonoBehaviour
{
    public string characterName = "My name";
    private int characterLevel = 5;
    private int outputValue;

    void Start()
    {
        Debug.Log(characterName);
        outputValue = RandomCalculations(characterLevel);
        Debug.Log($"Output value: {outputValue}");
        PrintCharacterValues(characterName, characterLevel);
    }

    void Update()
    {
        
    }

    /// <summary>
    /// Prints the characters name and level in the console.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="level"></param>
    public void PrintCharacterValues(string name, int level)
    {
        Debug.Log($"Player name: {name} | Player level: {level}");
    }

    /// <summary>
    /// Does some random calculations with the input, and outputs the result.
    /// </summary>
    /// <param name="level"></param>
    /// <returns></returns>
    public int RandomCalculations(int level)
    {
        return level * 5 + 10;
    }
}
