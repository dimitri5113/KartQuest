using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portail : MonoBehaviour
{
    [SerializeField] private string LevelName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLevel(){
        Debug.Log("ChngeLevel");
        SceneManager.LoadScene(LevelName);
    }
}
