import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import CreateUser from '../views/CreateUser.vue'
import UserList from '../views/UserList.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    },
    {
      path: '/about',
      name: 'about',
      component: () => import('../views/AboutView.vue')
    },
    { path: '/create-user', name: 'CreateUser', component: CreateUser },
    { path: '/user-list', name: 'UserList', component: UserList }
  ]
})

export default router
