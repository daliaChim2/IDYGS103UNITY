using UnityEngine;

public class GestorCarga : MonoBehaviour{

    public float fuerzaImpulso = 5f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //impulso
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * fuerzaImpulso, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Plataforma")
        {
            Debug.Log("¡Game Over! La carga cayó al suelo.");
        }
        else if (collision.gameObject.name == "Meta")
        {
            Debug.Log("¡Nivel completado! Carga entregada con éxito.");

        }
    }
}