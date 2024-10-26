<template>
  <div class="product-page">
    <HeaderNav @toggle-cart="$emit('toggle-cart')" />
    <div class="main-content">
      <div class="content-wrapper">
        <div v-if="product" class="product-details">
          <ProductReviews :reviews="product.reviews" />
          <h1>{{ product.name }}</h1>
          <p>{{ product.description }}</p>
          <div class="price">
            <span class="current-price">${{ product.price }}</span>
            <span class="original-price" v-if="product.originalPrice"
              >${{ product.originalPrice }}</span
            >
            <hr class="price-line" />
          </div>
          <img :src="product.imageUrl" alt="Product Image" />
          <p class="detailed-description-label">Description</p>
          <p class="detailed-description">{{ product.detailedDescription }}</p>
          <button @click="addToCart(product)">Add to Cart</button>
        </div>
        <div class="divider"></div>
        <div class="shopping-cart-container">
          <ShoppingCart
            :cartItems="cartItems"
            @update-quantity="updateQuantity"
            @remove-from-cart="removeFromCart"
          />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import HeaderNav from "@/components/HeaderNav.vue";
import ProductReviews from "@/components/ProductReviews.vue";
import ShoppingCart from "@/components/ShoppingCart.vue";
import axios from "axios";

export default {
  name: "ProductPage",
  components: {
    HeaderNav,
    ProductReviews,
    ShoppingCart,
  },
  props: ["id"],
  data() {
    return {
      product: null,
    };
  },
  computed: {
    cartItems() {
      return this.$store.state.cart;
    },
  },
  methods: {
    async fetchProductDetails() {
      try {
        const response = await axios.get(
          `https://localhost:7000/api/product/${this.id}`
        );
        this.product = response.data.result;
        console.log(this.product);
      } catch (error) {
        console.error("Error fetching product details:", error);
      }
    },
    addToCart(product) {
      this.$store.commit("addToCart", product);
    },
    updateQuantity({ item, action }) {
      this.$store.commit("updateQuantity", { item, action });
    },
    removeFromCart(item) {
      this.$store.commit("removeFromCart", item);
    },
  },
  created() {
    this.fetchProductDetails();
  },
};
</script>

<style scoped>
.product-page {
  text-align: center;
}
.main-content {
  display: flex;
  justify-content: center;
  padding: 20px;
}
.content-wrapper {
  display: flex;
  justify-content: center;
  gap: 50px;
}
.product-details {
  padding: 20px;
  min-width: 50%;
  text-align: left;
}
.product-details img {
  max-width: 100%;
  height: auto;
  margin: 20px 0;
}
.price {
  margin: 10px 0;
}
.current-price {
  font-size: 1.3em;
  font-weight: bold;
  color: #000;
}
.original-price {
  font-size: 1em;
  color: #999;
  text-decoration: line-through;
  margin-left: 10px;
}
.price-line {
  display: block;
  height: 1px;
  border: 0;
  border-top: 1px solid #999;
  margin: 1em 0;
  padding: 0;
}
.detailed-description-label {
  font-weight: bold;
  color: #999;
}
.divider {
  background-color: #999;
  width: 1px;
  min-width: 1px;
}
.shopping-cart-container {
  min-width: 48%;
  text-align: left;
}
button {
  background-color: #000;
  color: white;
  border: none;
  padding: 10px;
  cursor: pointer;
  width: 100%;
  border-radius: 3px;
}
</style>
