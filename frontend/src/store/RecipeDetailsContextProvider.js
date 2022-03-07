import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { singleRecipe } from "../ApiService/RecipesApi";
import RecipeContext from "./recipetDetails-content";

export const RecipeDetailsContextProvider = (props) => {
  const [data, setData] = useState({
    recipeName: "",
    description: "",
    category: {
      categoryName: "",
    },
    recipesIngredients: [
      {
        ingredient: {},
      },
    ],
  });
  const { recipeId } = useParams();

  useEffect(() => {
    singleRecipe(recipeId)
      .then((res) => setData(res.data))
      .catch((err) => console.log(err));
  }, []);

  return (
    <RecipeContext.Provider value={data}>
      {props.children}
    </RecipeContext.Provider>
  );
};
