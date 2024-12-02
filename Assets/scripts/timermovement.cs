using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timermovement : MonoBehaviour
{
    Transform transform_;

    public float movimiento;
 
    public float setime;


    // Start is called before the first frame update
    void Awake()
    {
        transform_ = GetComponent<Transform>();
            
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x,transform.position.y-0.2f*Time.deltaTime);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject,100*Time.deltaTime);
    }

}
