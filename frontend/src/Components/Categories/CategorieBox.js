import {
  Box,
  Card,
  CardActionArea,
  CardMedia,
  Grid,
  Typography,
} from "@mui/material";
import React from "react";
import { useNavigate } from "react-router-dom";

const CategorieBox = ({ categorie }) => {
  const navigate = useNavigate();
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
  const onCardClick = () => {
    navigate(`/recipes/${categorie.categoryName.toLowerCase()}`);
  };

  return (
    <Grid item xs={12} sm={6} md={4}>
      <Card>
        <CardActionArea onClick={onCardClick}>
          <Box sx={style.boxWrapper}>
            <CardMedia
              component="img"
              height="200"
              image={categorie.categoryImgUrl}
            />
            <Box sx={style.textBox}>
              <Typography variant="h5" align="center">
                {categorie.categoryName}
              </Typography>
            </Box>
          </Box>
        </CardActionArea>
      </Card>
    </Grid>
  );
};

export default CategorieBox;
