<template>
  <div class="shopping-cart">
    <h2>Your Shopping Cart</h2>

    <ul>
      <ShoppingCartItem
        v-for="(item, index) in cartItems"
        :key="index"
        :item="item"
        @update-quantity="updateQuantity"
        @remove-from-cart="removeFromCart"
      />
    </ul>
    <div class="article-wrapper">
      <span class="article-title">Shipping</span>
      <span class="article-content"
        >Experience seamless shopping with a bonus: Spend over $150 and unlock
        free global shipping, saving you the standard $30 shipping fee!</span
      >
    </div>
    <div class="shipping-cost">
      <span>Shipping Cost:</span>
      <span>${{ shippingCost.toFixed(2) }}</span>
    </div>
    <div class="article-wrapper">
      <span class="article-title">ShoppingApp Peace of Mind</span>
      <span class="article-content"
        >Shop confidently on ShoppingApp knowing if something goes wrong with an
        order, we've got your back for all eligible purchases.</span
      >
    </div>
    <div class="total">
      <span>Total:</span>
      <span>${{ totalAmount.toFixed(2) }}</span>
    </div>

    <button
      class="checkout-button"
      @click="checkout"
      :disabled="totalAmount === 0"
    >
      Checkout
    </button>
    <button class="empty-cart-button" @click="clearCart">Empty Cart</button>
  </div>
</template>

<script>
import ShoppingCartItem from "@/components/ShoppingCartItem.vue";

export default {
  components: {
    ShoppingCartItem,
  },
  props: {
    cartItems: Array,
  },
  computed: {
    totalAmount() {
      return this.cartItems.reduce(
        (total, item) => total + item.price * item.quantity,
        0
      );
    },
    shippingCost() {
      return this.totalAmount > 150 ? 0 : 30;
    },
  },
  methods: {
    updateQuantity({ item, action }) {
      console.log("Parent received update:", item, action);
      this.$emit("update-quantity", { item, action });
    },
    removeFromCart(item) {
      this.$emit("remove-from-cart", item);
    },
    checkout() {
      alert("TODO: Checkout functionality.");
    },
    clearCart() {
      this.$store.commit("clearCart");
    },
  },
};
</script>

<style scoped>
.shopping-cart {
  border: 1px solid #ddd;
  padding: 20px;
  text-align: left;
  max-width: 350px;
}
.shopping-cart h2 {
  margin-bottom: 20px;
}
.shopping-cart ul {
  list-style-type: none;
  padding: 0;
}
.cart-item-wrapper {
  display: flex;
  flex-direction: row;
  padding: 5px;
}
.product-info {
  flex: 1;
  padding-left: 10px;
}
.cart-item {
  border-bottom: 1px solid #eee;
  padding: 10px 0;
}
.inline-row {
  display: flex;
  justify-content: space-between;
}
.product-image {
  width: 60px;
  height: auto;
  border-radius: 2px;
}
.item-name,
.item-price {
  font-size: 14px;
  font-weight: bold;
}
.item-description {
  font-size: 12px;
  color: #999;
}
.item-button {
  color: #999;
}
.quantity-controls {
  display: flex;
  align-items: center;
  gap: 5px;
}
.quantity-controls button {
  background-color: #fff;
  border-radius: 5px;
  color: #000;
  border: none;
  padding: 5px 10px;
  cursor: pointer;
}
.remove-button {
  background-color: transparent;
  border: none;
  cursor: pointer;
}
.article-wrapper {
  display: block;
}
.article-title {
  font-weight: bold;
  display: block;
  font-size: 14px;
  padding-bottom: 15px;
}
.article-content {
  display: block;
  font-size: 13px;
}
.total,
.shipping-cost {
  font-weight: bold;
  display: flex;
  justify-content: space-between;
  border-bottom: 1px solid #eee;
  padding: 10px;
}
.total {
  margin: 20px 0;
  font-size: 16px;
}
.shipping-cost {
  margin: 20px 0;
  font-size: 14px;
}
.checkout-button {
  background-color: #1d7daf;
  color: white;
  width: 100%;
  border-radius: 5px;
  padding: 10px;
  cursor: pointer;
  border: none;
}
.checkout-button:disabled {
  background-color: #ccc;
  cursor: not-allowed;
}
.empty-cart-button {
  background-color: transparent;
  width: auto;
  cursor: pointer;
  border: none;
  margin-bottom: 10px;
  margin-top: 10px;
  text-decoration: underline;
  margin: 10px auto;
  display: block;
  text-align: center;
}
</style>
