using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class fightButton : MonoBehaviour
{
    [SerializeField] private Button buttonFightBtn;
    [SerializeField] private playerManager playerManager;
    [SerializeField] private fightEvent fightEvent;

    private void Start()
    { buttonFightBtn.onClick.AddListener(buttonFightClick); }
    private void buttonFightClick() 
    {
        fightEvent.ataque(ref fightEvent.tempPlayer, ref fightEvent.tempEnemy); 
    }
}