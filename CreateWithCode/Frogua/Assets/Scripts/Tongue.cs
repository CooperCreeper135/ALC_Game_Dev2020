using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue : MonoBehaviour
{
    [SerializeField] public Transform debugHitPointtransform;
    [SerializeField] public Transform hookshotTransform;
    //public bool tongueinput = false;
    //public GameObject pTongue;
    //public float tungspeed = 5;
    //public Transform target;
    public float speed = 10.0f;
    public GameObject player;
    public Rigidbody2D rb;
    private float hookshotSize;
    public Camera camera;
    
    private State state;
    private Vector2 hookshotPosition;
    public PlayerTwoMovement pl;
    private enum State{
        Normal,
        Climbing,
        HookshotThrown,
        HookshotFlyingPlayer,
        
    }
    

    // Start is called before the first frame update
    void Awake()
    {
        //position = debugHitPointtransform.transform.position;
        state = State.Normal;
        hookshotTransform.gameObject.SetActive(false);
        pl = GetComponentInParent<PlayerTwoMovement>();
    }
    
    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            
            default:
            case State.Normal:
                //controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
                
                handleHookshotStart();
                rb.gravityScale = 3f;
                
                break;
            case State.Climbing:
                rb.gravityScale = 0f;
                handleClimbing();
                break;
            case State.HookshotThrown:
                rb.gravityScale = 0f;
                HandleHookshotThrown();
                break;
            case State.HookshotFlyingPlayer:
                rb.gravityScale = 0f;
                handleHookshotMovement();
                break;
            
        }
        
        //if (extend == true){
        //    float step = speed * Time.deltaTime;
        //     player.transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        //}
        
    }
    // public void CollisionDetected(kid kid)
    //  {
    //      Debug.Log("peen");
        
    //      tongueinput = false;
    //      extend = true;
    //  } 

    private void handleClimbing(){
        if (pl.wallGrab == false){
            state = State.Normal;
        }
    }
    private void handleHookshotStart(){
        if (pl.wallGrab == true){
            state = State.Climbing;
        }
        if (Input.GetButtonDown("Space"))
        {
            LayerMask mask = LayerMask.GetMask("Wall");
            float step = speed * Time.deltaTime;
            RaycastHit2D hit = Physics2D.Raycast(hookshotTransform.position, player.transform.right,Mathf.Infinity,mask,-100,100);
            if(hit.collider != null && hit.collider.tag == "stick"){
                hookshotSize = 0f;
                
                debugHitPointtransform.position = hit.point;
                hookshotPosition = hit.point;
                
                hookshotTransform.gameObject.SetActive(true);
                hookshotTransform.localScale = Vector2.zero;
                state = State.HookshotThrown;
            }
            
             //tongueinput = true;
             //extend();
             //animator.SetBool("IsJumping", true);
        }
    }
    private void HandleHookshotThrown(){
        FindObjectOfType<RippleEffect>().Emit(Camera.main.WorldToViewportPoint(transform.position));
        float hookshotThrowSpeed = 40f;
        rb.velocity = new Vector2(0f,0f);
        hookshotSize += hookshotThrowSpeed * Time.fixedDeltaTime;
        hookshotTransform.localScale = new Vector2(hookshotSize, .0625f);
        if (hookshotSize >= Vector2.Distance(player.transform.position, hookshotPosition)){
            state = State.HookshotFlyingPlayer;
        }
    }
    private void handleHookshotMovement(){
        
        float hookshotSpeedMin = 5f;
        float hookshotSpeedMax = 9f;
        float hookshotSpeedMultiplier = 2f;
        float hookshotSpeed = Mathf.Clamp(Vector2.Distance(player.transform.position, hookshotPosition), hookshotSpeedMin, hookshotSpeedMax);
        float step = hookshotSpeed * Time.deltaTime * hookshotSpeedMultiplier;
        rb.velocity = new Vector2(0f,0f);

        player.transform.position = Vector2.MoveTowards(player.transform.position, hookshotPosition, step);
        float hookshotSize = Vector2.Distance(player.transform.position, hookshotPosition);
        
        hookshotTransform.localScale = new Vector2(hookshotSize, .0625f);
        float reachedHookshotPositionDistance = .5f;
        if (Vector2.Distance(player.transform.position, hookshotPosition) < reachedHookshotPositionDistance){
            state = State.Normal;
            hookshotTransform.gameObject.SetActive(false);
        }
    }
    // void FixedUpdate(){
    //     if (tongueinput == true){
    //         pTongue.transform.localScale += new Vector3(1, 0, 0) * tungspeed;

    //     }
    //     else {
    //         pTongue.transform.localScale += new Vector3(1, 0, 0) * 0;
    //     }
    // }
}
