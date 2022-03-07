import { Grid, Typography } from "@mui/material";
import React, { useRef, useState } from "react";
import DetailsForm from "./DetailsForm";
import IngredientsForm from "./IngredientsForm";
import * as Yup from "yup";
import { Form, Formik } from "formik";
import ButtonReusable from "../../ui-component/ButtonReusable";
import Table from "../../ui-component/Table";
import { addRecipe } from "../../../ApiService/RecipesApi";
const RecipeAddBody = () => {
  const ref = useRef(null);

  const [ingredients, setIngredients] = useState([]);

  const onSubmit = (values) => {
    addRecipe(values).then(res => console.log(res)).catch(err => console.log(err))
  };

  const initialValues = {
    recipeName: "",
    categorie: "",
    description: "",
    ingrediantName: "",
    measureUnit: "",
    measureQuantity: "",
    recipeImgUrl: ""
  };

  const validationSchema = Yup.object({
    recipeName: Yup.string().required("Recipe name is required"),
    categorie: Yup.string().required("Category is required"),
    description: Yup.string().required("Description is required"),
    ingrediantName: Yup.string().required("Ingredient name is required"),
    measureUnit: Yup.string().required("Measure unit is required"),
    measureQuantity: Yup.string().required("Measure quantity is required"),
    recipeImgUrl:  Yup.string().required("Image url is required")
  });

  const newIngredient = () => {
    let ingredient = {
      name: ref.current.values.ingrediantName,
      measureUnit: ref.current.values.measureUnit,
      quantity: ref.current.values.measureQuantity,
    };
    setIngredients((prevState) => [...prevState, ingredient]);
  };


  const columns = [
    {
      field: "id",
      headerName: "ID",
      width: 90,
      headerAlign: "center",
      align: "center",
      hide: true,
    },
    {
      field: "name",
      headerName: "Ingredient name",
      width: 150,
      flex: 1,
    },
    {
      field: "quantity",
      headerName: "Unit quantity",
      type: "number",
      width: 120,
      headerAlign: "center",
      align: "center",
    },
    {
      field: "measureUnit",
      headerName: "Measure Unit",
      width: 120,
      headerAlign: "center",
      align: "center",
    },
  ];

  const rows = ingredients.map((ingredient, id) => {
    return {
      id: id + 1,
      name: ingredient.name,
      quantity: ingredient.quantity,
      measureUnit: ingredient.measureUnit,
    };
  });

  return (
    <React.Fragment>
      <Typography variant="h3" align="center" mt={4}>
        Add new Recipe
      </Typography>
      <Formik
        initialValues={initialValues}
        validationSchema={validationSchema}
        onSubmit={(values) => {
          onSubmit(values);
        }}
        innerRef={ref}
      >
        <Form>
          <Grid container spacing={5} mt>
            <Grid item xs={12} sm={6}>
              <DetailsForm />
            </Grid>
            <Grid item xs={12} sm={6}>
              <IngredientsForm newIngredient={newIngredient} />
            </Grid>
          </Grid>
          <Table rows={rows} columns={columns} />
          <ButtonReusable type="submit" fullWidth variant="contained">
            Add recipe
          </ButtonReusable>
        </Form>
      </Formik>
    </React.Fragment>
  );
};

export default RecipeAddBody;
