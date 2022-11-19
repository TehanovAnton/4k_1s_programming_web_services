<script setup>
    import router from "../router/router";
    import axios from 'axios'
    import { onBeforeMount, ref } from 'vue';
    import { useErrorsStore } from '../stores/errors';

    const errorDescription = ref('')
    const errorsStore = useErrorsStore();

    onBeforeMount(async () => {
        let response = await axios.get(errorsStore.error.ErrorDescriptionUrl)
        .catch(error => {        
            console.log(error);
        })

        if (response && response.status == 200 ) {
            errorDescription.value = JSON.parse(response.data) 
        }
    })

    const studentsListView = () => {
        router.push({ name: 'students' })
    }
</script>

<template>
    <p v-if="errorDescription">
    {{ errorDescription }}
    </p>

    <button v-on:click="studentsListView">Students List</button>
</template>