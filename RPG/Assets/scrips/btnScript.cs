using System;
using UnityEngine;
using UnityEngine.UI;

public class btnScript : playerManager
{
    [SerializeField] private Button inventBtn;
    private void Start()
    {
        inventBtn.onClick.AddListener(inventClick);
    }
   
}
