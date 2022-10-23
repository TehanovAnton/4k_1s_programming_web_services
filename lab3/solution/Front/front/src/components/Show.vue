<script setup>
  import { ref, onBeforeMount } from 'vue'
  import router from "../router/router";
  import axios from 'axios'
  import { computed } from '@vue/reactivity';
  import { useRoute } from 'vue-router';

  const props = defineProps([
    'student'
  ]);

  const studentWL = ref({})
  const route = useRoute();
  const student = computed(() => {
    debugger
    return props.student ? props.student.Student : studentWL.value.Student;
  });

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

  const studentUrl = computed(() => {
    if (props.student) {
      return props.student.GetUrl
    } else {
      return route.params.link;
    }
  })

  const fetchStudent = async () => {
    debugger
    let response = await axios.get(studentUrl.value)
    .catch(error => {
      console.log(error)
    })

    setStudentByResponse(response)
  }

  const setStudentByResponse = (response) => {
    if (response.status == 200) {      
      studentWL.value = JSON.parse(response.data)
    } else {
      console.log('Something went wrong');
      return {}
    }
  }
</script>
  
<template>
    <StudentForm v-if="student" :action="updateStudent" action-name="Update" :new-stud="student"/>

    <button @click="destroyStudent">Destroy</button>
</template>
  