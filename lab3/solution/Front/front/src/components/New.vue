<script setup>
    import { onBeforeMount, ref } from 'vue'
    import {  useRoute } from 'vue-router'
    import router from "../router/router";
    import axios from 'axios'
    
    const route = useRoute()
    const postStudentUrl = ref("");
    const newStud = ref({})

    onBeforeMount(async () => {
        postStudentUrl.value = route.params.postStudentUrl;
    })

    const createStudent = async () => {
        let response = await axios.post(postStudentUrl.value,{
            Name: newStud.value.name,
            Phone: newStud.value.phone,
        }).catch(error => {
        console.log(error)
        })

        if (response && response.status === 204) {
            router.push({ name:'students' })
        }
    }
</script>

<template>
    {{ newStud.name }} - {{ newStud.phone }}
    <form>
      <p>
        <label for="studName">Name:</label>
        <input id="studName" type="text" v-model="newStud.name" required/>
      </p>

      <p>
        <label for="studPhone">Phone:</label>
        <input id="studPhone" type="text" v-model="newStud.phone" required/>
      </p>

      <button type="button" @click="createStudent">Create</button>
    </form>
</template>