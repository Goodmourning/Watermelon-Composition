using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextFruit : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startPosition;
    [SerializeField] private GameObject fruit0;
    [SerializeField] private GameObject fruit1;
    [SerializeField] private GameObject fruit2;
    [SerializeField] private GameObject fruit3;
    [SerializeField] private GameObject fruit4;
    void Start()
    {
        startPosition = GetComponent<Rigidbody2D>().transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var rb = GetComponent<Rigidbody2D>();
            var screenPos = Input.mousePosition;
            //var worldPos = Camera.main.ScreenToWorldPoint(screenPos);
            rb.transform.position = new Vector3(Input.mousePosition.x, startPosition.y, startPosition.z);
            rb.bodyType = RigidbodyType2D.Dynamic;
            //StartCoroutine(CreateNextFruit(startPosition));
            Instantiate(fruit1, startPosition, transform.rotation);
        }
    }
}
