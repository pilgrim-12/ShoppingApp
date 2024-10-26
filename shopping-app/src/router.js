import { createRouter, createWebHistory } from "vue-router";

import HomePage from "./views/HomePage.vue";
import ProductsListPage from "./views/ProductsListPage.vue";
import ProductPage from "./views/ProductPage.vue";
import ContactUsPage from "./views/ContactUsPage.vue";

import UserPage from "./views/UserPage.vue";
import CartPage from "./views/CartPage.vue";

const routes = [
  {
    path: "/",
    name: "HomePage",
    component: HomePage,
  },
  {
    path: "/product/:id",
    name: "ProductPage",
    component: ProductPage,
    props: true,
  },
  {
    path: "/products",
    name: "ProductsListPage",
    component: ProductsListPage,
  },
  {
    path: "/contact-us",
    name: "ContactUsPage",
    component: ContactUsPage,
  },
  {
    path: "/users",
    name: "UserPage",
    component: UserPage,
  },
  {
    path: "/cart",
    name: "CartPage",
    component: CartPage,
  },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
