<script setup>
  import { onBeforeMount, ref } from 'vue'
  import router from "../router/router";
  import axios from 'axios'
  import Show from './Show.vue';
  import { computed } from '@vue/reactivity';
  import { useFiltersStore } from '../stores/filters'

  const studentsWl = ref({})  
  const currentStudentWlIndex = ref(0);
  const fetched = ref(false)
  const filterStore = useFiltersStore()


  const currentStudentWl = computed(() => {
    if (currentStudentWlIndex.value > lastStudentIndex.value) {
        currentStudentWlIndex.value = 0;
    }

    if (currentStudentWlIndex.value < 0) {
        currentStudentWlIndex.value = lastStudentIndex.value;
    }

    return studentsWl.value[currentStudentWlIndex.value]
  })

  const lastStudentIndex = computed(() => {
    let length = studentsWl.value.length;
    return length - 1;
  });

  const studentUrl = computed(() => {
    return currentStudentWl.value.GetUrl
  })  

  onBeforeMount(async () => {
    await fetchStudents()
  })
  
  async function fetchStudents () {
    let studentsUrl = `http://localhost:8080/api/students.json/`
    let response = await axios.get(studentsUrl, { params: filterStore.state })
    .catch(error => {
      console.log(error)
    })

    if (response.status == 200 ) {
      studentsWl.value = JSON.parse(response.data)
      fetched.value = true;
      
    } else {
      studentsWl.value = { Name: 'error' }
    }
  }

  const nextStudent = () => {
    currentStudentWlIndex.value++;
  }
  
  const previousStudent = () => {
    currentStudentWlIndex.value--;
  }

  const studentShow = (studentId, studentLink) => {
    router.push({ name: 'student', params: { id: studentId, link: studentLink } })
  }

  const newView = () => {
    router.push({ name: 'createStudent', params: { postStudentUrl: 'http://localhost:8080/api/students/' } });
  }
</script>

<template>
    {{ filterStore.state.limit }}

    <p v-if="fetched">
        <Show :in-student="currentStudentWl"/>
    </p>
    <button @click="previousStudent">previous</button> - 
    <button @click="nextStudent">next</button>
</template>
