using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startPlay : MonoBehaviour
{
    [SerializeField] private Button start;
    [SerializeField] public int selecNumber;
    [SerializeField] private TMP_InputField nameInputField; // referência ao InputField
    public static string playerName; // variável onde guardamos o texto
    public static int playerClassSelection;

    private void Awake()
    {start.onClick.AddListener(loadScene);}
    public void loadScene()
    {
        playerName = nameInputField.text;
        playerClassSelection = selecNumber;
        if (playerName != "")
        {SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);}
    }
}
