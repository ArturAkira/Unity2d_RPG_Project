using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class fightButton : MonoBehaviour
{
    [SerializeField] private Button buttonFightBtn;
    private void Start()
    { buttonFightBtn.onClick.AddListener(buttonFightClick); }
    private void buttonFightClick() {  }
}