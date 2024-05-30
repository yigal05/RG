using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager sharedInstance;
    public List<LevelBlock> alTheLevelBlocks = new List<LevelBlock>();
    public List<LevelBlock> currentLevelBlocks = new List<LevelBlock>();
    public Transform LevelStartPosition;
    void Awake() {
    if (sharedInstance==null)
    {
        sharedInstance=this;
    }    
    }
    // Start is called before the first frame update
    void Start()
    {
        GenerateInitialBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLevelBlock(){
         int randomx=Random.Range(0,currentLevelBlocks.Count);
         LevelBlock block;
         Vector3 spawnPosition = Vector3.zero;

         if (currentLevelBlocks.Count==0){
             block =Instantiate(alTheLevelBlocks[randomx]);
             spawnPosition=LevelStartPosition.position;
         }else{
             block= Instantiate(alTheLevelBlocks[randomx]);
             spawnPosition=currentLevelBlocks[currentLevelBlocks.Count-1].exitpoint.position;
         }
         block.transform.SetParent(this.transform,false);
         Vector3 correction= new Vector3(spawnPosition.x-block.startpoint.position.x,spawnPosition.y-block.startpoint.position.y,0);
         block.transform.position=correction;
         currentLevelBlocks.Add(block);
    }

    public void GenerateInitialBlocks(){
        for(int i=0;i<3;i++){
            AddLevelBlock();
        }

    }
}
