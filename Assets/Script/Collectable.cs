using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private GameplayManager gameplayManager;


    // Start is called before the first frame update
    void Awake()
    {
        gameplayManager = GameObject.Find("GameplayManager").GetComponent<GameplayManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IsCollected()
    {
        gameplayManager.AddPieces();
        Destroy(gameObject);
    }
}
