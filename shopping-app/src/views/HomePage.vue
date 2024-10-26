<template>
    <div class="home-page">
      <HeaderNav />
      <h1>Home Page</h1>
    </div>
  </template>  
  <script>
  import HeaderNav from '@/components/HeaderNav.vue';
  export default {
    name: 'HomePage',
    components: {
      HeaderNav
    },
    created() {
     console.log("HomePage Created Hook");   
     this.$store.dispatch('fetchProducts');
  },
  mounted() {
    console.log("HomePage Mounted Hook");
  }
  };
  </script>
  
  <style scoped>
  .home-page {
    text-align: center;
  }
  </style>
  