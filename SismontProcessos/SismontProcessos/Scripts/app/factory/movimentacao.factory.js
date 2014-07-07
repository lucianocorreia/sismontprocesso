appModule.factory("movimentacaoFactory", function ($resource) {
    return $resource("/api/movimentacaovalue/:id", {}, {
        query: { method: 'GET', params: { id: '' }, isArray: true },
        post: { method: 'POST' },
        update: { method: 'PUT', params: { id: '@id' } },
        remove: { method: 'DELETE' }
    });
});