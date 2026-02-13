using UnityEngine;
using UnityEngine.SceneManagement;
public class enemyManager : dialogs
{
    [SerializeField] public int originScene;

    private void Start()
    {
        contentSetter("textPanel2", "placeHolder2");
    }
    private void Update()
    {
        interact = Input.GetKeyDown(KeyCode.E);
        if (dEnd == true) {SceneManager.LoadScene(2);}
        textbox(enemyDialog1);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") == true)
        {
            placeHolder = true;
            textbox(enemyDialog1);
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player") == true)
        {
            placeHolder = false;
            textPlaceHolder.SetActive(false);
            texto.SetActive(false);
        }
    }
}
