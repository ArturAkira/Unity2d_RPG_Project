using UnityEngine;
using UnityEngine.InputSystem;


public class playerManager : classes 
{
    [SerializeField] startPlay startPlay;
    private Rigidbody2D player;
    public float speed = 5f;
    private Vector2 moveInput;
    public bool invent, open;
    private GameObject inventario;

    void Awake()
    {
        player = GetComponent<Rigidbody2D>();
        inventario = GameObject.Find("inventário");  
    }
    private void Start()
    {
        inventario.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // esquerda/direita
        float moveY = Input.GetAxisRaw("Vertical");   // cima/baixo
        moveInput = new Vector2(moveX, moveY).normalized;
        invent = Input.GetKeyDown(KeyCode.I);
        if (invent == true)
        {
            inventClick();
        }
    }
    private void FixedUpdate()
    {
        player.MovePosition(player.position + (moveInput * speed * Time.fixedDeltaTime));
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
        Debug.Log(startPlay.selecNumber);
    }
}