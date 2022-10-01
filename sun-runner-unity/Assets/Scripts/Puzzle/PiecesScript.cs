using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PiecesScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;
    private Vector3 RightPosition;
    private Vector3 StartPosition;
    public bool IsInRightPosition;
    public bool IsInStartPosition;
    public bool IsSelected;

    void Start()
    {
        RightPosition = transform.position;
        StartPosition = new Vector3(Random.Range(5f, 10f), Random.Range(-5.5f, 5f));

        if (CompareTag("Starter"))
            IsInRightPosition = true;
    }

    void Update()
    {
        if (!IsInStartPosition && !IsInRightPosition)
            MoveToTheStartPosition();

        if (IsInStartPosition && !IsInRightPosition && !IsSelected)
            IsInRightPosition = CheckRightPosition();      
    }

    private void MoveToTheStartPosition()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, StartPosition, step);

        if (Vector3.Distance(transform.position, StartPosition) < 0.001f)
        {
            IsInStartPosition = true;
        }
    }

    private bool CheckRightPosition()
    {
        if (Vector3.Distance(transform.position, RightPosition) < 0.25f)
        {
            transform.position = RightPosition;
            GetComponent<SortingGroup>().sortingOrder = 0;
            return true;
        }
        return false;
    }
}
