using UnityEngine;

public class fightEvent : MonoBehaviour
{
    public static entityClass tempPlayer, tempEnemy;
    [SerializeField] private classes classes;
    [SerializeField] private exitScript exitScript;
    [SerializeField] private playerManager playerManager;
    [SerializeField] private enemyStats enemyStats;
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
    
    public static void ataque(ref entityClass ataque, ref entityClass dano)
    {
        dano.vida -= ataque.ataque - dano.defesa;
        Debug.Log(dano.vida);
        if (tempEnemy.vida <= 0)
        {
            exitScript.buttonExitClick();
            Debug.Log("voce venceu");
        }
        if (tempPlayer.vida <= 0)
        {
            exitScript.buttonExitClick();
            Debug.Log("voce perdeu");
        }
    }
}
