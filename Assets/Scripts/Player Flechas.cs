using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerFlechas : MonoBehaviour
{
    public float velocidad = 5f;
    private Vector2 movimientoInput;
    private Rigidbody2D rb;
    private Vector2 posicionInicial;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        posicionInicial = transform.position;
    }

    void OnMove(InputValue value)
    {
        movimientoInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movimientoInput * velocidad;
        rb.angularVelocity = 0f;
    }
 
    public void ReiniciarPosicion()
    {
        transform.position = posicionInicial;
        rb.linearVelocity = Vector2.zero;
    }
}
