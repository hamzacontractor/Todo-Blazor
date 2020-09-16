


// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).










//self.addEventListener('fetch', function (event) {
//    event.respondWith(
//        caches.open('dynamic-cache')
//            .then((cache) => {
//                return cache.match(event.request)
//                    .then((response) => {
//                        return response || fetch(event.request)
//                            .then((response) => {
//                                cache.put(event.request, response.clone());
//                                return response;
//                            });
//                    });
//            })
//    );
//});







self.addEventListener('fetch', function (event) {
    event.respondWith(
        fetch(event.request)
            .then((response) => {
                caches.open('dynamic-cache')
                    .then((cache) => { cache.put(event.request, response.clone()); });
                return response;
            })
            .catch(() => {
                return caches.open('dynamic-cache')
                    .then((cache) => { return cache.match(event.request); })
                    .catch()
            })
    );
});
