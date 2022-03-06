const authenticate = (jwt) => {
  if (typeof window !== "undefined") {
    console.log(jwt);
    sessionStorage.setItem("jwt", jwt);
  }
};
const isAuthentcated = () => {
  if (typeof window == "undefined") return false;
  let getToken = JSON.parse(sessionStorage.getItem("jwt"));

  if (!getToken) {
    return false;
  }
  return false;
};

export { authenticate, isAuthentcated };
