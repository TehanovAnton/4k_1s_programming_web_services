<script setup>
  import { onBeforeMount, ref, computed } from 'vue'
  import router from "../router/router";
  import axios from 'axios'

  const studentsWl = ref({});
  const filters = ref({ limit: '' })
  const filtersHash = computed(() => {
    return {
        limit: filters.value.limit
    }
  });

  onBeforeMount(async () => {
    await fetchStudents()
  })  
  
  async function fetchStudents () {
    let studentsUrl = `http://localhost:50369/api/students.json/`
    let response = await axios.get(studentsUrl, { params: filtersHash.value })
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
  <p>
    <button v-on:click="newView">Create New!</button>
    <button v-on:click="studensView">Each Student</button>
  </p>

  <label for="filterForm">Filters</label>
  <form action="" id="filterForm">
    <p>
        <label for="limit"></label>
        <input type="number" v-model="filters.limit" id="limit" name="limit" placeholder="limit">
    </p>

    <button type="button" @click="fetchStudents()">apply</button>
  </form>
  
  <ul>
    <li v-for="studentWL in studentsWl">
      <p>Id:{{ studentWL.Student.Id }}; Name:{{ studentWL.Student.Name }}; Phone:{{ studentWL.Student.Phone }}</p>
    </li>
  </ul>
</template>
