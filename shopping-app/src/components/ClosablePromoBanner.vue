<template>
  <div v-if="isVisible" class="promo-banner">
    <span class="message"
      >30% off storewide — Limited time! <a href="#">Shop Now &#8594;</a></span
    >
    <span class="close-button" @click="closeBanner">&times;</span>
  </div>
</template>

<script>
export default {
  name: "ClosablePromoBanner",
  data() {
    return {
      isVisible: true,
    };
  },
  methods: {
    closeBanner() {
      this.isVisible = false;
    },
  },
};
</script>

<style scoped>
.promo-banner {
  background-color: #e0e0e0;
  padding: 5px;
  text-align: center;
  font-size: 14px;
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.message {
  text-align: center;
  flex-grow: 1;
}
.close-button {
  cursor: pointer;
  padding: 0 10px;
  font-size: 18px;
  color: #333;
}
.close-button:hover {
  color: #999;
}
</style>
