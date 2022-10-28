<script setup>
    import { useRoute } from 'vue-router';
    import router from "../router/router";
    import axios from 'axios'
    import { onBeforeMount, ref } from 'vue';

    const route = useRoute()
    const postStudentUrl = ref('');
    const newStud = ref({ Name: '', Phone: '' })
    

    onBeforeMount(async () => {
        postStudentUrl.value = route.params.postStudentUrl;
    })
    
    const createStudent = async () => {
        let response = await axios.post(postStudentUrl.value, {
            Name: newStud.value.Name,
            Phone: newStud.value.Phone,
        }).catch(error => {
        console.log(error)
        })

        if (response && response.status === 204) {
            router.push({ name:'students' })
        }
    }
</script>

<template>
    <StudentForm :action="createStudent" action-name="Create" :new-stud="newStud"/>
</template>