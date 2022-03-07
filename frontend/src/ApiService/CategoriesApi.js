const listCategories = (displeyedCategories, pageSize) => {
  return fetch(
    `https://localhost:44372/category/getLoadMoreCategories?displeyedCategories=${displeyedCategories}&pageSize=${pageSize}`,
    {
      method: "GET",
    }
  )
    .then((response) => response.json())
    .catch((err) => console.log(err));
};

const getAllCategories = () => {
  return fetch(
    `https://localhost:44372/category/all`,
    {
      method: "GET",
    }
  )
    .then((response) => response.json())
    .catch((err) => console.log(err));
};


export { listCategories,getAllCategories };
