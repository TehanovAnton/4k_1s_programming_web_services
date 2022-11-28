<script setup>
  import axios from 'axios';
  import { onBeforeMount, ref } from 'vue';
  import { useFiltersStore } from '../stores/filters';

  const xml = ref('');
  const filters = useFiltersStore();

  onBeforeMount(async () => {
    await fetchStudents()
  })

  const fetchStudents = async () => {
    let studentsUrl = `http://localhost:8080/api/students.xml/`
    let response = await axios.get(studentsUrl, { params: filters.state })
    .catch(error => {
      console.log(error)
    })    

    if (response.status == 200 ) {
      xml.value = response.data;
    }
  }
</script>

<template>
  <p v-if="xml">{{ xml }}</p>
</template>
