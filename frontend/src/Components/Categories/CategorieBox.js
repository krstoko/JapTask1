import {
  Box,
  Card,
  CardActionArea,
  CardMedia,
  Grid,
  Typography,
} from "@mui/material";
import React from "react";

const CategorieBox = (props) => {
  const style = {
    boxWrapper: {
      position: "relative",
    },
    textBox: {
      position: "absolute",
      bottom: 0,
      left: 0,
      width: "100%",
      bgcolor: "rgba(0, 0, 0, 0.54)",
      color: "white",
      padding: "10px",
    },
  };
  return (
    <Grid item xs={12} sm={6} md={4}>
      <Card>
        <CardActionArea>
          <Box sx={style.boxWrapper}>
            <CardMedia
              component="img"
              height="200"
              image="https://mui.com/static/images/cards/contemplative-reptile.jpg"
            />
            <Box sx={style.textBox}>
              <Typography variant="h5" align="center">
                {props.categorie}
              </Typography>
            </Box>
          </Box>
        </CardActionArea>
      </Card>
    </Grid>
  );
};

export default CategorieBox;
