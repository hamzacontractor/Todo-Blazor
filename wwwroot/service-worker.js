const ServiceWorkerVersion = 'Version-1.0.0';
const cacheName = 'dynamic-cache';


self.addEventListener('fetch', function (event) {
    event.respondWith(
        caches.open(cacheName)
            .then((cache) => { return cache.match(event.request); })
            .catch(
                fetch(event.request)
                    .then((response) => {
                        return caches.open(cacheName)
                            .then((cache) => {
                                cache.put(event.request, response.clone());
                                return response;
                            });
                    })
                    .catch(e => console.error(e)))
    );

    fetch(event.request)
        .then((response) => {
            caches.open(cacheName)
                .then((cache) => {
                    cache.put(event.request, response);
                });
        })
        .catch(e => console.error(e));
});
