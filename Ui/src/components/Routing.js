import React, { memo } from "react";
import { Route, Switch } from "react-router-dom";
import Home from "./home/Home";
import Employees from "./employee/Employees";
import cafes from "./cafe/cafes";
import { EditEmployee } from "./employee/EditEmployee";
import { GlobalProvider } from "./../context/GlobalState";
import { AddEmployee } from "../components/employee/AddEmployee";
import { EditCafe } from "./cafe/EditCafe";
import { AddCafe } from "./cafe/AddCafe";

function Routing(props) {
  return (
    <GlobalProvider>
      <Switch>
        <Route exact path="/employees" component={Employees} />
        <Route path="/employees/add" component={AddEmployee} exact />
        <Route path="/employees/:id" component={EditEmployee} exact />
        <Route path="/cafes" component={cafes} exact />
        <Route path="/cafe/add" component={AddCafe} exact />
        <Route path="/cafe/:id" component={EditCafe} exact />
        <Route path="/" component={Home} />
      </Switch>
    </GlobalProvider>
  );
}
export default memo(Routing);
