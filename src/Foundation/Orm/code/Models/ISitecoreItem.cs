using System;

namespace Agency.Foundation.Orm.Models
{
    public interface ISitecoreItem
    {
        Guid Id { get; set; }

        Guid TemplateId { get; set; }

        string SitecorePath { get; set; }

        string Name { get; set; }

        string DisplayName { get; set; }

        string Icon { get; set; }

        string Url { get; set; }

        int SortOrder { get; set; }
    }
}