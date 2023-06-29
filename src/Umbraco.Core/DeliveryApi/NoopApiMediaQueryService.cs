﻿using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services.OperationStatus;

namespace Umbraco.Cms.Core.DeliveryApi;

public class NoopApiMediaQueryService : IApiMediaQueryService
{
    public Attempt<PagedModel<Guid>, ApiMediaQueryOperationStatus> ExecuteQuery(string? fetch, IEnumerable<string> filters, IEnumerable<string> sorts, int skip, int take)
        => Attempt.SucceedWithStatus(ApiMediaQueryOperationStatus.Success, new PagedModel<Guid>());
}
