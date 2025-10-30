using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class npcManager : dialogs
{
    void Start()
    {
        contentSetter("textPanel", "placeHolder");
    }

    void Update()
    {
        interact = Input.GetKeyDown(KeyCode.E);
        textbox(npcDialog1);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") == true) {placeHolder = true;}
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
}