using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialoguesManager : MonoBehaviour
{
    public PnjController pnjName;
    public GameObject canvas;
    public TMP_Text nameOfSpeaker;
    public TMP_Text dialogueOfSpeaker;
    
    public void StartDialogueUI(PnjController pnj)
    {
        pnjName = pnj;
        SetDialogueUI();
    }
    public void NextDialogueUI()
    {
        SetDialogueUI();
    }
    public void SetDialogueUI()
    {
        nameOfSpeaker.text = pnjName.dialoguesWithPNJ.Dialogues[pnjName.actualDialogue].name;
        dialogueOfSpeaker.text = pnjName.dialoguesWithPNJ.Dialogues[pnjName.actualDialogue].text;
    }
    public void ClosedDialogueUI()
    {
        canvas.SetActive(false);
    }
}