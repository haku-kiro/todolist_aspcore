import Vue from 'vue';
import Vuex from 'vuex';
import { state, mutations } from './mutations';
import { actions } from './actions';

Vue.use(Vuex);

// The state, mutations, and actions will be split into seperate files
export default new Vuex.Store({
  state,
  mutations,
  actions
});
