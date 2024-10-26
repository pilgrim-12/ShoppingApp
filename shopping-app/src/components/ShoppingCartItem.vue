<template>
  <li class="cart-item">
    <div class="cart-item-wrapper">
      <img :src="item.imageUrl" alt="Product Image" class="product-image" />
      <div class="product-info">
        <div class="inline-row">
          <div class="item-name">{{ item.name }}</div>
          <div class="item-price">${{ item.price }}</div>
        </div>
        <div class="inline-row">
          <div class="item-description">{{ item.description }}</div>
          <div class="item-button">
            <button class="remove-button" @click="removeFromCart">
              <i class="fa fa-trash"></i>
            </button>
          </div>
        </div>
        <div class="inline-row">
          <div class="quantity-controls">
            <button @click="updateQuantity('decrease')">-</button>
            <span>{{ item.quantity }}</span>
            <button @click="updateQuantity('increase')">+</button>
          </div>
        </div>
      </div>
    </div>
  </li>
</template>

<script>
export default {
  name: "ShoppingCartItem",
  props: {
    item: Object,
  },
  methods: {
    updateQuantity(action) {
      this.$emit("update-quantity", { item: this.item, action });
    },
    removeFromCart() {
      this.$emit("remove-from-cart", this.item);
    },
  },
};
</script>

<style scoped>
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
</style>
