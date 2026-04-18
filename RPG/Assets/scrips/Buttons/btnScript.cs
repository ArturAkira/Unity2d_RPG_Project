using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btnScript : MonoBehaviour
{ 
    [SerializeField] private Button inventBtn;
    [SerializeField] private playerManager playerManager;
    private void Start()
    {
        inventBtn.onClick.AddListener(buttonInventClick);
    }
    private void buttonInventClick()
    {
        playerManager.inventClick();
    }
}