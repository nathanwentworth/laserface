using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class loader : MonoBehaviour {

  public GameObject loadingPanel;

    void Start() {
      StartCoroutine(LoadNewScene());
    }

  IEnumerator LoadNewScene() {

      yield return new WaitForSeconds(8);
      loadingPanel.SetActive(false);
      yield return null;


    }

}
