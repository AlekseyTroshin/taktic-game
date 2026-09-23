using UnityEngine;

public class SelectionInput : MonoBehaviour
{

    private Player _selectedPlayer;
    private SelectionManager _sm;

    private void Start()
    {
        _sm = FindFirstObjectByType<SelectionManager>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
            Collider2D collider = Physics2D.OverlapPoint(mouseWorldPosition);

            if (collider != null)
            {
                _selectedPlayer = collider.GetComponent<Player>();

                if (_selectedPlayer != null)
                {
                    _sm.SetPlayer(_selectedPlayer);
                }
            }

        }
    }
    
}
