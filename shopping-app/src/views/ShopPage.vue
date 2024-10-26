<template>
  <div class="shop-page">
    <HeaderNav />
    <div class="product-list-wrapper">
      <div class="product-list">
        <div
          v-for="product in products"
          :key="product.productId"
          class="product-item"
          @click="goToProductPage(product.productId)"
        >
          <ProductReviews :reviews="product.reviews" />

          <h2>{{ product.name }}</h2>
          <p>{{ product.description }}</p>
          <div class="price">
            <span class="current-price">{{ product.price }}</span>
            <span class="original-price" v-if="product.originalPrice">{{
              product.originalPrice
            }}</span>
          </div>
          <img :src="product.imageUrl" alt="Product Image" />
          <button @click.stop="addToCart(product)">Add to Cart</button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import HeaderNav from "@/components/HeaderNav.vue";
import ProductReviews from "@/components/ProductReviews.vue";
import { mapState } from "vuex";

export default {
  name: "ShopPage",
  components: {
    HeaderNav,
    ProductReviews,
  },
  computed: {
    ...mapState(["products"]),
  },
  methods: {
    addToCart(product) {
      this.$store.commit("addToCart", product);
    },
    goToProductPage(productId) {
      this.$router.push({ name: "ProductPage", params: { id: productId } });
    },
  },
  created() {
    console.log("CREATED");
    this.$store.dispatch("fetchProducts");
  },
};
</script>

<style scoped>
.shop-page {
  text-align: center;
}

.product-list-wrapper {
  padding-top: 25px;
}

.product-list {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 20px;
  justify-content: center;
}

.product-item {
  border: 1px solid #ddd;
  padding: 20px;
  text-align: center;
}
.product-item img {
  max-width: 100%;
  height: auto;
}
.price {
  margin: 10px 0;
}
.current-price {
  font-size: 1.3em;
  color: #000;
}
.original-price {
  font-size: 1em;
  color: #999;
  text-decoration: line-through;
  margin-left: 10px;
}
button {
  background-color: #000;
  color: white;
  border: none;
  padding: 10px;
  cursor: pointer;
  margin-top: 10px;
}
</style>
