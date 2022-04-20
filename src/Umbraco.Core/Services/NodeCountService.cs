﻿using System;
using Umbraco.Cms.Core.Persistence.Repositories;
using Umbraco.Cms.Core.Scoping;
using Umbraco.Cms.Core.Services;

namespace Umbraco.Cms.Infrastructure.Services.Implement
{
    public class NodeCountService : INodeCountService
    {
        private readonly INodeCountRepository _nodeCountRepository;
        private readonly IScopeProvider _scopeProvider;

        public NodeCountService(INodeCountRepository nodeCountRepository, IScopeProvider scopeProvider)
        {
            _nodeCountRepository = nodeCountRepository;
            _scopeProvider = scopeProvider;
        }

        public int GetNodeCount(Guid nodeType)
        {
            using var scope = _scopeProvider.CreateScope(autoComplete: true);
            return _nodeCountRepository.GetNodeCount(nodeType);
        }

        public int GetMediaCount()
        {
            using var scope = _scopeProvider.CreateScope(autoComplete: true);
            return _nodeCountRepository.GetMediaCount();
        }
    }
}
