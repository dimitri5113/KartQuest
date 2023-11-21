using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public int numbersOfPieces = 0;
    public static GameplayManager instance;

    public bool questIsActive = false;
    
    void Awake()
    {

        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
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
