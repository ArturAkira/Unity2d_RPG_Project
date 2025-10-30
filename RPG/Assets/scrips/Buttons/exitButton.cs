using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class exitScript : MonoBehaviour
{
    [SerializeField] private Button buttonExitBtn;
    [SerializeField] private int sceneSelection;
    private void Start()
    {buttonExitBtn.onClick.AddListener(buttonExitClick);}   
    private void buttonExitClick() {SceneManager.LoadScene(sceneSelection);}
}