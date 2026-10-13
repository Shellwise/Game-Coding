using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    float size = 1.0f;
    float speed = 0.2f;
    int score = 10;

    void Start()
    {
        speed = 0.2f / size;

        float fractionalScore = 10 / size;
        score = (int)fractionalScore;

        string message = name + " size is " + size +", speed is " + speed +", score is " + score;
        Debug.Log(message);
    }

    void Update()
    {
        Vector3 scale = new Vector3();
        scale.x = size;
        scale.y = size;

        transform.localScale = scale;

        Vector3 position = transform.localPosition;
        position.x += speed;
        transform.localPosition = position;
    }
    
}
