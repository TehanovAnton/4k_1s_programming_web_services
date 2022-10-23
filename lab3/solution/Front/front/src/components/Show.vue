<script setup>
  import { ref, onBeforeMount } from 'vue'
  import { useRoute } from 'vue-router'
  import router from "../router/router";
  import axios from 'axios'

  const studentWL = ref({})
  const student = ref({});
  const route = useRoute();

  onBeforeMount(async () => {
    await fetchStudent()    
  })  

  const updateStudent = async () => {
    await axios.put(studentWL.value.UpdateUrl, {
      Name: student.value.Name,
      Phone: student.value.Phone,
      Id: student.Id
    })
    .catch(error => {
      console.log(error)
    })

    await fetchStudent()
  }

  const destroyStudent = async () => {
    await axios.delete(studentWL.value.DestroyUrl)
    .catch(error => {
      console.log(error)
    })

    router.push({ name:'students' })
  }

  const fetchStudent = async () => {
    let studentUrl = route.params.link;
    let response = await axios.get(studentUrl)
    .catch(error => {
      console.log(error)
    })

    setStudentByResponse(response)
  }

  const setStudentByResponse = (response) => {
    if (response.status == 200) {      
      studentWL.value = JSON.parse(response.data)
      student.value = studentWL.value.Student
    } else {
      console.log('Something went wrong');
      return {}
    }
  }
</script>
  
<template>
    <StudentForm :action="updateStudent" action-name="Update" :new-stud="student"/>

    <button @click="destroyStudent">Destroy</button>
</template>
  