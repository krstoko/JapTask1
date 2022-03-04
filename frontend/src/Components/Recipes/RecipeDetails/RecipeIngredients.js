import { Divider, Grid, Typography } from "@mui/material";
import React from "react";
import Table from "../../ui-component/Table";

const RecipeIngredients = () => {
  const columns = [
    {
      field: "id",
      headerName: "ID",
      width: 90,
      headerAlign: "center",
      align: "center",
      hide: true
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
    {
      field: "price",
      headerName: "Price",
      width: 110,
      headerAlign: "center",
      align: "center",
    },
  ];
  
  const rows = [
    { id: 1, name: "Ulje", quantity: 200, measureUnit: "gram", price: 200 },
    { id: 2, name: "Ulje", quantity: 200, measureUnit: "gram", price: 200 },
    { id: 3, name: "Ulje", quantity: 200, measureUnit: "gram", price: 200 },
    { id: 4, name: "Ulje", quantity: 200, measureUnit: "gram", price: 200 },
    { id: 5, name: "Ulje", quantity: 200, measureUnit: "gram", price: 200 },
    { id: 6, name: "Ulje", quantity: 200, measureUnit: "gram", price: 200 },
  ];
  
  return (
    <Grid item xs={12} sm={12} md={6} >
      <Typography variant="h5" align="center">Recipe Ingredients</Typography>
      <Divider />
      <Table rows={rows} columns={columns}/>
    </Grid>
  );
};

export default RecipeIngredients;
