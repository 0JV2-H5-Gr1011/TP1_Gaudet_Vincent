using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinDuJeu : MonoBehaviour
{

    bool trous1;
    bool trous2;
    bool trous3;
    bool trous4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        trous1 = GameObject.Find("flag-green").GetComponent<Checkpoint1>().hit1;
        trous2 = GameObject.Find("flag-blue").GetComponent<Checkpoint2>().hit2;
        trous3 = GameObject.Find("flag-red").GetComponent<Checkpoint3>().hit3;
        trous4 = GameObject.Find("flag-large-red").GetComponent<Checkpoint4>().hit4;
        if(trous1 == true && trous2 == true && trous3 == true && trous4 == true){
        
        Debug.Log("Victoire");

        }
    }
}
