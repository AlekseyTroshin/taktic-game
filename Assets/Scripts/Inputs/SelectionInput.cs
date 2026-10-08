using UnityEngine;

public class SelectionInput : MonoBehaviour
{
    [SerializeField] private int countMove = 0;
    
    private Cell _selectedCell;
    private SelectionManager _selectionManager;
    private MovementManager _movementManager;
    private ActionManager _actionManager;
    
    private void Start()
    {
        _selectionManager = FindFirstObjectByType<SelectionManager>();
        _movementManager = FindFirstObjectByType<MovementManager>();
        _actionManager = FindFirstObjectByType<ActionManager>();
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
                    
                    if(_movementManager.CanMove(playerPosition, cellPosition) && countMove < 3)
                    {
                        
                        ICommand command = new MoveCommand(
                            _selectionManager.SelectedPlayer,
                            _selectedCell.CellPosition,
                            _movementManager
                        );

                        _actionManager.SetCommand(command);
                        countMove++;
                    }
                    else
                    {
                        // Debug.Log("Can't move");
                        // _actionManager.Show();
                        countMove = 0;
                        _actionManager.Move(); // @@@ удалить пока для тестов 
                    }

                    return;
                }
            }

        }
    }
    
}
