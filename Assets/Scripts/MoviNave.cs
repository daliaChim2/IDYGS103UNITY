using UnityEngine;

public class MoviNave : MonoBehaviour
{
    public float velocidad = 5f;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Mover(Vector3.right, new Color(1f, 0.5f, 0f));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Mover(Vector3.left, new Color(1f, 0.5f, 0f));
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Mover(Vector3.up, Color.red);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Mover(Vector3.down, Color.yellow);
        }
    }

    void Mover(Vector3 direccion, Color color)
    {
        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
        rend.material.color = color;
    }
}
