import api from "./AxiosConfigure";
const listCategories = (displeyedCategories, pageSize, cb) => {
  api
    .get("/category/getLoadMoreCategories", {
      params: {
        displeyedCategories: displeyedCategories,
        pageSize: pageSize,
      },
    })
    .then((response) => cb(response.data))
    .catch((err) => {
      console.log(err);
      cb(false);
    });
};

const getAllCategories = (cb) => {
  api
    .get("/category/all")
    .then((response) => cb(response.data))
    .catch((err) => {
      console.log(err);
      cb(false);
    });
};

export { listCategories, getAllCategories };
