using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class exitScript : MonoBehaviour
{
    [SerializeField] private Button buttonExitBtn;
    public int sceneIndex;
    public static int sceneSelection;
    private void Start()
    {
        sceneSelection = sceneIndex;
        buttonExitBtn.onClick.AddListener(buttonExitClick);
    }   
    public static void buttonExitClick() {SceneManager.LoadScene(sceneSelection);}
}