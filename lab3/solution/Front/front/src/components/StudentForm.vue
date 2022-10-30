<script setup>
  const props = defineProps([
    'action',
    'actionName',
    'newStud'
  ]);    
</script>

<template>
  <form>
    <p>
      <label for="studName">Name:</label>
      <input id="studName" type="text" v-model="newStud.Name" required/>
    </p>

    <p>
      <label for="studPhone">Phone:</label>
      <input id="studPhone" type="text" v-model="newStud.Phone" required/>
    </p>      

    <button type="button" @click="action()">{{ actionName }}</button>
  </form>
</template>