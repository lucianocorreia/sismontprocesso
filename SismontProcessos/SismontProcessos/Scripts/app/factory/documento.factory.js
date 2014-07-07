appModule.factory("documentoFactory", function ($resource) {
    return $resource("/api/documentovalue/:id", {}, {
        query: { method: 'GET', params: { id: '' }, isArray: true },
        post: { method: 'POST' },
        update: { method: 'PUT', params: { id: '@id' } },
        remove: { method: 'DELETE' }
    });
});