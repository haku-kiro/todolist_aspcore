<template>
    <li class="todo" v-bind:class="{ completed: item.completed}">
        <input type="checkbox" 
               class="toggle"
               v-bind:checked="item.completed"
               v-on:change="toggleTodo({id: item.id, completed: !itme.completed})">
        <label v-text="item.text"></label>

        <button class="delete"
                v-on:click="deleteTodo(item.id)">
            <span class="glyphicon glyphicon-trash"></span>
        </button>
    </li>
</template>

<script>
import { mapActions } from 'vuex';

export default {
    props: ['item'],
    methods: {
        ...mapActions([
            'toggleTodo',
            'deleteTodo',
        ])
    }
}
</script>

<style>
    .todo {
        list-style-type: none;
    }

    .todo-completed {
        opacity: 0.5;
    }

    .todo-completed label {
        text-decoration: line-through;
    }

    button.delete {
        color: red;
        opacity: 0.5;
        -webkit-appearance: none;
        -moz-appearance: none;
        outline: none;
        border: 0;
        background: transparent;
    }
</style>