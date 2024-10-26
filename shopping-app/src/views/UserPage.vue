<template>
    <div>
      <HeaderNav /> 
      <div class="user-wrapper">
        <select v-model="selectedUserId">
        <option v-for="user in users" :key="user.userId" :value="user.userId">
          {{ user.email }}
        </option>
      </select>
      <p>Selected User ID: {{ selectedUserId }}</p>
      </div>
    </div>
  </template>
  
  <script>
  import HeaderNav from '@/components/HeaderNav.vue';
  import axios from 'axios';
    export default {
      name: 'UserPage',
      components: {
      HeaderNav
    },
    data() {
      return {
        selectedUserId: null,
        users: [
          { userId: 1, email: "danbarazani@gmail.com" },
          { userId: 2, email: "jamespalimio@gmail.com" },
          { userId: 3, email: "virgozalepio@gmail.com" }
        ]
      };
    },
    watch: {
    selectedUserId(newUserId) {
      this.fetchUserDetails(newUserId);
    }
  },
  methods: {
    async fetchUserDetails(userId) {
        try {
          const response = await axios.get(`https://localhost:7001/api/user/${userId}`);
          console.log('User details:', response.data);
        } catch (error) {
          console.error('Error fetching user details:', error);
        }
    }
  }
  };
  </script>

  
<style scoped>
    .user-wrapper {
      text-align: center;
    }
 
    button {
      background-color: #000;
      color: white;
      border: none;
      padding: 10px;
      cursor: pointer;
      border-radius: 5px;
    }
</style>
  