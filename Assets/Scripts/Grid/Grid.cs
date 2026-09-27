using UnityEngine;

public class Grid : MonoBehaviour
{
    
    [SerializeField] private GameObject _cellPrefab;
    [SerializeField] private int _width = 4;
    [SerializeField] private int _height = 4;

    private void Start()
    {
        for (int row = 0; row < _height; row++)
        {
            for (int col = 0; col < _width; col++)
            {
                GameObject cell = Instantiate(
                    _cellPrefab,
                    new Vector3(col, row, 0),
                    Quaternion.identity,
                    transform
                );

                cell.GetComponent<Cell>().CellPosition = new Vector2(col, row);
            }
        }
        
        
        transform.position = new Vector3(transform.position.x, transform.position.y, 1);
    }

}
