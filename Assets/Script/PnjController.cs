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
            if (gameplayManager.canGivePiece(QuestNumberOfPieces))
            {
                queteButton.SetActive(true);
                testQuitButton.SetActive(true);
                queteButton.GetComponent<Button>().onClick.AddListener(delegate { FivePiece(QuestNumberOfPieces); });
            }
            
        }

        if (actualDialogue == 3)
        {
            //queteButton.SetActive(true);

        }

        if (actualDialogue > 3)
        {
            ClosedDialogue();
        }

        dialoguesManager.SetDialogueUI();
    }

    public void FivePiece(int i)
    {
        gameplayManager.GivePiece(i);
        queteButton.SetActive(false);
        textSuivantButton.SetActive(true);
        actualDialogue++;
        dialoguesManager.SetDialogueUI();
    }

    public void ClosedDialogue()
    {
        dialoguesManager.ClosedDialogueUI();
    }
}
