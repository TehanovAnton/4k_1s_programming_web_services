import { createApp } from 'vue'
import App from './App.vue'
import StudentForm from './components/StudentForm.vue'

import axios from 'axios'
import VueAxios from 'vue-axios'

import router from './router/router'

const app = createApp(App)
app.use(router)

app.use(VueAxios, axios)
app.provide('axios', app.config.globalProperties.axios)

app.component('StudentForm', StudentForm)

app.mount('#app')
