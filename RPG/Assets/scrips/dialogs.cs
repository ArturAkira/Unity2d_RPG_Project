using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

public class dialogs : MonoBehaviour
{
    [SerializeField] private startPlay startPlay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Debug.Log(startPlay.playerName);
    }
    public Dictionary<int, string> npcDialog1 = new Dictionary<int, string>()
        {
            {0, "olá"+startPlay.playerName+", parece que você acordou" },
            { 1, "A saída é por aqui." },
            {2, "pode ir embora." }
        };
}
