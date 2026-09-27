using UnityEngine;

public class Cell : MonoBehaviour
{

    private Vector2 _cellPosition;
    
    public Vector2 CellPosition 
    {
        get { return _cellPosition; }
        set { _cellPosition = value; }
    }

}
