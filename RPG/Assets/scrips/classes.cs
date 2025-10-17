using UnityEngine;
using System.Collections.Generic;

public class classes : MonoBehaviour
{
    Dictionary<string, int> mago = new Dictionary<string, int>()
    {
        {"vida", 33 },
        {"defesa", 15},
        {"ataque", 18},
        {"distancia", 14},
        {"magia", 20}
    };

    Dictionary<string, int> guerreiro = new Dictionary<string, int>()
    {
        {"vida", 46 },
        {"defesa", 28},
        {"ataque", 16},
        {"distancia", 5},
        {"magia", 5}
    };

    Dictionary<string, int> arqueiro = new Dictionary<string, int>()
    {
        {"vida", 38 },
        {"defesa", 15},
        {"ataque", 17},
        {"distancia", 20},
        {"magia", 10}
    };
}