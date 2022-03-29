using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej08v2 : MonoBehaviour
{
    public int dado1;
    public int dado2;
    public int dado3;
    int caso = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(dado1 == 6)
        {
            caso++;
        }
        if (dado2 == 6)
        {
            caso++;
        }
        if(dado3 == 6)
        {
            caso++;
        }
        switch (caso)
        {
            case 3:
                Debug.Log("Excelente");
                break;
            case 2:
                Debug.Log("Muy Bien");
                break;
            case 1:
                Debug.Log("Regular");
                break;
            default:
                Debug.Log("Insuficiente");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
