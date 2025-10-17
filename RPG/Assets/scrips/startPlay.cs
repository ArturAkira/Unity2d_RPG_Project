using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startPlay : MonoBehaviour
{
    [SerializeField] private Button start;
    public static int selecNumber;
    [SerializeField] private TMP_InputField nameInputField; // referência ao InputField
    public static string playerName; // variável onde guardamos o texto

    private void Awake()
    {
        start.onClick.AddListener(loadScene);
    }
    public void loadScene()
    {
        playerName = nameInputField.text;
        if (playerName != "")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
