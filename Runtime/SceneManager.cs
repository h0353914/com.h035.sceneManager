using UnityEngine;

namespace h035.SceneManager
{
    /// <summary>
    /// 場景管理器:切換場景與退出遊戲
    /// </summary>
    public class SceneManager : MonoBehaviour
    {
        [SerializeField, Range(0.3f, 3), Header("音效長度")]
        float soundDuration = 2.7f;

        string nameSceneToChange;


        /// <summary>
        /// 透過nameScene切換關卡
        /// </summary>
        /// <param name="nameScene"></param>
        public void ChangeScene(string nameScene)//切換場景
        {   //print("切換場景");
            nameSceneToChange = nameScene;
            Invoke("DelayChangeScene", soundDuration);
        }
        public void DelayChangeScene()//切換場景
        {
            //print("切換場景");
            UnityEngine.SceneManagement.SceneManager.LoadScene(nameSceneToChange);
        }
        public void Quit()
        {
            Invoke("DelayQuit", soundDuration);
        }
        public void DelayQuit()
        {
            print("離開");
            Application.Quit();
        }
    }
}


