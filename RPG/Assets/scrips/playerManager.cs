using UnityEngine;
public class playerManager : MonoBehaviour 
{
    [SerializeField] private classes classes;
    private Rigidbody2D player;
    public float speed = 5f;
    private Vector2 moveInput;
    public bool invent, open;
    private GameObject inventario;
    public entityClass playerClass;

    void Awake()
    {
        player = GetComponent<Rigidbody2D>();
        inventario = GameObject.Find("inventário");
    }
    private void Start()
    {
        switch (startPlay.playerClassSelection)
        {
            case 0:
                Debug.Log(classes.guerreiroStats);
                classes.classSetter(ref playerClass, classes.guerreiroStats );
                Debug.Log("você escolheu o guerreiro");
                break;
            case 1:
                classes.classSetter(ref playerClass, classes.magoStats);
                Debug.Log("você escolheu o mago");
                break;
            case 2:
                classes.classSetter(ref playerClass, classes.arqueiroStats);
                Debug.Log("você escolheu o arqueiro");
                break;
        }
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
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        if (moveY != 0) {moveX = 0;}
        if (moveX != 0) { moveY = 0; }
        moveInput = new Vector2(moveX, moveY).normalized;
        return moveInput;
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