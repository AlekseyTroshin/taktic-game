using UnityEngine;

public class SelectionInput : MonoBehaviour
{
    
    private Cell _selectedCell;
    private SelectionManager _selectionManager;
    private MovementManager _movementManager;
    
    private void Start()
    {
        _selectionManager = FindFirstObjectByType<SelectionManager>();
        _movementManager = FindFirstObjectByType<MovementManager>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
            Collider2D[] colliders = Physics2D.OverlapPointAll(mouseWorldPosition);


            foreach (Collider2D collider in colliders)
            {
                Player player = collider.GetComponent<Player>();
  
                if (player != null)
                {
                    _selectionManager.SetPlayer(player);
                    return;
                }

                _selectedCell = collider.GetComponent<Cell>();
     
                if (_selectedCell != null && _selectionManager.SelectedPlayer != null)
                {
                    Vector2 playerPosition = _selectionManager.SelectedPlayer.CellPosition;
                    
                    Vector2 cellPosition = _selectedCell.CellPosition;

                    if(_movementManager.CanMove(playerPosition, cellPosition))
                    {
                        _movementManager.Move(
                            _selectionManager.SelectedPlayer, 
                            _selectedCell.CellPosition
                        );
                    }
                    else
                    {
                        Debug.Log("Can't move");
                    }

                    return;
                }
            }

        }
    }
    
}
