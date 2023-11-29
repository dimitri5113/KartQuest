using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PnjController : MonoBehaviour
{
    public int actualDialogue = 0;
    public GameplayManager gameplayManager;
    public DialoguesManager dialoguesManager;
    public DialoguesWithPNJ dialoguesWithPNJ;
    public InterfaceManager interfaceManager;
    public QuestOfPnj questOfPnj;


    public GameObject textSuivantButton;
    public GameObject queteButton;
    public GameObject testQuitButton;

    public int QuestNumberOfPieces = 5;

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
        if (actualDialogue == 2)
        {
            gameplayManager.questIsActive = true;
            textSuivantButton.SetActive(false);
            testQuitButton.SetActive(true);
            queteButton.SetActive(true);
            
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
        actualDialogue++;
        if (actualDialogue == 2)
        {
            gameplayManager.questIsActive = true;
            textSuivantButton.SetActive(false);
            testQuitButton.SetActive(true);
            queteButton.SetActive(true);
            
        }

        if (actualDialogue == 3)
        {

        }

        if (actualDialogue > 3)
        {
            ClosedDialogue();
        }

        dialoguesManager.SetDialogueUI();
    }


    public void ClosedDialogue()
    {
        dialoguesManager.ClosedDialogueUI();
    }

    public void CheckQuest()
    {
        if (gameplayManager.numbersOfPieces >= questOfPnj.nombresDePieces)
        {
            gameplayManager.GivePiece(questOfPnj.nombresDePieces);
            gameplayManager.questIsActive = false;
            actualDialogue = questOfPnj.dialogueToGoOnFinished;
            dialoguesManager.SetDialogueUI();
            interfaceManager.UpdatePiecesInterface();
            textSuivantButton.SetActive(true);
            queteButton.SetActive(false);

        }
    }
}
