using Microsoft.Unity.VisualStudio.Editor;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int[] guerreiroStats = new int[] { 46, 28, 16, 5, 5 };
    public int[] magoStats = new int[] { 33, 15, 18, 14, 20 };
    public int[] arqueiroStats = new int[] { 38, 15, 17, 20, 10 };
    public int exp = 0;
    public int playerClassSelection;
    public HashSet<string> collectedItems = new HashSet<string>();
    public Objects[] slots;
    public int[] slotAmount;
    public List<Objects> gameWepons;

    private void Awake()
    { 
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}