using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Checkpoint1 : MonoBehaviour
{

    public float trous = 0;
    public bool hit1 = false;
    public TextMeshProUGUI trousTexte;
    [SerializeField] GameObject _objet;
    Vector3 _position;
    Quaternion _rotation;

    // Start is called before the first frame update
    void Start()
    {
        string score = trous.ToString();
             string fraction = "/4 Trous";
            trousTexte.text = score+fraction;
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
        int i = 1;
        
        while(i < 7){
        _position = new Vector3(Random.Range(8f, 18f), 402f, Random.Range(214f, 215f));
        _rotation = Random.rotation;
        Instantiate(_objet, _position, _rotation);
        i += 1;
        }

        if(hit1==false){
            trous += 1;
            hit1 = true;
            string score = trous.ToString();
             string fraction = "/4 Trous";
            trousTexte.text = score+fraction;
        }
    }
}
