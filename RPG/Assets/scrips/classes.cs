using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    public List<Objects> warriorWepons;
    public List<Objects> mageWepons;
    public List<Objects> archerWepons;

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
    public void itemClassSetter()
    {
        switch (GameManager.instance.playerClassSelection)
        {
            case 0:
                GameManager.instance.gameWepons = warriorWepons;
                break;
            case 1:
                GameManager.instance.gameWepons = mageWepons;
                break;
            case 2:
                GameManager.instance.gameWepons = archerWepons;
                break;
        }
    }
    public Objects itemSetter(int x)
    {
        if (GameManager.instance.gameWepons != null && x < GameManager.instance.gameWepons.Count)
        {
            return GameManager.instance.gameWepons[x];
        }
        return null;
    }
}