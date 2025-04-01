using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Checkpoint3 : MonoBehaviour
{
    public bool hit3 = false;
    public float trous = 0;
    public TextMeshProUGUI trousTexte;
    bool trous1;
    bool trous2;

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
        trousTexte = GameObject.Find("flag-green").GetComponent<Checkpoint1>().trousTexte;
        trous1 = GameObject.Find("flag-green").GetComponent<Checkpoint1>().hit1;
        trous2 = GameObject.Find("flag-blue").GetComponent<Checkpoint2>().hit2;
        if(hit3==false && trous1 == true && trous2 == true){
            trous = 3;
            hit3 = true;
            string score = trous.ToString();
            string fraction = "/4 Trous";
            trousTexte.text = score+fraction;
        }
    }
}
