using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LaserFiring : MonoBehaviour {

    public float maxLaser = 100f;
    public float innerExplosionRadius = 2f;
    public float outerExplosionRadius = 4f;

    public float explosionPower = 10f;
    public float lift = 3f;

    public float laserCooldown = 3f;
    private float cooldownTimer = 0f;
    private bool coolingDown = false;

	public Material laserGraphic;

	public Image reticle;

	private Color flashColor = new Color(1f, 0f, 0f);
	private float flashColorAlpha = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && coolingDown == false && Main.m.paused == false) {
			//DO PHYSICS
			RaycastHit hit;
			if (Physics.Raycast (transform.position, transform.forward, out hit, Mathf.Infinity)) {
				if (hit.rigidbody != null) {
					//EXPLODE
					Collider[] outerColliders = Physics.OverlapSphere (hit.point, outerExplosionRadius);
					for (int i = 0; i < outerColliders.Length; i++) {
						if (outerColliders [i].GetComponent<Rigidbody> () != null)
							outerColliders [i].GetComponent<Rigidbody> ().AddExplosionForce (explosionPower, hit.point, outerExplosionRadius, lift, ForceMode.Force);
					}
					Collider[] innerColliders = Physics.OverlapSphere (hit.point, innerExplosionRadius);
					for (int i = 0; i < innerColliders.Length; i++) {
						innerColliders [i].SendMessage ("Explode");
					}
				}

			}

			//GET FLASHY
			laserGraphic.color = flashColor;
			flashColorAlpha = 1.2f;
			GetComponent<AudioSource>().Play ();

			//DO COOLDOWN STUFF
			coolingDown = true;
			reticle.enabled = false;

		} else {
			if (laserGraphic.color.a > 0) {
				laserGraphic.color = new Color (1f, 0, 0, flashColorAlpha);
				flashColorAlpha -= 1f * Time.deltaTime;
			}
		}

		//COUNT COOLDOWN
		if (coolingDown == true) {
			cooldownTimer += Time.deltaTime;
			if (cooldownTimer >= laserCooldown) {
				coolingDown = false;
				cooldownTimer = 0;
				reticle.enabled = true;
			}
		}
	}
}
