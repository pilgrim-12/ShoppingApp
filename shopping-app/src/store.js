import axios from "axios";
import { createStore } from "vuex";

const store = createStore({
  state: {
    cart: [],
    products: [],
  },
  mutations: {
    setProducts(state, products) {
      state.products = products;
    },
    addToCart(state, product) {
      const item = state.cart.find((i) => i.name === product.name);
      if (item) {
        item.quantity++;
      } else {
        state.cart.push({ ...product, quantity: 1 });
      }
    },
    updateQuantity(state, { item, action }) {
      const cartItem = state.cart.find((i) => i.name === item.name);
      if (cartItem && action === "increase") {
        cartItem.quantity++;
      } else if (cartItem && action === "decrease" && cartItem.quantity > 1) {
        cartItem.quantity--;
      }
    },
    removeFromCart(state, item) {
      state.cart = state.cart.filter((i) => i.name !== item.name);
    },
    clearCart(state) {
      state.cart = [];
    },
  },
  actions: {
    async fetchProducts({ commit }) {
      try {
        const response = await axios.get("https://localhost:7000/api/product");
        const products = response.data.result;
        commit("setProducts", products);
      } catch (error) {
        console.error("Failed to fetch products:", error);
      }
    },
  },
  getters: {
    products: (state) => state.products,
    cartItems: (state) => state.cart,
    totalAmount: (state) =>
      state.cart.reduce((total, item) => total + item.price * item.quantity, 0),
    cartItemCount: (state) =>
      state.cart.reduce((total, item) => total + item.quantity, 0),
  },
});

export default store;
