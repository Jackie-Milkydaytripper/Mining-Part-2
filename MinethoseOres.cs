using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinethoseOres : MonoBehaviour {
    public int BronzeSupply;
    int BronzePlayer;
    public int SilverSupply;
    int SilverPlayer;
	public int GoldSupply;
	int GoldPlayer;
	static int Scoring;
    public int MineSpeed;
    int Minetime;
	int time;
	int xPosition;

	Vector3 cubePosition;
	public GameObject CubePrefab;
	public GameObject CubePrefab2;
	public GameObject CubePrefabulous3;
	public GameObject currentCube;


	public int Time
    {
        get
        {
            return time;
        }

        set
        {
            time = value;
        }
    }


    // Use this for initialization
    void Start() {
		
        BronzePlayer = 0;
        SilverPlayer = 0;
        BronzeSupply = 2;
        SilverSupply = 1;
        MineSpeed = 3;
        Minetime = 1;
		GoldPlayer = 0;
		print ("You currently have " + BronzePlayer +  "Bronze ores and " + SilverPlayer + " Silver Ores ");
       
    }

    // Update is called once per frame
    void Update()
    {

		if (UnityEngine.Time.time > Minetime) {
			{

				if (BronzeSupply >= 0) {
                    BronzeSupply -= 1;
                    BronzePlayer += 1; 

					cubePosition = new Vector3 (Random.Range(-5, 4), Random.Range(-5, 9),0);
					currentCube = Instantiate (CubePrefab, cubePosition, Quaternion.identity);
					// I have to remember to spell quaternion correctly. Kept screaming at me to add a Transformation int...lol
					xPosition += 2;

					currentCube.GetComponent<Renderer> ().material.color = Color.white;


				}

			
				}

				if (BronzePlayer >= 3) {
                    SilverSupply -= 1;
                    SilverPlayer += 1;
				    
				cubePosition = new Vector3 (Random.Range(-3, 5), Random.Range(-2, 6),0);
				currentCube = Instantiate (CubePrefab2, cubePosition, Quaternion.identity);
				xPosition += 2;

				currentCube.GetComponent<Renderer> ().material.color = Color.white;

				}
				
			/// I wasn't able to create code for the gold to instantiate correctly. 
			if (BronzePlayer == 2 && SilverPlayer == 2) {
				currentCube = Instantiate (CubePrefabulous3, new Vector3 (Random.Range (-5, 5), Random.Range (-5, 5), 0), Quaternion.identity);
				currentCube.GetComponent<Renderer> ().material.color = Color.yellow;
				xPosition += 2;

				GoldPlayer += 1;


			}

					print ("Bronze: " + BronzePlayer + " ...Silver: " + SilverPlayer);

			Minetime += MineSpeed;
				}
					

                    {

                    }
				}    
			}   
