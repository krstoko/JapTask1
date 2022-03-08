import axios from "axios";
const jwtToken = sessionStorage.getItem("jwt");
const api = axios.create({
  baseURL: "https://localhost:44372/",
});

api.interceptors.request.use(
  (config) => {
    config.headers.authorization = `Bearer ${jwtToken}`;
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

export default api;
