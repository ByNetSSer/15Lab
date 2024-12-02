using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pasarlayout : MonoBehaviour
{
    public string LAYOUT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            
        }
    }
   public void LoadScene()
    {
        SceneManager.LoadScene(LAYOUT);
    }
}
