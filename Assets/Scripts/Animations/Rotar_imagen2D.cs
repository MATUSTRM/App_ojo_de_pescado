using UnityEngine;
using UnityEngine.UI;
public class Rotar_imagen2D : MonoBehaviour
{
    Image img;
    public float velocidad = 2;
    float valuerand;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        valuerand = Random.Range(0.5f, velocidad);
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        img.transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y,valuerand));
    }
}
