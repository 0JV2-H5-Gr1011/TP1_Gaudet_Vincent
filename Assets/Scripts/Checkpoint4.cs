using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Checkpoint4 : MonoBehaviour
{
    public bool hit4 = false;
    public float trous = 0;
    public TextMeshProUGUI trousTexte;
    bool trous1;
    bool trous2;
    bool trous3;
    [SerializeField] GameObject _objet;
    Vector3 _position;
    Quaternion _rotation;

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
        trous3 = GameObject.Find("flag-red").GetComponent<Checkpoint3>().hit3;



        if (hit4 == false && trous1 == true && trous2 == true && trous3 == true)
        {

            int i = 1;
            while (i < 36)
            {
                _position = new Vector3(Random.Range(13.8f, 17.5f), 402f, Random.Range(271f, 281f));
                _rotation = Random.rotation;
                Instantiate(_objet, _position, _rotation);
                i += 1;
            }

            trous = 4;
            hit4 = true;
            string score = trous.ToString();
            string fraction = "/4 Trous";
            trousTexte.text = score + fraction;
        }
    }
}
