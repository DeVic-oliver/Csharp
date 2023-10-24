using TMPro;
using UnityEngine;

public class Incrementer : MonoBehaviour
{

    public TextMeshProUGUI Count;
    private int _currentCount;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            Increment();

        if (Input.GetKeyDown(KeyCode.B))
            Decrement();
    }

    private void Increment()
    {
        _currentCount++;
        Count.text = _currentCount.ToString();
    }

    private void Decrement()
    {
        _currentCount--;
        Count.text = _currentCount.ToString();
    }
}
