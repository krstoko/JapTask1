import { Divider, Grid, Typography } from "@mui/material";
import { Box } from "@mui/system";
import React from "react";

const RecipeDetails = () => {
  const style = {
    higher: {
      borderLeft: "5px solid #316c6b",
      pl: 2,
    },
    paragraph: {
      wordWrap: "break-word",
    },
  };
  return (
    <Grid item xs={12} sm={12} md={6}>
      <Typography variant="h5" align="center">
        Recipe Details
      </Typography>
      <Divider />
      <Box component="div" pt={3}>
        <Typography variant="h5" sx={style.higher} gutterBottom>
          Recipe Name:
        </Typography>
        <Typography paragraph sx={style.paragraph} gutterBottom>
          Ime recepta
        </Typography>
        <Typography variant="h5" sx={style.higher} gutterBottom>
          Recipe Categories:
        </Typography>
        <Typography paragraph sx={style.paragraph} gutterBottom>
          Kategorija1 ,Kategorija1 ,Kategorija1 ,Kategorija1 ,Kategorija1
        </Typography>
        <Typography variant="h5" sx={style.higher} gutterBottom>
          Recipe Description:
        </Typography>
        <Typography paragraph sx={style.paragraph} gutterBottom>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque
          posuere, nisl vel lacinia vestibulum, libero mi rhoncus leo, vitae
          congue libero urna vitae risus. Vivamus sed sapien non urna tempus
          tempus quis dignissim felis. Vivamus vitae rhoncus turpis. Sed ut
          commodo velit, eu congue lacus. Maecenas tincidunt nunc quis dui
          mattis, quis pulvinar eros blandit. Maecenas maximus augue eget ex
          euismod molestie. Duis vulputate magna in tristique ornare. Vestibulum
          interdum tempor est vitae interdum. Vestibulum finibus quis orci sit
          amet lacinia.
        </Typography>
      </Box>
    </Grid>
  );
};

export default RecipeDetails;
