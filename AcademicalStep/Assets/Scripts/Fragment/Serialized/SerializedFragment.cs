using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SerializedFragment
{
    public string content;
    public string fragmentID;
    public SerializedChoice[] choices;
    public SerializedCharacter[] characters;
    public string speakerID;
    public string backgroundPath;
    public string systemMessage; // Error messages, etc.
}