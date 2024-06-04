using UnityEngine;

public class ChamberManager: MonoBehaviour {
    [SerializeField] private GameObject chamberPrefab;

    void Start () {
        InstantiateChamberGrid(6, 8);
    }

    void InstantiateChamberGrid(int width, int height) {
        for (int i = -width/2; i < width/2; i++) {
            for (int j = -height/2; j < height/2; j++) {
                Instantiate(chamberPrefab, new Vector3(i, 0, j), Quaternion.identity);
            }
        }
    }
}
