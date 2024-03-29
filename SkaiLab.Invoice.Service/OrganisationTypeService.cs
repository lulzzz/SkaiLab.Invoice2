﻿using System.Collections.Generic;
using System.Linq;
using SkaiLab.Invoice.Models;

namespace SkaiLab.Invoice.Service
{
    public class OrganisationTypeService:Service,IOrganisationTypeService
    {
        public OrganisationTypeService(IDataContext context):base(context)
        {
        }

        public List<OrganisationType> Gets()
        {
            using var context = Context();
            var khmer = IsKhmer;
            return context.OrganisationType.Select(u => new OrganisationType
            {
                Id=u.Id,
                Name = IsKhmer ? u.NameKh : u.Name
            }).ToList();
        }
    }
}
