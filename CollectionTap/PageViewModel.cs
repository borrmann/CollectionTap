using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace CollectionTap
{

    public class ProjectDto
    {
        public int Id { get; set; }
        public string Name => $"Number {Id}";
        public Types Type { get; set; }
        public enum Types
        {
            TypeA,
            TypeB,
        }
    }


    public partial class MyPageViewModel : ObservableObject
    {

        [RelayCommand]
        private async Task OpenDetails(ProjectDto proj)
        {
            await AppShell.Current.DisplayAlert(proj.Name, proj.Id.ToString(), "ok");
            await FetchDataAsync();
        }




        [ObservableProperty]
        private List<ProjectDto> projects = [];

        // OPTION 1:
        //[ObservableProperty]
        //private ObservableCollection<ProjectDto> projects = [];

        public async Task FetchDataAsync()
        {
            await Task.Delay(1000);

            int idx = 1;
            List<ProjectDto> list = [
                new() { Id = idx++, Type = ProjectDto.Types.TypeA },
                new() { Id = idx++, Type = ProjectDto.Types.TypeB },
                new() { Id = idx++, Type = ProjectDto.Types.TypeA },
                new() { Id = idx++, Type = ProjectDto.Types.TypeB },
                new() { Id = idx++, Type = ProjectDto.Types.TypeA },
                new() { Id = idx++, Type = ProjectDto.Types.TypeB },
                new() { Id = idx++, Type = ProjectDto.Types.TypeA },
                new() { Id = idx++, Type = ProjectDto.Types.TypeB },
                new() { Id = idx++, Type = ProjectDto.Types.TypeA },
                new() { Id = idx++, Type = ProjectDto.Types.TypeB },
                new() { Id = idx++, Type = ProjectDto.Types.TypeA },
                new() { Id = idx++, Type = ProjectDto.Types.TypeB },
                new() { Id = idx++, Type = ProjectDto.Types.TypeA },
                new() { Id = idx++, Type = ProjectDto.Types.TypeB },
                new() { Id = idx++, Type = ProjectDto.Types.TypeA },
                new() { Id = idx++, Type = ProjectDto.Types.TypeB },
                new() { Id = idx++, Type = ProjectDto.Types.TypeA },
                new() { Id = idx++, Type = ProjectDto.Types.TypeB },
                new() { Id = idx++, Type = ProjectDto.Types.TypeA },
                new() { Id = idx++, Type = ProjectDto.Types.TypeB },
                new() { Id = idx++, Type = ProjectDto.Types.TypeA },
                new() { Id = idx++, Type = ProjectDto.Types.TypeB },
                new() { Id = idx++, Type = ProjectDto.Types.TypeA },
                new() { Id = idx++, Type = ProjectDto.Types.TypeB },
            ];


            // OPTION 1: Change list to ObservableCollection and use this to have unwanted animation of the UI
            //Projects.Clear();
            //foreach (var item in list)
            //{
            //    Projects.Add(item);
            //};


            // OPTION 2: use this to get tap errors after tapping multiple times on an item on iOS
            Projects = list;
        }
    }
}
