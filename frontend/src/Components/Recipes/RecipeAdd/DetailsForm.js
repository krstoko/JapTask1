import { Grid } from "@mui/material";
import React from "react";
import FormikControl from "../../FormikComponents/FormikControl";

const DetailsForm = () => {
  const categories = [
    { id: 1, name: "Pizza" },
    { id: 2, name: "Nesto durgo" },
    { id: 3, name: "TRece" },
    { id: 4, name: "Auu" },
    { id: 5, name: "Dadad" },
  ];
  return (
    <Grid container columnSpacing={5}>
      <Grid item xs={6}>
        <FormikControl
          control="input"
          type="text"
          label="Recipe Name"
          name="recipeName"
        />
      </Grid>
      <Grid item xs={6}>
        <FormikControl
          control="select"
          name="categorie"
          label="Recipe Category"
          options={categories}
        />
      </Grid>
      <Grid item xs={12}>
        <FormikControl
          control="textArea"
          name="description"
          label="Recipe Description"
        />
      </Grid>
    </Grid>
  );
};

export default DetailsForm;
