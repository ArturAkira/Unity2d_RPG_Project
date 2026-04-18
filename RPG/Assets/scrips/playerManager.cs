using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UIElements;
public class playerManager : MonoBehaviour 
{
    [SerializeField] private classes classes;
    [SerializeField] private fightEvent fightEvent;
    [SerializeField] Animator animator;
    private Rigidbody2D player;
    private Vector2 moveInput;
    private GameObject inventario;
    private SpriteRenderer sr;
    public Sprite guerreiro, mago, arqueiro;
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
                    animator.SetInteger("player-selection", 0);
                    classes.spriteSetter(sr, guerreiro);
                    Debug.Log("você escolheu o guerreiro");
                    break;
                case 1:
                    classes.classSetter(ref playerClass, GameManager.instance.magoStats);
                    animator.SetInteger("player-selection", 1);
                    classes.spriteSetter(sr, mago);
                    Debug.Log("você escolheu o mago");
                    Debug.Log(sr);
                    Debug.Log(teste);
                    break;
                case 2:
                    classes.classSetter(ref playerClass, GameManager.instance.arqueiroStats);
                    animator.SetInteger("player-selection", 2);
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
        if(dialogs.i == 0) { player.MovePosition(player.position + (moveInput * speed * Time.fixedDeltaTime)); 
                             animator.SetFloat("up-down", moveInput.y);
                             animator.SetFloat("left-right", moveInput.x); 
        }
    }
    private Vector2 movementWay()
    {
        if(open == false)
        {
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");
            if (moveY != 0) { moveX = 0; animator.SetBool("isrunning", true);  }
            if (moveX != 0) { moveY = 0; animator.SetBool("isrunning", true);  }
            if (moveX == 0 && moveY == 0) { animator.SetBool("isrunning", false); }
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