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
    public int[] guerreiroStats = { 46, 28, 16, 5, 5, };
    public int[] magoStats = {33,15,18,14,20};
    public int[] arqueiroStats = { 38, 15, 17, 20, 10 };
    public int[] enemy1 = { 10,15,5,5,5};
    public static void classSetter(ref entityClass n, int[] v)
    {
        n.vida = v[0];
        n.defesa = v[1];
        n.ataque = v[2];
        n.distância = v[3];
        n.magia = v[4];
    }
}