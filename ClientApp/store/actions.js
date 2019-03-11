import axios from 'axios';

const sleep = ms => {
  return new Promise(resolve => setTimeout(resolve, ms));
};

export const actions = {
  checkLoggedIn ({ commit }) {
    // TODO: commit('loggedIn') if the user is already logged in
  },

  async login ({ dispatch, commit }, data) {
    // TODO: Log the user in
    commit('loggedIn', { userName: data.email });
  },

  async logout ({ commit }) {
    // TODO: log the user out
    commit('loggedOut');
  },

  async loginFailed ({ commit }, message) {
    commit('loginError', message);
    await sleep(3000);
    commit('loginError', null);
  },

  async getAllTodos ({ commit }) {
    // TODO: get the users to-do items
    commit('loadTodos', [{ text: 'Fake todo item' }]);
  },

  async addTodo ({ dispatch }, data) {
    // TODO: save a new to-do item
    await dispatch('getAllTodos');
  },

  async toggleTodo ({ dispatch }, data) {
    // TODO: toggle to-do item completed/not completed
    await dispatch('getAllTodos');
  },

  async deleteTodo ({ dispatch }, id) {
    // TODO: delete to-do item
    await dispatch('getAllTodos');
  }
};
