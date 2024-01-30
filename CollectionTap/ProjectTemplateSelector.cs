
namespace CollectionTap
{
    public class ProjectTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TypeA { get; set; }
        public DataTemplate TypeB { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var ts = (ProjectDto)item;

            if(ts.Type == ProjectDto.Types.TypeA)
            {
                return TypeA;
            }
            else
            {
                return TypeB;
            }
        }
    }
}
