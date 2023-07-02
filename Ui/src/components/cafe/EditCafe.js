import React, { useContext } from "react";
import { useParams } from "react-router-dom";
import CafeForm from "./CafeForm";
import { GlobalContext } from "../../context/GlobalState";

export default function EditCafe() {
  const { id } = useParams();
  const { cafes } = useContext(GlobalContext);
  const cafe = cafes.find((cafe) => cafe.id === id);

  if (!cafe) {
    return <div>Cafe not found</div>;
  }

  return <CafeForm initialValues={cafe} action={"Edit"} />;
}
