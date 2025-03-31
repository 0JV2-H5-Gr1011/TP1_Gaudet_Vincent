using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Checkpoint2 : MonoBehaviour
{

    private bool hit2 = false;
    public float trous = 0;
    public TextMeshProUGUI trousTexte;

    // Start is called before the first frame update
    void Start()
    {
       // float trous = GameObject.Find("flag-blue").GetComponent<Checkpoint1>().trous;
        //TextMeshProUGUI trousTexte = GameObject.Find("flag-blue").GetComponent<Checkpoint1>().trousTexte;
       // bool trous1 = GameObject.Find("flag-green").GetComponent<Checkpoint1>().hit1;
    }

    void /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        bool trous1 = GameObject.Find("flag-green").GetComponent<Checkpoint1>().hit1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(hit2==false && trous1 == true){
            trous = 2;
            hit2 = true;
            string score = trous.ToString();
            string fraction = "/4 Trous";
            trousTexte.text = score+fraction;
        }
    }
}
