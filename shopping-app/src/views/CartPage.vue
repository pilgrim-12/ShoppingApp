<template>
  <div class="product-page">
    <HeaderNav @toggle-cart="$emit('toggle-cart')" />
    <div class="main-content">
      <div class="content-wrapper">
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
import ShoppingCart from "@/components/ShoppingCart.vue";
import { mapState } from "vuex";

export default {
  name: "ProductPage",
  components: {
    HeaderNav,
    ShoppingCart,
  },
  props: ["id"],
  computed: {
    ...mapState({
      products: (state) => state.products,
      cartItems: (state) => state.cart,
    }),
    product() {
      return this.products.find((product) => product.id === parseInt(this.id));
    },
  },
  methods: {
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
  border-radius: 5px;
}
</style>
