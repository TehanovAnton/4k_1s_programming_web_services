<script setup>
  import { ref, computed, onBeforeMount } from 'vue'
  import { useRoute } from 'vue-router'
  import router from "../router/router";
  import axios from 'axios'

  const route = useRoute()
  const studentWL = ref({})
  
  const studentParams = ref({
    name: "HelloTom",
    phone: "456"
  })

  onBeforeMount(async () => {
    await fetchStudent()    
  })


  const fetchStudent = async () => {
    let studentUrl = route.params.link;
    let response = await axios.get(studentUrl)
    .catch(error => {
      console.log(error)
    })

    setStudentByResponse(response)
  }

  const updateStudent = async () => {
    await axios.put(studentWL.value.UpdateUrl, {
      Name: studentParams.value.name,
      Phone: studentParams.value.phone,
      Id: studentWL.value.Id
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

    router.push({ name:'students' })
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
    <div>
      <p>Id:{{ studentWL.Student.Id }}; Name:{{ studentWL.Student.Name }}; Phone:{{ studentWL.Student.Phone }}</p>
    </div>

    <form>
      <p>
        <label for="studName">Name:</label>
        <input id="studName" type="text" v-model="studentParams.name" />
      </p>

      <p>
        <label for="studPhone">Phone:</label>
        <input id="studPhone" type="text" v-model="studentParams.phone" />
      </p>

      <button type="button" @click="updateStudent">Update</button>
    </form>
    <button @click="destroyStudent">Destroy</button>
</template>
  