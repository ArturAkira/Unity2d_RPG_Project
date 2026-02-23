using System;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dialogs : MonoBehaviour
{
    public GameObject texto, textPlaceHolder;
    [SerializeField] public TMP_Text textoContent;
    public bool placeHolder, interact,dEnd;
    public static int i = 0;
    public void textbox(Dictionary<int, string> D)
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
                }
                else
                {
                    texto.SetActive(false);
                    i = 0;
                    dEnd = true;
                }
            }
        }
        
    }
    public void contentSetter(string n,string np)
    {
        texto = GameObject.Find(n);
        textPlaceHolder = GameObject.Find(np);
        texto.SetActive(false);
        textPlaceHolder.SetActive(false);
        interact = false;
        placeHolder = false;
    }
   
    public Dictionary<int, string> npcDialog1 = new Dictionary<int, string>()
        {
            {0, "olá "+startPlay.playerName+", parece que você acordou" },
            {1, "Preciso da sua ajuda!" },
            {2, "tem um goblin maldito bloqueando a porta..." },
            {3, "por favor, pega aquela arma e acaba com ele!" }
        };
    public Dictionary<int, string> enemyDialog1 = new Dictionary<int, string>()
        {
            {0, "Aí seu fraco!" },
            {1, "Ta achando que vai conseguir sair daqui?" },
            {2, "então cai pra treta!" }
        };
}
