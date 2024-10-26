<template>
  <div class="contact-us-page">
    <HeaderNav />
    <h1>Contact Us Page</h1>
  </div>
</template>

<script>
import HeaderNav from '@/components/HeaderNav.vue';

export default {
  name: 'ContactUsPage',
  components: {
    HeaderNav
  }
};
</script>

<style scoped>
.contact-us-page {
  text-align: center;
}
</style>
