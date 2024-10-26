<template>
  <div>
    <ClosablePromoBanner />
    <div class="header">
      <div class="logo">
        <h1>ShoppingApp</h1>
      </div>
      <div class="nav-links">
        <RouterLink to="/" active-class="active">Home</RouterLink>
        <RouterLink to="/products" active-class="active">Shop</RouterLink>
        <!-- <RouterLink to="/product" active-class="active">Product</RouterLink>
          <RouterLink to="/contact-us" active-class="active">Contact Us</RouterLink> -->
        <RouterLink to="#">Product</RouterLink>
        <RouterLink to="#">Contact Us</RouterLink>
      </div>
      <div class="icons">
        <span @click="gotoSearch"><i class="fa fa-search search"></i></span>
        <span @click="goToUsers"><i class="fa fa-user user"></i> </span>
        <span @click="gotoCart"><i class="fa fa-shopping-cart cart"></i></span>
        <span @click="gotoCart" class="cart-count">{{ cartItemCount }}</span>
      </div>
    </div>
  </div>
</template>

<script>
import ClosablePromoBanner from "@/components/ClosablePromoBanner.vue";
import { mapGetters } from "vuex";

export default {
  name: "HeaderNav",
  components: {
    ClosablePromoBanner,
  },
  computed: {
    ...mapGetters(["cartItemCount"]),
  },
  methods: {
    gotoSearch() {
      alert("Search functionality.");
    },
    goToUsers() {
      this.$router.push({ path: "/users" });
    },
    gotoCart() {
      this.$router.push({ path: "/cart" });
    },
  },
};
</script>

<style scoped>
.header {
  padding: 10px 20px;
  display: flex;
  justify-content: space-between;
  align-items: center;
  border-bottom: 1px solid #ddd;
}
.nav-links {
  display: flex;
  gap: 20px;
}
.nav-links a {
  text-decoration: none;
  color: #333;
  font-size: 16px;
}
.nav-links a:hover {
  text-decoration: none;
  color: #999;
  font-size: 16px;
}
.nav-links .active {
  font-weight: bold;
  color: black;
}
.icons {
  display: flex;
  gap: 15px;
  padding-right: 25px;
}
.search:hover,
.user:hover,
.cart:hover {
  cursor: pointer;
  color: #999;
}
.cart-count {
  background-color: #ee76b4;
  color: white;
  border-radius: 50%;
  padding: 2px;
  height: 15px;
  width: 15px;
  font-size: 12px;
}
.cart-count:hover {
  background-color: #201f1f;
  cursor: pointer;
}
</style>
