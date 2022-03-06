const authenticate = (jwt) => {
  if (typeof window !== "undefined") {
    sessionStorage.setItem("jwt", JSON.stringify(jwt));
  }
};
const isAuthentcated = () => {
  if (typeof window == "undefined") return false;
  let getToken = JSON.parse(sessionStorage.getItem("jwt"));

  if (!getToken) {
    return false;
  }
  return true;
};

export default { authenticate, isAuthentcated };
