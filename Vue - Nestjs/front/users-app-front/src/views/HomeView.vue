<template>
  <div>
    <h1>Pantalla de Inicio</h1>
    <button @click="goToCreateUser" class="btn-prim">Crear Usuario</button>
    <button @click="goToUserList" class="btn-prim ml-2">Lista de Usuarios</button>
  </div>
</template>

<script>
export default {
  methods: {
    goToCreateUser() {
      this.$router.push('/create-user')
    },
    goToUserList() {
      this.$router.push('/user-list')
    }
  }
}
</script>
