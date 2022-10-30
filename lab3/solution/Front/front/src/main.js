import { createApp } from 'vue'
import App from './App.vue'
import StudentForm from './components/StudentForm.vue'

const app = createApp(App)

import { createPinia } from "pinia";
app.use(createPinia());

import router from './router/router'
app.use(router)

import axios from 'axios'
import VueAxios from 'vue-axios'
app.use(VueAxios, axios)
app.provide('axios', app.config.globalProperties.axios)

app.component('StudentForm', StudentForm)

app.mount('#app')
