using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System;
using System.Linq;

namespace MyFacebookAppLogic
{
    public class SliderGalleryController
    {
        private readonly List<Image> r_images;
        private readonly Timer r_timer;
        private int m_CurrentIndex;

        public SliderGalleryController(TimeSpan i_RotationInterval)
        {
            r_images = new List<Image>();
            r_timer = new Timer(i_RotationInterval.TotalMilliseconds);
            r_timer.Elapsed += OnTimedElapsedEvent;
        }

        private void OnTimedElapsedEvent(Object source, ElapsedEventArgs e)
        {
            onRound();
        }

        public event Action SliderGalleryImagesChanged;

        public Image CurrentImage => r_images[m_CurrentIndex];

        public void Start() => r_timer.Start();

        public void Add(Image i_Image) => r_images.Add(i_Image);

        public void Remove(Image i_Image) => r_images.Remove(i_Image);

        private void startRound() => m_CurrentIndex = (m_CurrentIndex + 1) % r_images.Count;

        private void onRound()
        {
            if (r_images.Any())
            {
                startRound();
                SliderGalleryImagesChanged?.Invoke();
            }
        }
    }
}
