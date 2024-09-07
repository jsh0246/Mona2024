using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HexagonalGrid : MonoBehaviour
{


    //public void OnCollisionEnter2D(Collision2D other)
    //{
    //    Tilemap tilemap = other.gameObject.GetComponentInParent<Tilemap>();

    //    Vector3Int cellPosition = tilemap.WorldToCell(transform.position);
    //    Vector3 tilepos = tilemap.GetCellCenterWorld(cellPosition);
    //}

    Tilemap tilemap;

    private void Awake()
    {
        //DUDU();
        //Coordinate();
        Init();
    }

    private void Update()
    {
        LeftClickGivesMousePosition();
    }

    private void Init()
    {
        tilemap = GetComponent<Tilemap>();
    }

    private void Coordinate()
    {
        //Grid grid = transform.parent.parent.GetComponent<Grid>();
        //Vector3Int cellPosition = grid.WorldToCell(transform.position);
        ////transform.position = grid.GetCellCenterWorld(cellPosition);
        //print(cellPosition);

        Tilemap tilemap = transform.parent.GetComponent<Tilemap>();
        //Vector3Int cP = tilemap.WorldToCell(transform.position);
        //print(cP);

        
    }





    private void DUDU()
    {
        Tilemap tilemap = GameObject.Find("Tilemap").GetComponent<Tilemap>();
        //Tilemap tilemap = GetComponent<Tilemap>();

        Vector3Int cellPosition = tilemap.WorldToCell(transform.position);
        Vector3 tilepos = tilemap.GetCellCenterWorld(cellPosition);

        print(cellPosition);
        print(tilepos);
    }

    private void LeftClickGivesMousePosition()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldPoint = ray.GetPoint(-ray.origin.y / ray.direction.y);

            Vector3Int cellPosition = tilemap.WorldToCell(worldPoint);
            print(cellPosition);

        }
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    Vector3 worldPoint = ray.GetPoint(-ray.origin.y / ray.direction.y);
        //    //Vector2Int moousePoint = Calc.Vector3to2Int(GlobalGrid.Instance.Grid.WorldToCell(worldPoint));

        //    print("MOUSE POSITION : " + worldPoint);
        //    //print("MOUSE POSITION : " + moousePoint);
        //}
    }


}
