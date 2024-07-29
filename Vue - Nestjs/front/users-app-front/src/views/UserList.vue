<template>
  <div>
    <h1>Lista de usuarios</h1>
    <ul>
      <li v-for="user in users" :key="user.id">
        {{ user.name }} {{ user.surname }} - {{ user.email }}
      </li>
    </ul>
    <p v-if="errorMessage">{{ errorMessage }}</p>
  </div>
</template>

<script>
import axios from 'axios'

export default {
  data() {
    return {
      users: [],
      errorMessage: ''
    }
  },
  async created() {
    try {
      const response = await axios.get('http://localhost:3000/users')
      this.users = response.data
    } catch (error) {
      this.errorMessage = 'Error fetching users: ' + error.message
    }
  }
}
</script>
