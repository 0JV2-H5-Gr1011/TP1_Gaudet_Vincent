using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Checkpoint2 : MonoBehaviour
{

    public bool hit2 = false;
    public float trous = 0;
    public TextMeshProUGUI trousTexte;
    bool trous1;
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
        if (hit2 == false && trous1 == true)
        {
            int i = 1;
            while (i < 13)
            {
                _position = new Vector3(Random.Range(16.8f, 17.5f), 402f, Random.Range(220f, 245f));
                _rotation = Random.rotation;
                Instantiate(_objet, _position, _rotation);
                i += 1;
            }

            trous = 2;
            hit2 = true;
            string score = trous.ToString();
            string fraction = "/4 Trous";
            trousTexte.text = score + fraction;
        }
    }
}
