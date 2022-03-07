import { Typography } from "@mui/material";
import React, { useState } from "react";
import ButtonReusable from "../ui-component/ButtonReusable";
import ContainerPaper from "../ui-component/ContainerPaper";
import * as Yup from "yup";
import { Formik, Form } from "formik";
import FormikControl from "../FormikComponents/FormikControl";
import { useNavigate } from "react-router-dom";
import { login } from "../../ApiService/AuthApi";
import { authenticate } from "./AuthHelper/authHelper";

const SignIn = () => {
  const [error, setError] = useState({ isError: false, message: "" });
  const navigate = useNavigate();
  const onSubmit = (values) => {
    login(values)
      .then((res) => {
        if (!res.success) {
          setError({ isError: true, message: res.message });
        } else {
          authenticate(res.data);
          navigate("/categories");
        }
      })
      .catch((err) => console.log(err));
  };

  const initialValues = {
    username: "",
    password: "",
  };

  const validationSchema = Yup.object({
    username: Yup.string().required("Username is required"),
    password: Yup.string().required("Password is required"),
  });

  return (
    <React.Fragment>
      <ContainerPaper type="centered">
        <Typography component="h1" variant="h5" align="center">
          Sign in
        </Typography>
        <Formik
          initialValues={initialValues}
          validationSchema={validationSchema}
          onSubmit={(values) => {
            onSubmit(values);
          }}
        >
          <Form>
            <FormikControl
              control="input"
              type="text"
              label="Username"
              name="username"
              errors={error}
            />
            <FormikControl
              control="input"
              type="password"
              label="Password"
              name="password"
              errors={error}
            />
            <ButtonReusable type="submit" fullWidth variant="contained">
              Sign In
            </ButtonReusable>
          </Form>
        </Formik>
      </ContainerPaper>
    </React.Fragment>
  );
};

export default SignIn;
