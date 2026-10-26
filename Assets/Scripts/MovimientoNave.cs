using UnityEngine;

public class MovimientoNave : MonoBehaviour

{
    public float velocidadHorizontal = 5f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        
        float movimiento = Input.GetAxisRaw("Horizontal");
        
        rb.linearVelocity = new Vector2(movimiento * velocidadHorizontal, 0f);
    }
}