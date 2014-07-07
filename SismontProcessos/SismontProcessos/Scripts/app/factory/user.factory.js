app.service("userService", function ($http, $window) {
    this.getUser = function (callback) {
        $http.get(url + "/api/login").success(callback);
    };

    this.updatePassword = function (senha, callback) {
        $http.put(uri + senha).success(callback);
    };

    this.signin = function (user) {
        $http.post(url + 'api/login/signin', user)
            .success(function (data) {
                $window.location.href = url + "home";
                return true;
            })
            .error(function () {
                $window.sessionStorage.removeItem('token');
                return false;
            });
    };
});

app.factory('AuthInterceptor', function ($window, $q) {
    return {
        request: function (config) {
            config.headers = config.headers || {};
            if ($window.sessionStorage.getItem('token')) {
                config.headers.Authorization = 'Bearer ' + $window.sessionStorage.getItem('token');
            }
            return config || $q.when(config);
        },
        response: function (response) {
            if (response.status === 401) {
                // TODO: Redirect user to login page.
            }
            return response || $q.when(response);
        }
    };
});