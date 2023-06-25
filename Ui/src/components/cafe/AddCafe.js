import React from "react";
import CafeForm from "./CafeForm";

function AddCafe() {
  const cafe = {
    id: "",
    name: "",
    discription: "",
    location: "",
    logo: "",
  };

  return <CafeForm initialValues={cafe} />;
}

export default AddCafe;
