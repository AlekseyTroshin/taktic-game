using UnityEngine;

public class Grid : MonoBehaviour
{
    
    [SerializeField] private GameObject _cellPrefab;
    [SerializeField] private int _width = 4;
    [SerializeField] private int _height = 4;

    private void Start()
    {

        for (int i = 0; i < _height; i++)
        {
            for (int j = 0; j < _width; j++)
            {
                Instantiate(
                    _cellPrefab,
                    new Vector3(j, -i, 0),
                    Quaternion.identity,
                    transform
                );    
            }
        }
    }
    

}
