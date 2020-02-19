using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class MainManager : MonoBehaviour
{
    [SerializeField] private ARTrackedImageManager _arTrackedImageManager;
    
    void OnEnable()
    {
        _arTrackedImageManager.trackedImagesChanged += ImageChanged;
    }

    void OnDisable()
    {
        _arTrackedImageManager.trackedImagesChanged -= ImageChanged;
    }

    private void ImageChanged(ARTrackedImagesChangedEventArgs arTrackedImagesChangedEventArgs)
    {
        foreach (var trackedImage in arTrackedImagesChangedEventArgs.added)
        {
            Debug.Log(trackedImage.name);
        }
    }
}
