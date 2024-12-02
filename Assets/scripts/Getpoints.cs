using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Getpoints : MonoBehaviour
{
    public Text PuntosView;
    public float puntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetPoints(int points)
    {
        puntos = puntos + points;
        PuntosView.text = "Puntaje: " + puntos;
    }
    public void Asigpoints(Text puntitos)
    {
        PuntosView = puntitos;
    }
}
