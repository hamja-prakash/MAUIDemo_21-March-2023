using CommunityToolkit.Mvvm.ComponentModel;
using MAUISampleDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.ViewModels
{
    public partial class ArtifactViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Artifact> artifactList;

        public ArtifactViewModel()
        {
            artifactList = new ObservableCollection<Artifact>();
            GetArtifactList();
        }

        public ObservableCollection<Artifact> GetArtifactList()
        {
            artifactList.Add(new Artifact
            {
                Title = "Double Whistle",
                ImageUrlSmall =
                    "https://images.metmuseum.org/CRDImages/mi/web-large/DT4624a.jpg",
                ImageUrl =
                    "https://images.metmuseum.org/CRDImages/mi/original/DT4624a.jpg",
                Date = "7th–9th century"
            });

            artifactList.Add(new Artifact
            {
                Title = "Seated Female Figure",
                ImageUrlSmall =
                    "https://images.metmuseum.org/CRDImages/ao/web-large/DP-12659-001.jpg",
                ImageUrl =
                    "https://images.metmuseum.org/CRDImages/ao/original/DP-12659-001.jpg",
                Date = "6th–9th century"
            });

            artifactList.Add(new Artifact
            {
                Title = "Censer Support",
                ImageUrlSmall =
                    "https://images.metmuseum.org/CRDImages/ao/web-large/DP102949.jpg",
                ImageUrl =
                    "https://images.metmuseum.org/CRDImages/ao/original/DP102949.jpg",
                Date = "mid-7th–9th century"
            });

            artifactList.Add(new Artifact
            {
                Title = "Tripod Plate",
                ImageUrlSmall =
                    "https://images.metmuseum.org/CRDImages/ao/web-large/DP219258.jpg",
                ImageUrl =
                    "https://images.metmuseum.org/CRDImages/ao/original/DP219258.jpg",
                Date = "9th–10th century"
            });

            artifactList.Add(new Artifact
            {
                Title = "Costumed Figure",
                ImageUrlSmall =
                    "https://images.metmuseum.org/CRDImages/ao/web-large/1979.206.953_a.JPG",
                ImageUrl =
                    "https://images.metmuseum.org/CRDImages/ao/original/1979.206.953_a.JPG",
                Date = "7th–8th century"
            });

            artifactList.Add(new Artifact
            {
                Title = "Mirror-Bearer",
                ImageUrlSmall =
                    "https://images.metmuseum.org/CRDImages/ao/web-large/DP-24340-001.jpg",
                ImageUrl =
                    "https://images.metmuseum.org/CRDImages/ao/original/DP-24340-001.jpg",
                Date = "6th century"
            });
            return artifactList;
        }
    }
}
