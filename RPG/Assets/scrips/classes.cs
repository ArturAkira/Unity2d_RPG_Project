using UnityEngine;
using System.Collections.Generic;
public struct entityClass
{
    public int vida;
    public int defesa;
    public int ataque;
    public int distância;
    public int magia;
}
public class classes : MonoBehaviour
{

    public Dictionary<string, int[]> enemyStatsList = new Dictionary<string, int[]>
    {
        {"enemy1", new int[] {10,15,5,5,5} }
    };



    public static void classSetter(ref entityClass n, int[] v)
    {
        n.vida = v[0];
        n.defesa = v[1];
        n.ataque = v[2];
        n.distância = v[3];
        n.magia = v[4];
    }
    public static void spriteSetter(SpriteRenderer pSprite, Sprite inicialSprite)
    {
        pSprite.sprite = inicialSprite;
    }
}