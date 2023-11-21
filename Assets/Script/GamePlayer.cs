using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GamePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collectable")
        {
            other.GetComponent<Collectable>().IsCollected();
            Debug.Log(other);
        }
        
        if (other.tag == "PNJ")
        {
            other.GetComponent<PnjController>().StartConversation();
        }

        if (other.tag == "Portail")
        {
            other.GetComponent<Portail>().ChangeLevel();
        }
        
    }
}
