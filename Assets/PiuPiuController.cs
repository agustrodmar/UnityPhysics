using UnityEngine;

public class PiuPiu : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 direction = new Vector2(1, -1).normalized; // Inicialmente se dirige hacia abajo y a la derecha

    void Update()
    {
        // Mueve a PiuPiu en la dirección actual
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Comprueba qué pared ha golpeado PiuPiu
        if (other.gameObject.name == "ParedInferior" || other.gameObject.name == "ParedSuperior")
        {
            // Invierte la dirección en el eje Y
            direction.y *= -1;
        }
        else if (other.gameObject.name == "ParedDerecha" || other.gameObject.name == "ParedIzquierda")
        {
            // Invierte la dirección en el eje X
            direction.x *= -1;
        }
    }
}
