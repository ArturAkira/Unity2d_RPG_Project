using UnityEngine;

public class fightEvent : MonoBehaviour
{
    [SerializeField] private playerManager playerManager;
    private int pVida, pAtaque, pDefesa, pDistancia, pMagia;
    void Start()
    {
        pVida = playerManager.playerClass.vida;
        pAtaque = playerManager.playerClass.ataque;
        pDefesa = playerManager.playerClass.defesa;
        pDistancia = playerManager.playerClass.distância;
        pMagia = playerManager.playerClass.magia;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
