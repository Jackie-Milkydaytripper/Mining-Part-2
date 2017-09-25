using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinethoseOres : MonoBehaviour
{
    int BronzeSupply;
    int BronzePlayer;
    int SilverSupply;
    int SilverPlayer;
    int MineSpeed;
    int Minetime;
	int time;
	bool printedMessage = false;

    public GameObject Sphere;


    // Use this for initialization
	void Start() {
		print ("Start");
		printedMessage = false;
        BronzePlayer = 0;
        SilverPlayer = 0;
        BronzeSupply = 3;
        SilverSupply = 3;
        MineSpeed = 3;
        Minetime = 3;
    }

    // Update is called once per frame
    void Update()
    {
		if (Time.time > 3 && printedMessage == false) {
			print ("It has been three seconds!"); 
			printedMessage = true;

		}

		if (Time.time > Minetime) {
			{

				if (BronzeSupply > 0) {
					BronzeSupply -= 1;
					BronzePlayer += 1;
				}

				if (BronzeSupply == 0 && SilverSupply > 0) {
					SilverSupply -= 1;
					SilverPlayer += 1;
				}

				{

					print ("Bronze: " + BronzePlayer + " ...and Silver: " + SilverPlayer);
				}    
			}   
		}
	}    
}
