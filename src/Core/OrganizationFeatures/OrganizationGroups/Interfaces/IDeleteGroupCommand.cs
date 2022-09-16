﻿using Bit.Core.Entities;

namespace Bit.Core.OrganizationFeatures.OrganizationGroups;

public interface IDeleteGroupCommand
{
    Task DeleteAsync(Group group);

    Task<ICollection<Group>> DeleteManyAsync(Guid orgId, IEnumerable<Guid> groupIds);
}