<template>
  <div class="reviews">
    <span v-for="star in 5" :key="star" class="fa fa-star stars"></span>
    <span>{{ reviews }} Reviews</span>
  </div>
</template>

<script>
export default {
  name: "ProductReviews",
  props: {
    reviews: {
      type: Number,
      required: true,
    },
  },
};
</script>

<style scoped>
.reviews {
  display: flex;
  align-items: center;
  gap: 5px;
}
.stars {
  color: gray;
}
</style>
