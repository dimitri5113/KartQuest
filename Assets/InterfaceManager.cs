using System;
using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.WellKnownTypes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    public GameplayManager gameplayManager;
    public Text pieceText;
    void Awake()
    {
        gameplayManager = GameObject.Find("GameplayManager").GetComponent<GameplayManager>();
    }
    void Start()
    {
       UpdatePiecesInterface();
    }

    // Update is called once per frame
    public void UpdatePiecesInterface()
    {
         pieceText.text =  "nombre de piece: " + gameplayManager.numbersOfPieces ;
    }
}
