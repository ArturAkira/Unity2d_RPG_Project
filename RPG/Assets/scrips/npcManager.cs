using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class npcManager : dialogs
{
    private GameObject texto, textPlaceHolder;
    [SerializeField] private TMP_Text textoContent;
    private bool placeHolder, interact;
    private int i=0;
    void Start()
    {
        texto = GameObject.Find("textPanel");
        textPlaceHolder = GameObject.Find("placeHolder");
        texto.SetActive(false);
        textPlaceHolder.SetActive(false);
        interact = false;
        placeHolder = false;
    }

    void Update()
    {
        interact = Input.GetKeyDown(KeyCode.E);
        textbox(npcDialog1);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") == true)
        {
            placeHolder = true;
        }

    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player") == true)
        {
            placeHolder = false;
            textPlaceHolder.SetActive(false);
            texto.SetActive(false);
        }
    }

    private void textbox(Dictionary<int, string> D)
    {
        if (placeHolder == true)
        {
            textPlaceHolder.SetActive(true);
            if (interact == true)
            {
                texto.SetActive(true);
                if (i < D.Count)
                {
                    textoContent.text = D[i];
                    i++;
                    Debug.Log(i);
                }
                else
                {
                    texto.SetActive(false);
                    i = 0;
                }
            }
        }
    }
}