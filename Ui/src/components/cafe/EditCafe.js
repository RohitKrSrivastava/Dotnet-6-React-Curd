import React, { useContext } from "react";
import { useParams } from "react-router-dom";
import CafeForm from "./CafeForm";
import { GlobalContext } from "../../context/GlobalState";

export default function EditEmployee() {
  const { id } = useParams();
  const { employees } = useContext(GlobalContext);
  const employee = employees.find((emp) => emp.id === id);

  if (!employee) {
    return <div>Cafe not found</div>;
  }

  return <CafeForm initialValues={employee} action={"Edit"} />;
}
