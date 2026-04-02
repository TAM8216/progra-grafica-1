using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float velocidad = 5f;

    private Rigidbody2D rb2d;
    
    private Animator animator;
    private float movimientoH;
    private float movimientoV;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movimientoH = Input.GetAxis("Horizontal");
        movimientoV = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 movimiento = new Vector2(movimientoH, movimientoV);
        rb2d.linearVelocity = movimiento * velocidad;

        if (movimientoH > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (movimientoH < 0)
            transform.localScale = new Vector3(-1, 1, 1);
        
        animator.SetFloat("velocidad", Mathf.Abs(movimientoH) + Mathf.Abs(movimientoV));
    }
}