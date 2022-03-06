const listRecipesForCategory = (categoryName,displeyedRecipes, pageSize) => {
    return fetch(
      `https://localhost:44372/recipe/${categoryName}?displeyedRecipes=${displeyedRecipes}&pageSize=${pageSize}`,
      {
        method: "GET",
      }
    )
      .then((response) => response.json())
      .catch((err) => console.log(err));
  };
  
  export { listRecipesForCategory };
  