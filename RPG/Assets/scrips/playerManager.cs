using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UIElements;
public class playerManager : MonoBehaviour 
{
    [SerializeField] private classes classes;
    [SerializeField] private fightEvent fightEvent;
    private Rigidbody2D player;
    private Vector2 moveInput;
    private GameObject inventario;
    private SpriteRenderer sr;
    public Sprite guerreiro;
    public Sprite mago;
    public Sprite arqueiro;
    private int maxLife;
    public float speed = 5f;
    public bool invent, open;
    public static entityClass playerClass;

    void Awake()
    {
        player = GetComponent<Rigidbody2D>();
        inventario = GameObject.Find("inventário");
    }
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Sprite teste = Resources.Load<Sprite>("pixelMap_20");
        playerClass.vida = fightEvent.tempPlayer.vida;
        if (playerClass.vida <= 0)
        {
            switch (GameManager.instance.playerClassSelection)
            {
                case 0:
                    Debug.Log(GameManager.instance.guerreiroStats);
                    classes.classSetter(ref playerClass, GameManager.instance.guerreiroStats);
                    classes.spriteSetter(sr, guerreiro);
                    Debug.Log("você escolheu o guerreiro");
                    break;
                case 1:
                    classes.classSetter(ref playerClass, GameManager.instance.magoStats);
                    classes.spriteSetter(sr, mago);
                    Debug.Log("você escolheu o mago");
                    Debug.Log(sr);
                    Debug.Log(teste);
                    break;
                case 2:
                    classes.classSetter(ref playerClass, GameManager.instance.arqueiroStats);
                    classes.spriteSetter(sr, arqueiro);
                    Debug.Log("você escolheu o arqueiro");
                    break;
            }
            maxLife = playerClass.vida;
        }
        fightEvent.tempPlayer = playerClass;
        Debug.Log($"Status: \nvida: {playerClass.vida}, defesa: {playerClass.defesa}, ataque: {playerClass.ataque}, distâcia: {playerClass.distância}, magia: {playerClass.magia}");
        open = false;
        inventario.SetActive(false);
    }
    void Update()
    {
        invent = Input.GetKeyDown(KeyCode.I);
        if (invent == true) {inventClick();}
    }
    private void FixedUpdate()
    {
        moveInput = movementWay();
        if(dialogs.i == 0) { player.MovePosition(player.position + (moveInput * speed * Time.fixedDeltaTime)); }
    }
    private Vector2 movementWay()
    {
        if(open == false)
        {
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");
            if (moveY != 0) { moveX = 0; }
            if (moveX != 0) { moveY = 0; }
            moveInput = new Vector2(moveX, moveY).normalized;
            return moveInput;
        }
        else { return moveInput = new Vector2(0,0); }
    }
    public void inventClick()
    {
        if (open == false)
        {
            inventario.SetActive(true);
            open = true;
        }
        else
        {
            inventario.SetActive(false);
            open = false;
        }
    }
}