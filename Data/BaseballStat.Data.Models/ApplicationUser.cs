// ReSharper disable VirtualMemberCallInConstructor
namespace BaseballStat.Data.Models
{
    using System;
    using System.Collections.Generic;

    using BaseballStat.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.Players = new HashSet<Player>();
            this.Teams = new HashSet<Team>();
            this.Leagues = new HashSet<League>();
            this.Categories = new HashSet<Category>();
            this.Awards = new HashSet<Award>();
        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public virtual ICollection<League> Leagues { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<Award> Awards { get; set; }
    }
}
