using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class DialoguesManager : MonoBehaviour
{
    public PnjController pnjName;
    public GameObject canvas;
    public TMP_Text nameOfSpeaker;
    public TMP_Text dialogueOfSpeaker;

    public GameObject textSuivantButton;
    public GameObject queteButton;
    public GameObject testQuitButton;
    
    public void StartDialogueUI(PnjController pnj)
    {
        pnjName = pnj;
        SetDialogueUI();
        canvas.SetActive(true);
    }
    public void NextDialogueUI()
    {
        SetDialogueUI();
    }
    public void SetDialogueUI()
    {
        if(pnjName.actualDialogue >= pnjName.dialoguesWithPNJ.Dialogues.Length) {
            return;
        }
        nameOfSpeaker.text = pnjName.dialoguesWithPNJ.Dialogues[pnjName.actualDialogue].name;
        dialogueOfSpeaker.text = pnjName.dialoguesWithPNJ.Dialogues[pnjName.actualDialogue].text;
    }
    public void ClosedDialogueUI()
    {
        canvas.SetActive(false);
    }
    public void NextDialogue()
    {
     
    }
}