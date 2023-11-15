using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public int numbersOfPieces = 0;
    
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPieces()
    {
        numbersOfPieces ++;
    }


}
