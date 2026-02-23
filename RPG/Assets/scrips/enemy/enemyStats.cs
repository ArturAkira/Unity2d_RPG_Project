using UnityEngine;
using UnityEngine.Video;

public class enemyStats : MonoBehaviour
{
    [SerializeField] public static entityClass enemy;
    [SerializeField] public classes classe;
    [SerializeField] public fightEvent fightEvent;
    public string enemyClass;
    public string coisa;
    public bool winState;
    public int dieExp;
    void Awake()
    {
        classes.classSetter(ref enemy, classe.enemyStatsList[coisa]);
        fightEvent.tempEnemy = enemy;
        //Debug.Log($"Status do inimigo: \nvida: {enemy.vida}, defesa: {enemy.defesa}, ataque: {enemy.ataque}, distâcia: {enemy.distância}, magia: {enemy.magia}");
    }

}
