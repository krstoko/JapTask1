import React from "react";
import ContainerPaper from "../ui-component/ContainerPaper";
import Header from "../ui-component/Header";
import ArrowBackIcon from "@mui/icons-material/ArrowBack";
import ButtonReusable from "../ui-component/ButtonReusable";
import { Box } from "@mui/system";
import { useNavigate } from "react-router-dom";

const Recipes = () => {
    const navigate = useNavigate()
    const style = {
        width: "100%"
    }
    const onBackClick = () =>{
        navigate("/categories")
    }
  return (
    <ContainerPaper maxWidth="lg">
      <Header>
        <Box display="flex" justifyContent="space-between" sx={style}>
          <ButtonReusable
            variant="outlined"
            size="small"
            startIcon={<ArrowBackIcon />}
            onClick={onBackClick}
          >
            Go Back
          </ButtonReusable>
          <ButtonReusable
            variant="contained"
            size="small"
          >
            Add Recipe
          </ButtonReusable>
        </Box>
      </Header>
    </ContainerPaper>
  );
};

export default Recipes;
