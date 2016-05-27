using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

    public class Button : MonoBehaviour {

        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        public void showEvidence() {
        SceneManager.LoadScene((EventSystem.current.currentSelectedGameObject).name);
        }

        public void returnToEvidence() {
            SceneManager.LoadScene("Evidence");
        }

        public void goToOverview() {
        SceneManager.LoadScene("Overview");
        }
}