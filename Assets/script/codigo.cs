using UnityEngine;

public class codigo : MonoBehaviour
{
    public GameObject encendido;

    public GameObject movimiento;

    public void Switch()
    {
        Renderer renderer = encendido.GetComponent<Renderer>();

        renderer.enabled = !renderer.enabled;
    }

    public void Mover()
    {
        float x = Random.Range(0f, 20f);
        float y = Random.Range(0f, 20f);
        float z = Random.Range(0f, 20f);

        movimiento.transform.position = new Vector3(x, y, z);
    }
}