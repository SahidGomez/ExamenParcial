using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Internal;
using Unity.VisualScripting;

public class Inventario4x4 : MonoBehaviour
{
    public List<GameObject> Bolsa = new List<GameObject>();
    public GameObject[] Inv;
    public bool Activar_Inv;

    public GameObject Selector;
    public int ID;

    public List<Image> Equipo = new List<Image>();
    public int ID_Equipo;
    public int Fases_Inv;

    public GameObject opciones;
    public Image[] Seleccion;
    public Sprite[] Seleccion_Sprite;
    public int ID_Select;




    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Item"))
        {
            for (int i = 0; i < Bolsa.Count; i++)
            {
                if (Bolsa[i].GetComponent<Image>().enabled == false)
                {
                    Bolsa[i].GetComponent<Image>().enabled = true;
                    Bolsa[i].GetComponent<Image>().sprite = coll.GetComponent<SpriteRenderer>().sprite;
                    coll.gameObject.SetActive(false);
                    break;
                }
            }
        }
    }

    public void Navegar()
    {
        if (Input.GetKeyDown(KeyCode.D) && ID < Bolsa.Count - 1)
        {
            ID++;
        }
        if (Input.GetKeyDown(KeyCode.A) && ID > 0)
        {
            ID--;
        }
        if (Input.GetKeyDown(KeyCode.W) && ID > 3)
        {
            ID -= 4;
        }
        if (Input.GetKeyDown(KeyCode.S) && ID < 12)
        {
            ID += 4;
        }
        Selector.transform.position = Bolsa[ID].transform.position;

        //switch (Fases_Inv)
        //{
        //    case 0:
        //        Selector.SetActive(true);
        //        opciones.SetActive(false);

        //        Inv[1].SetActive(false);
        //        if (Input.GetKeyDown(KeyCode.W) && ID_Equipo > 0)
        //        {
        //            ID_Equipo--;
        //        }
        //        if (Input.GetKeyDown(KeyCode.S) && ID_Equipo < Equipo.Count - 1)
        //        {
        //            ID_Equipo++;
        //        }
        //        Selector.transform.position = Equipo[ID_Equipo].transform.position;

        //        if (Input.GetKeyDown(KeyCode.F) && Activar_Inv)
        //        {
        //            Fases_Inv = 1;
        //        }
        //        break;

        //    case 1:
        //        Selector.SetActive(true);
        //        opciones.SetActive(false);

        //        if (Input.GetKeyDown(KeyCode.F) && Bolsa[ID].GetComponent<Image>().enabled == true)
        //        {
        //            Fases_Inv = 2;

        //        }
        //        Inv[1].SetActive(true);

        //        if (Input.GetKeyDown(KeyCode.D) && ID < Bolsa.Count - 1)
        //        {
        //            ID++;
        //        }
        //        if (Input.GetKeyDown(KeyCode.A) && ID > 0)
        //        {
        //            ID--;
        //        }
        //        if (Input.GetKeyDown(KeyCode.W) && ID > 3)
        //        {
        //            ID -= 4;
        //        }
        //        if (Input.GetKeyDown(KeyCode.S) && ID < 12)
        //        {
        //            ID += 4;
        //        }
        //        Selector.transform.position = Equipo[ID_Equipo].transform.position;

        //        if (Input.GetKeyDown(KeyCode.G) && Activar_Inv)
        //        {
        //            Fases_Inv = 0;
        //        }
        //        break;

        //    case 2:
        //        if (Input.GetKeyDown(KeyCode.G))
        //        {
        //            Fases_Inv = 1;
        //        }
        //        opciones.SetActive(true);
        //        opciones.transform.position = Bolsa[ID].transform.position;
        //        Selector.SetActive(false);

        //        if (Input.GetKeyDown(KeyCode.W) && ID_Select > 0)
        //        {
        //            ID_Select--;
        //        }

        //        if (!Input.GetKeyDown(KeyCode.S) && ID_Select < Seleccion.Length - 1)
        //        {
        //            ID_Select++;
        //        }

        //        switch (ID_Select)
        //        {
        //            case 0:
        //                Seleccion[0].sprite = Seleccion_Sprite[1];
        //                Seleccion[1].sprite = Seleccion_Sprite[0];

        //                if (Input.GetKeyDown(KeyCode.F))
        //                {
        //                    if (Equipo[ID_Equipo].GetComponent<Image>().enabled == false)
        //                    {
        //                        Equipo[ID_Equipo].GetComponent<Image>().sprite = Bolsa[ID].GetComponent<Image>().sprite;
        //                        Equipo[ID_Equipo].GetComponent<Image>().enabled = true;
        //                        Bolsa[ID].GetComponent<Image>().sprite = null;
        //                        Bolsa[ID].GetComponent<Image>().enabled = false;
        //                    }
        //                    else
        //                    {
        //                        Sprite obj = Bolsa[ID].GetComponent<Image>().sprite;
        //                        Bolsa[ID].GetComponent<Image>().sprite = Equipo[ID_Equipo].GetComponent<Image>().sprite;
        //                        Equipo[ID_Equipo].GetComponent<Image>().sprite = obj;
        //                    }


        //                    Fases_Inv = 0;
        //                }
        //                break;

        //            case 1:
        //                Seleccion[0].sprite = Seleccion_Sprite[0];
        //                Seleccion[1].sprite = Seleccion_Sprite[1];
        //                if (Input.GetKeyDown(KeyCode.F))
        //                {
        //                    Bolsa[ID].GetComponent<Image>().sprite = null;
        //                    Bolsa[ID].GetComponent<Image>().enabled = false;
        //                    Fases_Inv = 1;
        //                }
        //                break;

        //        }
        //        break;

        //}
        if (Input.GetKeyDown(KeyCode.F))
        {
            Bolsa[ID].GetComponent<Image>().sprite = null;
            Bolsa[ID].GetComponent<Image>().enabled = false;
            
        }

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Navegar();


        //for (int i = 0; i < Bolsa.Count; i++)
        //{
        //    if (Input.GetKeyDown(KeyCode.Delete))
        //    {
        //        Bolsa[i].GetComponent<Image>().enabled = false;
                
        //        break;
        //    }
        //}

        if (Activar_Inv)
        {
            Inv[0].SetActive(true);
        }
        else
        {
            
            Inv[0].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.I)) 
        {
            Activar_Inv = !Activar_Inv;
        }

    }
}
