using UnityEngine;
using System.Collections;

public class LavaScript : MonoBehaviour 
{
    public GameObject go_platforms;
	
	private PriorityQueue<PlatformComparer> _pq_platforms;
	private static float _increaseLavaAmount	= 0;
	
	public static Transform[]	lastPlatforms	{ get; private set; }
	public static float			lastplatHeight	{ get; private set; }
	

	/*void Awake( ){
        go_platforms = (GameObject)GameObject.Find("PlatformList");
        _pq_platforms = new PriorityQueue<PlatformComparer>();
        print(go_platforms);
        foreach (Transform t in go_platforms.transform)
		{
			PlatformComparer pl	= t.gameObject.GetComponent<PlatformComparer>( ) as PlatformComparer;
            _pq_platforms.AddElement(pl);
		}
		GetLastPlatforms( );
	}*/
	
	void OnTriggerEnter( Collider other )
	{
		if ( other.tag	== "Player" )
		{	
			//Application.LoadLevel( 0 );
		} if ( other.tag == "Enemy" )
		{
			GameObject.Destroy( other.gameObject );
			IncreaseLava( );
		}
	}
	
	public void GetLastPlatforms( )
	{
		PlatformComparer[] plat;
        if (_pq_platforms.GetHighestPriorities(out plat))
		{
			lastPlatforms	= new Transform[plat.Length];
			for ( int i = 0; i < plat.Length; ++i )
			{
				lastPlatforms[i] = plat[i].transform;				
			}
			lastplatHeight	= lastPlatforms[0].transform.position.y;
		}
	}
	
	void Update( )
	{
		if ( _increaseLavaAmount != 0 )
		{
			transform.position		+= Vector3.up * _increaseLavaAmount;
			_increaseLavaAmount		= 0;
			/*if ( transform.position.y > lastplatHeight )
			{
				PlatformComparer[] pc;
                if (_pq_platforms.TryPopHighestPriorities(out pc))
				{
					foreach ( PlatformComparer pl in pc )
					{
						Destroy( pl.gameObject );
					}					
					GetLastPlatforms( );
				}
			}*/
		}
	}
	
	public static void IncreaseLava( float amount = 0.3f )
	{
		_increaseLavaAmount	= amount;
	}
	
	public static void DecreaseLava( float amount = -2 )
	{
		_increaseLavaAmount	= amount;
	}
}
