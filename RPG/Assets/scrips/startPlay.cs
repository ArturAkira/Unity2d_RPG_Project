using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startPlay : MonoBehaviour
{
    [SerializeField] private Button start;
    [SerializeField] public int selecNumber;
    [SerializeField] private TMP_InputField nameInputField;
    public static string playerName;

    private void Awake()
    {start.onClick.AddListener(loadScene);}
    public void loadScene()
    {
        playerName = nameInputField.text;
        GameManager.instance.playerClassSelection = selecNumber;
        if (playerName != "")
        {SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);}
    }
}
