<script setup>
  import { ref, onBeforeMount } from 'vue'
  import router from "../router/router";
  import axios from 'axios'
  import { computed } from '@vue/reactivity';
  import { useRoute } from 'vue-router';

  const props = defineProps([
    'inStudent'
  ]);

  const studentWL = ref({})
  const route = useRoute();
  const propStudent = computed(() => {
    return props.inStudent;
  });
  const student = computed(() => {
    studentWL.value = props.inStudent;
    return props.inStudent.Student;
  }) 

  onBeforeMount(async () => {
    await fetchStudent()    
  })  

  const updateStudent = async () => {
    await axios.put(studentWL.value.UpdateUrl, {
      Name: student.value.Name,
      Phone: student.value.Phone,
      Id: student.value.Id
    })
    .catch(error => {
      console.log(error)
    })

    await fetchStudent()
  }

  const destroyStudent = async () => {
    debugger
    await axios.delete(studentWL.value.DestroyUrl)
    .catch(error => {
      console.log(error)
    })

    studentsListView();
  }

  const studentUrl = computed(() => {
    return props.inStudent.GetUrl
  })

  const fetchStudent = async () => {
    let response = await axios.get(studentUrl.value)
    .catch(error => {
      console.log(error)
    })

    if (response.status == 200) {      
      studentWL.value = JSON.parse(response.data)
    } else {
      console.log('Something went wrong');
      return {}
    }
  }

  const studentsListView = () => {
    router.push({ name: 'students' })
  }
</script>
  
<template>
  <button v-on:click="studentsListView">Students List</button>

  <p v-if="student">
    {{ student.Id }} - {{ student.Name }} - {{ student.Phone }}
  </p>
  <StudentForm :action="updateStudent" action-name="Update" :new-stud="student"/>

  <button @click="destroyStudent">Destroy</button>
</template>
  