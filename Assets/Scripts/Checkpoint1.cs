using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Checkpoint1 : MonoBehaviour
{

    public float trous = 0;
    public bool hit1 = false;
    public TextMeshProUGUI trousTexte;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    private void OnTriggerEnter(Collider other)
    {
        if(hit1==false){
            trous += 1;
            hit1 = true;
            string score = trous.ToString();
             string fraction = "/4 Trous";
            trousTexte.text = score+fraction;
        }
    }
}
