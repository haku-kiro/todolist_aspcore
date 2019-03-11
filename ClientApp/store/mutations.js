import router from '../router';

// TODO: split this into its own file
export const state = {
  todos: [],
  loggedIn: false,
  loginError: null,
  userName: null
};

export const mutations = {
  loggedIn (state, data) {
    state.loggedIn = true;
    state.userName = (data.name || '').split(' ')[0] || 'Hello';

    let redirectTo = state.route.query.redirect || '/';
    router.push(redirectTo);
  },
  loggedOut (state) {
    state.loggedIn = false;
    router.push('/login');
  },
  loginError (state, message) {
    state.loginError = message;
  },
  loadTodos (state, todos) {
    state.todos = todos || [];
  }
};
