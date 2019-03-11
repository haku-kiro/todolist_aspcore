<template>
    <div class="dashboard">
        <h2>{{ name }}, here's your to-do list</h2>

        <input type="text" 
            class="new-todo"
            autofocus
            autocomplete="off"
            placeholder="What needs to be done ?"
            v-on:keyup.enter="addTodo">

        <ul class="todo-list">
            <todo-item v-for="(todo, index) in todos" v-bind:key="index" v-bind:item="todo"></todo-item>
        </ul>

        <p>
            {{ remaining }} Remaining
        </p>
        <router-link to="/logout">Log out</router-link>
    </div>
</template>

<script>
import TodoItem from './TodoItem';

export default {
    components: { TodoItem },
    mounted () {
        this.$store.dispatch('getAllTodos');
    },
    computed: {
        name () {
            return this.$store.state.userName;
        },
        todos () {
            return this.$store.state.todos;
        },
        complete () {
            return this.todos.filter(todo => todo.completed).length;
        },
        remaining () {
            return this.todos.filter(todo => !todo.completed).length;
        }
    },
    methods: {
        addTodo (e) {
            let text = e.target.value || '';
            text = text.trim();

            if (text.length) {
                this.$store.dispatch('addTodo', { text });
            }

            e.target.value = '';
        }
    }
}
</script>

<style scoped>
    .new-todo {
        width: 100%;
        font-size: 18px;
        margin-bottom: 15px;
        border-top-width: 0;
        border-left-width: 0;
        border-right-width: 0;
        border-bottom: 1px solid rgba(0, 0, 0, 0.2);
    }
</style>