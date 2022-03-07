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

  const searchRecipes = (categoryName,searchValue,displeyedRecipes, pageSize) => {
    return fetch(
      `https://localhost:44372/recipe/search/${categoryName}?searchValue=${searchValue}&displeyedRecipes=${displeyedRecipes}&pageSize=${pageSize}`,
      {
        method: "GET",
      }
    )
      .then((response) => response.json())
      .catch((err) => console.log(err));
  };
  
  
  export { listRecipesForCategory,searchRecipes };
  