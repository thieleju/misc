<template>
  <div>
    <h3 v-bind="$attrs">Hello from Message component</h3>
    <h4>Message {{ message }}</h4>
    <button @click="onClick">Press Me</button>
  </div>
</template>

<script lang="ts">
export default {
  inheritAttrs: false,
};
</script>

<script lang="ts" setup>
// import { useAttrs } from "vue";
// const attrs = useAttrs();
// console.log(attrs);

const emits = defineEmits(["pressed"]);

function onClick(): void {
  emits("pressed", {
    message: "Hello from Message component",
    date: new Date(),
  });
}

interface props {
  message?: string;
}

const props = withDefaults(defineProps<props>(), {
  message: "Default message",
});
</script>
