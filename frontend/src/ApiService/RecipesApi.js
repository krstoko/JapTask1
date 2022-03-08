import api from "./AxiosConfigure";

const listRecipesForCategory = (categoryName, data, cb) => {
  api
    .get(`/recipe/${categoryName}`, {
      params: data,
    })
    .then((response) => cb(response.data))
    .catch((err) => {
      console.log(err);
      cb(false);
    });
};

const searchRecipes = (categoryName, data, cb) => {
  api
    .get(`/recipe/search/${categoryName}`, {
      params: data,
    })
    .then((response) => cb(response.data))
    .catch((err) => {
      console.log(err);
      cb(false);
    });
};

const singleRecipe = (recipeId, cb) => {

  api
    .get(`/recipe/single/${recipeId}`)
    .then((response) => cb(response.data))
    .catch((err) => {
      console.log(err);
      cb(false);
    });
};
const addRecipe = (recipe) => {
  return fetch(`https://localhost:44372/recipe/add`, {
    method: "POST",
    headers: { Accept: "application/json", "Content-Type": "application/json" },
    body: JSON.stringify(recipe),
  })
    .then((response) => response.json())
    .catch((err) => console.log(err));
};
export { listRecipesForCategory, searchRecipes, singleRecipe, addRecipe };
