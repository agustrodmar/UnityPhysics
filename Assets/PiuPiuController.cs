using UnityEngine;

public class PiuPiu : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 direction = new Vector2(1, -1).normalized; // Le digo que se dirija hacia abajo y a la derecha

    void Update()
    {
        // Hago que se mueva en la dirección actual
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Compruebo qué pared ha golpeado PiuPiu. Las paredes son IsTrigger
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
