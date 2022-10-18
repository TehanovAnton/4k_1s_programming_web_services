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
      path: '/students/:id?:link',
      name: 'student',
      component: () => import('../views/StudentView.vue')
    }
  ]
})

export default router
