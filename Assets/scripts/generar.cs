using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class generar : MonoBehaviour
{
    public GameObject prefabenemy;
    float minposicion=-1.5f;
    float maxposicion = 1.5f;
    public float countspawn;
    public float concurrenttimecreation;
    public Getpoints getpoin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        concurrenttimecreation = concurrenttimecreation + Time.deltaTime;
        if(concurrenttimecreation> countspawn)
        {
            GameObject enemigo = Instantiate(prefabenemy, new Vector2(Random.Range(minposicion, maxposicion), transform.position.y), transform.rotation);
            enemigo.GetComponent<destroy>().assigpoints(getpoin);
            
            
            concurrenttimecreation = 0;
        }
    }
}
