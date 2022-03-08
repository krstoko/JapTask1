import { Grid, Typography } from "@mui/material";
import React, { useRef, useState } from "react";
import DetailsForm from "./DetailsForm";
import IngredientsForm from "./IngredientsForm";
import ButtonReusable from "../../ui-component/ButtonReusable";
import Table from "../../ui-component/Table/Table";
import { recipeAddColumns } from "../../ui-component/Table/TableColumns";
import { addRecipe } from "../../../ApiService/RecipesApi";
import MyModal from "../../ui-component/MyModal";
const RecipeAddBody = () => {
  const detailsFormRef = useRef(null);
  const columns = recipeAddColumns();
  const [openModal, setOpenModal] = useState(false);
  const [ingredients, setIngredients] = useState([]);

  const newIngredient = (ingredient) => {
    let ingredientBody = {
      name: ingredient.ingrediantName,
      measureUnit: ingredient.measureUnit,
      quantity: ingredient.measureQuantity,
    };
    setIngredients((prevState) => [...prevState, ingredientBody]);
  };

  const rows = ingredients.map((ingredient, id) => {
    return {
      id: id + 1,
      name: ingredient.name,
      quantity: ingredient.quantity,
      measureUnit: ingredient.measureUnit,
    };
  });
  const addRecipeCall = (recipe) => {
    addRecipe(recipe).then((res) => {
      setIngredients([])
    });
  };
  const onClickHandler = () => {
    if (ingredients.length === 0) {
      setOpenModal(true);
    } else {
      detailsFormRef.current.handleSubmit();
    }
  };

  return (
    <React.Fragment>
      <MyModal
        title={"Error happaned"}
        message={
          "Looks like you tried to add recipe without ingrediants.Please try again with at least one ingredient"
        }
        openModal={openModal}
        closeModal={() => setOpenModal(false)}
      />
      <Typography variant="h3" align="center" mt={4}>
        Add new Recipe
      </Typography>
      <Grid container spacing={5} mt>
        <Grid item xs={12} sm={6}>
          <DetailsForm ref={detailsFormRef} addRecipe={addRecipeCall} />
        </Grid>
        <Grid item xs={12} sm={6}>
          <IngredientsForm newIngredient={newIngredient} />
        </Grid>
      </Grid>
      <Table rows={rows} columns={columns} />
      <ButtonReusable
        type="button"
        onClick={onClickHandler}
        fullWidth
        variant="contained"
      >
        Add recipe
      </ButtonReusable>
    </React.Fragment>
  );
};

export default RecipeAddBody;
