using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnjController : MonoBehaviour
{
    public int actualDialogue = 0;
    public GameplayManager gameplayManager;
    public DialoguesManager dialoguesManager;
    public DialoguesWithPNJ dialoguesWithPNJ;
    
    void Awake()
    {
        gameplayManager = GameObject.Find("GameplayManager").GetComponent<GameplayManager>();
    }
    void Start()
    {
        if (gameplayManager.questIsActive == true)
        {
            actualDialogue = 2;
        }
        else
        {
            actualDialogue = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartConversation()
    {
       dialoguesManager.StartDialogueUI(this);
    }
    
    public void NextDialogue()
    {
        actualDialogue ++;
        if (actualDialogue == 2)
        {
            gameplayManager.questIsActive = true;
        }
        if (actualDialogue > 2)
        {
            ClosedDialogue();
        }

         dialoguesManager.SetDialogueUI();
    }

    public void ClosedDialogue()
    {
        dialoguesManager.ClosedDialogueUI();
    }
}
