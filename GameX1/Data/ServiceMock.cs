using GameX1.Data;

namespace GameX1.Data
{
    public static class ServiceMock
    {
        public static List<Picture> SetPicture()
        {
            List<Picture> PictureList = new List<Picture>();

            PictureList.Add(new Picture { Url = "https://media.istockphoto.com/id/464852512/photo/seattle-skyline-at-night-with-mt-rainier-in-the-distance.jpg?s=612x612&w=0&k=20&c=yBBr2gTWY7OSh-ogIUeNIJKJmaiSJOgxQvZHrFyEPGc=" });
            PictureList.Add(new Picture { Url = "https://media.gettyimages.com/id/157740062/photo/seattle-downtown-waterfront-with-space-needle-and-great-wheel.jpg?s=612x612&w=0&k=20&c=LWKHmGRc0CWf8Ch_DJ8keUdRhHmXsZdxttJxrEWm1_A=" });
            PictureList.Add(new Picture { Url = "https://media.gettyimages.com/id/1338118638/photo/drone-shot-of-seattle-with-mt-rainier-in-distance.jpg?s=612x612&w=0&k=20&c=04X9RxajpGqrE6wwUm9wxfvSDWAk4PRy-ev8ZwBtv90=" });
            PictureList.Add(new Picture { Url = "https://media.gettyimages.com/id/553821387/photo/seattle-skyline.jpg?s=612x612&w=0&k=20&c=RHShVCg_7A7QuFhc6nGiAW2o20B8T6lebXznv8T5j_w=" });
            PictureList.Add(new Picture { Url = "https://media.gettyimages.com/id/660588915/photo/side-view-of-man-walking-by-cars-on-street-in-city.jpg?s=612x612&w=0&k=20&c=9SaglRfgUYyliKPueKGRdvFLJHicTS3SKwhSTr9447Q=" });
            PictureList.Add(new Picture { Url = "https://media.gettyimages.com/id/1083898122/photo/view-of-skyscrapers-in-city.jpg?s=612x612&w=0&k=20&c=tLZF_vRelRwg3ptr41GORMemBju0ZK8DcsLAdmmSn7Q=" });
            PictureList.Add(new Picture { Url = "https://media.gettyimages.com/id/517206972/photo/night-view-of-seattle-skyscapers-and-space-needle-washington-united-states.jpg?s=612x612&w=0&k=20&c=Ci1eYTlaYTeIE3XoMFJ8AxAgJapmCAhY45BPCaQ2J-E=" });
            PictureList.Add(new Picture { Url = "https://media.gettyimages.com/id/157673935/photo/downtown-seattle-skyline.jpg?s=612x612&w=0&k=20&c=v3Os0P1znMzTWbNgu0DxCylYhT1wSqph_wu4tdVC9yk=" });
            PictureList.Add(new Picture { Url = "https://media.gettyimages.com/id/174670761/photo/seattle-skyline-in-winter.jpg?s=612x612&w=0&k=20&c=oRQJQoCMHDHo51XMGZYTDtCS3_c6BVyFw5T-5UXqVzg=" });

            return PictureList;
        }
    }
}
