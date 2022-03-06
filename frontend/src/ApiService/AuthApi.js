const login = (credentials) => {
  return fetch(`https://localhost:44372/Auth/Login`, {
    method: "POST",
    headers: { Accept: "application/json", "Content-Type": "application/json" },
    body: JSON.stringify(credentials),
  })
    .then((response) => response.json())
    .catch((err) => console.log(err));
};

export { login };
