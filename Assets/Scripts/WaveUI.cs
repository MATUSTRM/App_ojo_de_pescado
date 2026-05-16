using UnityEngine;

public class WaveUI : MonoBehaviour
{
    public float intensity;
    public float speed;

    float rad;
    RectTransform rectTransform;

    private void Start() 
    {
        rectTransform = GetComponent<RectTransform>();
        rad = Random.Range(0, Mathf.PI*2f);
    }

    private void Update() 
    {
        rad += speed * Time.deltaTime;

        Vector2 position;
        position.x = 0;
        position.y = Mathf.Sin(rad) * intensity;

        rectTransform.anchoredPosition = position; 
    }
  
}
