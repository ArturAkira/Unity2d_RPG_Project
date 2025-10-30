using UnityEngine;
using UnityEngine.Video;

public class enemyStats : MonoBehaviour
{
    entityClass enemy;
    public int vida, defesa, ataque, distancia, magia;
    private int[] enemyPoints;
    void Start()
    {
        enemyPoints = new int[5] { vida, defesa, ataque, distancia, magia };
        classes.classSetter(ref enemy, enemyPoints);
        Debug.Log($"Status do inimigo: \nvida: {enemy.vida}, defesa: {enemy.defesa}, ataque: {enemy.ataque}, distâcia: {enemy.distância}, magia: {enemy.magia}");
    }
}
