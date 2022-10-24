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
    return props.student;
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
    return props.student.GetUrl
  })

  const fetchStudent = async () => {
    debugger
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
</script>
  
<template>
    <StudentForm :action="updateStudent" action-name="Update" :new-stud="student.Student"/>

    <button @click="destroyStudent">Destroy</button>
</template>
  