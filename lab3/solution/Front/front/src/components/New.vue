<script setup>
    import { useRoute } from 'vue-router';
    import router from "../router/router";
    import axios from 'axios'
    import { onBeforeMount, ref } from 'vue';
    import { useErrorsStore } from '../stores/errors';

    const route = useRoute()
    const postStudentUrl = ref('');
    const newStud = ref({ Name: '', Phone: '' })
    const errors = useErrorsStore();
    

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

      if (response && response.status === 200) {
        router.push({ name: 'students' })
      } else {
        debugger
        errors = JSON.parse(response.data)
        router.push({ name: 'error' })
      }
    }
</script>

<template>
    <StudentForm :action="createStudent" action-name="Create" :new-stud="newStud"/>
</template>