using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class DialoguesWithPNJ : ScriptableObject
{[System.Serializable]
    public class DialogueEntry
    {
        public string name;
        public string text;
    }

    public DialogueEntry[] Dialogues;
}
