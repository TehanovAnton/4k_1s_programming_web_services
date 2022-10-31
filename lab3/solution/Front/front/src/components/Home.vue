<script setup>
  import { onBeforeMount, ref, computed } from 'vue'
  import router from "../router/router";
  import axios from 'axios'
  import { useFiltersStore } from '../stores/filters'

  const studentsWl = ref({});
  const filters = useFiltersStore();
  const filterColumns = computed(() => {
    return filters.columns;
  });


  onBeforeMount(async () => {
    await fetchStudents()
  })  
  
  async function fetchStudents () {
    let studentsUrl = `http://localhost:50369/api/students.json/`

    let response = await axios.get(studentsUrl, { params: filters.state })
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
        <label for="limit">limit:</label>
        <input type="number" v-model="filters.state.limit" id="limit" name="limit" />
    </p>

    <p>
        <label for="sort">sort:</label>
        <input type="checkbox" v-model="filters.state.sort" name="sort" id="sort" />
    </p>

    <p>
        <label for="minId">MinId:</label>
        <input id="minId" type="text" v-model="filters.state.minId" required /> - 

        <label for="maxId">MaxId:</label>
        <input id="maxId" type="text" v-model="filters.state.maxId" required />
    </p>

    <p>
        <label for="offset">offset:</label>
        <input type="number" v-model="filters.state.offset" required  />
    </p>

    <p>
        <label for="like">like:</label>
        <input type="text" v-model="filters.state.like" required />
    </p>
    
    <p>
        <label for="globallike">globallike:</label>
        <input type="text" v-model="filters.state.globallike" required />
    </p>

    <p>
        <label for="columns">columns:</label>
        <input type="checkbox" v-model="filterColumns.id" />
        <input type="checkbox" v-model="filterColumns.name" />
        <input type="checkbox" v-model="filterColumns.phone" />
    </p>

    <button type="button" @click="fetchStudents()">apply</button>
  </form>
  
  <ul>
    <li v-for="studentWL in studentsWl">
      <p>Id:{{ studentWL.Student.Id }}; Name:{{ studentWL.Student.Name }}; Phone:{{ studentWL.Student.Phone }}</p>
    </li>
  </ul>
</template>