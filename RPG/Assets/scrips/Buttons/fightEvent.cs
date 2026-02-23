using UnityEngine;

public class fightEvent : MonoBehaviour
{
    public static entityClass tempPlayer, tempEnemy;
    [SerializeField] private classes classes;
    [SerializeField] private exitScript exitScript;
    [SerializeField] private playerManager playerManager;
    [SerializeField] private enemyStats enemyStats;
    public int expLevel;
    void Start()
    {
        tempPlayer = playerManager.playerClass;
        tempEnemy = enemyStats.enemy;
        Debug.Log("player vida: "+tempPlayer.vida+"\nPlayer ataque: "+tempPlayer.ataque);
        Debug.Log("enemy vida: " + tempEnemy.vida + "\nenemy defese: " + tempEnemy.defesa);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ataque(ref entityClass ataque, ref entityClass dano)
    {
        if (dano.defesa > ataque.ataque){dano.vida -= ataque.ataque - dano.defesa;}
        else { dano.vida -= 1; }
            Debug.Log(dano.vida);
        if (tempEnemy.vida <= 0)
        {
            playerManager.playerClass.vida = tempPlayer.vida;
            GameManager.instance.exp = enemyStats.dieExp; 
            exitScript.buttonExitClick();
            Debug.Log("voce venceu");
        }
        if (tempPlayer.vida <= 0)
        {
            exitScript.buttonExitClick();
            Debug.Log("voce perdeu");
        }
    }

    public void levelUP(int exp)
    {
        if(exp >= expLevel)
        {

        }
    }
}
