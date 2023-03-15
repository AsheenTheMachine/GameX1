using GameX1.Data;
using Microsoft.AspNetCore.Components;

namespace Stage1Base
{
    public class Stage1Base : ComponentBase
    {
        public List<Picture>? Pictures  
        {
            get;
            set;
        }

        public string? CurrentPictureURL
        {
            get; 
            set;
        }

        public int CurrentPictureIndex 
        {
            get;
            set;
        }

        public int ConfigMaxPictureStageCount
        {
            get;
            set;
        } = 8;

        protected override Task OnInitializedAsync()
        {
            CurrentPictureIndex = 1;

            Pictures = new List<Picture>();
            Pictures = ServiceMock.SetPicture();

            CurrentPictureURL = Pictures[CurrentPictureIndex].Url;

            return base.OnInitializedAsync();
        }

        public void LoadNextPicture() 
        {
            if (CurrentPictureIndex < ConfigMaxPictureStageCount && Pictures != null) 
            {
                CurrentPictureIndex++;
                CurrentPictureURL = Pictures[CurrentPictureIndex].Url;
            }
        }

        public void LoadPreviousPicture() 
        {
            if (CurrentPictureIndex > 0 && Pictures != null)
            {
                CurrentPictureIndex--;
                CurrentPictureURL = Pictures[CurrentPictureIndex].Url;
            }
        }
    }
}
