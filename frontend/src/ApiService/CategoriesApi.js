const listCategories = (displeyedCategories, pageSize) => {
  return fetch(
    `https://localhost:44372/category/GetCategories?displeyedCategories=${displeyedCategories}&pageSize=${pageSize}`,
    {
      method: "GET",
    }
  )
    .then((response) => response.json())
    .catch((err) => console.log(err));
};


export { listCategories };
