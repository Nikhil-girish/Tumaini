using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyInputExample : MonoBehaviour
{
    public TextMeshProUGUI output;

    public void Update()
    {
        // A
        if ((Input.GetKeyDown(KeyCode.A)) || (Input.GetKey(KeyCode.A)))
        {
            Debug.Log("Key Down: " + KeyCode.A);
            output.text = "Hand Sign A";
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("Key Up: " + KeyCode.A);
            output.text = "NO INPUT";
        }

        // B
        if ((Input.GetKeyDown(KeyCode.B)) || (Input.GetKey(KeyCode.B)))
        {
            Debug.Log("Key Down: " + KeyCode.B);
            output.text = "Hand Sign B";
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            Debug.Log("Key Up: " + KeyCode.B);
            output.text = "NO INPUT";
        }

        // C
        if ((Input.GetKeyDown(KeyCode.C)) || (Input.GetKey(KeyCode.C)))
        {
            Debug.Log("Key Down: " + KeyCode.C);
            output.text = "Hand Sign C";
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("Key Up: " + KeyCode.C);
            output.text = "NO INPUT";
        }

        // D
        if ((Input.GetKeyDown(KeyCode.D)) || (Input.GetKey(KeyCode.D)))
        {
            Debug.Log("Key Down: " + KeyCode.D);
            output.text = "Hand Sign D";
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Key Up: " + KeyCode.D);
            output.text = "NO INPUT";
        }

        // E
        if ((Input.GetKeyDown(KeyCode.E)) || (Input.GetKey(KeyCode.E)))
        {
            Debug.Log("Key Down: " + KeyCode.E);
            output.text = "Hand Sign E";
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log("Key Up: " + KeyCode.E);
            output.text = "NO INPUT";
        }

        // F
        if ((Input.GetKeyDown(KeyCode.F)) || (Input.GetKey(KeyCode.F)))
        {
            Debug.Log("Key Down: " + KeyCode.F);
            output.text = "Hand Sign F";
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("Key Up: " + KeyCode.F);
            output.text = "NO INPUT";
        }

        // G
        if ((Input.GetKeyDown(KeyCode.G)) || (Input.GetKey(KeyCode.G)))
        {
            Debug.Log("Key Down: " + KeyCode.G);
            output.text = "Hand Sign G";
        }

        if (Input.GetKeyUp(KeyCode.G))
        {
            Debug.Log("Key Up: " + KeyCode.G);
            output.text = "NO INPUT";
        }

        // H
        if ((Input.GetKeyDown(KeyCode.H)) || (Input.GetKey(KeyCode.H)))
        {
            Debug.Log("Key Down: " + KeyCode.H);
            output.text = "Hand Sign H";
        }

        if (Input.GetKeyUp(KeyCode.H))
        {
            Debug.Log("Key Up: " + KeyCode.H);
            output.text = "NO INPUT";
        }
        // I
        if ((Input.GetKeyDown(KeyCode.I)) || (Input.GetKey(KeyCode.I)))
        {
            Debug.Log("Key Down: " + KeyCode.I);
            output.text = "Hand Sign I";
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            Debug.Log("Key Up: " + KeyCode.I);
            output.text = "NO INPUT";
        }
        // J
        if ((Input.GetKeyDown(KeyCode.J)) || (Input.GetKey(KeyCode.J)))
        {
            Debug.Log("Key Down: " + KeyCode.J);
            output.text = "Hand Sign J";
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            Debug.Log("Key Up: " + KeyCode.J);
            output.text = "NO INPUT";
        }
        // K
        if ((Input.GetKeyDown(KeyCode.K)) || (Input.GetKey(KeyCode.K)))
        {
            Debug.Log("Key Down: " + KeyCode.K);
            output.text = "Hand Sign K";
        }

        if (Input.GetKeyUp(KeyCode.K))
        {
            Debug.Log("Key Up: " + KeyCode.K);
            output.text = "NO INPUT";
        }
        // L
        if ((Input.GetKeyDown(KeyCode.L)) || (Input.GetKey(KeyCode.L)))
        {
            Debug.Log("Key Down: " + KeyCode.L);
            output.text = "Hand Sign L";
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            Debug.Log("Key Up: " + KeyCode.L);
            output.text = "NO INPUT";
        }
        // M
        if ((Input.GetKeyDown(KeyCode.M)) || (Input.GetKey(KeyCode.M)))
        {
            Debug.Log("Key Down: " + KeyCode.M);
            output.text = "Hand Sign M";
        }

        if (Input.GetKeyUp(KeyCode.M))
        {
            Debug.Log("Key Up: " + KeyCode.M);
            output.text = "NO INPUT";
        }
        // N
        if ((Input.GetKeyDown(KeyCode.N)) || (Input.GetKey(KeyCode.N)))
        {
            Debug.Log("Key Down: " + KeyCode.N);
            output.text = "Hand Sign N";
        }

        if (Input.GetKeyUp(KeyCode.N))
        {
            Debug.Log("Key Up: " + KeyCode.N);
            output.text = "NO INPUT";
        }
        // O
        if ((Input.GetKeyDown(KeyCode.O)) || (Input.GetKey(KeyCode.O)))
        {
            Debug.Log("Key Down: " + KeyCode.O);
            output.text = "Hand Sign O";
        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            Debug.Log("Key Up: " + KeyCode.O);
            output.text = "NO INPUT";
        }
        // P
        if ((Input.GetKeyDown(KeyCode.P)) || (Input.GetKey(KeyCode.P)))
        {
            Debug.Log("Key Down: " + KeyCode.P);
            output.text = "Hand Sign P";
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            Debug.Log("Key Up: " + KeyCode.P);
            output.text = "NO INPUT";
        }
        // Q
        if ((Input.GetKeyDown(KeyCode.Q)) || (Input.GetKey(KeyCode.Q)))
        {
            Debug.Log("Key Down: " + KeyCode.Q);
            output.text = "Hand Sign Q";
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            Debug.Log("Key Up: " + KeyCode.Q);
            output.text = "NO INPUT";
        }
        // R
        if ((Input.GetKeyDown(KeyCode.R)) || (Input.GetKey(KeyCode.R)))
        {
            Debug.Log("Key Down: " + KeyCode.R);
            output.text = "Hand Sign R";
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            Debug.Log("Key Up: " + KeyCode.R);
            output.text = "NO INPUT";
        }
        // S
        if ((Input.GetKeyDown(KeyCode.S)) || (Input.GetKey(KeyCode.S)))
        {
            Debug.Log("Key Down: " + KeyCode.S);
            output.text = "Hand Sign S";
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            Debug.Log("Key Up: " + KeyCode.S);
            output.text = "NO INPUT";
        }
        // T
        if ((Input.GetKeyDown(KeyCode.T)) || (Input.GetKey(KeyCode.T)))
        {
            Debug.Log("Key Down: " + KeyCode.T);
            output.text = "Hand Sign T";
        }

        if (Input.GetKeyUp(KeyCode.T))
        {
            Debug.Log("Key Up: " + KeyCode.T);
            output.text = "NO INPUT";
        }
        // U
        if ((Input.GetKeyDown(KeyCode.U)) || (Input.GetKey(KeyCode.U)))
        {
            Debug.Log("Key Down: " + KeyCode.U);
            output.text = "Hand Sign U";
        }

        if (Input.GetKeyUp(KeyCode.U))
        {
            Debug.Log("Key Up: " + KeyCode.U);
            output.text = "NO INPUT";
        }
        // V
        if ((Input.GetKeyDown(KeyCode.V)) || (Input.GetKey(KeyCode.V)))
        {
            Debug.Log("Key Down: " + KeyCode.V);
            output.text = "Hand Sign V";
        }

        if (Input.GetKeyUp(KeyCode.V))
        {
            Debug.Log("Key Up: " + KeyCode.V);
            output.text = "NO INPUT";
        }
        // W
        if ((Input.GetKeyDown(KeyCode.W)) || (Input.GetKey(KeyCode.W)))
        {
            Debug.Log("Key Down: " + KeyCode.W);
            output.text = "Hand Sign W";
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("Key Up: " + KeyCode.W);
            output.text = "NO INPUT";
        }
        // X
        if ((Input.GetKeyDown(KeyCode.X)) || (Input.GetKey(KeyCode.X)))
        {
            Debug.Log("Key Down: " + KeyCode.X);
            output.text = "Hand Sign X";
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            Debug.Log("Key Up: " + KeyCode.X);
            output.text = "NO INPUT";
        }
        // Y
        if ((Input.GetKeyDown(KeyCode.Y)) || (Input.GetKey(KeyCode.Y)))
        {
            Debug.Log("Key Down: " + KeyCode.Y);
            output.text = "Hand Sign Y";
        }

        if (Input.GetKeyUp(KeyCode.Y))
        {
            Debug.Log("Key Up: " + KeyCode.Y);
            output.text = "NO INPUT";
        }
        // Z
        if ((Input.GetKeyDown(KeyCode.Z)) || (Input.GetKey(KeyCode.Z)))
        {
            Debug.Log("Key Down: " + KeyCode.Z);
            output.text = "Hand Sign Z";
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            Debug.Log("Key Up: " + KeyCode.Z);
            output.text = "NO INPUT";
        }
    }
}