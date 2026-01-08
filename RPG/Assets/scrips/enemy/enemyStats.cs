using UnityEngine;
using UnityEngine.Video;

public class enemyStats : MonoBehaviour
{
    [SerializeField] entityClass enemy;
    [SerializeField] public classes classe;
    void Start()
    {
        classes.classSetter(ref enemy, classe.enemy1);
        Debug.Log($"Status do inimigo: \nvida: {enemy.vida}, defesa: {enemy.defesa}, ataque: {enemy.ataque}, distâcia: {enemy.distância}, magia: {enemy.magia}");
    }
}
