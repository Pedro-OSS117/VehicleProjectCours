using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Narrative Element", menuName = "Narrative/Narrative Element")]
public class NarrativeElement : ScriptableObject
{
    public AudioClip sound;

    public string text;
    public string text_EN;

    // Narrative Struct
    public NarrativeStruct[] myNarrative;

    // PAS BIEN
    public string[] allText = new string[]
    {
        "Premmier text",
        "Deuxieme text"
    };
}


[Serializable]
public struct NarrativeStruct
{
    public AudioClip sound;

    public string text;
}