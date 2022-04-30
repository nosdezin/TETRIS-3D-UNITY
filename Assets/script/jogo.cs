using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogo : MonoBehaviour
{
    public GameObject block;
    public GameObject block1;    
    public GameObject block2;
    public GameObject block3;
    public Vector3 posInicial; 
    private int blockNumber;
    
    void Start() {
        blockNumber = Random.Range(1,4);

        switch(blockNumber){
            case 1:
                Instantiate(block, posInicial, Quaternion.identity);
                break;
            case 2:
                Instantiate(block1, posInicial, Quaternion.identity);
                break;
            case 3:
                Instantiate(block2, posInicial, Quaternion.identity);
                break;
            case 4:
                Instantiate(block3, posInicial, Quaternion.identity);
                break;
        }
    }
}
