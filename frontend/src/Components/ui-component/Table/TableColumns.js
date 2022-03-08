export const recipeColumns = [
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
  {
    field: "price",
    headerName: "Price",
    width: 110,
    headerAlign: "center",
    align: "center",
  },
];

export const recipeAddColumns = () => {
  return [
    {
      field: "id",
      headerName: "ID",
      width: 90,
      headerAlign: "center",
      align: "center",
      hide: true,
    },
    {
      field: "ingredientName",
      headerName: "Ingredient name",
      width: 150,
      flex: 1,
    },
    {
      field: "recipeMeasureUnit",
      headerName: "Unit quantity",
      type: "number",
      width: 120,
      headerAlign: "center",
      align: "center",
    },
    {
      field: "recipeMeasureQuantity",
      headerName: "Measure Unit",
      width: 120,
      headerAlign: "center",
      align: "center",
    },
  ];
};
