<template>
  <div>
    <h1>Crear Usuario</h1>
    <form @submit.prevent="createUser" style="width: 20rem">
      <div>
        <label for="name" class="mb-2">Nombre:</label>
        <input v-model="user.name" id="name" class="frigth inpText" type="text" required />
      </div>
      <br />
      <div>
        <label for="surname" class="mb-2">Apellidos:</label>
        <input v-model="user.surname" id="surname" class="frigth inpText" type="text" required />
      </div>
      <br />
      <div>
        <label for="email" class="mb-2">Email:</label>
        <input v-model="user.email" id="email" class="frigth inpText" type="email" required />
      </div>
      <br />
      <button type="submit" class="frigth btn-prim">Crear Usuario</button>
    </form>
    <p v-if="message">{{ message }}</p>
  </div>
</template>

<script>
import axios from 'axios'

export default {
  data() {
    return {
      user: {
        name: '',
        surname: '',
        email: ''
      },
      message: ''
    }
  },
  methods: {
    async createUser() {
      try {
        const response = await axios.post('http://localhost:3000/users', this.user)
        this.message = response.data.message
      } catch (error) {
        this.message = 'Error creando el usuario'
      }
    }
  }
}
</script>
