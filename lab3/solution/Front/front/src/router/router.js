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
    }
  ]
})

export default router
