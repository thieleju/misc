<template>
  <div class="App">
    <h1>{{ title }}</h1>

    <button @click="increase">Count: {{ count }}</button>

    <Message :message="title" @pressed="pressed" />
    <h2>{{ message }}</h2>
    <h2>{{ date }}</h2>
  </div>
</template>

<script lang="ts" setup>
import Message from "./components/Message.vue";
import axios from "axios";
import { ref, isRef, reactive } from "vue";

let title: string = "";

let message = ref("");
let date = ref(null);
let count = ref(1);

const cube = reactive<{ length: number; width: number; height: number }>({
  length: 10,
  width: 20,
  height: 33,
});

function increase(): void {
  count.value++;
}

function pressed(data: any): void {
  message.value = data.message;
  date.value = data.date;
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
