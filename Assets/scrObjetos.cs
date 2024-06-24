using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrObjetos : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] objetos;
    int pos = 0;
    void Start()
    {
        foreach (GameObject objeto in objetos)
        {
            objeto.SetActive(false);
        }

        objetos[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pos++;

            if (pos > objetos.Length-1)
            {
                pos = 0;
                objetos[pos].SetActive(true);
                objetos[objetos.Length-1].SetActive(false);
            } else
            {
                objetos[pos].SetActive(true);
                objetos[pos-1].SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pos--;
            if (pos < 0)
            {
                pos = objetos.Length-1;
                objetos[pos].SetActive(true);
                objetos[0].SetActive(false);
            } else
            {
                objetos[pos].SetActive(true);
                objetos[pos + 1].SetActive(false);
            }
        }

       

       
    }

   
}
