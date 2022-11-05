import { createRouter, createWebHistory } from 'vue-router'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'students',
      component: () => import('../views/HomeView.vue')
    },
    {
      path: '/students/new?:postStudentUrl',
      name: 'createStudent',
      component: () => import('../views/NewView.vue')
    },
    {
      path: '/student',
      name: 'student',
      component: () => import('../views/StudentsView.vue')
    },
    {
      path: '/students/xml',
      name: 'studentsXml',
      component: () => import('../views/StudentsXmlView.vue')
    },
    {
      path: '/students/errors',
      name: 'errors',
      component: () => import('../views/ErrorView.vue')
    }
  ]
})

export default router
