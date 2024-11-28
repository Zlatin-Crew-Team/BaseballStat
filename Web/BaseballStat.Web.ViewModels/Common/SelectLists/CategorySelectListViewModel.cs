namespace BaseballStat.Web.ViewModels.Common.SelectLists
{
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;

    public class CategorySelectListViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
