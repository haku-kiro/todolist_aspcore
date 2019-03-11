import Vue from 'vue';
import App from './components/App';
import router from './router';
import store from './store';
import { sync } from 'vuex-router-sync';

// Sync Vue router and the vuex store
sync(store, router);

// Somehow this is loaded to the App component ? I don't get this, as we don't use the #app id anywhere?
new Vue({
  el: '#app',
  store,
  router,
  template: '<App/>',
  components: { App }
});

// Might not use the same auth that this tutorial will use
store.dispatch('checkLoggedIn');
