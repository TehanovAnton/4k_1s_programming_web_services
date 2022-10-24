<script setup>
  import { onBeforeMount, ref, computed } from 'vue'
  import router from "../router/router";
  import axios from 'axios'

  const studentsWl = ref({})  

  onBeforeMount(async () => {
    await fetchStudents()
  })  
  
  async function fetchStudents () {
    let studentsUrl = `http://localhost:50369/api/students.json/`
    let response = await axios.get(studentsUrl)
    .catch(error => {
      console.log(error)
    })
    if (response.status == 200 ) {
      studentsWl.value = JSON.parse(response.data)
    } else {
      studentsWl.value = { Name: 'error' }
    }
  }  

  const newView = () => {
    router.push({ name: 'createStudent', params: { postStudentUrl: 'http://localhost:50369/api/students/' } });
  }
  const studensView = () => {
    router.push({ name: 'student' })
  }
</script>

<template>
  <button v-on:click="newView">Create New!</button>
  <button v-on:click="studensView">Each Student</button>
  
  <ul>
    <li v-for="studentWL in studentsWl">
      <p>Id:{{ studentWL.Student.Id }}; Name:{{ studentWL.Student.Name }}; Phone:{{ studentWL.Student.Phone }}</p>
    </li>
  </ul>
</template>
